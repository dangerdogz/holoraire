using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HoraireAlpha
{
    class Ressource
    {
        private int id;

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


    }
}
