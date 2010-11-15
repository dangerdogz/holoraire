using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    public class Parametre
    {

        private static Parametre instance;
        public int endTime = 24;
        public int startTime = 0;

        private Parametre()
        {

          
        }

        public static Parametre getInstance()
        {
            if (instance != null)
            {
                instance = new Parametre();
            }

            return instance;
        }
    }
}
