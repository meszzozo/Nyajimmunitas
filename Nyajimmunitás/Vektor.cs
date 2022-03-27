using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyajimmunitás
{
    class Vektor
    {
        public double x { get; set; }
        public double y { get; set; }

        public Vektor(double X, double Y) => (x, y) = (X, Y);

        public Vektor()
        {
            Random r = new Random();
            if(r.Next(2)==1)
            {
                this.x = Math.Round(r.NextDouble(), 1)*10;
            }
            else
            {
                this.x = Math.Round(r.NextDouble(), 1) * -10;
            }
            if (r.Next(2) == 1)
            {
                this.y = Math.Round(r.NextDouble(), 1)*10;
            }
            else
            {
                this.y = Math.Round(r.NextDouble(), 1) * -10;
            }
        }
    }
}
