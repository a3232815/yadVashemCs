using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DAL
{
    public class Class1
    {
        static List<Item> items;

        public static void allDateis()
        {
            using (StreamReader r = new StreamReader("real.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
                if (items != null && items.Count > 0)
                {
                    foreach (var realItem in items)
                    {
                        //Console.WriteLine($"item:{RealItem}    tag:{ Item.tag}");
                        Console.WriteLine($"item:{realItem.title} tag:{ realItem.tag}");
                        foreach (var resours in realItem.resources)
                        {
                            Console.WriteLine($"resourse:{resours.title}");
                        }
                        foreach (var tran in realItem.transcriptSTR)
                        {
                            Console.WriteLine($"transcriptSTR:{tran.fromSecond}");
                        }
                    }
                }
            }
        }
    }
}
