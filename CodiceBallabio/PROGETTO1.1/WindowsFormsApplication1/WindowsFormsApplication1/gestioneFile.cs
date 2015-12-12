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
        List<scelteCheck> scelte;
        List<scelteRadio> radio;
        public gestioneFile()
        {
            questionario = new List<domanda>();
            risposte = new List<risposte>();
            scelte = new List<scelteCheck>();
            radio = new List<scelteRadio>();
            caricaQ();
        }

        //creazione questionario totale!
        public void caricaQ()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(@"C:\Users\Balla\Desktop\DA CARICARE\PROGETTO\WindowsFormsApplication1\WindowsFormsApplication1\Domande_Informatica.csv");
            
            
            for (int i = 0; i < 41; i++)
            {
                d = allLines[i].Split(';');
                domanda domand = new domanda();
                domand.creaDomanda(d);
                questionario.Add(domand);
                
            }
            
            
        }
        //----------------------------

        public void OttieniScelteCK(int indice)
        {
            string[] d;

            d = questionario[indice].Scelte.Split('/');
            scelteCheck sc = new scelteCheck();
            sc.setScelte(d);
            scelte.Add(sc);            
        }

        public void OttieniScelteRD(int indice)
        {
            string[] d;

            d = questionario[indice].Scelte.Split('/');
            scelteRadio rd = new scelteRadio();
            rd.setScelte(d);
            radio.Add(rd); 
        }

        public void caricaR()
        {

        }

        public String getTipo(int indice)
        {
            return questionario.ElementAt(indice).getTipo();
            
        }

        public String getTesto(int indice)
        {
            return questionario.ElementAt(indice).getTesto();

        }
        
        public String getprima(int indice)
        {
            return scelte.ElementAt(indice).getprima();
        }

        public String getseconda(int indice)
        {
            return scelte.ElementAt(indice).getseconda();
        }

        public String getterza(int indice)
        {
            return scelte.ElementAt(indice).getterza();
        }

        public String getquarta(int indice)
        {
            return scelte.ElementAt(indice).getquarta();
        }

        public String getA(int indice)
        {
            return radio.ElementAt(indice).getA();
        }

        public String getB(int indice)
        {
            return radio.ElementAt(indice).getB();
        }
       
    }
}