using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public class Character
    {
        // Private vars
        private string player;
        private string name;
        private string race;
        private string clas;
        private string background;
        private int str;
        private int dex;
        private int con;
        private int intel;
        private int wis;
        private int cha;
        private int movement;
        private string size;

        // Public properties
        public String Player { get; set; }
        public String Name { get; set; }
        public String Race { get; set; }
        public String Clas { get; set; }
        public String Background { get; set; }
        public int Str { get; set; }
        public int Dex { get; set; }
        public int Con { get; set; }
        public int Intel { get; set; }
        public int Wis { get; set; }
        public int Cha { get; set; }
        public int Movement { get; set; }
        public String Size { get; set; }

        public Character(string _player, string _name, string _race, string _clas, string _background, int _str, int _dex, int _con, int _intel, int _wis, int _cha, int _movement, string _size)
        {
            Player = _player;
            Name = _name;
            Race = _race;
            Clas = _clas;
            Background = _background;
            Str = _str;
            Dex = _dex;
            Con = _con;
            Intel = _intel;
            Wis = _wis;
            Cha = _cha;
            Movement = _movement;
            Size = _size;
        }
    }
}
