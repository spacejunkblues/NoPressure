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


            Task<HttpResponseMessage> APITask2 = client.GetAsync("/SendMessage?message=" + "(" + user + ")" + MessageToSend + "dfsahofidosfdshuhidouihodsuihdosdisaudisuadfsio" + "&user=" + user);

            APITask2.Wait();

            HttpResponseMessage APIResponse2 = APITask2.Result;

            string data2 = APIResponse2.Content.ReadAsStringAsync().Result;

            Console.Write("(" + user + ")" + MessageToSend);
        }

        public static void Main(string[] args)
        {
            string Message = "";
            bool Carriageflag = false;

             //create client
             HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("http://localhost:1337");

            

            Console.Clear();

            string user = "";

            Console.WriteLine("what is your username?");
            user = Console.ReadLine();
            Console.SetCursorPosition(0, Console.WindowHeight + 1);
            int i = 1;
            while (true)
            {
                Task<HttpResponseMessage> APITask2 = client.GetAsync("/GetMessage?user=" + user);

                while (!APITask2.IsCompleted) 
                {
                
                }

                if (APITask2.IsCompleted)
                {

                    HttpResponseMessage APIResponse2 = APITask2.Result;

                    string data2 = APIResponse2.Content.ReadAsStringAsync().Result;

                    if (data2 != "")
                    {

                        //Console.SetCursorPosition(0, Console.CursorTop + (i + 1));
                        Console.WriteLine(data2);

                        //Console.SetCursorPosition(0, Console.CursorTop + i);

                        //Console.WriteLine((char)13);

                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.SetCursorPosition(0, Console.WindowHeight + i);
                        i++;
                    }

                    data2 = "";

                    if (Console.KeyAvailable)
                    {
                        if (Carriageflag) 
                        {
                            //Console.SetCursorPosition(0, Console.WindowHeight + 1);
                            //Carriageflag = false;
                        }

                        var key = Console.ReadKey();

                        Message = Message + key.KeyChar;

                        if (key.KeyChar == (char)13)
                        {
                            //Carriageflag = true
                            //Console.SetCursorPosition(0, Console.CursorTop + i);
                            SendMessage(Message, user);

                            Message = "";
                            //Console.WriteLine();
                            //Console.WriteLine();
                            //Console.SetCursorPosition(0, Console.CursorTop + i);

                            Console.WriteLine();
                            //Console.WriteLine();
                            i++;
                        }
                    }
                }
            }

            
        }
    }
}
