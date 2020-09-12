using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Chat_caller
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
             //create client
             HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("http://www.omdbapi.com/");

            //call the servers function, this is the API call
            Task<HttpResponseMessage> APITask = client.GetAsync("/GetMessage");


            int x = Console.CursorLeft;

            while (!APITask.IsCompleted)
            {
                Console.SetCursorPosition(x, Console.WindowHeight / 2);

                Console.Write("   ");

                Console.SetCursorPosition(x, Console.WindowHeight / 2);

                Console.Write(".");
                Thread.Sleep(100);

                Console.Write(".");
                Thread.Sleep(100);

                Console.Write(".");
                Thread.Sleep(100);
            }

            HttpResponseMessage APIResponse = APITask.Result;

            string data = APIResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(data);
        }
    }
}
