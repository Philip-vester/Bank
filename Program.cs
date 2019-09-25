using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int Konto = 10;
            int InKonto = 0;
            int UtKonto = 0;
            int On = 1;
            string Antal;

                
                Console.WriteLine("\nHej och välkommen till din bank!\n \nHur kan vi stå till tjänst?");

            while(On == 1)
            {

                Console.WriteLine("Ta ut pengar[1] \nSätta in pengar[2] \nSe saldo[3] \nAvsluta[4]");
                string Val = Console.ReadLine();

                switch(Val)
                    {
                        case "1":
                            if(Konto == 0)
                                {
                                    Console.WriteLine("Saldot är 0.");
                                    break;
                                }
                            else
                                {
                                    Console.WriteLine("Hur mycket vill du ta ut?\nDitt saldo är:" + Konto);
                                    Antal = Console.ReadLine();
                                    UtKonto = int.Parse(Antal);
                                    
                                    
                                    if( UtKonto > Konto)
                                        {
                                            Console.WriteLine("Belop överskrider tillängligt saldo. ");
                                            break;
                                        }
                                    
                                    else
                                    {
                                        Konto=(Konto - UtKonto);
                                        Console.WriteLine("Du tog ut " + UtKonto + "kr. \nDitt saldo är nu: " + Konto);
                                        break;
                                    }

                                }

                        case "2":
                            Console.WriteLine("Hur mycket pengar vill du sätta in?");
                            Antal = Console.ReadLine();
                            InKonto = int.Parse(Antal);

                                Konto = (Konto + InKonto);

                                Console.WriteLine("Ditt saldo är nu: " + Konto);
                                break;

                        case "3":
                            Console.WriteLine("Ditt saldo är: " + Konto);
                            break;

                        case "4":
                        Console.WriteLine("Tack och hej!");
                        On = 0;
                        break;   
                    }
            }


        }
    }
}
