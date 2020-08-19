using System;
using System.Json;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace moviedatabaseAPI
{
    class Program
    {
        public string parse()
        {
            return null;
        }

        static void Main(string[] args)
        {
            //Create variables
            string title = "";
            string season = "";
            string episode = "";
            string typeoftitle = "";

            Console.WriteLine("What is the title of your movie/series?");
            title = "t=" + Console.ReadLine();

            Console.WriteLine("is it a show, or a movie?");
            typeoftitle = Console.ReadLine();

            if (typeoftitle == "show") 
            {
                Console.WriteLine("do you want to include season and episode? (yes or no)");
                typeoftitle = Console.ReadLine();

                if(typeoftitle == "yes") 
                {
                    title = title + "&";

                    Console.WriteLine("what is the season? (a number)");
                    season = "season=" + Console.ReadLine() + "&";

                    Console.WriteLine("what is the episode? (also a number)");
                    episode = "episode=" + Console.ReadLine();
                }
            }

            //create client
            HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("http://www.omdbapi.com/");

            //call the servers function, this is the API call
            Task<HttpResponseMessage> APITask = client.GetAsync("?" + title + season + episode + "&apikey=da203959");

            int x = 0;

            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
            Console.Write("Loading");
            x = Console.CursorLeft;

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
            
            //save the response
            HttpResponseMessage APIResponse = APITask.Result;

            //convert the API response into a string
            string data = APIResponse.Content.ReadAsStringAsync().Result;
            JsonValue json = JsonValue.Parse(data);


            
            if (true)
            {
                

                for (int i = 0; i < json.Count; i++)
                {
                    Console.WriteLine(i);
                }
            }
            var temp = json["Episodes"];
            var temp2 = temp.JsonType;
        }
    }
}
