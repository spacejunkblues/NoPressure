﻿using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.CodeDom;

namespace Chat_caller
{

    class MainClass
    {
        static bool IsDone;
        static string user = "";
        public static bool mysearch()
        {
            Thread.Sleep(1250);
            //Console.Write("Counted to 5");

            return true;
        }

        public static async void Wait()
        {
            //IsDone = false;
            var test = await Task.Run(mysearch);
            //Console.Write("!");
            IsDone = true;
            GetMessage();
        }

        public static void GetMessage() 
        {
            //create client
            HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("https://nopressure-chatroom.herokuapp.com");

            Task<HttpResponseMessage> APITask2 = client.GetAsync("/GetMessage?user=" + user);

            APITask2.Wait();
            HttpResponseMessage APIResponse2 = APITask2.Result;

            string data2 = APIResponse2.Content.ReadAsStringAsync().Result;
            
            if (data2 != "")
            {

                //Console.SetCursorPosition(0, Console.CursorTop + (i + 1));
                Console.Write(data2);

                //Console.SetCursorPosition(0, Console.CursorTop + i);

                //Console.WriteLine((char)13);

                //Console.WriteLine();
                //Console.WriteLine();
                //Console.SetCursorPosition(0, Console.WindowHeight + i);
                //i++;
            }

            data2 = "";
        }

        static public void SendMessage(string MessageToSend)
        {
            //create client
            HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("https://nopressure-chatroom.herokuapp.com");

            Task<HttpResponseMessage> APITask2 = client.GetAsync("/SendMessage?message=" + "(" + user + ")" + MessageToSend + "&user=" + user);

            //APITask2.Wait();

            //HttpResponseMessage APIResponse2 = APITask2.Result;

            //string data2 = APIResponse2.Content.ReadAsStringAsync().Result;

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

            user = "";

            Console.WriteLine("what is your username?");
            user = Console.ReadLine();
            Console.SetCursorPosition(0, Console.WindowHeight + 1);

            int i = 1;
            Wait();
            while (true)
            {
                if (IsDone)
                {
                    Wait();
                    IsDone = false;
                }

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
                        Message = Message.Replace('\r', '\n');
                        SendMessage(Message);

                        Message = "";
                        //Console.WriteLine();
                        //Console.WriteLine();
                        //Console.SetCursorPosition(0, Console.CursorTop + i);

                        //Console.WriteLine();
                        //Console.WriteLine();
                        i++;
                    }
                }


                //IsDone = false;
            }


        }
    }
}
