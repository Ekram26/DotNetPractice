using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPractice
{
    public class Mobile
    {
      public static void Main(string[] args)
        {
            Smartphone obj = new Smartphone();
            obj.Name = "Apple";
            obj.Price = 75999;
            obj.colour = "white";
            Console.WriteLine(obj.Name  +" "+ obj.colour +" "+ obj.Price);
            
        }
    }
}
