using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class VirtorianChair:IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitDown()
        {
            Console.WriteLine("Вы сидите на кресле викторианского периода");
        }
    }
}
