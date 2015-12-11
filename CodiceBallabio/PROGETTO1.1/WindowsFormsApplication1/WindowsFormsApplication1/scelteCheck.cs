using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class scelteCheck
    {
        private String scelta1;
        private String scelta2;
        private String scelta3;
        private String scelta4;
        private int quante;

        public scelteCheck()
        {
            scelta1 = "";
            scelta2 = "";
            scelta3 = "";
            scelta4 = "";
            quante = 0;
        }

        public void setScelte(String []d)
        {
            quante += 4;
            scelta1 = d[quante-=4].Substring(1);
            quante += 4;
            scelta2 = d[quante-=3].Substring(1);
            quante += 3;
            scelta3 = d[quante-=2].Substring(1);
            quante += 2;
            scelta4 = d[quante-=1].Substring(1);
            quante += 1;
        }

        public String getprima()
        {
            return scelta1;
        }

        public String getseconda()
        {
            return scelta2;
        }

        public String getterza()
        {
            return scelta3;
        }

        public String getquarta()
        {
            return scelta4;
        }
           
    }
}
