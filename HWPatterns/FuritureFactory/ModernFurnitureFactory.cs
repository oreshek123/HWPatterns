using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class ModernFurnitureFactory: IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
