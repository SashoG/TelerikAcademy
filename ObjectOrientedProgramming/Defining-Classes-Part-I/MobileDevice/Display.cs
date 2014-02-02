using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Display
    {
        private int size;
        private int numColors;

        //Properties
        public int Size
        {
            get { return this.size; }
            set
            {
                if (!int.TryParse(value.ToString(), out value))
                {
                    throw new ArgumentException("Invalid Display Size");
                }
                this.size = value;
            }
        }
        public int NumColors
        {
            get { return this.numColors; }
            set
            {
                if (!int.TryParse(value.ToString(), out value))
                {
                    throw new ArgumentException("Invalid Display Colors Number");
                }
                this.numColors = value;
            }
        }

        //Constructors
        public Display()
        {
        }
    }
}
