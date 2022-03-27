using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Nyajimmunitás
{
    class Ember
    {
        //static List<Ember> lista = new List<Ember>();
        public Label negyzet = new Label();
        public Vektor v;
        public int napjafertozott;

        public Ember(Label l , Vektor v)
        {
            this.negyzet = l;
            this.v = v;
            this.napjafertozott = 0;
        }
    }
}
