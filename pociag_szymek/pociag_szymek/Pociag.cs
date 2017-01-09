using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pociag_szymek
{
    class Pociag: IPoprawnyPociag, IUzupelnijSklad
    {
        private List<Wagon> wagony = new List<Wagon>();
        private List<Lokomotywa> lokomotywy = new List<Lokomotywa>();
        public bool Mozejechac()
        {
            int masa_l = 0;
            int masa_w = 0;
            foreach (var x in wagony)
            {
                masa_w += x.ZwrocMase();
            }
            foreach (var x in lokomotywy)
            {
                masa_l += x.ZwrocMase();
            }
            return masa_l >= masa_w;
        }
        public void DodajOsobowy(int masa, string model, string rodzaj)
        {
            wagony.Add(new Osobowy(model, masa, rodzaj));
        }
        public void DodajTowarowy(int masa, string model, string ladunek)
        {
            wagony.Add(new Towarowy(model, masa, ladunek));
        }
        public void DodajLokomotywe(int masa, string model)
        {
            lokomotywy.Add(new Lokomotywa(model, masa));
        }
        public string Informacje()
        {
            string sklad = string.Format("Skład pociągu: \n");
            foreach (var x in lokomotywy)
            {
                sklad += string.Format("{0}\n", x.Informacje());
            }
            foreach (var x in wagony)
            {
                sklad += string.Format("{0}\n", x.Informacje());
            }
            return sklad;

        }
    }
}
