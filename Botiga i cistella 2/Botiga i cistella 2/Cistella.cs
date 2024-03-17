using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace Botiga_i_cistella_2
{
    internal class Cistella
    {
        //Atributs
        private Botiga botiga;
        private DateTime data;
        private Producte[] productes;
        private int[] quantitat;
        private int nElements;
        private int diners;

        //Propietats
        public Botiga Botiga
        {
            get
            {
                return botiga;
            }
            set
            {
                botiga = value;
            }
        }
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }
        public Producte[] Productes
        {
            get { return productes; }
            set { productes = value; }
        }
        public int[] Quantitat
        {
            get
            {
                return quantitat;
            }
            set
            {
                quantitat = value;
            }
        }
        public int NElements
        {
            get
            {
                return nElements;
            }
            set
            {
                nElements = value;
            }
        }
        public int Diners
        {
            get
            {
                return diners;
            }
            set
            {
                diners = value;
            }
        }

        //Contructors
        public Cistella()
        {
            Producte[] productes = new Producte[10];
            this.nElements = 0;
            this.diners = 0;
            Botiga botiga = null;
        }
        public Cistella(Botiga botiga)
        {
            this.botiga = botiga;
        }
        public Cistella(string botiga, Producte[] productes)
        {
            this.productes = productes;
        }
        public Cistella(string botiga, Producte[] productes, int[] quantitat)
        {
            this.quantitat = quantitat;
        }
        public Cistella(string botiga, Producte[] productes, int[] quantitat, int diners)
        {
            this.diners = diners;
        }

        //Metodes
        public void ComprarProducte(Producte producte, int quantitat)
        {

        }
        public void ComprarProducte(Producte[] productes, int[] quantitats)
        {

        }
        public void OrdenarCistella()
        {

        }
        public void Mostra()
        {

        }
        public void CostTotal()
        {

        }
        public override string ToString()
        {

        }

    }
}
