using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class domanda
    {
        public String Autore, DataIns, Categoria, Testo, Tipo, Scelte , rispostaData;

        public domanda()
        {
            
        }
        //public domanda(String Tipo, String Categoria, String Testo, String Scelte, String Autore, String DataIns)
        //{
        //    this.Autore = Autore;
        //    this.DataIns = DataIns;
        //    this.Categoria = Categoria;
        //    this.Testo = Testo;
        //    this.Tipo = Tipo;
        //    this.Scelte = Scelte;
        //    this.rispostaData = "";
        //}

        public void creaDomanda(String[] campi)
        {
            this.Tipo = campi[0];
            this.Categoria = campi[1];
            this.Testo = campi[2];
            this.Scelte = campi[3];
            this.Autore = campi[4];
            this.DataIns = campi[5];
            this.rispostaData = "";

        }

        
        
        public void rispondi(String rispostaData)
        {
            this.rispostaData = rispostaData;
        }


        public String ricercaCorretta()
        { 
            String s = "";
            for(int i=0;i<Scelte.Length;i++)
            {
                if (Tipo.Equals("matematica"))
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
            
            if(rispostaData.Equals(ricercaCorretta()))
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


        //public void visualizzaDomanda()
        //{
        //    System.Console.WriteLine(Autore + DataIns + Categoria + Testo +  Tipo + Scelte + rispostaData);
        
        
        //}
    }
}
