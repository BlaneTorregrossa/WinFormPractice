using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FSM
{

    class TrafficLight
    {

        public delegate void LightSwitch();
        public LightSwitch lightSwitch;


        public TrafficLight(int CurrentLight)
        {

            CurrentLight = m_currentLight;

        }



        public int Timer(int CurrentTime)
        {

            //CurrentTime = 0;
            //while (true)
            //    CurrentTime += 
            

            return CurrentTime;
        }


        //public int RedLight()
        //{
           

        //    return;
        //}



        //public int GreenLight()
        //{


        //    return;
        //}



        //public int YellowLight()
        //{


        //    return;
        //}


        //public int Exit()
        //{


        //    return;
        //}





        private int m_nextLight;
        private int m_currentLight;

    }

}
