using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17._01._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Height = 30;
        }
        int vstup, ciferny_soucet;
        bool konec = false;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Na vstupu je celé kladné číslo n. Pomocí MessageBox vypište ciferný součet. Do komponenty ListBox vypište všechny jeho dělitele.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Ciferný součet čísla " + vstup + " je: " + ciferny_soucet + "\n");            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Start();
            konec = false;
            label1.Text = "Dělitelé čísla: ";
            try
            {                            
                vstup = Convert.ToInt32(numericUpDown1.Value);
                label1.Text += vstup.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }

            int pocet = 0;
            listBox1.Items.Clear();
            listBox1.Height = 30;
            for (int i = 1; i <= vstup / 2; i++)
            {                
                if (vstup % i == 0)
                {                    
                    listBox1.Items.Add(i.ToString());
                    pocet++;
                }
                if (pocet <= 10) listBox1.Height = 17 + 13 * (pocet - 1);
            }

            ciferny_soucet = 0;
            for (int i = vstup; i > 0; i /= 10)
            {
                ciferny_soucet += i % 10;                 
            }
            
        }
    }
}
