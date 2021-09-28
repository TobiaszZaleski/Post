using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Czy utworzyć nowy post?");
                Console.WriteLine("Wciśnij enter aby utworzyć nowy post lub esc aby wyjść.");
                var pierwszyKlawisz = Console.ReadKey(true).Key;


                if (ConsoleKeyInfo.Equals(pierwszyKlawisz, ConsoleKey.Enter))
                {
                    Console.WriteLine("Podaj tytuł: ");
                    var tytuł = Console.ReadLine();

                    Console.WriteLine("Podaj opis: ");
                    var opis = Console.ReadLine();

                    var post = new Post(tytuł, opis);

                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Data utworzenia: " + post.TimeCreated);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(post.Title + "\n");
                        Console.ResetColor();
                        Console.WriteLine(post.Description);
                        Console.WriteLine("\nVotes: " + post.Votes);
                        Console.WriteLine("\n\nUp-Vote   -> wciśnij strzałkę w górę");
                        Console.WriteLine("Down-Vote -> wciśnij strzałkę w dół");
                        Console.WriteLine("Wyjście   -> wciśnij Escape");

                        var klawisz = Console.ReadKey(true).Key;

                        if (ConsoleKeyInfo.Equals(klawisz, ConsoleKey.UpArrow))
                        {
                            post.UpVote();
                            continue;
                        }
                        else if (ConsoleKeyInfo.Equals(klawisz, ConsoleKey.DownArrow))
                        {
                            post.DownVote();
                            continue;
                        }
                        else if (ConsoleKeyInfo.Equals(klawisz, ConsoleKey.Escape))
                        {
                            break;
                        }
                        else
                            throw new ArgumentOutOfRangeException("Klawisz inny niż podane możliwości glosowania");
                    }

                }
                else if (ConsoleKeyInfo.Equals(pierwszyKlawisz, ConsoleKey.Escape))
                {
                    break;
                }
                else
                    throw new ArgumentOutOfRangeException("Klawisz inny niż podane możliwości");
            }
        }
    }
}
