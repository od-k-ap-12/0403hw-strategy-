using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__strategy_
{
    class Context
    {
        private IStrategy Strategy;

        public Context()
        { }
        public Context(IStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.Strategy = strategy;
        }
        public void StrategyCall()
        {
            Strategy.Message();
        }
    }

    public interface IStrategy
    {
        void Message();
    }
    class ArriveByTaxi : IStrategy
    {
        public void Message()
        {
            Console.WriteLine("You can choose taxi");
        }
    }

    class ArriveByBus : IStrategy
    {
        public void Message()
        {
            Console.WriteLine("You can choose bus");
        }
    }

    class ArriveByBike : IStrategy
    {
        public void Message()
        {
            Console.WriteLine("You can choose bike");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            Console.WriteLine("Choose by speed(1) or by cost(2)?");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1':
                    Console.WriteLine("Speed? 1-Low 2-Medium 3-High");
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            context.SetStrategy(new ArriveByBike());
                            context.StrategyCall();
                            break;
                        case '2':
                            context.SetStrategy(new ArriveByBus());
                            context.StrategyCall();
                            break;
                        case '3':
                            context.SetStrategy(new ArriveByTaxi());
                            context.StrategyCall();
                            break;
                    }

                    break;
                case '2':
                    Console.WriteLine("How many to spend on transport? 1-Free 2-15 3->15");
                    int Money = Convert.ToInt32(Console.ReadLine());
                    switch (Console.ReadKey(true).KeyChar)
                    {
                        case '1':
                            context.SetStrategy(new ArriveByBike());
                            context.StrategyCall();
                            break;
                        case '2':
                            context.SetStrategy(new ArriveByBus());
                            context.StrategyCall();
                            break;
                        case '3':
                            context.SetStrategy(new ArriveByTaxi());
                            context.StrategyCall();
                            break;
                    }
                    break;
            } 
        }
    }
}
