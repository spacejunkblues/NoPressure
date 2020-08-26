using System;
using System.Collections.Generic;
using System.Json;
using System.Net.Http;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace moviedatabaseAPI
{
    class Program
    {
        static public string parse(string ToParse)
        {
            int LastCheck = 0;

            while (ToParse.IndexOf(',', LastCheck) != -1)
            {
                ToParse = ToParse.Remove(ToParse.IndexOf(',', LastCheck) + 1, 1);

                LastCheck = ToParse.IndexOf(',', LastCheck) + 2;
            }

            //replace all commas with inlines
            ToParse = ToParse.Replace(',', (char)10);

            

            return ToParse;
        }

        static void Main(string[] args)
        {
            //Create variables
            string title = "";
            string season = "";
            string episode = "";
            string typeoftitle = "";
            int LastPrint = 0;

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

            LastPrint = Console.CursorTop + 1;

            //Console.SetCursorPosition(0, LastPrint = Console.CursorTop + 1);
            //Console.Write("here");

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

            //Deletes the word loading and the dots after it
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

            Console.Write("          ");

            //save the response
            HttpResponseMessage APIResponse = APITask.Result;

            //values that must be parsed by a comma
            string[] keysToBeParsed = { "Actors", "Genre", "Writer" };

            //convert the API response into a string
            string data = APIResponse.Content.ReadAsStringAsync().Result;
            JsonValue json = JsonValue.Parse(data);

           

            Console.SetCursorPosition(0, LastPrint);

            bool foundoccurence = false;

            //this prints all keys and values
            /*  foreach (KeyValuePair<string, JsonValue> j in json)
              {
                  Console.WriteLine(j.Key + ":" + (char)10);

                  //prints multiple values that are stored as a single string
                  foreach(var s in keysToBeParsed)
                  {
                      if (j.Key == s) 
                      {
                          Console.WriteLine(parse(j.Value));
                          foundoccurence = true;
                      }
                  }

                  //prints single string
                  if (!foundoccurence) 
                  {
                      Console.WriteLine(j.Value.ToString());
                  }

                  //Resseting the bool flag
                  foundoccurence = false;

                  //Printing an enter for clarity
                  Console.WriteLine();
                  Console.WriteLine();

              }*/

            //this prints keys and values of our choice
            // and in the order we choose

            //first keys to display
            string[] topKeys = { "Title", "Year", "Runtime", "Type" };//********need to error check

            //this string will contain all keys starting with the top keys
            string[] keys;

            //get the restof the keys
            string[] restKeys = new string[json.Count - topKeys.Length];

            //Created index for foreach
            int i = 0;

            //Creat bool for flagging if it is equal to a single top key
            bool IsEqual = false;

            //loop through json to find the rest of the keys
            foreach (KeyValuePair<string, JsonValue> j in json) 
            {
                foreach (string s in topKeys) 
                {
                    if (s == j.Key) 
                    {
                        IsEqual = true;
                    }
                }

                if (!IsEqual) 
                {
                    restKeys[i++] = j.Key;
                }

                //Reset the bool flag
                IsEqual = false;
            }

            //Assign keys length to topkeys.length and restkeys.length
            keys = new string[topKeys.Length + restKeys.Length];

            //add top keys to keys
            for (int j =0; j<topKeys.Length; j++) 
            {
                keys[j] = topKeys[j];
            }

            //Reset i
            i = topKeys.Length;

            //add the rest of the keys to keys
            for (int j =0; j<restKeys.Length; j++, i++) 
            {
                keys[i] = restKeys[j];
            }

            foreach (var k in keys)
            {
                Console.WriteLine(k + ":" + (char)10);

                //prints multiple values that are stored as a single string
                foreach (var s in keysToBeParsed)
                {
                    if (k == s)
                    {
                        Console.WriteLine(parse(json[k].ToString()));
                        foundoccurence = true;
                    }
                }

                //prints single string
                if (!foundoccurence)
                {
                    Console.WriteLine(json[k].ToString());
                }

                //Resseting the bool flag
                foundoccurence = false;

                //Printing an enter for clarity
                Console.WriteLine();
                Console.WriteLine();

            }


            //Console.Write(json.ToString());
        }
    }
}
