using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_i_cistella_2
{
    /// <summary>
    /// Creem la classe Producte amb els seus atributs,constructors,propietats i els seus mètodes
    /// </summary>
    internal class Producte
    {
        //Atributs(privats)-->són les característiques que defineixen la classe
        /// <summary>
        /// Atribut del nom del producte
        /// </summary>
        private string nom;
        /// <summary>
        /// Atribut del preu inicial
        /// </summary>
        private double preu_sense_iva;
        /// <summary>
        /// Atribut del IVA assignat
        /// </summary>
        private double iva;
        /// <summary>
        ///Atribut de la Quantitat de productes en stock
        /// </summary>
        private int quantitat;

       
        //Constructors (publiques)--->s'executen per crear o destruir un objecte
        /// <summary>
        /// Constructor buit posar iva al 21%, quantitat a 0
        /// </summary>
        public Producte()
        {
            quantitat = 0;
            iva = preu_sense_iva * 0.21;
        }
        /// <summary>
        /// Constructor amb el paràmetre nom
        /// </summary>
        /// <param name="nom">És el nom del producte de tipus string</param>
        public Producte(string nom)
        {

        }
        /// <summary>
        /// Constructor amb nom i preu inicial
        /// </summary>
        /// <param name="nom">És el nom del producte de tipus string</param>
        /// <param name="preu_sense_iva">És el preu inicial del prducte de tipus double </param>
        public Producte (string nom, double preu_sense_iva)
        {
            this.nom = nom;
            this.preu_sense_iva = preu_sense_iva;
      

        }
        /// <summary>
        /// Constructor amb paràmetres (nom,preusenseiva i iva)
        /// </summary>
        /// <param name="nom">És el nom del producte de tipus string</param>
        /// <param name="preu_sense_iva">És el preu inicial del producte de tipus double</param>
        /// <param name="iva">És l'IVA assignat de tipus double</param>
        public Producte(string nom, double preu_sense_iva, double iva)
        {

        }
        /// <summary>
        /// Constructor complet
        /// </summary>
        /// <param name="nom">És el nom del producte de tipus string</param>
        /// <param name="preu_sense_iva">És el preu inicial del producte de tipus double</param>
        /// <param name="iva">És l'IVA assignat de tipus double</param>
        /// <param name="quantitat">´És la quantitat de productes en stock de tipus int</param>
        public Producte (string nom,double preu_sense_iva,double iva, int quantitat)
        {
            this.nom = nom;
            this.preu_sense_iva = preu_sense_iva;
            this.iva = iva;
            this.quantitat = quantitat;
            StreamReader fitxer = new StreamReader(@".\Productes.csv");
            fitxer.Close();
        }
        /// <summary>
        /// Reaprofitar constructors
        /// </summary>
        /// <param name="nom">És el nom del producte de tipus string</param>
        /// <param name="preu_sense_iva">És el preu inicial del producte de tipus double</param>
        /// <param name="quantitat">És la quantitat de productes en stock de tipus int</param>
        public Producte(string nom, double preu_sense_iva, int quantitat)
        {
            this.nom = nom;
            this.preu_sense_iva = preu_sense_iva;
            this.quantitat = quantitat;
        }



        //b)Propietats --->una vegada tinc crada la classe(objecte),permet retornar o modificar els atributs (publiques)
      /// <summary>
      /// Propietat del atribut nom
      /// </summary>
        public string Nom
        {
            get { return nom; }
            set { Nom = value; }
        }
        /// <summary>
        /// Propietat del atribut preu inicial
        /// </summary>
        public double Preu_sense_iva
        {
            get { return preu_sense_iva; }
            set { preu_sense_iva = value; }
        }

        /// <summary>
        /// Propietat del atribut iva assignat
        /// </summary>
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }

        /// <summary>
        /// Propietat del atribut quantitat
        /// </summary>
        public int Quantitat
        {
            get { return quantitat; }
            set { quantitat = value; }
        }


        //Mètodes públics
        /// <summary>
        /// Mètode que retorna el preu del producte amb IVA
        /// </summary>
        /// <returns>retorna un preu númeric amb el preu amb l'iva inclòs</returns>
        public double Preu()
        {
            return iva;
        }

        /// <summary>
        /// Mètode que retorna un string
        /// </summary>
        /// <returns>retorna un String amb el text del nom, preu i quantitat</returns>
        public override string ToString()
        {
            string result = $"Nom : {nom}\n, el preu: {iva}, la quantitat{quantitat}: ";
            return result ;
        }



    }
}
