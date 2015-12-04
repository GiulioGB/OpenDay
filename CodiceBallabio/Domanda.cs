using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class domanda
    {
        public String Autore, DataIns, Categoria, Testo, Tipo, Scelte , rispostaData;
        public Int16 id;
        public domanda(String Autore, String DataIns, String Categoria, String Testo, String Tipo, String Scelte)
        {
            this.Autore = Autore;
            this.DataIns = DataIns;
            this.Categoria = Categoria;
            this.Testo = Testo;
            this.Tipo = Tipo;
            this.Scelte = Scelte;
            this.rispostaData = "";
            this.id = 0;

        }

        public void rispondi(String rispostaData)
        {
            this.rispostaData = rispostaData;
        }


        public domanda(String s)
        { 
            
        }

        public String rispostaCorretta()
        { 
            String s = "";

            return s;
        }
    }
}
