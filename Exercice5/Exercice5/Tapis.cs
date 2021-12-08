using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice5
{
    /// <summary>
    /// Cette classe permet de gérer des tapis
    /// </summary>
    class Tapis
    {
        public string nom { get; set; }
        public int dimensionX { get; }
        public int dimensionY { get; }
        public string couleur { get; }
        
        /// <summary>
        /// Permet d'initialiser un tapis
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="dimensionX"></param>
        /// <param name="dimensionY"></param>
        /// <param name="couleur"></param>
        

        public Tapis(string nom, int dimensionX, int dimensionY, string couleur)
        {           
            this.nom = nom;
            this.dimensionX = dimensionX;
            this.dimensionY = dimensionY;
            this.couleur = couleur;
        }

        /// <summary>
        /// Permet de changer le nom d'un tapis
        /// </summary>
        /// <param name="nom"></param>

        public void ChangeNom(string nom)
        {
            this.nom = nom;
        }

        /// <summary>
        /// Retourne l'aire du tapis
        /// </summary>
        /// <returns></returns>

        public int GetSuperficie()
        {
            return dimensionX * dimensionY;
        }
    }
}
