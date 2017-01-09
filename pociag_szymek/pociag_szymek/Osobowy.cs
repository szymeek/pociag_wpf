using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pociag_szymek
{
    class Osobowy:Wagon
    {
        private string rodzaj;
        public Osobowy(string model_, int masa_, string rodzaj_)
        {
            this.model = model_;
            this.masa = masa_;
            this.rodzaj = rodzaj_;
        }
        public override string Informacje()
        {
            return "wagon osobowy: model: " + model + ",masa: " + masa + ",rodzaj: " + rodzaj;
        }
    }
}
