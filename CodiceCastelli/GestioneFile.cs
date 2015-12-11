using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class gestioneFile
    {
        List<domanda> questionario;
        List<risposte> risposte;

        public gestioneFile()
        {
            questionario = new List<domanda>();
            risposte = new List<risposte>();
            caricaQ();
            caricaFileRisposte();
        }

        //creazione questionario totale!
        public void caricaQ()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(@"D:\BALLA_GIT\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\Domande_Informatica.csv");
            
            
            for (int i = 0; i < 42; i++)
            {
                d = allLines[i].Split(';');
                domanda domand = new domanda();
                domand.creaDomanda(d);
                questionario.Add(domand);
                
            }
            //for (int i = 0; i < 42; i++)
            //{
            //    questionario.ElementAt(i).visualizzaDomanda();
            //}
            
        }
        //----------------------------

        public void caricaFileRisposte()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(@"D:\BALLA_GIT\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\risposte.csv");


            for (int i = 0; ; i++)
            {
                d = allLines[i].Split(';');
                risposte risp = new risposte();
                risp.setRisposte(Int32.Parse(d[0]) , d[1].ToString() , d[2].ToString() , d[3].ToString() );
                risposte.Add(risp);
            }
        
        }
        public void caricaR(risposte r)
        {
            risposte.Add(r);
        }

        public void scriviFileRisposte()
        {
            var file = @"D:\GITHUB\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\risposte.csv";
            
           
            //stampa la riga
                


        }

        public String getTipo(int indice)
        {
            return questionario.ElementAt(indice).getTipo();
            
        }

        public String getTesto(int indice)
        {
            return questionario.ElementAt(indice).getTesto();

        }
        

    }
}