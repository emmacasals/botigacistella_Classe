using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_i_cistella_2
{
    internal class Producte
    {
        /// <summary>
        /// Els atributs són privats i són les característiques que defineixen la classe
        /// </summary>
        //Atributs 
        private string nom;// nom del producte
        private double preu_sense_iva;// preu inicial
        private double iva; // iva assignat
        private int quantitat;// quantitat de productes en stock


        //Constructors (publiques)--->s'executen per crear o destruir un objecte
        public Producte()
        {
            quantitat = 0;
            iva = preu_sense_iva * 0.21;
        }
        public Producte(string nom)
        {

        }

        public Producte(string nom, double preu_sense_iva)
        {

        }
        public Producte(string nom, double preu_sense_iva, double iva)
        {

        }

        public Producte(string nom, double preu_sense_iva, double iva, int quantitat)
        {

        }

        //b)Propietats --->una vegada tinc crada la classe(objecte),permet retornar o modificar els atributs (publiques)
        public string Nom
        {
            get { return nom; }
            set { Nom = value; }
        }

        public double Preu_sense_iva
        {
            get { return preu_sense_iva; }
            set { preu_sense_iva = value; }
        }


        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }


        public int Quantitat
        {
            get { return quantitat; }
            set { quantitat = value; }
        }


        //Mètodes públics


        public double Preu()
        {
            return iva;
        }


        public string ToString()

        {
            return $"Nom : {nom}\n, el preu: {iva}, la quantitat{quantitat}: ";
        }

    }
}
