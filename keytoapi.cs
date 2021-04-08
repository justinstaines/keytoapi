using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


// (c) Copyright Justin Staines 2021
// simple program that reads a key and then calls an endpoint of an API when the button is pressed
// doesnt wait for asynch to confirm request so very fast
namespace keytoapidemo
{
    class Program
    {

        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {

            int start = 1;
            string apisend = "https://jsonplaceholder.typicode.com";

            while (start == 1)
            {

                string apicommand;

                

                ConsoleKeyInfo cki;
                cki = Console.ReadKey(true);
             


                apicommand = cki.Key.ToString();
             

                string[,] a1 = new string[2, 2] { { "L", "https://jsonplaceholder.typicode.com/todos/2" }, { "T", "https://jsonplaceholder.typicode.com/todos/1" } };

                int y = 0;

                while (y < 2)
                {
                    
                    if (apicommand == a1[y, 0]) { apisend = a1[y, 1]; };

                    y++;

                }


                 StreamWriter sw = new StreamWriter("C:\\apilog.txt", append: false);

               

                 sw.WriteLine(apisend);



                 sw.Close();

               client.GetAsync(apisend);

                
               apisend = "https://jsonplaceholder.typicode.com";
            }

        }
        }
    }
