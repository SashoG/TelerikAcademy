using System;
using System.Text;

namespace DefiningClassesHW
{
    public class Display
    {
        private int size;

        private int numberColors;

        public int Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.size = value;
            }
        }

        public int NumberColors
        {
            get
            {
                return this.numberColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                this.numberColors = value;
            }
        }

        public Display(int size=0, int numberColors=0)
        {
            this.Size = size;
            this.NumberColors = numberColors;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("Size:{0}", Size));
            sb.AppendLine();
            sb.Append(String.Format("NumberColors:{0}", NumberColors));
            
            return sb.ToString();
        }
    }
}