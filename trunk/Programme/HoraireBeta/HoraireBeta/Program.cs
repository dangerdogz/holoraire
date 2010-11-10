using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HoraireBeta
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Loader l = new Loader();

            l.loadPoste();
            l.LoadProfil();

          

            l.LoadEquipe();
            l.loadBloc();
            l.bloc.ElementAt(0).addRessourceVoulue(1, l.posteCharge.ElementAt(0));

            TabSchedule t = new TabSchedule();
            t.generate(l.bloc, l.profilCharge);




        }
    }
}
