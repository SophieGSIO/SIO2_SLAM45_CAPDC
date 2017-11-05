using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassCapdc
{
    public class Parcelle
    {
        // attributs privés
        private string id;
        private string nomExploitant;
        private string especeCultivee;
        private DateTime dateSemis;
        private DateTime dateRecoltePrevue;
        private double surface;
        private List<TraitementPhytosanitaire> lesTraitementsPhyto;

        // constructeur
        public Parcelle(string unId, string unExploitant, string uneEspece, DateTime uneDateSemis, DateTime uneDateRecolte, double uneSurface)
        {
            this.id = unId;
            this.nomExploitant = unExploitant;
            this.especeCultivee = uneEspece;
            this.dateSemis = uneDateSemis;
            this.dateRecoltePrevue = uneDateRecolte;
            this.surface = uneSurface;
            lesTraitementsPhyto = new List<TraitementPhytosanitaire>();
        }
        // méthodes
        public double GetSurface()
        {
            return this.surface;
        }
        public List<TraitementPhytosanitaire> GetLesTraitementsPhytosanitaires()
        {
            return this.lesTraitementsPhyto;
        }
        public void AjouteUnTraitement(TraitementPhytosanitaire unTraitement)
        {
            this.lesTraitementsPhyto.Add(unTraitement);
        }

        // A COMPLETER
    }
}
