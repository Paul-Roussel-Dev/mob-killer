using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Mob_Killer.Entities
{
    public class Joueur
    {
        public int IdJoueur { get; set; }

        public string NameJoueur { get; set; }

        public double HealthJoueur { get; set; }

        public double EvasionJoueur { get; set; }

        public int ItemId { get; set; }

        public Item Item { get; set; }

        public Joueur(Joueur joueur)
        {
            joueur.IdJoueur = this.IdJoueur;
            joueur.NameJoueur = this.NameJoueur;
            joueur.HealthJoueur = this.HealthJoueur;
            joueur.EvasionJoueur = this.EvasionJoueur;
            joueur.IdJoueur = this.IdJoueur;
            joueur.Item = this.Item;
        }
        public Joueur()
        {

        }
    }
}
