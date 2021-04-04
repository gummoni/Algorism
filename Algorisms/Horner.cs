using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorism.Algorisms
{
    [Sample]
    public static class Horner
    {
        /// <summary>
        /// ホーナー法
        /// </summary>
        /// <returns></returns>
        public static string Start()
        {
            var result = new List<string>();
            var a = new int[] { 1, 2, 3, 4, 5 };

            for (var x = 1; x <= a.Length; x++)
            {
                result.Add($"fn({x}) = {Fn(x, a, 4)}");
            }

            return string.Join("\r\n", result);
        }

        static int Fn(int x, int[] a, int n)
        {
            int p = a[n];
            for (var i = n - 1; i >= 0; i--)
            {
                p = p * x + a[i];
            }
            return p;
        }
    }
}
