using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    class VictorianSofa: ISofa
    {
        public bool IsSoft()
        {
            return false;
        }

        public void LieDown()
        {
            Console.WriteLine("Вы лежите на софе викторианского периода");
        }
    }
}
