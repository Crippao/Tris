using System;

namespace Tris
    {
    internal class Program
        {
        static void Main(string[] args)
            {

            //INPUT DELLE VARIABILI
            Random moneta = new Random(); //sceglie randomicamente da 0 a 100 e fa se è pari(giocatore 2) o dispari(giocatore 1)
            bool esci = false; //in caso di uscita dal gioco
            int ca = 0; //per contenere il numero random
            string sm = " "; //mette il valore vincitore
            bool par = false; //in caso di pareggio
            bool win = false; //in caso di vittoria
            string sc = " "; //la scelta della partita
            bool turno = false; //a chi tocca giocare tra il giocatore 1 o giocatore 2
            bool reset = false; //la pulizia del tabellone 
            bool ck = false; //controlla in caso di sovvrascrittura del simbolo
            int g = 0; //variabile per contenere la scelta dell'utente per determinare che giocatore è
            int p = 0; //variabile per mettere la X o la O dentro al tabellone
            bool giocatore = false;//g1=falso(x) g2=vero(o)
            string[] Tris = new string[9] { "0", "1", "2", "3", "4", "5", "6", "7", "8" };//casella di gioco
            string[] TrisP = new string[9]{ "0", "1", "2", "3", "4", "5", "6", "7", "8" };//casella di pulizia
            string[] TrisG = new string[9] { " ", " ", " ", " ", " ", " ", " ", " ", " " };//casella di grafica


            //SCHERMATA PRINCIPALE
            Console.WriteLine("-------------              -------------");
            Thread.Sleep(500);
            Console.WriteLine("| X | O | X |              | X | X | O |");
            Thread.Sleep(500);
            Console.WriteLine("|-----------|              |-----------|");
            Thread.Sleep(500);
            Console.WriteLine("| O | O | X |     TRIS     | O | O | X |");
            Thread.Sleep(500);
            Console.WriteLine("|-----------|              |-----------|");
            Thread.Sleep(500);
            Console.WriteLine("|   | O |   |              | O | X | X |");
            Thread.Sleep(500);
            Console.WriteLine("-------------              -------------");
            Thread.Sleep(500);
            Console.WriteLine(" ");
            Console.WriteLine("Vince chi fa 3 simboli in fila");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Vuoi giocare?(y/n) ");
            sc = Console.ReadLine();
            Console.WriteLine(" ");
            if (sc == "n")
                {
                esci = true;
                }
            while (esci == false)
                {

                //SCELTA GIOCATORE
                reset = false;
                Console.Write("che giocatore vuoi essere(1/2)? ");
                g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                if (g == 1)
                    {
                    giocatore = false;   // gioca con il simbolo X
                    }
                else
                    {
                    giocatore = true;    //gioca con il simbolo O
                    }


                do
                    {
                    //RANDOM D'INIZIO
                    Console.WriteLine("Lancio una moneta per determinare chi inizia...");
                    Console.WriteLine(" ");
                    Thread.Sleep(3000);
                    ca = moneta.Next(0, 100);
                    if (ca % 2 == 0)
                        {
                        Console.WriteLine("Inizia il giocatore 2");
                        Console.WriteLine(" ");
                        turno = true;
                        }
                    else
                        {
                        Console.WriteLine("Inizia il giocatore 1");
                        Console.WriteLine(" ");
                        turno = false;
                        }
                    //INIZIO DEL GIOCO
                    do
                        {
                        do
                            {
                            Console.Write("In che casella vuoi inserire il tuo simbolo?(da 0 a 8) "); //il numero che deve inserire l'utente per metterlo nel tabellone (array)
                            p = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" ");
                            switch (p)
                                {
                                case 0:
                                    if (Tris[p] == "0")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 1:
                                    if (Tris[p] == "1")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 2:
                                    if (Tris[p] == "2")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 3:
                                    if (Tris[p] == "3")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 4:
                                    if (Tris[p] == "4")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 5:
                                    if (Tris[p] == "5")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 6:
                                    if (Tris[p] == "6")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 7:
                                    if (Tris[p] == "7")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                case 8:
                                    if (Tris[p] == "8")
                                        {
                                        if (turno)
                                            {
                                            Tris[p] = "O";
                                            TrisG[p] = "O";
                                            ck = false;
                                            }
                                        else
                                            {
                                            Tris[p] = "X";
                                            TrisG[p] = "X";
                                            ck = false;
                                            }

                                        }
                                    else
                                        {
                                        Console.WriteLine("ATTENZIONE:Casella già occupata,scegli un'altra casella");//in caso di sovvrascrittura
                                        Console.WriteLine(" ");
                                        ck = true;
                                        }
                                    break;
                                }

                            } while (ck == true);

                        //GENERAZIONE GRAFICA DEL TABELLONE
                        Console.WriteLine("-------------");
                        Thread.Sleep(300);
                        Console.WriteLine("| "+TrisG[0]+" | "+ TrisG[1] + " | " + TrisG[2] + " |");
                        Thread.Sleep(300);
                        Console.WriteLine("-------------");
                        Thread.Sleep(300);
                        Console.WriteLine("| " + TrisG[3] + " | " + TrisG[4] + " | " + TrisG[5] + " |");
                        Thread.Sleep(300);
                        Console.WriteLine("-------------");
                        Thread.Sleep(300);
                        Console.WriteLine("| " + TrisG[6] + " | " + TrisG[7] + " | " + TrisG[8] + " |");
                        Thread.Sleep(300);
                        Console.WriteLine("-------------");
                        Thread.Sleep(300);

                        //CONTROLLO VINCITORE
                        if (Tris[0] == Tris[3] && Tris[3] == Tris[6])
                            {
                            win = true;
                            sm = Tris[0];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[2] == Tris[5] && Tris[5] == Tris[8])
                            {
                            win = true;
                            sm = Tris[2];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[1] == Tris[4] && Tris[4] == Tris[7])
                            {
                            win = true;
                            sm = Tris[1];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[0] == Tris[1] && Tris[1] == Tris[2])
                            {
                            win = true;
                            sm = Tris[0];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[3] == Tris[4] && Tris[4] == Tris[5])
                            {
                            win = true;
                            sm = Tris[3];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[6] == Tris[7] && Tris[7] == Tris[8])
                            {
                            win = true;
                            sm = Tris[6];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[0] == Tris[4] && Tris[4] == Tris[8])
                            {
                            win = true;
                            sm = Tris[0];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[2] == Tris[4] && Tris[4] == Tris[6])
                            {
                            win = true;
                            sm = Tris[2];
                            if (sm == "O")
                                {
                                giocatore = true;
                                }
                            else
                                {
                                giocatore = false;
                                }
                            }
                        else if (Tris[0] != "0" && Tris[1] != "1" && Tris[2] != "2" && Tris[3] != "3" && Tris[4] != "4" && Tris[5] != "5" && Tris[6] != "6" && Tris[7] != "7" && Tris[8] != "8")
                            {
                            par = true;
                            win = true;
                            }
                        else
                            {
                            if (turno)
                                {
                                turno = false;
                                Console.WriteLine("Tocca al giocatore 1");
                                Console.WriteLine(" ");
                                }
                            else
                                {
                                turno = true;
                                Console.WriteLine("Tocca al giocatore 2");
                                Console.WriteLine(" ");
                                }
                            }
                        } while (win == false);
                    //ANNUNCIO DEL VINCITORE O PARITA' E RICHIESTA DI FARE UN'ALTRA PARTITA
                    if (par == true)
                        {
                        win = false;
                        }
                    if (win)
                        {
                        if (giocatore == false)
                            {
                            Console.WriteLine("Ha vinto il giocatore 2");
                            Console.WriteLine(" ");
                            Console.Write("Vuoi fare un altra partita?(y/n) ");
                            sc = Console.ReadLine();
                            Console.WriteLine(" ");
                            if (sc == "y")
                                {
                                reset = true;
                                for (int i = 0; i < 9; i++)
                                    {
                                    TrisG[i] = " ";
                                    Tris[i] = TrisP[i];
                                    }
                                par = false;
                                win = false;
                                }
                            else
                                {
                                esci = true;
                                reset = false;
                                }

                            }
                        else if (giocatore == true)
                            {
                            Console.WriteLine("Ha vinto il giocatore 1");
                            Console.WriteLine(" ");
                            Console.Write("Vuoi fare un altra partita?(y/n) ");
                            sc = Console.ReadLine();
                            Console.WriteLine(" ");
                            if (sc == "y")
                                {
                                reset = true;
                                for (int i = 0; i < 9; i++)
                                    {
                                    TrisG[i] = " ";
                                    Tris[i] = TrisP[i];
                                    }
                                par = false;
                                win = false;
                                }
                            else
                                {
                                esci = true;
                                reset = false;
                                }
                            }

                        }
                    if (par)
                        {
                        Console.WriteLine("è finita con un pareggio");
                        Console.WriteLine(" ");
                        Console.Write("Vuoi fare un altra partita?(y/n) ");
                        sc = Console.ReadLine();
                        Console.WriteLine(" ");
                        if (sc == "y")
                            {
                            reset = true;
                            for (int i = 0; i < 9; i++)
                                {
                                TrisG[i] = " ";
                                Tris[i] = TrisP[i];
                                }
                            par = false;
                            win = false;
                            }
                        else
                            {
                            esci = true;
                            reset = false;
                            }
                        }

                    } while (reset == true);
                }

            //FINE DEL GIOCO E CHIUSURA DEL PROGRAMMA
            Console.WriteLine(" ");
            Console.WriteLine("Grazie per aver giocato");
            Console.WriteLine(" ");
            Thread.Sleep(3000);
            Console.WriteLine("Programma finito...cliccare 'INVIO' per chiudere il programma");
            Console.ReadLine();
            }
        }
    }
