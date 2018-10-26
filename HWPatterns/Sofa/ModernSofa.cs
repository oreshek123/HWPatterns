using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class ModernSofa: ISofa
    {
        public bool IsSoft()
        {
            return true;
        }

        public void LieDown()
        {
            Console.WriteLine("Вы лежите на современной софе");
        }
    }
}
