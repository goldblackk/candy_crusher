using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace candy_crusher
{
    class Program
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static Timer aTimer;
        static void Main(string[] args)
        {
            string candy1 = RandomString(10);
            string candy2 = RandomString(10);
            string candy3 = RandomString(10);
            string candy4 = RandomString(10);
            string candy5 = RandomString(10);
            string candy6 = RandomString(10);
            string candy7 = RandomString(10);
            Console.WriteLine("You've got 8 seconds to write it down: " + candy1);
            aTimer = new Timer();
            aTimer.Interval = 8000;
            aTimer.Elapsed += OnTimedEvent;
            aTimer.Enabled = true;
            string text = Console.ReadLine();
            if (text.Contains(candy1))
            {
                aTimer.Enabled = false;
                Console.WriteLine("Code 1/7 - Next code: " + candy2);
                aTimer.Enabled = true;
                string text2 = Console.ReadLine();
                if (text2.Contains(candy2))
                {
                    aTimer.Enabled = false;
                    Console.WriteLine("Code 2/7 - Next code: " + candy3);
                    aTimer.Enabled = true;
                    string text3 = Console.ReadLine();
                    if (text3.Contains(candy3))
                    {
                        aTimer.Enabled = false;
                        Console.WriteLine("Code 3/7 - Next code: " + candy4);
                        aTimer.Enabled = true;
                        string text4 = Console.ReadLine();
                        if (text4.Contains(candy4))
                        {
                            aTimer.Enabled = false;
                            Console.WriteLine("Code 4/7 - Next code: " + candy5);
                            aTimer.Enabled = true;
                            string text5 = Console.ReadLine();
                            if (text5.Contains(candy5))
                            {
                                aTimer.Enabled = false;
                                Console.WriteLine("Code 5/7 - Next code: " + candy6);
                                aTimer.Enabled = true;
                                string text6 = Console.ReadLine();
                                if (text6.Contains(candy6))
                                {
                                    aTimer.Enabled = false;
                                    Console.WriteLine("Code 6/7 - Next code: " + candy7);
                                    aTimer.Enabled = true;
                                    string text7 = Console.ReadLine();
                                    if (text7.Contains(candy7))
                                    {
                                        Console.WriteLine("Code 7/7 - Successfull!");
                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Wrong!");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Wrong!");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong!");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong!");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Wrong!");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Wrong!");
                Console.ReadKey();
            }
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Time out! You failed.");
        }
    }
}
