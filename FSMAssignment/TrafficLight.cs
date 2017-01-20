using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMAssignment
{
    class TrafficLight
    {


        public TrafficLight(int RedLight, int GreenLight, int YellowLight)
        {

            RedLight = m_redlight;
            GreenLight = m_greenlight;
            YellowLight = m_yellowlight;

        }



        public int SwitchLight(int CurrentLight)
        {

            return CurrentLight;

        }


        //public int RedLight;
        //public int GreenLight;
        //public int YellowLight;
        private int m_redlight;
        private int m_greenlight;
        private int m_yellowlight;
        private int m_currentlight;

    }




}
