using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pociag_szymek
{
    abstract class Wagon
    {
        protected string model;
        protected int masa;
        public abstract string Informacje();
        public int ZwrocMase()
        {
            return masa;
        }
    }
}
