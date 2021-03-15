using System;
using System.Collections.Generic;

namespace P1
{
    // 購入するもを計算
    class Program
    {
        static void Main(string[] args)
        {
            // 消費者が購入するもの
            List<Food> food = new List<Food>();
            food.Add(new Orange()) ;
            food.Add(new Tomato());
            // レジ係
            MoneyCalc moneyCalc = new MoneyCalc(food[0].Value + food[1].Value);
            // 消費者が支払う価格
            foreach(Food f in food)
            {
                Console.WriteLine("{0} : {1}円", f.Name, f.Value);
            }
            Console.WriteLine("合計価格(税込) : {0}", moneyCalc.TaxValue);
        }
    }
}
