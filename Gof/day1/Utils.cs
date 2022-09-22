using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace andestech.learning2022.gof
{
    public static class Utils
    {
        private static string multString(string s, int n = 1)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++) sb.Append(s);
            return sb.ToString();
        }

        public static void echo(string? s = null, string ch = "-", int N = 80)
        {
            if (N <= 0 || N > 120) N = 70;
            if (s == null) { WriteLine(ch, N); return; }

            int L = s.Length;
            if (L > N) s = s.Substring(0, N);

            int chL = ch.Length;
            string half = multString(ch, (N - L) / 2 / chL);

            if (N - L >= 4 * chL) WriteLine($"{half} {s} {half}");
            else WriteLine(s);
        }


    }
}
