using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        gestioneFile Liste;
        public Form1()
        {
            Liste = new gestioneFile();
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Liste.getTipo(1).Equals("Risposta aperta"))
            {
                label3.Visible = false; //IIS
                label6.Visible = false; //GENERALITA
                label5.Visible = false; //CONOS
                label4.Visible = false; //BENVEN
                label7.Visible = false; //FINE
                label10.Visible = true; //TESTO DOMANDA sempre true
                label11.Visible = false; //DOPO AVER...
                label12.Visible = false; //PUNTEGGIO CONSI
                label13.Visible = false; //PUNTEGGIO OTT
                textBox1.Visible = true; //BARRA BIANCA
                button8.Visible = false; //INZIO
                button9.Visible = false; //TEST CON
                button10.Visible = false; //TEST GENER
                pictureBox1.Visible = true; //LOGO
                button2.Visible = false; //CONSEGNA
                button1.Visible = true; //-->
                button7.Visible = true; //<--
                checkBox10.Visible = false;  //sempre cosi
                checkBox6.Visible = false; 
                checkBox7.Visible = false;
                checkBox8.Visible = false;
                checkBox9.Visible = false;




            }
            else if (Liste.getTipo(1).Equals("Ripsosta multipla"))
            {

            }
            else if (Liste.getTipo(1).Equals("Ripsosta multipla singola"))
            {

            }
            else if (Liste.getTipo(1).Equals("Vero o Falso"))
            {

            }
                            


        }
    }
}
