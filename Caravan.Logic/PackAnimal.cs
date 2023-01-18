namespace Caravan.Logic
{
    /// <summary>
    /// Abstrakte Basisklasse, die generelle Eigenschaften und Methoden von 
    /// Packtieren beschreibt.
    /// </summary>
    public abstract class PackAnimal
    {
        /// <summary>
        /// Damit die Vorlage compilierbar bleibt
        /// </summary>
        protected PackAnimal()
        {
        }

        /// <summary>
        /// Name des Tiers und Maximalgeschwindigkeit des Tiers
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="maxPace">MaxPace</param>
        protected PackAnimal(string name, int maxPace)
        {
        }

        public string Name { get { return string.Empty;  } }

        /// <summary>
        /// Maximale Geschwindigkeit des Tiers
        /// </summary>
        public int MaxPace { get { return -1; } }

        /// <summary>
        /// Anzahl der Ballen, die das Tier trägt
        /// </summary>
        public int Load 
        {
            get { return -1; }
            set { ; }
        }
        
        /// <summary>
        /// Geschwindigkeit des Tiers
        /// </summary>
        public abstract int Pace { get; }  //! logisch eigentlich ein Property

        /// <summary>
        /// Karawane, in der das Tier mitläuft. Kann einfach durch Zuweisung 
        /// gewechselt werden. Umkettung in Karawanen erfolgt automatisch
        /// </summary>
        public Caravan MyCaravan 
        {
            get { return null; }
            set { ; }
        }
    }
}
