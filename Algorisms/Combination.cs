using System.Collections.Generic;

namespace Algorism.Algorisms
{

    /// <summary>
    /// コンビネーション(漸化式)
    /// </summary>
    [Sample]
    public class Combination
    {
        public static string Start()
        {
            var result = DoAction(5, 2);
            return string.Join("\r\n", result);
        }

        public static List<string> DoAction(int n, int r)
        {
            var result = new List<string>();
            for (var nidx = 0; nidx < n; nidx++)
            {
                var msg = $"{nidx}: ";
                for (var ridx = 0; ridx <= nidx; ridx++)
                {
                    var nch = (char)('a' + nidx);
                    var rch = (char)('a' + ridx);
                    msg += $" {nch}{rch}";
                }
                result.Add(msg);
            }
            return result;
        }
    }
}
