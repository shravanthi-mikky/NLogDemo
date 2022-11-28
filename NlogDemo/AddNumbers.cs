using System;
using System.Collections.Generic;
using System.Text;

namespace NlogDemo
{
    internal class AddNumbers
    {
        NLog nlog = new NLog();
        public int Sum(int a, int b)
        {
            if (a==0 || b == 0)
            {
                nlog.LogDebug("Debug sucessfull : Sum()");
                nlog.LogError("Expecting null variables");
                nlog.LogWarn("a or b should nont be equal to 0");

            }
            int c = a + b;
            nlog.LogDebug("Debug sucessfull");
            nlog.LogInfo("Sum Method Passed"+c);
            return c;
        }
    }
}
