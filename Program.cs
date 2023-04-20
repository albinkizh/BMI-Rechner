do
{
    Console.WriteLine("BMI-Rechner \nAuswahl: (Mann / Frau / Kind)");
    string ans = Console.ReadLine();


    if (ans == "Mann")
    {
        Console.WriteLine("Was ist Ihr Körpergewicht?");
        double Gewicht = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Was ist Ihre Körpergröße in m?");
        double Größe = Convert.ToDouble(Console.ReadLine());

        double bmi = Gewicht / (Größe * Größe);

        Console.WriteLine(bmi);

        {
            if (bmi < 18.5)
            {
                Console.WriteLine("Sie gehören zur Untergewichtigten Gruppe");
            }
            else if (bmi < 24.9)
            {
                Console.WriteLine("Sie gehören zur Normalgewichtingten Gruppe");
            }
            else if (bmi < 29.9)
            {
                Console.WriteLine("Sie gehören zur Übergewichtigten Gruppe");
            }
            else if (bmi < 34.9)
            {
                Console.WriteLine("Sie gehören zur starken Übergewichtigten Gruppe");
            }
            else
            {
                Console.WriteLine("Sie gehören zur Adipositas Gruppe");
            }

            Console.WriteLine("Nochmal? (Ja/Nein)");
            string asn = Console.ReadLine();
            if (asn == "Ja")
            {
                Console.Clear();
                Console.WriteLine("Willkommen zurück!");
                continue;
            }
            else
            {
                break;
            }

        }

    }
    else if (ans == "Frau")
    {

        Console.WriteLine("Was ist Ihr Körpergewicht?");
        double Gewicht = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Was ist Ihre Körpergröße in m?");
        double Größe = Convert.ToDouble(Console.ReadLine());

        double bmi = Gewicht / (Größe * Größe);

        Console.WriteLine("Ihr Bmiwert ist: " + bmi);

        {
            if (bmi < 17.5)
            {
                Console.WriteLine("Sie gehören zur Untergewichtigten Gruppe");
            }
            else if (bmi < 24)
            {
                Console.WriteLine("Sie gehören zur Normalgewichtingten Gruppe");
            }
            else if (bmi < 29)
            {
                Console.WriteLine("Sie gehören zur Übergewichtigten Gruppe");
            }
            else if (bmi < 34)
            {
                Console.WriteLine("Sie gehören zur starken Übergewichtigten Gruppe");
            }
            else
            {
                Console.WriteLine("Sie gehören zur Adipositas Gruppe");
            }

            Console.WriteLine("Nochmal? (Ja/Nein)");
            string asn = Console.ReadLine();
            if (asn == "Ja")
            {
                Console.Clear();
                Console.WriteLine("Willkommen zurück!");
                continue;
            }
            else
            {
                break;
            }

        }

    }
    else if (ans == "Kind")
    {

        Console.WriteLine("Was ist Ihr Körpergewicht?");
        double Gewicht = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Was ist Ihre Körpergröße in m?");
        double Größe = Convert.ToDouble(Console.ReadLine());

        double bmi = Gewicht / (Größe * Größe);

        Console.WriteLine(bmi);

        {
            if (bmi < 14.4)
            {
                Console.WriteLine("Sie gehören zur Untergewichtigten Gruppe");
            }
            else if (bmi < 20.8)
            {
                Console.WriteLine("Sie gehören zur Normalgewichtingten Gruppe");
            }
            else if (bmi < 24.2)
            {
                Console.WriteLine("Sie gehören zur Übergewichtigten Gruppe");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Sie gehören zur starken Übergewichtigten Gruppe");
            }
            else
            {
                Console.WriteLine("Sie gehören zur Adipositas Gruppe");
            }

            Console.WriteLine("Nochmal? (Ja/Nein)");
            string asn = Console.ReadLine();
            if (asn == "Ja")
            {
                Console.Clear();
                Console.WriteLine("Willkommen zurück!");
                continue;
            }
            else
            {
                break;
            }
        }

    }
    else
    {
        Console.WriteLine("Irgendwas ist schiefgelaufen, versuche es nochmal");
        continue;
    }


}while(true);