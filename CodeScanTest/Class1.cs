using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeScanTest
{
    public class Class1
    {
        public int Method1()
        {
            var result = 1;
            try
            {
                
                for (int i = 0; i < 100; i++)
                {
                    i++;
                }
            }
            catch (Exception)
            { }

            return result;
        }
    }
}
