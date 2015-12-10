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
        }

        //creazione questionario totale!
        public void caricaQ()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(@"D:\BALLABIO_GIT\OpenDay\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\Domande_Informatica.csv");
            
            
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
        

        public void caricaR()
        {

        }

        public String getTipo(int indice)
        {
            return questionario.ElementAt(indice).getTipo();
            
        }
        

    }
}