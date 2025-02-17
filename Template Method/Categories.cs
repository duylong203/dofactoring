﻿using System;
using System.Collections.Generic;

namespace Template.RealWorld
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    public class Categories : DataAccessor
    {
        private List<string> categories;

        public override void Connect()
        {
            categories = new List<string>();
        }

        public override void Select()
        {
            categories.Add("Red");
            categories.Add("Green");
            categories.Add("Blue");
            categories.Add("Yellow");
            categories.Add("Purple");
            categories.Add("White");
            categories.Add("Black");
        }

        public override void Process(int top)
        {
            Console.WriteLine("Categories ---- ");

            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(categories[i]);
            }

            Console.WriteLine();
        }

        public override void Disconnect()
        {
            categories.Clear();
        }
    }
}
