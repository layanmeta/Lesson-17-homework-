using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Citizen
    {
        public string m_name;
        public Citizen[] m_children;
        public readonly int m_fatherID;
        public readonly int m_ID;
        public static int m_number_of_current_citizens;
        public const int m_max_numer_of_citizens =6000;

        public Citizen(string m_name, int m_fatherID)
        {
            this.m_name = m_name;
            this.m_fatherID = m_fatherID;
        }

        public Citizen(string m_name, int m_fatherID, int m_ID) : this(m_name, m_fatherID)
        {
            this.m_ID = m_ID;
        }


        static void Print_Number_Of_Citizens()
        {
            Console.WriteLine($"The number of citizens is : {m_max_numer_of_citizens} ");
            
        }

        static bool Reached_Half_Of_Maximum_Citizens()
        {
            
            if (m_number_of_current_citizens == m_max_numer_of_citizens / 2) 
            {
                return true;
            }
             else
            {
                return false;
            }
            
        }
        public void Print_ID()
        {

        }

        public void Pring_Gap_Between_My_ID_And_Father()
        {
            Console.WriteLine($" The gabe between my ID and father's is : {m_ID - m_fatherID}");
        }

        public void Set_Children(Citizen[])
        {
            Citizen[] children = new Citizen[]
            {

            };
        }
    }
}
