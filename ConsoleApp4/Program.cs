﻿using System;

public class breakexample
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            if(i == 5)
            {
                break;
            }
            Console.WriteLine(i);
        }
    }
}
