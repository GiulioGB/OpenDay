using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class risposte
    {
        int IdQuestionario;
        
        String Data;
        String[] Domanda;
        int numEl;

       
        public risposte()
        {
            int numEl = 0;
            Data = DateTime.Today.ToShortDateString();
        }

        public void setRisposte(int id , String testo, String scelte, String risp)
        {
            this.IdQuestionario = id;
            Domanda[numEl] = testo + scelte + risp;
            numEl++;
        }


        public String getRow()
        {
            String row = IdQuestionario + Data;
            for (int i = 0; i < numEl; i++)
                row = row + Domanda[i];

            return row;
        }

        public int getNumEl()
        {
            return numEl;
        }
    
    }
}
