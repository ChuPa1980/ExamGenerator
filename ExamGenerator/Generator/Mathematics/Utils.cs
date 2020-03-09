using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGenerator.Generator.Mathematics
{
    public static class Utils
    {
        public static Random r = new Random();

        public static int RandomInt(int max)
        {
            return r.Next(max);
        }

        public static int RandomInt(int min, int max)
        {
            return r.Next(min, max);
        }
    }
}
