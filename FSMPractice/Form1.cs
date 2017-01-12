using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Combat: 2 Parties: 1 PlayersPerParty: -EndTurn
//Classes for Combat, Party, and Player


namespace FSMPractice
{


    public partial class Form1 : Form
    {

        // The classes that below are required to have a working turn based system. 


        public class Player                        // Class for players 
        {
            private int m_characterturn = 1;


            public int PlayerTurn
            {
                get { return m_characterturn; }
                set { value = m_characterturn; }
            }


           

        }                                   

        public class Party                         // Class has to contain 2-3 players per party
        {


            private int m_party;
            private int m_partyturn = 1;


            public int PartyTurn
            {
                get { return m_partyturn; }
                set { value = m_partyturn; }
            }



            // Players must be used/accessed from here.

            


        }

        public class Combat                        // Class has to contain 2 parties 
        {
            private int m_turn;


            public int Turn
            {
                get { return m_turn; }
                set { value = m_turn; }
            }


            // Parties must be used/accessed from here

        }

        public Form1()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        



    }
}
