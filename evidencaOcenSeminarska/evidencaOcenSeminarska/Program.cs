using System;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters;

int[][] ocene = new int[11][];
Menu(ocene);
ocene = Vnos(ocene);



static void Menu(int[][] ocene) //Menu
{
    Console.Clear();
    Console.WriteLine("Dobrodošli v evidenco ocen. Izberite kaj želite storiti.");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("[1] Vnos novih ocen");
    Console.WriteLine("[2] Urejanje starih ocen");
    Console.WriteLine("[3] Briši ocene");
    Console.WriteLine("[4] Išči po ocenah");
    Console.WriteLine("[5] Izpis ocen");
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("[0] za izhod");
    bool izbira = false;  //zagotavljanje pravilnega vnosa v začetnem Meniju

    int izbrana_možnost;
    izbrana_možnost = int.Parse(Console.ReadLine());
    if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 3 || izbrana_možnost == 4 || izbrana_možnost == 5 || izbrana_možnost == 0)
        izbira = true;


    while (izbira == false)
    {
        Menu(ocene);
        izbrana_možnost = int.Parse(Console.ReadLine());
        if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 3 || izbrana_možnost == 4 || izbrana_možnost == 5 || izbrana_možnost == 0)
            izbira = true;
    }

    if (izbrana_možnost == 0)
        Environment.Exit(0);
    else if (izbrana_možnost == 1)
        Vnos(ocene);
    else if (izbrana_možnost == 2)
        Urejanje(ocene);
    else if (izbrana_možnost == 3)
        Brisanje(ocene);
    else if (izbrana_možnost == 4)
        Iskanje(ocene);
    else if (izbrana_možnost == 5)
        Izpis(ocene);

    /*switch (izbrana_možnost)
    {
        case 0: Environment.Exit(0); break;
        case 1: Vnos(ocene); break;
        case 2: Urejanje(ocene); break;
        case 3: Brisanje(ocene); break;
        case 4: Iskanje(ocene); break;
        case 5: Izpis(ocene); break;
    }*/
}



static int[][] Vnos(int[][] ocene) //Vnos
{
    Console.Clear();
    Console.WriteLine("Izberite predmet za katerega želite vnesti oceno: ");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[1] Matematika");
    Console.WriteLine("[2] Slovenščina");
    Console.WriteLine("[3] Angleščina");
    Console.WriteLine("[4] Fizika");
    Console.WriteLine("[5] NPA");
    Console.WriteLine("[6] NSA");
    Console.WriteLine("[7] NPB");
    Console.WriteLine("[8] Robotika");
    Console.WriteLine("[9] VOS");
    Console.WriteLine("[10] VSO");
    Console.WriteLine("[11] Športna vzgoja");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[0] za nazaj");

    bool izbira_predmeta = false; //zagotavljanje pravilnega vnosa v Meniju za predmete

    int izbrana_možnost2;
    izbrana_možnost2 = int.Parse(Console.ReadLine());
    if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
        izbira_predmeta = true;
    while (izbira_predmeta == false)
    {
        Vnos(ocene);
        izbrana_možnost2 = int.Parse(Console.ReadLine());
        if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
            izbira_predmeta = true;
    }
    if (izbrana_možnost2 == 0)
        Menu(ocene);

    else if (izbrana_možnost2 == 1)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *MATEMATIKA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 0; k < 1; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *MATEMATIKA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5)", ocene[0].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[0].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[0][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[0][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 2)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *SLOVENŠČINA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 1; k < 2; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *SLOVENŠČINA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5)", ocene[1].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[1].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());

            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[1][j] = ocena;
            }

            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[1][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 3)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *ANGLEŠČINA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 2; k < 3; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *ANGLEŠČINA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[2].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[2].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[2][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[2][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 4)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *FIZIKA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 3; k < 4; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *FIZIKA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: {0}. Naj bo vnos pravilen (1-5).", ocene[3].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[3].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[3][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[3][j] = ocena;
                }
            }

        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 5)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *NPA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 4; k < 5; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *NPA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[4].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[4].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[4][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[4][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 6)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *NSA*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 5; k < 6; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *NSA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[5].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[5].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[5][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[5][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 7)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *NPB*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 6; k < 7; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *NPB*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[6].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[6].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[6][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[6][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 8)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *ROBOTIKA*?");
        Console.WriteLine("--------------------------");
        for (int k = 7; k < 8; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *ROBOTIKA*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[7].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[7].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[7][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[7][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 9)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *VOS*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 8; k < 9; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *VOS*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[8].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[8].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[8][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[8][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 10)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *VSO*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 9; k < 10; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *VSO*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[9].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[9].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[9][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[9][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost2 == 11)
    {
        Console.Clear();
        Console.WriteLine("Koliko ocen želite vnesti pri predmetu *ŠVZ*?");
        Console.WriteLine("--------------------------------------------------");
        for (int k = 10; k < 11; k++)
        {
            int štOcen = int.Parse(Console.ReadLine());
            ocene[k] = new int[štOcen];
        }
        Console.Clear();
        Console.WriteLine("Vnos ocen pri predmetu *ŠVZ*");
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Vnesite toliko ocen: *{0}*. Naj bo vnos pravilen (1-5).", ocene[10].Length);
        Console.WriteLine("Napačen vnos se ne šteje! ");
        Console.WriteLine("----------------------------------------------------");
        for (int j = 0; j < ocene[10].Length; j++)
        {
            bool pravilno = false;
            int ocena = int.Parse(Console.ReadLine());
            if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
            {
                pravilno = true;
                ocene[10][j] = ocena;
            }
            while (pravilno == false)
            {
                ocena = int.Parse(Console.ReadLine());
                if (ocena == 1 || ocena == 2 || ocena == 3 || ocena == 4 || ocena == 5)
                {
                    pravilno = true;
                    ocene[10][j] = ocena;
                }
            }
        }
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }
    return ocene;

}

static void Urejanje(int[][] ocene) //UREJANJE OCEN
{
    Console.Clear();
    Console.WriteLine("Izberite kaj želite storiti:");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[1] Dodajanje ocen");
    Console.WriteLine("[2] Popravljanje ocen");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[0] za nazaj v začetni Meni");
    bool izbira = false; //zagotavljanje pravilnega vnosa v Meniju za Izpis

    int izbrana_možnost;
    izbrana_možnost = int.Parse(Console.ReadLine());
    if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
        izbira = true;
    while (izbira == false)
    {
        Izpis(ocene);
        izbrana_možnost = int.Parse(Console.ReadLine());
        if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
            izbira = true;
    }
    switch (izbrana_možnost)
    {
        case 0: Menu(ocene); break;
    }

    if (izbrana_možnost == 1)
    {
        Console.Clear();
        Console.WriteLine("Izberite predmet za katerega želite dodati oceno: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[1] Matematika");
        Console.WriteLine("[2] Slovenščina");
        Console.WriteLine("[3] Angleščina");
        Console.WriteLine("[4] Fizika");
        Console.WriteLine("[5] NPA");
        Console.WriteLine("[6] NSA");
        Console.WriteLine("[7] NPB");
        Console.WriteLine("[8] Robotika");
        Console.WriteLine("[9] VOS");
        Console.WriteLine("[10] VSO");
        Console.WriteLine("[11] Športna vzgoja");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni Meni");

        bool izbira_predmeta = false; //zagotavljanje pravilnega vnosa v Meniju za predmete

        int izbrana_možnost2;
        izbrana_možnost2 = int.Parse(Console.ReadLine());
        if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
            izbira_predmeta = true;
        while (izbira_predmeta == false)
        {
            izbrana_možnost2 = int.Parse(Console.ReadLine());
            if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
                izbira_predmeta = true;
        }
        switch (izbrana_možnost2)
        {
            case 0: Menu(ocene); break;
        }
        if (izbrana_možnost2 == 1) //Dodajanje ocen
        {
            if (ocene[0] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *MATEMATIKA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[0].Length + 1];
                    for (int j = 0; j < ocene[0].Length; j++)
                        kopija[j] = ocene[0][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[0] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);

        }

        else if (izbrana_možnost2 == 2)
        {
            if (ocene[1] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *SLOVENŠČINA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[1].Length + 1];
                    for (int j = 0; j < ocene[1].Length; j++)
                        kopija[j] = ocene[1][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[1] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 3)
        {
            if (ocene[2] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *ANGLEŠČINA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[2].Length + 1];
                    for (int j = 0; j < ocene[2].Length; j++)
                        kopija[j] = ocene[2][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[2] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 4)
        {
            if (ocene[3] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *FIZIKA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[3].Length + 1];
                    for (int j = 0; j < ocene[3].Length; j++)
                        kopija[j] = ocene[3][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[3] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 5)
        {
            if (ocene[4] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *NPA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[4].Length + 1];
                    for (int j = 0; j < ocene[4].Length; j++)
                        kopija[j] = ocene[4][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[4] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 6)
        {
            if (ocene[5] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *NSA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[5].Length + 1];
                    for (int j = 0; j < ocene[5].Length; j++)
                        kopija[j] = ocene[5][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[5] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 7)
        {
            if (ocene[6] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *NPB*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[6].Length + 1];
                    for (int j = 0; j < ocene[6].Length; j++)
                        kopija[j] = ocene[6][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[6] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 8)
        {
            if (ocene[7] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *ROBOTIKA*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[7].Length + 1];
                    for (int j = 0; j < ocene[7].Length; j++)
                        kopija[j] = ocene[7][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[7] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 9)
        {
            if (ocene[8] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *VOS*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[8].Length + 1];
                    for (int j = 0; j < ocene[8].Length; j++)
                        kopija[j] = ocene[8][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[8] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 10)
        {
            if (ocene[9] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *VSO*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[9].Length + 1];
                    for (int j = 0; j < ocene[9].Length; j++)
                        kopija[j] = ocene[9][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[9] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }
        else if (izbrana_možnost2 == 11)
        {
            if (ocene[10] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Dodajanje ocen pri predmetu *ŠVZ*");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesite novo oceno: ");
                int novaOcena = int.Parse(Console.ReadLine());
                if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                {
                    int[] kopija = new int[ocene[10].Length + 1];
                    for (int j = 0; j < ocene[10].Length; j++)
                        kopija[j] = ocene[10][j];

                    kopija[kopija.Length - 1] = novaOcena;

                    ocene[10] = kopija;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0)
                Menu(ocene);
        }

    }

    else if (izbrana_možnost == 2) //Popravljanje ocen
    {

        Console.Clear();
        Console.WriteLine("Izberite predmet za katerega želite urediti oceno: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[1] Matematika");
        Console.WriteLine("[2] Slovenščina");
        Console.WriteLine("[3] Angleščina");
        Console.WriteLine("[4] Fizika");
        Console.WriteLine("[5] NPA");
        Console.WriteLine("[6] NSA");
        Console.WriteLine("[7] NPB");
        Console.WriteLine("[8] Robotika");
        Console.WriteLine("[9] VOS");
        Console.WriteLine("[10] VSO");
        Console.WriteLine("[11] Športna vzgoja");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni Meni");

        bool izbira_predmeta = false; //zagotavljanje pravilnega vnosa v Meniju za predmete

        int izbrana_možnost2;
        izbrana_možnost2 = int.Parse(Console.ReadLine());
        if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
            izbira_predmeta = true;
        while (izbira_predmeta == false)
        {
            izbrana_možnost2 = int.Parse(Console.ReadLine());
            if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
                izbira_predmeta = true;
        }
        switch (izbrana_možnost2)
        {
            case 0: Menu(ocene); break;
        }

        if (izbrana_možnost2 == 1)
        {
            if (ocene[0] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[0].Length; j++)
                    if (ocene[0][j] != 0)
                        Console.Write("{0}  ", ocene[0][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[0].Length; j++)
                {
                    if (ocene[0][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }

                }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[0][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);

        }

        else if (izbrana_možnost2 == 2)
        {
            if (ocene[1] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[1].Length; j++)
                    if (ocene[1][j] != 0)
                        Console.Write("{0}  ", ocene[1][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[1].Length; j++)
                    if (ocene[1][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[1][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);

        }

        else if (izbrana_možnost2 == 3)
        {
            if (ocene[2] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[2].Length; j++)
                    if (ocene[2][j] != 0)
                        Console.Write("{0}  ", ocene[2][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[2].Length; j++)
                    if (ocene[2][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[2][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);

        }

        else if (izbrana_možnost2 == 4)
        {
            if (ocene[3] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[3].Length; j++)
                    if (ocene[3][j] != 0)
                        Console.Write("{0}  ", ocene[3][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[3].Length; j++)
                    if (ocene[3][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[3][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);

        }

        else if (izbrana_možnost2 == 5)
        {
            if (ocene[4] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[4].Length; j++)
                    if (ocene[4][j] != 0)
                        Console.Write("{0}  ", ocene[4][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[4].Length; j++)
                    if (ocene[4][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[4][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 6)
        {
            if (ocene[5] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[5].Length; j++)
                    if (ocene[5][j] != 0)
                        Console.Write("{0}  ", ocene[5][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[5].Length; j++)
                    if (ocene[5][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[5][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 7)
        {
            if (ocene[6] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[6].Length; j++)
                    if (ocene[6][j] != 0)
                        Console.Write("{0}  ", ocene[6][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[6].Length; j++)
                    if (ocene[6][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[6][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 8)
        {
            if (ocene[7] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[7].Length; j++)
                    if (ocene[7][j] != 0)
                        Console.Write("{0}  ", ocene[7][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[7].Length; j++)
                    if (ocene[7][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[7][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 9)
        {
            if (ocene[8] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[8].Length; j++)
                    if (ocene[8][j] != 0)
                        Console.Write("{0}  ", ocene[8][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[8].Length; j++)
                    if (ocene[8][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[8][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 10)
        {
            if (ocene[9] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[9].Length; j++)
                    if (ocene[9][j] != 0)
                        Console.Write("{0}  ", ocene[9][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[9].Length; j++)
                    if (ocene[9][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[9][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }

            Console.WriteLine("[0] za nazaj");
            if (int.Parse(Console.ReadLine()) == 0)
                Urejanje(ocene);
        }

        else if (izbrana_možnost2 == 11)
        {
            if (ocene[10] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[10].Length; j++)
                    if (ocene[10][j] != 0)
                        Console.Write("{0}  ", ocene[10][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš urediti: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[10].Length; j++)
                    if (ocene[10][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    Console.Clear();
                    Console.WriteLine("Vnesi novo oceno, ki bo zamenjala staro oceno ({0}): ", ocena);
                    Console.WriteLine("--------------------------------------------------");
                    int novaOcena = int.Parse(Console.ReadLine());
                    if (novaOcena == 1 || novaOcena == 2 || novaOcena == 3 || novaOcena == 4 || novaOcena == 5)
                    {
                        ocene[10][index] = novaOcena;
                    }
                    else
                    {
                        Console.WriteLine("Napačen vnos. ");
                        Console.WriteLine("--------------------------------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Nimate takšne ocene pri tem predmetu. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
        }

        Console.WriteLine("[0] za nazaj");
        if (int.Parse(Console.ReadLine()) == 0)
            Urejanje(ocene);
    }
}


static void Brisanje(int[][] ocene) //brisanje
{
    Console.Clear();
    Console.WriteLine("Izberite način brisanja: ");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[1] Vse ocene");
    Console.WriteLine("[2] Izberite predmet in oceno");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[0] za nazaj v začetni Meni");

    bool izbira = false; //zagotavljanje pravilnega vnosa v Meniju za Izpis

    int izbrana_možnost;
    izbrana_možnost = int.Parse(Console.ReadLine());
    if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
        izbira = true;
    while (izbira == false)
    {
        Brisanje(ocene);
        izbrana_možnost = int.Parse(Console.ReadLine());
        if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
            izbira = true;
    }
    switch (izbrana_možnost)
    {
        case 0: Menu(ocene); break;
    }

    if (izbrana_možnost == 1)
    {
        Console.Clear();
        Console.WriteLine("Zbrisali boste vse ocene, ali ste prepičani da to želite narediti? ");
        Console.WriteLine("[1] DA");
        Console.WriteLine("[2] NE (nazaj)");
        int brisi = int.Parse(Console.ReadLine());
        if (brisi == 1)
        {
            for (int i = 0; i < ocene.Length; i++)
                ocene[i] = null;
            Console.Clear();
            Console.WriteLine("Zbrisali ste vse ocene. ");
        }
        else if (brisi == 2)
            Brisanje(ocene);
        Console.WriteLine("--------------------------");
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
            Menu(ocene);
    }
    if (izbrana_možnost == 2)
    {
        Console.Clear();
        Console.WriteLine("Izberite predmet za katerega želite brisati ocene: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[1] Matematika");
        Console.WriteLine("[2] Slovenščina");
        Console.WriteLine("[3] Angleščina");
        Console.WriteLine("[4] Fizika");
        Console.WriteLine("[5] NPA");
        Console.WriteLine("[6] NSA");
        Console.WriteLine("[7] NPB");
        Console.WriteLine("[8] Robotika");
        Console.WriteLine("[9] VOS");
        Console.WriteLine("[10] VSO");
        Console.WriteLine("[11] Športna vzgoja");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni Meni");

        bool izbira_predmeta = false; //zagotavljanje pravilnega vnosa v Meniju za predmete

        int izbrana_možnost2;
        izbrana_možnost2 = int.Parse(Console.ReadLine());
        if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
            izbira_predmeta = true;
        while (izbira_predmeta == false)
        {
            Brisanje(ocene);
            izbrana_možnost2 = int.Parse(Console.ReadLine());
            if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 3 || izbrana_možnost2 == 4 || izbrana_možnost2 == 5 || izbrana_možnost2 == 6 || izbrana_možnost2 == 7 || izbrana_možnost2 == 8 || izbrana_možnost2 == 9 || izbrana_možnost2 == 10 || izbrana_možnost2 == 11 || izbrana_možnost2 == 0)
                izbira_predmeta = true;
        }
        if (izbrana_možnost2 == 1)
        {
            if (ocene[0] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[0].Length; j++)  //izpis trenutnih ocen pri predmetu MATEMATIKA
                    if (ocene[0][j] != 0)
                        Console.Write("{0}  ", ocene[0][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());  //preberemo izbrano oceno
                for (int j = 0; j < ocene[0].Length; j++)
                    if (ocene[0][j] == ocena)  //poiščemo izbrano oceno v tabeli
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)  //če ocena obstaja v tabeli, jo zapišemo na zadnji index in jo zamenjamo z 0
                {
                    for (int i = index; i < ocene[0].Length - 1; i++)
                        ocene[0][i] = ocene[0][i + 1];
                    ocene[0][ocene[0].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }

        if (izbrana_možnost2 == 2)
        {
            if (ocene[1] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[1].Length; j++)
                    if (ocene[1][j] != 0)
                        Console.Write("{0}  ", ocene[1][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[1].Length; j++)
                    if (ocene[1][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[1].Length - 1; i++)
                        ocene[1][i] = ocene[1][i + 1];
                    ocene[1][ocene[1].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }

        if (izbrana_možnost2 == 3)
        {
            if (ocene[2] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[2].Length; j++)
                    if (ocene[2][j] != 0)
                        Console.Write("{0}  ", ocene[2][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[2].Length; j++)
                    if (ocene[2][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[2].Length - 1; i++)
                        ocene[2][i] = ocene[2][i + 1];
                    ocene[2][ocene[2].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 4)
        {
            if (ocene[3] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[3].Length; j++)
                    if (ocene[3][j] != 0)
                        Console.Write("{0}  ", ocene[3][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[3].Length; j++)
                    if (ocene[3][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[3].Length - 1; i++)
                        ocene[3][i] = ocene[3][i + 1];
                    ocene[3][ocene[3].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 5)
        {
            if (ocene[4] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[4].Length; j++)
                    if (ocene[4][j] != 0)
                        Console.Write("{0}  ", ocene[4][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[4].Length; j++)
                    if (ocene[4][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[4].Length - 1; i++)
                        ocene[4][i] = ocene[4][i + 1];
                    ocene[4][ocene[4].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 6)
        {
            if (ocene[5] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[5].Length; j++)
                    if (ocene[5][j] != 0)
                        Console.Write("{0}  ", ocene[5][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[5].Length; j++)
                    if (ocene[5][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[5].Length - 1; i++)
                        ocene[5][i] = ocene[5][i + 1];
                    ocene[5][ocene[5].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 7)
        {
            if (ocene[6] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[6].Length; j++)
                    if (ocene[6][j] != 0)
                        Console.Write("{0}  ", ocene[6][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[6].Length; j++)
                    if (ocene[6][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[6].Length - 1; i++)
                        ocene[6][i] = ocene[6][i + 1];
                    ocene[6][ocene[6].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 8)
        {
            if (ocene[7] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[7].Length; j++)
                    if (ocene[7][j] != 0)
                        Console.Write("{0}  ", ocene[7][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[7].Length; j++)
                    if (ocene[7][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[7].Length - 1; i++)
                        ocene[7][i] = ocene[7][i + 1];
                    ocene[7][ocene[7].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 9)
        {
            if (ocene[8] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[8].Length; j++)
                    if (ocene[8][j] != 0)
                        Console.Write("{0}  ", ocene[8][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[8].Length; j++)
                    if (ocene[8][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[8].Length - 1; i++)
                        ocene[8][i] = ocene[8][i + 1];
                    ocene[8][ocene[8].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 10)
        {
            if (ocene[9] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[9].Length; j++)
                    if (ocene[9][j] != 0)
                        Console.Write("{0}  ", ocene[9][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[9].Length; j++)
                    if (ocene[9][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[9].Length - 1; i++)
                        ocene[9][i] = ocene[9][i + 1];
                    ocene[9][ocene[9].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
        if (izbrana_možnost2 == 11)
        {
            if (ocene[10] == null)
            {
                Console.Clear();
                Console.WriteLine("Pri tem predmetu nimate vpisanih ocen.");
            }
            else
            {
                int index = 0;
                Console.Clear();
                Console.Write("Trenutne ocene: ");
                for (int j = 0; j < ocene[10].Length; j++)
                    if (ocene[10][j] != 0)
                        Console.Write("{0}  ", ocene[10][j]);
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Vnesi oceno katero želiš brisati: ");
                Console.WriteLine("--------------------------------------------------");
                bool obstaja = false;
                int ocena = int.Parse(Console.ReadLine());
                for (int j = 0; j < ocene[10].Length; j++)
                    if (ocene[10][j] == ocena)
                    {
                        index = j;
                        obstaja = true;
                    }
                if (obstaja == true)
                {
                    for (int i = index; i < ocene[10].Length - 1; i++)
                        ocene[10][i] = ocene[10][i + 1];
                    ocene[10][ocene[10].Length - 1] = 0;
                }
                else
                {
                    Console.WriteLine("Napačen vnos. ");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("[0] za nazaj v začetni meni");
            if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                Menu(ocene);
        }
    }
}


static void Iskanje(int[][] ocene) //ISKANJE OCEN
{
    Console.Clear();
    Console.WriteLine("----------------------ISKANJE----------------------");
    Console.WriteLine("[1] Število določenih ocen");
    Console.WriteLine("[2] Izračunaj povprečje");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[0] za nazaj");

    bool izbira = false; //zagotavljanje pravilnega vnosa v glavnem Meniju za izpis

    int izbrana_možnost;
    izbrana_možnost = int.Parse(Console.ReadLine());
    if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
        izbira = true;
    while (izbira == false)
    {
        Iskanje(ocene);
        izbrana_možnost = int.Parse(Console.ReadLine());
        if (izbrana_možnost == 1 || izbrana_možnost == 2 || izbrana_možnost == 0)
            izbira = true;
    }
    if (izbrana_možnost == 0)
        Menu(ocene);

    if (izbrana_možnost == 1)
    {
        Console.Clear();
        Console.WriteLine("*ŠTEVILO DOLOČENIH OCEN*");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("Vnesite oceno katero želite prešteti: ");
        int stevilo = int.Parse(Console.ReadLine());
        int stevec = 0;
        int st;

        for (int i = 0; i < ocene.Length; i++)
        {
            if (ocene[i] != null) //če bi ena podtabela slučajno bila prazna, program ne bi nadaljeval.
            {

                for (int j = 0; j < ocene[i].Length; j++)
                {
                    if (ocene[i][j] == stevilo) //preverjanje če se vnešena ocena ujema z oceno v tabeli, če se, povečamo števec
                        stevec++;
                }
            }

        }
        Console.Clear();
        Console.WriteLine("Oceno {0} v Vaši evidenci smo prešteli {1}-krat. ", stevilo, stevec);
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni Meni");
        Console.WriteLine("[3] za nazaj");
        st = int.Parse(Console.ReadLine());
        if (st == 3)
            Iskanje(ocene);

        else if (st == 0)
            Menu(ocene);
    }

    else if (izbrana_možnost == 2)
    {
        Console.Clear();
        Console.WriteLine("*POVPREČJE*");
        Console.WriteLine("--------------------------------------------------");
        for (int i = 0; i < ocene.Length; i++)
        {
            switch (i) //za formatiran izpis
            {
                case 0: Console.Write("Matematika: "); break;
                case 1: Console.Write("Slovenščina: "); break;
                case 2: Console.Write("Angleščina: "); break;
                case 3: Console.Write("Fizika: "); break;
                case 4: Console.Write("NPA: "); break;
                case 5: Console.Write("NSA: "); break;
                case 6: Console.Write("NPB: "); break;
                case 7: Console.Write("Robotika: "); break;
                case 8: Console.Write("VOS: "); break;
                case 9: Console.Write("VSO: "); break;
                case 10: Console.Write("ŠVZ: "); break;
            }
            decimal vsota = 0;
            decimal stevec = 0;
            if (ocene[i] == null) //če nimamo vpisanih ocen
            {
                Console.WriteLine("-");
                Console.WriteLine("--------------------------------------------------");
            }
            else
            {

                for (int j = 0; j < ocene[i].Length; j++)
                {
                    vsota += ocene[i][j];
                    if (ocene[i][j] != 0)
                        stevec++;
                }
                Console.WriteLine(decimal.Round(vsota / stevec, 2, MidpointRounding.AwayFromZero)); //če rezultat ni celo število
                Console.WriteLine("--------------------------------------------------"); //ga izpiše na dva decimalna mesta
            }

        }
        Console.WriteLine("[0] za nazaj v začetni Meni");
        Console.WriteLine("[3] za nazaj");
        int st = int.Parse(Console.ReadLine());
        if (st == 3)
            Iskanje(ocene);

        else if (st == 0)
            Menu(ocene);


    }

}

static void Izpis(int[][] ocene)
{
    Console.Clear();
    Console.WriteLine("Izberite način izpisovanja ocene: ");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[1] Za posamezen predmet");
    Console.WriteLine("[2] Vse ocene pri vseh predmetih");
    Console.WriteLine("--------------------------------------------------");
    Console.WriteLine("[0] za nazaj");

    bool izbira_predmeta = false; //zagotavljanje pravilnega vnosa v Meniju za Izpis

    int izbrana_možnost2;
    izbrana_možnost2 = int.Parse(Console.ReadLine());
    if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 0)
        izbira_predmeta = true;
    while (izbira_predmeta == false)
    {
        Izpis(ocene);
        izbrana_možnost2 = int.Parse(Console.ReadLine());
        if (izbrana_možnost2 == 1 || izbrana_možnost2 == 2 || izbrana_možnost2 == 0)
            izbira_predmeta = true;
    }
    if (izbrana_možnost2 == 0)
        Menu(ocene);

    if (izbrana_možnost2 == 1) //Odpre meni za izbiro posameznega predmeta za katerega želimo izpisati ocene.
    {
        Console.Clear();
        Console.WriteLine("Izberite predmet za katerega želite izpisati ocene: ");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[1] Matematika");
        Console.WriteLine("[2] Slovenščina");
        Console.WriteLine("[3] Angleščina");
        Console.WriteLine("[4] Fizika");
        Console.WriteLine("[5] NPA");
        Console.WriteLine("[6] NSA");
        Console.WriteLine("[7] NPB");
        Console.WriteLine("[8] Robotika");
        Console.WriteLine("[9] VOS");
        Console.WriteLine("[10] VSO");
        Console.WriteLine("[11] Športna vzgoja");
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni meni");

        bool izbira_predmeta2 = false; //zagotavljanje pravilnega vnosa v Meniju za predmete

        int izbrana_možnostv2;
        izbrana_možnostv2 = int.Parse(Console.ReadLine());
        if (izbrana_možnostv2 == 1 || izbrana_možnostv2 == 2 || izbrana_možnostv2 == 3 || izbrana_možnostv2 == 4 || izbrana_možnostv2 == 5 || izbrana_možnostv2 == 6 || izbrana_možnostv2 == 7 || izbrana_možnostv2 == 8 || izbrana_možnostv2 == 9 || izbrana_možnostv2 == 10 || izbrana_možnostv2 == 11 || izbrana_možnostv2 == 0)
            izbira_predmeta2 = true;
        while (izbira_predmeta2 == false)
        {
            Izpis(ocene);
            izbrana_možnostv2 = int.Parse(Console.ReadLine());
            if (izbrana_možnostv2 == 1 || izbrana_možnostv2 == 2 || izbrana_možnostv2 == 3 || izbrana_možnostv2 == 4 || izbrana_možnostv2 == 5 || izbrana_možnostv2 == 6 || izbrana_možnostv2 == 7 || izbrana_možnostv2 == 8 || izbrana_možnostv2 == 9 || izbrana_možnostv2 == 10 || izbrana_možnostv2 == 11 || izbrana_možnostv2 == 0)
                izbira_predmeta2 = true;
        }
        if (izbrana_možnostv2 == 0)
            Menu(ocene);

        else if (izbrana_možnostv2 == 1) //MATEMATIKA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *MATEMATIKA*");
            Console.WriteLine("--------------------------");
            Console.Write("Matematika: ");
            if (ocene[0] == null) //če je tabela prazna
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0) //prebere vnos, če vnesemo 0, vrne na začetni meni
                    Menu(ocene);
            }
            else //če tabela ni prazna, izpiše ocene
            {
                for (int m = 0; m < ocene[0].Length; m++)
                {
                    if (ocene[0][m] != 0)
                        Console.Write("{0}{1}", ocene[0][m], m == (ocene[0].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }

        else if (izbrana_možnostv2 == 2) //SLOVENŠČINA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *SLOVENŠČINA*");
            Console.WriteLine("--------------------------");
            Console.Write("Slovenščina: ");
            if (ocene[1] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[1].Length; m++)
                {
                    if (ocene[1][m] != 0)
                        Console.Write("{0}{1}", ocene[1][m], m == (ocene[1].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 3) //ANGLEŠČINA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *ANGLEŠČINA*");
            Console.WriteLine("--------------------------");
            Console.Write("Angleščina: ");
            if (ocene[2] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[2].Length; m++)
                {
                    if (ocene[2][m] != 0)
                        Console.Write("{0}{1}", ocene[2][m], m == (ocene[2].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 4) //FIZIKA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *FIZIKA*");
            Console.WriteLine("--------------------------");
            Console.Write("Fizika: ");
            if (ocene[3] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[3].Length; m++)
                {
                    if (ocene[3][m] != 0)
                        Console.Write("{0}{1}", ocene[3][m], m == (ocene[3].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 5) //NPA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *NPA*");
            Console.WriteLine("--------------------------");
            Console.Write("NPA: ");
            if (ocene[4] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[4].Length; m++)
                {
                    if (ocene[4][m] != 0)
                        Console.Write("{0}{1}", ocene[4][m], m == (ocene[4].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 6) //NSA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *NSA*");
            Console.WriteLine("--------------------------");
            Console.Write("NSA: ");
            if (ocene[5] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[5].Length; m++)
                {
                    if (ocene[5][m] != 0)
                        Console.Write("{0}{1}", ocene[5][m], m == (ocene[5].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 7) //NPB
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *NPB*");
            Console.WriteLine("--------------------------");
            Console.Write("NPB: ");
            if (ocene[6] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[6].Length; m++)
                {
                    if (ocene[6][m] != 0)
                        Console.Write("{0}{1}", ocene[6][m], m == (ocene[6].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 8) //ROBOTIKA
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *ROBOTIKA*");
            Console.WriteLine("--------------------------");
            Console.Write("Robotika: ");
            if (ocene[7] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[7].Length; m++)
                {
                    if (ocene[7][m] != 0)
                        Console.Write("{0}{1}", ocene[7][m], m == (ocene[7].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 9) //VOS
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *VOS*");
            Console.WriteLine("--------------------------");
            Console.Write("VOS: ");
            if (ocene[8] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[8].Length; m++)
                {
                    if (ocene[8][m] != 0)
                        Console.Write("{0}{1}", ocene[8][m], m == (ocene[8].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 10) //VSO
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *VSO*");
            Console.WriteLine("--------------------------");
            Console.Write("VSO: ");
            if (ocene[9] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[9].Length; m++)
                {
                    if (ocene[9][m] != 0)
                        Console.Write("{0}{1}", ocene[9][m], m == (ocene[9].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
        else if (izbrana_možnostv2 == 11) //ŠVZ
        {
            Console.Clear();
            Console.WriteLine("Izpis ocen pri predmetu *ŠVZ*");
            Console.WriteLine("--------------------------");
            Console.Write("ŠVZ: ");
            if (ocene[10] == null)
            {
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
            else
            {
                for (int m = 0; m < ocene[10].Length; m++)
                {
                    if (ocene[10][m] != 0)
                        Console.Write("{0}{1}", ocene[10][m], m == (ocene[10].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("[0] za nazaj v začetni meni");
                if (int.Parse(Console.ReadLine()) == 0)
                    Menu(ocene);
            }
        }
    }
    if (izbrana_možnost2 == 2) //za izpis vseh ocen pri vseh predmetih
    {
        Console.Clear();
        Console.WriteLine("Izpis vseh ocen: ");
        Console.WriteLine("---------------------------------------------");
        for (int i = 0; i < ocene.Length; i++)
        {
            switch (i) //za formatiran izpis
            {
                case 0: Console.Write("Ocene pri predmetu *MATEMATIKA*: "); break;
                case 1: Console.Write("Ocene pri predmetu *SLOVENŠČINA*: "); break;
                case 2: Console.Write("Ocene pri predmetu *ANGLEŠČINA*: "); break;
                case 3: Console.Write("Ocene pri predmetu *FIZIKA*: "); break;
                case 4: Console.Write("Ocene pri predmetu *NPA*: "); break;
                case 5: Console.Write("Ocene pri predmetu *NSA*: "); break;
                case 6: Console.Write("Ocene pri predmetu *NPB*: "); break;
                case 7: Console.Write("Ocene pri predmetu *ROBOTIKA*: "); break;
                case 8: Console.Write("Ocene pri predmetu *VOS*: "); break;
                case 9: Console.Write("Ocene pri predmetu *VSO*: "); break;
                case 10: Console.Write("Ocene pri predmetu *ŠVZ*: "); break;
            }
            if (ocene[i] == null)
            {
                Console.WriteLine("--------");
            }
            else
            {
                for (int j = 0; j < ocene[i].Length; j++)
                {
                    if (ocene[i][j] != 0)
                        Console.Write("{0}{1}", ocene[i][j], j == (ocene[i].Length - 1) ? "" : " ");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("[0] za nazaj v začetni meni");
        if (int.Parse(Console.ReadLine()) == 0)
            Menu(ocene);
    }

}




