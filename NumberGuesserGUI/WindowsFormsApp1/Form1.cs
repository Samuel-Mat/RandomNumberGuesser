using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int guessedNumber = 0;
        int winNumber;
        int counter = 0;
        bool playMusic = false;
        SoundPlayer simpleSound = new SoundPlayer(@"C:\Daten\BBBaden\Lernatelier_2\LA-1\musicReal.wav");





        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                guessedNumber = Int32.Parse(textBox1.Text);

                if (guessedNumber == winNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    richTextBox1.Text = ("Bravo, Sie haben die richtige Zahl erraten. Die Zahl war " + winNumber);
                    Console.WriteLine("Die Zahl war " + winNumber);
                    textBox1.Enabled = false;
                    button3.Visible = true;
                    textBox1.Clear();
                    button1.Visible = false;
                }
                else
                {

                    if (guessedNumber < winNumber)
                    {

                        richTextBox1.Text = ("Ihre Zahl ist kleiner als die gesuchte Zahl");
                        counter++;
                        richTextBox2.Text = Convert.ToString(counter);

                    }
                    else
                    {

                        richTextBox1.Text = ("Ihre Zahl ist grösser als die gesuchte Zahl");
                        counter++;
                        richTextBox2.Text = Convert.ToString(counter);

                    }
                }
            }
            catch (Exception)
            {
                richTextBox1.Text = ("Wählen sie bitte nur ganze Zahlen zwischen 1 bis 100");
            }
        }


        private void Form1_Activated(object sender, EventArgs e)
        {
            richTextBox1.Text = "Herzlich Wilkommen zum Zahlen Rate Spiel. Wählen Sie eine ganze Zahl zwischen 1 und 100:";
            Random rdNumber = new Random();
            winNumber = rdNumber.Next(0, 100);
            textBox1.MaxLength = 2;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Herzlich Wilkommen zum Zahlen Rate Spiel. Wählen Sie eine ganze Zahl zwischen 1 und 100:";
            Random rdNumber = new Random();
            winNumber = rdNumber.Next(0, 101);
            textBox1.Enabled = true;
            counter = 0;
            richTextBox2.Text = Convert.ToString(counter);
            button3.Visible = false;
            button1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (playMusic == false)
            {
                
                simpleSound.Play();
                playMusic = true;
                button4.Text = "Musik Stoppen";
            }
            else
            {
                simpleSound.Stop();
                playMusic = false;
                button4.Text = "Musik abspielen";
            }
            
        }
    }
}
