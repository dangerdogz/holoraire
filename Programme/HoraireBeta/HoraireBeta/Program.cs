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
            /*CreateXml xml = new CreateXml();
            xml.CreateProfileXml();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HoraireBeta());*/

            Loader l = new Loader();
            TabSchedule tab = new TabSchedule();


            l.loadPoste();
            l.LoadProfil();
            l.LoadEquipe();
            l.loadBloc();

            l.bloc.ElementAt(2).addRessourceVoulue(1, l.posteCharge.ElementAt(0));

            tab.generate(l.bloc, l.profilCharge);








        }
    }
}
