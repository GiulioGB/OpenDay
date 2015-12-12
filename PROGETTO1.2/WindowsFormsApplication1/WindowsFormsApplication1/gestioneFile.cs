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
        String fileDomande;
        String fileRisposte;

        public gestioneFile()
        {
            fileDomande = @"D:\BALLABIO_GIT\OpenDay\CodiceBallabio\PROGETTO1.1\WindowsFormsApplication1\WindowsFormsApplication1\Domande_Informatica.csv";
            fileRisposte = @"D:\BALLABIO_GIT\OpenDay\CodiceBallabio\PROGETTO1.1\WindowsFormsApplication1\WindowsFormsApplication1\risposte.csv";
            questionario = new List<domanda>();
            risposte = new List<risposte>();
            scelte = new List<scelteCheck>();
            radio = new List<scelteRadio>();
            caricaQ();
            caricaFileRisposte();
        }

        //creazione questionario totale!
        public void caricaQ()
        {
            string[] d;
            string[] allLines = File.ReadAllLines(fileDomande);
            
            
            for (int i = 0; i < 41; i++)
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
                risp.setRisposte( d[2].ToString() , d[3].ToString() , d[4].ToString());
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
            var newLine = " ";

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