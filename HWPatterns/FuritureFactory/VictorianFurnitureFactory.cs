using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class VictorianFurnitureFactory: IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VirtorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
