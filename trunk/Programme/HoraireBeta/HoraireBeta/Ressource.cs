using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireBeta
{
    public class Ressource
    {
        private int id;
        private int heuresMax = 0;
        private int heuresTravaillees = 0;

        public Ressource()
        {

        }

        public Ressource(int id)
        {
            setId(id);
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public List<Bloc> getPref()
        {
            return (new List<Bloc>());
        }

        public List<Bloc> getDispo()
        {
            return (new List<Bloc>());
        }

        public int getHeuresMax()
        {

            return heuresMax;
        }

        public int getHeuresTravaillees()
        {

            return heuresTravaillees;
        }




    }
}
