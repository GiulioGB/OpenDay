using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   
    class Vettore
    {
        List<domanda> questionario;
        List<domanda> risposte;
        String fileName, fileFinale;
        public Vettore()
        { 
            questionario = new List<domanda>();
            risposte = new List<domanda>();
            fileName = "";
            fileFinale = "";
            LeggiFile(fileName);
        
        }

        public void ScriviFileRisposte(String fileFinale)
        {
            domanda s ;
            // Write sample data to CSV file
            using (CsvFileWriter writer = new CsvFileWriter(fileName))
            {
                for (int i = 0; i < 100; i++)
                {
                    s = risposte.ElementAt(i);
                    CsvRow row = new CsvRow();
                    row.Add(String.Format(s.ToString()));
                    writer.WriteRow(row);
                }
            }
        }

        public void LeggiFile(String fileName)
        {
            
            // Read sample data from CSV file
            using (CsvFileReader reader = new CsvFileReader(fileName))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    domanda d = new domanda(row.ToArray());
                    //foreach (string str in row)
                    //{
                    //    dom = new domanda(str);
                    //    questionario.Add(dom);
                    //}
                    questionario.Add(d);
                }
            }
        }




    }
}
