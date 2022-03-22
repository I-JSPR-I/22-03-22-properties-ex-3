using System;
using System.Collections.Generic;
using System.Text;

namespace _22_03_22_properties_ex_3
{
    class CD
    {
        private string titel;
        private string uitvoerder;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        public string Uitvoerder
        {
            get { return uitvoerder; }
            set { uitvoerder = value; }
        }
        public CD()
        {
            titel = "Titel";
            uitvoerder = "Uitvoerder";
        }

    }
}
