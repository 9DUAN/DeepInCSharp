using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepInCSharp
{
    
    class 数据类型
    {
        //C# 1.0:  没有强类型集合
        private class Product01
        {
            string name;
            public string Name { get { return name; } }

            decimal price;
            public decimal Price { get { return price; } }

            public Product01(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }

            public static ArrayList GetSampleProducts()
            {
                ArrayList list = new ArrayList();
                list.Add(new Product01("West Side Story", 9.99m));
                list.Add(new Product01("West Side ", 10.99m));
                list.Add(new Product01("West Side Story", 11.99m));
                list.Add(new Product01("West Story", 12.99m));
                return list;
            }

            public override string ToString()
            {
                return string.Format("{0}:{1}", name, price);
            }
        }


    }
}
