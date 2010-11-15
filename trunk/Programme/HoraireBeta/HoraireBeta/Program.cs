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

           /* Loader loader = new Loader();

            loader.loadPoste();
            loader.LoadProfil();
            loader.LoadEquipe();
            loader.loadBloc();

             CreateXml xml = new CreateXml();
            xml.CreateProfileXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoraireBeta(loader));*/

            Loader l = new Loader();

            l.loadPoste();
            l.LoadProfil();

          

            l.LoadEquipe();
            l.loadBloc();
            l.loadErreurs();
            l.bloc.ElementAt(0).addRessourceVoulue(1, l.posteCharge.ElementAt(0));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoraireBeta(l));

           // TabSchedule t = new TabSchedule();
            //t.generate(l.bloc, l.profilCharge);




        }
    }
}
