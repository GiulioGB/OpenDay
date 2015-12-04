using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scrivi
{
    class domanda
    {
        String Autore, DataIns, Categoria, Testo, Tipo, Scelte;

        public domanda(String Autore, String DataIns, String Categoria, String Testo, String Tipo, String Scelte)
        {
            this.Autore = Autore;
            this.DataIns = DataIns;
            this.Categoria = Categoria;
            this.Testo = Testo;
            this.Tipo = Tipo;
            this.Scelte = Scelte;

        }



    }
}
