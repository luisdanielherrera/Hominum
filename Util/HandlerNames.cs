using Hominum.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hominum.Util
{
    public static class HandlerNames
    {
        public static string SetName(Gender Gender, string Generation = "")
        {
            List<string> MaleNames = new List<string> { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" };
            List<string> FemaleNames = new List<string> { "abby", "abigail", "adele", "adrian" };
            Random rand = new Random();
            if (Gender == 0)
            {
                return MaleNames[rand.Next(0, MaleNames.Count - 1)] + Generation;
            }
            else
            {
                return FemaleNames[rand.Next(0, FemaleNames.Count - 1)] + Generation;
            }
        }
    }
}
