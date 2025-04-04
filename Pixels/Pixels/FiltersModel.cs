using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pixels
{
    public class FiltersModel
    {

        public string Name { get; set; }
        public System.Drawing.Bitmap Image { get; set; }
        public int Value { get; set; }

        private int activeFilter = 0;

        private int filterValue;
        public FiltersModel(string name, Byte[] image, int value)
        {
            Name = name;
            Image = ByteArrayToBitmap(image);
            Value = value;
        }

        public static Bitmap ByteArrayToBitmap(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }

        

    }
}
