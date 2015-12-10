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
        int contatore;
        Random random;
        int numeroCasuale;
        public Form1()
        {
            Liste = new gestioneFile();
            random = new Random();
            contatore = 0;
            numeroCasuale = 0;
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            contatore+=1;
            if(contatore<=20)
            {
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    //visualizzazione 
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
                    button8.Visible = false; //INZIO
                    button9.Visible = false; //TEST CON
                    button10.Visible = false; //TEST GENER
                    pictureBox1.Visible = true; //LOGO
                    button2.Visible = false; //CONSEGNA
                    button1.Visible = true; //-->
                    button7.Visible = true; //<--
                    checkBox10.Visible = false;  //sempre cosi
                    checkBox6.Visible = true;
                    checkBox7.Visible = true;
                    checkBox8.Visible = true;
                    checkBox9.Visible = true;
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla singola"))
                {
                    //visualizzazione
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
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
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    //---
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
            }
            
                            


        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contatore+=1;
            if (contatore <= 20)
            {
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    //visualizzazione 
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
                    button8.Visible = false; //INZIO
                    button9.Visible = false; //TEST CON
                    button10.Visible = false; //TEST GENER
                    pictureBox1.Visible = true; //LOGO
                    button2.Visible = false; //CONSEGNA
                    button1.Visible = true; //-->
                    button7.Visible = true; //<--
                    checkBox10.Visible = false;  //sempre cosi
                    checkBox6.Visible = true;
                    checkBox7.Visible = true;
                    checkBox8.Visible = true;
                    checkBox9.Visible = true;
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla singola"))
                {
                    //visualizzazione
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
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
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            contatore -= 1;
            if (contatore >=1)
            {
                numeroCasuale--; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    //visualizzazione 
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
                    button8.Visible = false; //INZIO
                    button9.Visible = false; //TEST CON
                    button10.Visible = false; //TEST GENER
                    pictureBox1.Visible = true; //LOGO
                    button2.Visible = false; //CONSEGNA
                    button1.Visible = true; //-->
                    button7.Visible = true; //<--
                    checkBox10.Visible = false;  //sempre cosi
                    checkBox6.Visible = true;
                    checkBox7.Visible = true;
                    checkBox8.Visible = true;
                    checkBox9.Visible = true;
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Ripsosta multipla singola"))
                {
                    //visualizzazione
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
                    radioButton7.Visible = false;
                    radioButton8.Visible = false;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    //visualizzazione
                    label3.Visible = false; //IIS
                    label6.Visible = false; //GENERALITA
                    label5.Visible = false; //CONOS
                    label4.Visible = false; //BENVEN
                    label7.Visible = false; //FINE
                    label10.Visible = true; //TESTO DOMANDA sempre true
                    label11.Visible = false; //DOPO AVER...
                    label12.Visible = false; //PUNTEGGIO CONSI
                    label13.Visible = false; //PUNTEGGIO OTT
                    textBox1.Visible = false; //BARRA BIANCA
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
                    radioButton7.Visible = true;
                    radioButton8.Visible = true;
                    //---
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
            }
        }
    }
}
