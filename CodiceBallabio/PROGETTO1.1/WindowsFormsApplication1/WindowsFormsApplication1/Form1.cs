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
        //Random random;
        int numeroCasuale;
        int numeroMAX;
        int inizio1;
        int inizio2;
        int indiceCK;
        int indiceRD;
        public Form1()
        {
            Liste = new gestioneFile();
            //random = new Random();
            contatore = 0;
            numeroCasuale = 0;
            numeroMAX = 20;
            inizio1 = 2;
            inizio2 = 15;
            indiceCK = 0;
            indiceRD = 0;
            InitializeComponent();
        }

        //TEST 1
        private void setRispostaAperta1() //1
        {
            //visualizzazione 
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
            button2.Visible = false; //CONSEGNA
            button1.Visible = true; //--> 1
            button7.Visible = true; //<-- 1
            button3.Visible = false; //<-- 2
            button4.Visible = false; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            //---

        }
        private void setRispostaMultipla1() //1
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
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


        }
        private void setRispostaMultiplaSingola1() //1
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
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
        
        }
        private void setVF1() //1
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
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
        
        }
        private void fine1() //1 
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = false; //CONOS
            label4.Visible = false; //BENVEN
            label7.Visible = true; //FINE
            label10.Visible = false; //TESTO DOMANDA
            label11.Visible = false; //DOPO AVER...
            label12.Visible = true; //PUNTEGGIO CONSI
            label13.Visible = true; //PUNTEGGIO OTT
            textBox1.Visible = false; //BARRA BIANCA
            button8.Visible = false; //INZIO
            button9.Visible = false; //TEST CON
            button10.Visible = false; //TEST GENER
            pictureBox1.Visible = false; //LOGO
            button2.Visible = true; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = true; //<-- 1
            button3.Visible = false; //<-- 2
            button3.Visible = false; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
        }
        private void button9_Click(object sender, EventArgs e) //Inizia Test A
        {
            pictureBox1.Visible = false;
            numeroCasuale = inizio1; //parte con Nome Cognome
            contatore+=1;
            if(contatore<numeroMAX)
            {
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta1();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla1();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);
                                        
                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK += 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola1();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF1();
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD += 1;
                    //
                }
            }
            else
            {
                button7.Visible = false;
            }
                            


        }
        private void button1_Click(object sender, EventArgs e) //avanti A
        {
            
            if (contatore < numeroMAX)
            {
                contatore += 1;   
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);

                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK += 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD += 1;
                    //
                }
                
            }
            else
            {
                fine1();
            }
        }
        private void button7_Click(object sender, EventArgs e) //indietro A
        {
            if (contatore >1)
            {
                contatore -= 1;
                
                numeroCasuale--; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);

                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK -= 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF1();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD -= 1;
                    //
                }
            }
            else
            {
                button7.Visible = false;
            }
        }

        //FINE TEST 1

        //TEST 2
        
        private void setRispostaAperta2() //2
        {
            //visualizzazione 
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
            button2.Visible = false; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = false; //<-- 1
            button3.Visible = true; //<-- 2
            button4.Visible = true; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            //---

        }
        private void setRispostaMultipla2() //2
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
            button2.Visible = false; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = false; //<-- 1
            button3.Visible = true; //<-- 2
            button4.Visible = true; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            checkBox9.Visible = true;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            //---

        }
        private void setRispostaMultiplaSingola2() //2
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
            button2.Visible = false; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = false; //<-- 1
            button3.Visible = true; //<-- 2
            button4.Visible = true; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            //---

        }
        private void setVF2() //2
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = true; //CONOS
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
            pictureBox1.Visible = false; //LOGO
            button2.Visible = false; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = false; //<-- 1
            button3.Visible = true; //<-- 2
            button4.Visible = true; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            //---

        }
        private void fine2() //2 
        {
            //visualizzazione
            label3.Visible = false; //IIS
            label6.Visible = false; //GENERALITA
            label5.Visible = false; //CONOS
            label4.Visible = false; //BENVEN
            label7.Visible = true; //FINE
            label10.Visible = false; //TESTO DOMANDA
            label11.Visible = false; //DOPO AVER...
            label12.Visible = true; //PUNTEGGIO CONSI
            label13.Visible = true; //PUNTEGGIO OTT
            textBox1.Visible = false; //BARRA BIANCA
            button8.Visible = false; //INZIO
            button9.Visible = false; //TEST CON
            button10.Visible = false; //TEST GENER
            pictureBox1.Visible = false; //LOGO
            button2.Visible = true; //CONSEGNA
            button1.Visible = false; //--> 1
            button7.Visible = false; //<-- 1
            button3.Visible = true; //<-- 2
            button4.Visible = false; //--> 2
            checkBox10.Visible = false;  //sempre cosi
            checkBox6.Visible = false;
            checkBox7.Visible = false;
            checkBox8.Visible = false;
            checkBox9.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
        }
        private void button10_Click(object sender, EventArgs e) //Inizia Test B
        {
            pictureBox1.Visible = false;
            numeroCasuale = inizio2;
            
            contatore += 1;
            if (contatore < numeroMAX)
            {
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta2();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);

                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK += 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla2();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola2();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF2();
                    //assegnamento
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD += 1;
                    //
                }
            }
            else
            {
                button3.Visible = false;
                button7.Visible = false;
            }
        }
        private void button3_Click(object sender, EventArgs e) //indietro 2
        {
            if (contatore > 1)
            {
                contatore -= 1;

                numeroCasuale--; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);

                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK -= 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD -= 1;
                    //
                }
            }
            else
            {
                button3.Visible = false;
            }
        }
        private void button4_Click(object sender, EventArgs e) //avanti 2
        {

            if (contatore < numeroMAX)
            {
                contatore += 1;
                numeroCasuale++; // numeroCasuale = random.Next(1, 41);
                if (Liste.getTipo(numeroCasuale).Equals("Risposta aperta"))
                {
                    setRispostaAperta2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla"))
                {
                    setRispostaMultipla2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento scelte
                    Liste.OttieniScelteCK(numeroCasuale);

                    checkBox6.Text = Liste.getprima(indiceCK);

                    checkBox7.Text = Liste.getseconda(indiceCK);

                    checkBox8.Text = Liste.getterza(indiceCK);

                    checkBox9.Text = Liste.getquarta(indiceCK);

                    indiceCK += 1;
                    //
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Risposta multipla singola"))
                {
                    setRispostaMultiplaSingola2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                }
                else if (Liste.getTipo(numeroCasuale).Equals("Vero o Falso"))
                {
                    setVF2();
                    //assegnamenti
                    label10.Text = Liste.getTesto(numeroCasuale);
                    //assegnamento
                    Liste.OttieniScelteRD(numeroCasuale);

                    label10.Text = Liste.getTesto(numeroCasuale);

                    radioButton7.Text = Liste.getA(indiceRD);
                    radioButton8.Text = Liste.getB(indiceRD);

                    indiceRD += 1;
                    //
                }

            }
            else
            {
                fine2();
            }
            
        }

        //FINE TEST 2
        
    }
}
