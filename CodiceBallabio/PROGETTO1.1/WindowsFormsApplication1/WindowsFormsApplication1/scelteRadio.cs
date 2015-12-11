using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class scelteRadio
    {
        private String opzioneA;
        private String opzioneB;
        private int quante;

        public scelteRadio()
        {
            opzioneA = "";
            opzioneB = "";
            quante=0;
        }

        public void setScelte(String []d)
        {
            quante += 2;
            opzioneA = d[quante-=2].Substring(1);
            quante += 2;
            opzioneB = d[quante-=1].Substring(1);
            quante += 1;
            
        }

        public String getA()
        {
            return opzioneA;
        }

        public String getB()
        {
            return opzioneB;
        }
    }
}
