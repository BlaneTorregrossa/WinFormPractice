using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FSMAssignment
{

    /* Goal: Have a working FSM (Finite State Machine) that can be used for a trafic light.
       The Finite State Machine should have 5 states (Init(0), RedLight(1), GreenLight(2), YellowLight(3), Exit(100)) and 7 transistions to certain states.
       Conditions for transistions between the lights are dependent on a timer passing certain values.
       COnditions for a transition to the Exit state is when the user inputs 'p'.

        enum LightState
     {
        INIT = 0,
        RedLight = 1,
        GreenLight = 2,
        YellowLight = 3,
        Exit = 100,
    }



    */


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
