using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HoraireBeta
{
    public class Ressource
    {
        protected int id;
  

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
        public void draw(Bloc bloc, int i, Graphics gfx)
        {
        }

     }
}
