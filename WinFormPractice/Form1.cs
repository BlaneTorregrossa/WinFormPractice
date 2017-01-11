using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPractice
{


    // EXP needed for new Level is: Current Level multiplied by the Original EXP requirment to Level up (Lvl * Exp = LvlReq).
    // Button increases Player EXP and as the player Levels up the progress bar resets and the amount of Exp need to level up increases.
    // Need a counter for current Player Level


    class Player : Form1
    {
        Player() { }
        private int m_exp = 0;
        public int Exp
        {
            get { return m_exp; }
            set { value = m_exp; }
        }


    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void button1_Click(object sender, EventArgs e)                  // Button labled "button1"
        {
            progressBar1.Value += 5;                                            // Increases Progress Bar by 5 if "button1" is pressed.
            

            if (progressBar1.Value == 100)                                      // If the Progress Bar's value is equal to 100 then Text in the textbox is displayed as "Level Up!" and the Progress Bar's value is set to 0.
            {
                textBox1.Text = "Level Up!!!";
                progressBar1.Value = 0;      
                
            }

            
        }

        private void button2_Click(object sender, EventArgs e)                  // Button labled "button2"
        {
            progressBar1.Value -= 5;                                           // Decreases Progress Bar by 5 if "button2" is pressed.
        }

     

        private void progressBar1_Click(object sender, EventArgs e)             // Progress Bar
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)           // Text Box
        {

        }

       
    }
}
