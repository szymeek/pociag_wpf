using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pociag_szymek
{
    class Lokomotywa
    {
        private string model;
        private int masa;
        public Lokomotywa(string model_, int masa_)
        {
            this.model = model_;
            this.masa = masa_;
        }
        public int ZwrocMase()
        {
            return masa;
        }
        public string Informacje()
        {
            return string.Format("model lokomotywy to: {0} masa: {1}", model, masa);
        }
    }
}
