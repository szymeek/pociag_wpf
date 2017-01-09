using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pociag_szymek
{
    class Towarowy:Wagon
    {
        private string ladunek;
        public Towarowy(string model_, int masa_, string ladunek_)
        {
            this.model = model_;
            this.masa = masa_;
            this.ladunek = ladunek_;
        }
        public override string Informacje()
        {
            return "wagon towarowy: model: " + model + ",masa: " + masa + ",ladunek: " + ladunek;
        }
    }
}
