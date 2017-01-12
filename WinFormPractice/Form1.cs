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


    // EXP needed for new Level is: Current Level multiplied by the Original EXP requirment to Level up (Lvl * Exp = LvlReq).                   [X]
    // Button increases Player EXP and as the player Levels up the progress bar resets and the amount of Exp need to level up increases.        [X]
    // Need a counter for current Player Level                                                                                                  [X]
    // Have Delegates used                                                                                                                      [ ]



         
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 100;                                          // Increases Progress Bar by 100 if "button1" is pressed.

            textBox3.Text = "";                                                 // Clears the text box of previous text that was present in textBox3
            textBox3.Text += progressBar1.Value;                                // Text Displays the current "Exp" gained by pushing the button.


            if (progressBar1.Value == progressBar1.Maximum)                     // If statement that activates if the Value of progressBar1 equals the set maximum given to itself
            {
                textBox4.Text = "Level Up!!!";                                  // Displays text "Level Up!!!" to textBox4
                progressBar1.Value = 0;                                         // Resets the value of progressBar4 back to 0
                progressBar1.Maximum = progressBar1.Maximum * 2;                // Sets the Maximum value allowed for progressBar1 to it's previous value miltiplied by 2
                progressBar2.Value += 1;                                        // Increases the value of progressBar2 by 1
                textBox2.Text = "";                                             // Clears the text box of previous text that was present in textBox2
                textBox2.Text += progressBar2.Value;                            // Displays the value of progressBar2 to textBox2
            }

            if (progressBar2.Value == progressBar2.Maximum)                     // If statement that activates if the value of progressBar2 is equal to the maximum set for itself
            {
                textBox4.Text = "Max Level!";                                   // Displays "Max Level!" to textBox4
                button1.Enabled = false;                                        // Disables button1 to prevent the addition of more "Exp"
            }


        }




        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
