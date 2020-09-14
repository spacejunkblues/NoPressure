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
        static public void SendMessage(string MessageToSend, string user)
        {
            //create client
            HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("http://localhost:1337");


            Task<HttpResponseMessage> APITask2 = client.GetAsync("/SendMessage?text=" + MessageToSend);

            HttpResponseMessage APIResponse2 = APITask2.Result;

            string data2 = APIResponse2.Content.ReadAsStringAsync().Result;

            while (APITask2.IsCompleted)
            {

            }

            Console.Write("(" + user + ")" + MessageToSend);
        }

        public static void Main(string[] args)
        {
            
             //create client
             HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("http://localhost:1337");

            

            Console.Clear();

            string user = "";

            Console.WriteLine("what is your username?");
            user = Console.ReadLine();

            while (true)
            {
                Task<HttpResponseMessage> APITask2 = client.GetAsync("/GetMessage");

                HttpResponseMessage APIResponse2 = APITask2.Result;


                string data2 = APIResponse2.Content.ReadAsStringAsync().Result;

                while (APITask2.IsCompleted)
                {
                    
                }

                Console.WriteLine(data2);

                if (Console.KeyAvailable)
                {
                    string message = Console.ReadLine();

                    SendMessage(message, user);
                }
            }

            
        }
    }
}
