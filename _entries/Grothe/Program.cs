﻿namespace e
{
    class m
    {
        static void Main()
        {
            using (var b = new System.IO.BinaryWriter(System.Console.OpenStandardOutput()))
            {
                for (int t = 0; t < 246000; t++)
                    b.Write((ushort)(t / 4100 % 5 == 0 ? t * t * t : t * t));
            }
        }
    }
}