using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Coupling
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void copy()
        {
            Console.WriteLine("Object Copied to clipboard.");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicate");
        }
    }
}
