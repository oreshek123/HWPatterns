using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWPatterns
{
    public class Client
    {
        public IFurnitureFactory Factory { get; set; }
        public IChair Chair { get; set; }
        public ISofa Sofa { get; set; }

        public Client(IFurnitureFactory factory)
        {
            Factory = factory;
        }

        public void CreateFurniture()
        {
            Chair = Factory.CreateChair();
            Sofa = Factory.CreateSofa();
        }

        public void SitDown()
        {
            Chair.SitDown();
        }

        public void LieDown()
        {
            Sofa.LieDown();
        }
    }
}
