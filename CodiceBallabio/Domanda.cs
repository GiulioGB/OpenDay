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
        
        //public domanda(String Autore, String DataIns, String Categoria, String Testo, String Tipo, String Scelte)
        //{
        //    this.Autore = Autore;
        //    this.DataIns = DataIns;
        //    this.Categoria = Categoria;
        //    this.Testo = Testo;
        //    this.Tipo = Tipo;
        //    this.Scelte = Scelte;
        //    this.rispostaData = "";
            

        //}

        public domanda(String []campi)
        {
            this.Autore = campi[4];
            this.DataIns = campi[5];
            this.Categoria = campi[1];
            this.Testo = campi[2];
            this.Tipo = campi[0];
            this.Scelte = campi[3];
            this.rispostaData = "";
            

        }

        public void rispondi(String rispostaData)
        {
            this.rispostaData = rispostaData;
        }


        public String ricercaCorretta()
        { 
            String s = "";
            for(int i=0;i<Scelte.length;i++)
            {
                if (Tipo.equals("matematica"))
                {
                    if (Scelte[0] == 'V')
                        //da modificare
                        s = Scelte;
                        //------------.
                }
                else
                {
                    if (Scelte[0] == '1')
                        //da modificare
                        s = Scelte;
                       //-------------
                }
            
               
            }
            
            return s;
        }

        
        public int correzione(int punteggio)
        {
            
            if(rispostaData.equals(ricercaCorretta()))
            {
                punteggio += 1;
            }
            else
            {
                //non assegno punti
            }
            return punteggio;
        }

        public String getTipo()
        {
            return Tipo;
        }

    }
}
