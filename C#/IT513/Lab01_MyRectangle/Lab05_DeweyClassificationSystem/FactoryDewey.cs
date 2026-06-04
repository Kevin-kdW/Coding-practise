using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_DeweyClassificationSystem
{
    internal class FactoryDewey
    {
        public static Dewey CreateDewey(string line)
        {
            string[] parts = line.Split(":");
            int code = int.Parse(parts[0]);
            string classification = parts[1];
            return new Dewey(code, classification);
        }

       
    }
}
