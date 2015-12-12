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
            this.numEl = 0;
            Domanda = new String[100];
        }

        public void setData()
        {
            this.Data = DateTime.Today.ToShortDateString();
        }

        public void setData(String d)
        {
            this.Data = d;
        }

        public void setId(Int32 id)
        {
            this.IdQuestionario = id;
        }

        public void setRisposte(String testo, String scelte, String risp)
        {
            Domanda[this.numEl] = testo + ";" + scelte + ";" + risp + ";";
            this.numEl = this.numEl+1;
        }

        
        public String getRow()
        {
            String row = IdQuestionario+";" + Data + ";";
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
