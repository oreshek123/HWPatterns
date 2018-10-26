using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class ModernChair:IChair
    {
        public bool HasLegs()
        {
            return true;
        }

        public void SitDown()
        {
            Console.WriteLine("Вы сидите на современном кресле");
        }
    }
}
