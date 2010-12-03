using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HoraireBeta
{
    public class Profil : Ressource
    {
        private string prenom;
        private string nom;
        private string email;
        private string numTelephone;
        private int anciennete;
        private int heuresTravaillees;
        private int heuresMax;
        private bool mod;
        private List<Poste> poste = new List<Poste>();
        private List<Bloc> preference = new List<Bloc>();
        private List<Bloc> disponibilite = new List<Bloc>();
        private Poste posteassgine;

        public Profil() { }

        public Profil(Poste poste, string prenom, string nom, string email, int heureMax, string numTelephone, int anciennete)
        {

            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            setHeuresMax(heureMax);
            this.poste.Add(poste);
            mod = false;

        }

        public Profil(string prenom, string nom, string email, string numTelephone, int anciennete, int heureMax)
        {
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            id = -1;
            setHeuresMax(heureMax);
            mod = false;

        }


        public Profil(string prenom, string nom, string email, string numTelephone, int anciennete)
        {
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            id = -1;
            heuresMax = 0;
            mod = false;

        }

        public Profil(int id, string prenom, string nom, string email, string numTelephone, int anciennete,int heurmax)
        {
            setId(id);
            setPrenom(prenom);
            setNom(nom);
            setEmail(email);
            setNumTelephone(numTelephone);
            setAnciennete(anciennete);
            heuresMax = heurmax;
            mod = true;

        }

        public void setPrenom(string prenom)
        {
            this.prenom = prenom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void SetPosteAssigne(Poste newposte){this.posteassgine=newposte;}

        public Poste getPosteAssigne() { return posteassgine; }

        public void setNumTelephone(string numTelephone)
        {
            this.numTelephone = numTelephone;
        }

        public void setAnciennete(int anciennete)
        {
            this.anciennete = anciennete;
        }

        public void setHeuresTravaillees(int heuresTravaillees)
        {
            this.heuresTravaillees = heuresTravaillees;
        }

        

        public int getHeuresMax()
        {

            return (heuresMax);
        }

        public void setHeuresMax(int heuresMax) {
            this.heuresMax = heuresMax;
        }
        public void setPoste(Poste poste)
        {
          this.poste.Add(poste);
        }

        public String getPrenom()
        {
            return prenom;
        }

        public String getNom()
        {
            return nom;
        }

        public String getEmail()
        {
            return email;
        }

        public String getNumTelephone()
        {
            return numTelephone;
        }

        public int getAnciennete()
        {
            return anciennete;
        }

        public int getHeuresTravaillees()
        {
            return heuresTravaillees;
        }

        public Poste getPoste(int num) 
        {
         return (poste[num]);
        }

        public List<Poste> getPoste()
        {
            return poste;
        }

        public void addDispo(Bloc dispo)
        {
            disponibilite.Add(dispo);
        }

        public void addPref(Bloc pref)
        {
            preference.Add(pref);
        }

        public List<Bloc> getPref(){
            return (preference);
        }

        public List<Bloc> getDispo()
        {
            return (disponibilite);
        }

        public void robert()
        {
            MessageBox.Show("robert");
        }

        public void save()
        {
            
            DBConnect proc = new DBConnect();
            if (mod == false)
            {
                proc.ajouterProfil(id, prenom, nom, numTelephone, heuresMax, 0, email, anciennete);
                foreach (Ressource lui in poste)
                {

                    proc.addPosteProfil(lui.getId(), id);
                    mod = true;
                    
                }

            }
            else
                if(mod == true)
                {
                    proc.modifierProfil(id, prenom, nom, numTelephone, heuresMax, 0, email, anciennete);
                    proc.deletePosteProfil(id);
                    foreach (Ressource lui in poste)
                    {
                        proc.addPosteProfil(lui.getId(), id);
                    }
                }
            proc.deleteProfilPreference(id);
            
            foreach (Bloc pref in preference)
            {
                if (pref.getId()<0)
                    proc.addPlage(pref.getDebut().ToString("yyyy-MM-dd HH:mm:ss"), pref.getFin().ToString("yyyy-MM-dd HH:mm:ss"), Loader.SemaineToInt(pref.getFin()));
                proc.addProfilPreference(id, Convert.ToInt32(proc.getLastStuff("Plage").Rows[0]["idPlage"].ToString()));
            }
            proc.deleteProfilDispo(id);

            foreach (Bloc dispo in disponibilite)
            {
                proc.addPlage(dispo.getDebut().ToString("yyyy-MM-dd HH:mm:ss"), dispo.getFin().ToString("yyyy-MM-dd HH:mm:ss"), Loader.SemaineToInt(dispo.getFin()));
                proc.addProfilDispo(id, Convert.ToInt32(proc.getLastStuff("Plage").Rows[0]["idPlage"].ToString()));
            }
        }

        public void save(bool mod)
        {

            DBConnect proc = new DBConnect();
            if (mod == false)
            {
                proc.ajouterProfil(id, prenom, nom, numTelephone, heuresMax, 0, email, anciennete);
                foreach (Ressource lui in poste)
                {

                    proc.addPosteProfil(lui.getId(), id);
                    mod = true;

                }

            }
            else
                if (mod == true)
                {
                    proc.modifierProfil(id, prenom, nom, numTelephone, heuresMax, 0, email, anciennete);
                    proc.deletePosteProfil(id);
                    foreach (Ressource lui in poste)
                    {
                        proc.addPosteProfil(lui.getId(), id);
                    }
                }
            proc.deleteProfilPreference(id);

            foreach (Bloc pref in preference)
            {
                if (pref.getId() < 0)
                    proc.addPlage(pref.getDebut().ToString("yyyy-MM-dd HH:mm:ss"), pref.getFin().ToString("yyyy-MM-dd HH:mm:ss"), Loader.SemaineToInt(pref.getFin()));
                proc.addProfilPreference(id, Convert.ToInt32(proc.getLastStuff("Plage").Rows[0]["idPlage"].ToString()));
            }
            proc.deleteProfilDispo(id);

            foreach (Bloc dispo in disponibilite)
            {
                proc.addPlage(dispo.getDebut().ToString("yyyy-MM-dd HH:mm:ss"), dispo.getFin().ToString("yyyy-MM-dd HH:mm:ss"), Loader.SemaineToInt(dispo.getFin()));
                proc.addProfilDispo(id, Convert.ToInt32(proc.getLastStuff("Plage").Rows[0]["idPlage"].ToString()));
            }
        }

        public void draw(Bloc bloc,int i, Graphics gfx)
        {
            Font laFont = new Font("Arial", 16);
            SolidBrush brush = new SolidBrush(Color.Red);


            int x = bloc.getX();
            int y = bloc.getY() + (i * 20) + 20;

            Point coin = new Point(x, y);
           
            gfx.DrawString(nom + " " + prenom, laFont, brush, coin);
            
        }


        public bool modifierBloc(Bloc leBloc, Bloc leBloc2, bool isPref)
        {
            int nbBloc;
            bool blocTrouve = false;
            List<Bloc> blocs = null;

            if (isPref)
                blocs = getPref();
            else
                {
                blocs = getDispo();
                }

            nbBloc = blocs.Count;
            //Les conditions a modifier devront être unique a chaque blocs
            for (int i = 0; i < nbBloc; i++)
            {
                if (blocs[i].getDebut() == leBloc.getDebut())
                {
                    blocs[i] = leBloc2;
                    blocTrouve = true;
                    break;
                }

            }

            return blocTrouve;

        }


        public List<Bloc> getBlocFromDate(DateTime day, bool isPref)
        {
            List<Bloc> temp = new List<Bloc>();
            List<Bloc> bloc = null;
            if (isPref)
                bloc = getPref();
            else
                if (!isPref)
                    bloc = getDispo();

            if (bloc.Count != 0)
            {
                for (int i = 0; i < bloc.Count; i++)
                {

                    DateTime datebloc = bloc.ElementAt(i).getDebut();
                    if (datebloc.DayOfYear == day.DayOfYear && datebloc.Month == day.Month && datebloc.Year == day.Year)
                    {
                        temp.Add(bloc.ElementAt(i));

                    }
                }
            }
            return temp;
        }

    }
}
