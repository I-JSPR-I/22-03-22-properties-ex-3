using System;

namespace _22_03_22_properties_ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            CD CEEDEE = new CD();
            CEEDEE.Titel = "Muziek";
            CEEDEE.Uitvoerder = "Jasper Meersschaut";

            Console.WriteLine(CEEDEE.Titel);
            Console.WriteLine(CEEDEE.Uitvoerder);

        }
    }
}
