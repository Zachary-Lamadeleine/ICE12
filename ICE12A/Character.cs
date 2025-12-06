using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE12A
{
    public class Character
    {
        // private instance members (fields)
        private string m_agility;
        private string m_strength;
        private string m_vigour;
        private string m_perception;
        private string m_intellect;
        private string m_will;

        // public properties
        public string AGL
        {
            // getter (get accessor)
            get { return m_agility; }
            // setter (set mutator)
            set { m_agility = value; }
        }

        public string STR
        {
            get { return m_strength;  }
            set { m_strength = value; }
        }

        public string VGR
        {
            get { return m_vigour; }
            set { m_vigour = value; }
        }

        public string PER
        {
            get { return m_perception; }
            set { m_perception = value; }
        }

        public string INT
        {
            get { return m_intellect; }
            set { m_intellect = value; }
        }

        public string WIL
        {
            get { return m_will; }
            set { m_will = value; }
        }

        // auto-properties
        public string Name { get; set; }
        public string Career { get; set; }
        public string Species { get; set; }

        // computed properties
        public int AWA
        {
            get { return int.Parse(AGL) + int.Parse(PER);  }
        }

        public int TOU
        {
            get { return int.Parse(STR) + int.Parse(VGR); }
        }

        public int RES
        {
            get { return int.Parse(INT) + int.Parse(WIL); }
        }

        // constructors

        // default / empty constructor
        public Character()
        {
            Name = "Unknown";
            Career = "Unknown";
            Species = "Unknown";
            m_agility = "0";
            m_strength = "0";
            m_vigour = "0";
            m_perception = "0";
            m_intellect = "0";
            m_will = "0";
        }

        // parameterized constructor
        public Character(string name, string career, string species, string AGL, string STR, string VGR, string PER, string INT, string WIL)
        {
            
            Name = name;
            Career = career;
            Species = species;
            m_agility = AGL;
            m_strength = STR;
            m_vigour = VGR;
            m_perception = PER;
            m_intellect = INT;
            m_will = WIL;
        }

        // overloaded parameterized constructor
        public Character (string name, string career, string species, int AGL, int STR, int VGR, int PER, int INT, int WIL)
        {
            Name = name;
            Career = career;
            Species = species;
            m_agility = AGL.ToString();
            m_strength = STR.ToString();
            m_vigour = VGR.ToString();
            m_perception = PER.ToString();
            m_intellect = INT.ToString();
            m_will = WIL.ToString();
        }

        // public methods
        public override string ToString()
        {
            return $"{Name}, {Career}, {Species}: AGL = {AGL}, STR = {STR}, VGR = {VGR}, PER = {PER}, INT = {INT}, WIL = {WIL}";
        }

        // private methods
    }
}
