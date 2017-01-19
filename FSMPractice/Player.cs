using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSMPractice
{
    // First class to work on
    // Evreything that is here, (that is not commented), is required to get the windform working.


    /// <summary>
    /// 
    /// </summary>
    class Player
    {

        
        public delegate void OnEndTurn();
        public OnEndTurn onEndTurn;


        public delegate void OnPartyEnd();
        public OnPartyEnd onPartyEnd;


        public Player( string Name, /*int Attack, int Defend,*/ int EndTurn )
        {

            Name = m_name;
            EndTurn = m_endTurn;

        }


        //public Player(/*int Health, int TurnNum,*/ /*int ContinuingTurn, int EndingTurn*/ /*string Name*/)
        //{

        //m_health = Health;
        //m_turnNum = TurnNum;
        //m_continuingTurn = ContinuingTurn;
        //m_endingTurn = EndingTurn;

        //}

            
        public void EndTurn()
        {

            if (onEndTurn != null)
            {
                onEndTurn.Invoke();
            }

            else
            {
                
            }

        }


        public bool NextPlayer()
        {

            return false;

        }


        public void EndParty()
        {

            

        }


      


        //public string Name;
        //public int Attack;
        //public int Defend;
        //public bool EndTurn;

        private string m_name;
        //private int m_attack;
        //private int m_defend;
        private int m_endTurn;

        //private int m_health;
        //private int m_turnNum;

        //private int m_endingTurn;
        //private int m_continuingTurn;

    }
}
