using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PametniTelefon : ElektronickiUredjaji
    {
        public string OperativniSistem { get; set; }
        public PametniTelefon(string naziv, int proizvodac, int godinaProizvodnje, string operativniSustav)
            : base(naziv, proizvodac, godinaProizvodnje)
        {
            OperativniSustav = operativniSustav
        }
    }
}



    
    
    

