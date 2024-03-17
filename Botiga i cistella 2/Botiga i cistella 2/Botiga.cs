using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Botiga_i_cistella_2
{
    /// <summary>
    /// Creem la classe Botiga amb els seus atributs,constructors,propietats i els seus mètodes
    /// </summary>
    internal class Botiga
    {
        //Atributs 
        /// <summary>
        /// Atribut del nom de la botiga
        /// </summary>
        private string nomBotiga;
        /// <summary>
        /// Atribut que serà una taula d'objectes tipus Producte
        /// </summary>
        private Producte[] productes;
        /// <summary>
        /// //Atribut de tipus enter que són el número d’elements de la taula que controlarà el número de productes a la botiga 
        /// </summary>
        private int nElements;

        //Constructors
        /// <summary>
        /// És un constructor buit que inicialitza els les taules de productes a 10 i posa nElements a 0
        /// </summary>
        public Botiga()
        {
            productes = new Producte[10];
            nElements = 0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nomBotiga">És el nom de la botiga de tipus string</param>
        public Botiga(string nomBotiga)
        {
        }
        /// <summary>
        /* És un constructor anomenat Botiga(nom, nombreProductes) que inicialitza la taula 
         * productes amb tants producte com indica nombreProductes i també inicialitza nElements a 0. */
        /// </summary>
        /// <param name="nomBotiga">És el nom de la botiga de tipus string</param>
        /// <param name="nombreProductes">És el nombre de produces que tindrà la taula Productes de tipus int</param>
        public Botiga(string nomBotiga, int nombreProductes)
        {
            NomBotiga = nomBotiga;
            nombreProductes = 10;
            nElements = 0;
        }
        /// <summary>
        /*És un constructor amb nom i productes com a paràmetres que posa un nom i inicialitza la taula de productes 
         * amb els valors dels paràmetres, assignar-li aquesta mida a nElements(valors diferent a null).*/
        /// </summary>
        /// <param name="nomBotiga">És el nom de la botiga de tipus strinf</param>
        /// <param name="productes">Són els productes extrets de la taula Productes </param>
        public Botiga(string nomBotiga, Producte[] productes)
        {
            NomBotiga = nomBotiga;
            nElements = 0;
            this.productes = productes;
            for (int i = 0; i < productes.Length; i++)
            {
                // Comprova si el producte que hi ha a la posició actual no té valor 0.
                if (productes[i] != null)
                {
                    productes[nElements] = productes[i];
                    nElements++;
                }
            }
        }
        /// <summary>
        /// Constructor amb els parametres nom de la botiga, productes i nombre d'elements
        /// </summary>
        /// <param name="nomBotiga">És el nom de la botiga de tipus string</param>
        /// <param name="productes">Són els productes extrets de la taula Productes</param>
        /// <param name="nElements">És el número d'elements de la taula</param>
        public Botiga(string nomBotiga, int[] productes, int nElements)
        {
        }

        //Propietats
        /// <summary>
        /// Propietat del atribut nom de la botiga
        /// </summary>
        public string NomBotiga
        {
            get { return nomBotiga; }
            set { nomBotiga = value; }
        }
        /// <summary>
        /// Propietat del atribut de la taula Producte
        /// </summary>
        public Producte[] Productes
        {
            get { return productes; }
            set { productes = value; }
        }
        /// <summary>
        /// Propietat del atribut número d'elements de la taula
        /// </summary>
        public int NElements
        {
            get { return nElements; }
            set { nElements = value; }
        }


        //Mètodes 
        /// <summary>
        /// És un mètode de tipus int que mira a partir de la llargada de la taula si hi ha algun espai lliure a la taula productes o si la botiga està plena
        /// </summary>
        /// <returns>>Retorna la posició de la taula a on es pot afegir un producte. Retorna -1 si la botiga està plena</returns>
        public int EsapiLliure()
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Indexador de la botiga segons el seu atribut producte, ha de poder trobar un producte segons el nom d’aquest producte.
        /// </summary>
        /// <param name="producte">És el producte de tipus string</param>
        /// <returns>Retorna -1 si no troba producte, si el troba retorna la posicio del producte </returns>
        public int Index(string producte)
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i].Nom == producte)
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /* És un mètode que afegeix un producte a la botiga.Controla si la botiga està plena.Quan inserim un producte hem d’actualitzar nElements.En cas de no cabre ens
        ha de preguntar si volem ampliar la tenda, fora del mètode...*/
        /// </summary>
        /// <param name="producte">És el producte de tipus string</param>
        /// <returns>Retorna un booleà amb false si no s’ha pogut afegir el producte, altrament retorna true. </returns>
        public bool AfegirProducte(Producte producte)
        {
            int posicio = EsapiLliure();
            if (posicio != -1)
            {
                productes[posicio] = producte;
                nElements++;
                return true;
            }
            else
            {
                Console.WriteLine("La botiga està plena. Voleu ampliar la botiga? SI/NO");
                string resposta = Console.ReadLine();
                if (resposta == "SI")
                {
                    AmpliarBotiga(nElements);
                }
                return false;
            }
        }

        /// <summary>
        /* És un mètode que afegeix un conjunt de productes. Quan inserim
        productes hem d’actualitzar nElements.En cas de no cabre ens ha de preguntar si volem
        ampliar la tenda.*/
        /// </summary>
        /// <param name="productes">És el valor de la taula</param>
        /// <returns></returns>
        public bool AfegirProducte(Producte[] productes)
        {
            if (nElements + productes.Length <= this.productes.Length)
            {
                for (int i = 0; i < productes.Length; i++)
                {
                    AfegirProducte(productes[i]);
                    nElements++;
                }
                return true;
            }
            else
            {
                //Console.WriteLine("No hi ha prou espai a la botiga. Voleu ampliar-la?");
                //string resposta = Console.ReadLine();
                //if (resposta == "SI")
                //{

                //    AmpliarBotiga(nElements);
                //}
                return false;
            }
        }


        /// <summary>
        /* És un mètode que donat el valor extra en que ampliarem la tenda, hem de fer més
        grans els valors dels atributs mantenint els valors actuals,anem a ampliar la taula productes.*/
        /// </summary>
        /// <param name="num">És el número en què volem ampliar la tenda</param>
        public void AmpliarBotiga(int num)
        {
            StreamWriter fitxer2 = new StreamWriter(@".\Botiga.csv");
            Array.Resize(ref productes, productes.Length + num);
        }
        /// <summary>
        /*És un mètode que donat un producte hem de buscar-lo a la taula
        de productes i modificar el seu preu, en cas de no trobar el producte informar que no s’ha
        trobat.*/
        /// </summary>
        /// <param name="producte">És producte de tipus string</param>
        /// <param name="preu">És el preu del producte de tipus double</param>
        /// <returns></returns>
        public bool ModificarPreu(string producte, double preu)
        {
            int index = Index(producte);
            if (index != -1)
            {
                return true;
                productes[Index(producte)].Preu_sense_iva = preu;
            }
            else
            {
                Console.WriteLine("No s'ha trobat el producte...");
            }
            return false;
        }
        /// <summary>
        /*És un mètode que fa una crida a una altre mètode */
        /// </summary>
        /// <param name="producte">És el producte</param>
        /// <returns>: Retorna la funció buscar producte a partir del nom</returns>
        public bool BuscarProducte(Producte producte)
        {
            return BuscarProducte(producte.Nom);
        }
        /// <summary>
        /*És un mètode que busca un producte a partir del seu nom*/
        /// </summary>
        /// <param name="producte"></param>
        /// <returns>: Retorna true si l’ha trobat </returns>
        public bool BuscarProducte(string producte)
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i].Nom == producte)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /*És un mètode que donat un producte hem de buscar-lo a la taula de productes per saber quina posició de la
        taula ocupa, per així després modificar les dades. R*/
        /// </summary>
        /// <param name="producte">És el producte</param>
        /// <param name="nouNom">És el nou nom del producte</param>
        /// <param name="nouPreu">És el nou preu del producte</param>
        /// <param name="novaQuantitat">És la nova quantitat del producte</param>
        /// <returns> Retorna un booleà amb true si s’ha pogut modificar i false si ho s’ha pogut.</returns>
        public bool ModificarProducte(Producte producte, string nouNom, double nouPreu, int novaQuantitat)
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] != null && productes[i].Equals(producte))
                {
                    productes[i].Nom = nouNom;
                    productes[i].Preu_sense_iva = nouPreu;
                    productes[i].Quantitat = novaQuantitat;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /* És un mètode que ordena els atributs productes en ordre afabètic de producte.
        Implementa els mètodes d’ordenació vistos a classe.*/
        /// </summary>
        public void OrdenarProducte()
        {
            Array.Sort(productes, (p1, p2) => string.Compare(p1.Nom, p2.Nom));
        }
        /// <summary>
        /*És un mètode que ordena els atributs productes de forma creixent segons els preus dels
        productes. (igual que l’anterior)*/
        /// </summary>
        public void OrdenarPreus()
        {
            Array.Sort(productes, (p1, p2) => p1.Preu().CompareTo(p2.Preu()));
        }

        /// <summary>
        /* És un mètode que Donat un producte hem de buscar-lo a la taula de
        productes per saber quina posició de la taula ocupa, per així després esborrar-lo.Mantenim
        l’ordre a la taula productes quan l’esborrem.*/
        /// </summary>
        /// <param name="producte">És el producte</param>
        /// <returns>Retorna true en el cas de que s'hagui esborrat el producte i retorna false en cas contrari</returns>
        public bool EsborrarProducte(Producte producte)
        {
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] != null && productes[i].Equals(producte))
                {
                    Array.Copy(productes, i + 1, productes, i, nElements - i - 1);
                    productes[nElements - 1] = null;
                    nElements--;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        ///És un mètode que mostra tots els productes de la botiga de forma amigable amb els seus preus
        /// </summary>
        public void Mostra()
        {
            Console.WriteLine($"Productes de la botiga '{nomBotiga}':");
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] != null)
                {
                    Console.WriteLine($"Nom: {productes[i].Nom}, Preu: {productes[i].Preu:C}");
                }
            }
        }
        /// <summary>
        /* És un mètode que  retorna de forma amigable un string amb tots els productes amb els seus preus i
        iva respectius.*/
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string result = "Botiga: " + NomBotiga + "\n";
            for (int i = 0; i < productes.Length; i++)
            {
                if (productes[i] != null)
                {
                    result += productes[i].ToString() + "\n";
                }
            }
            return result;
        }




    }
}
