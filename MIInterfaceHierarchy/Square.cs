using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
        // Using explicit implementation to handle member name clash.
        void IPrintable.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing to screen...");
        }
        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        public int GetNumberOfSides()
        { return 4; }
    }
}
