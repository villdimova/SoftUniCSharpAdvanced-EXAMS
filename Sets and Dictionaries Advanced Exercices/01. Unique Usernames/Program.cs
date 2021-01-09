﻿using System;
using System.Collections.Generic;

namespace _01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();
                userNames.Add(userName);
            }

            foreach (var user in userNames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
