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
        
        public domanda(String Autore, String DataIns, String Categoria, String Testo, String Tipo, String Scelte)
        {
            this.Autore = Autore;
            this.DataIns = DataIns;
            this.Categoria = Categoria;
            this.Testo = Testo;
            this.Tipo = Tipo;
            this.Scelte = Scelte;
            this.rispostaData = "";
            

        }

        public domanda(String []campi)
        {
            this.Autore = campi[0];
            this.DataIns = DataIns;
            this.Categoria = Categoria;
            this.Testo = Testo;
            this.Tipo = Tipo;
            this.Scelte = Scelte;
            this.rispostaData = "";
            

        }

        public void rispondi(String rispostaData)
        {
            this.rispostaData = rispostaData;
        }


        //domanda multipla
        public String rispostaCorretta1()
        { 
            String s = "";



            return s;
        }

        //VoF
        public String rispostaCorretta2()
        {
            String s = "";



            return s;
        }

    }
}
