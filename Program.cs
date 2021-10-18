using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Data.SqlTypes;
using System.Data.Common;


namespace Demo_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ implementation in c#....");

            int[] scores = new int[] { 10, 35, 40, 50, 80, 25 };

            string[] cities = new string[] { "Agra", "Mumbai", "Delhi", "Kolkatta", "Banglore" };

            //IEnumerable<int> ScoreQuerry =
            //  from score in scores
            //where score > 35
            //orderby score descending
            //select score;
            IEnumerable<string> CityQuery =
                            from city in cities
                            where city is "delhi" or "Mumbai"
                            select city;
                             foreach(var item in CityQuery)
            {
                Console.WriteLine(item + "\n");
            }

            // foreach(int item in ScoreQuerry)
            
            //{
              //  Console.WriteLine(item + " ");
            //}


            
        }
    }
}
