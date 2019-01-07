using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4WordBruteForce
{
    class Program
    {
        static void Main(string[] args)
        {

            String str;
            Char[] characters = new Char[] { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G',
                'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            StringBuilder sb = new StringBuilder();
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();
            int counter = 0;
            int value = 0;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            foreach (Char i in characters) // Checks 1 character passwords 
            {
                sb.Append(i);
                str = sb.ToString();
                Console.WriteLine(sb);
                value++;
                if (str == password)
                {
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Brute-Force found your password.");
                    long time = elapsedMs / 1000;
                    Console.WriteLine("It took " + time + " seconds to break the password.");
                    counter += 1;
                    break;
                }
                sb.Clear();
                if (counter == 1)
                {
                    break;
                }
            }
            if (counter == 0) //Checks 2 character passwords
            {
                foreach (Char i in characters)
                {
                    foreach (Char x in characters)
                    {
                        sb.Append(i);
                        sb.Append(x);
                        str = sb.ToString();
                        Console.WriteLine(sb);
                        value++;
                        if (str == password)
                        {
                            watch.Stop();
                            var elapsedMs = watch.ElapsedMilliseconds;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Brute-Force found your password.");
                            long time = elapsedMs / 1000;
                            Console.WriteLine("It took " + time + " seconds to break the password.");
                            counter += 1;
                            Console.WriteLine("It took " + value + " combinations to find the password");
                        }
                        sb.Clear();
                        if (counter == 1)
                        {
                            break;
                        }
                    }
                    if (counter == 1)
                    {
                        break;
                    }
                }
            }
            if (counter == 0) //checks 3 character passwords
            {
                foreach (Char i in characters)
                {
                    foreach (Char x in characters)
                    {
                        foreach (Char y in characters)
                        {
                            sb.Append(i);
                            sb.Append(x);
                            sb.Append(y);
                            str = sb.ToString();
                            Console.WriteLine(sb);
                            value++;
                            if (str == password)
                            {
                                watch.Stop();
                                var elapsedMs = watch.ElapsedMilliseconds;
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Brute-Force found your password.");
                                counter += 1;
                                long time = elapsedMs / 1000;
                                Console.WriteLine("It took " + time + " seconds to break the password.");
                                Console.WriteLine("It took " + value + " combinations to find the password");
                                break;
                            }
                            sb.Clear();
                        }
                        sb.Clear();
                        if (counter == 1)
                        {
                            break;
                        }
                    }
                    if (counter == 1)
                    {
                        break;
                    }
                }
            }
            if (counter == 0) //Checks 4 character passwords
            {
                foreach (Char i in characters)
                {
                    foreach (Char x in characters)
                    {
                        foreach (Char y in characters)
                        {
                            foreach (Char z in characters)
                            {
                                sb.Append(i);
                                sb.Append(x);
                                sb.Append(y);
                                sb.Append(z);
                                str = sb.ToString();
                                Console.WriteLine(sb);
                                value++;
                                if (str == password)
                                {
                                    watch.Stop();
                                    var elapsedMs = watch.ElapsedMilliseconds;
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Brute-Force found your password.");
                                    long time = elapsedMs / 1000;
                                    Console.WriteLine("It took " + time + " seconds to break the password.");
                                    counter += 1;
                                    Console.WriteLine("It took " + value + " combinations to find the password");
                                    break;
                                }
                                sb.Clear();
                            }
                            sb.Clear();
                        }
                        sb.Clear();
                        if (counter == 1)
                        {
                            break;
                        }
                    }
                    if (counter == 1)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
