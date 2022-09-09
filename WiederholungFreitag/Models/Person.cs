using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiederholungFreitag.Models
{
    internal class Person
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private string _Vorname;

        public string Vorname
        {
            get { return _Vorname; }
            set { _Vorname = value; }
        }
        private string _Geschlecht;

        public string Geschlecht
        {
            get { return _Geschlecht; }
            set { _Geschlecht = value; }
        }

        private string _Profilbild;

        public string Profilbild
        {
            get { return _Profilbild; }
            set { _Profilbild = value; }
        }
        public override string ToString()
        {
            return $"Person mit ID {ID} Vorname: {Vorname}";
        }



    }
}
