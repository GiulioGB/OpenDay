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
        String fileDomande;
        String fileRisposte;

        public gestioneFile()
        {
            fileDomande = @"D:\GIT\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\Domande_Informatica.csv";
            fileRisposte = @"D:\GIT\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\risposte.csv";
            questionario = new List<domanda>();
            risposte = new List<risposte>();
            //caricaQ();
            caricaFileRisposte();
        }

        //creazione questionario totale!
        public void caricaQ()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(fileDomande);
            
            
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
            string[] allLines = File.ReadAllLines(fileRisposte);
            int num = File.ReadAllLines(fileRisposte).Length;
            

            for (int i = 0; i<num ; i++)
            {
                d = allLines[i].Split(';');
                risposte risp = new risposte();
                risp.setId(Int32.Parse(d[0]));
                risp.setData(d[1]);
                risp.setRisposte( d[2].ToString() , d[3].ToString() , d[4].ToString() );
                risposte.Add(risp);
            }
        
        }

        
        
        public void caricaR(risposte r)
        {
            risposte.Add(r);
        }

        public void scriviFileRisposte()
        {
           
            var csv = new StringBuilder();
            var newLine = "";

            for (int i = 0; i < risposte.Count; i++)
            {
                newLine = risposte.ElementAt(i).getRow();
                csv.Append(newLine+'\n');
            }

            File.WriteAllText(fileRisposte, csv.ToString());
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