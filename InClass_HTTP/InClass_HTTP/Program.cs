using System;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;  //must include this to use HttpClient class
using System.Threading.Tasks; //must include to use Task<>
using System.Json;
using HomeMadeJSON; //to use my home made json parser

namespace InClass_HTTP
{
    
    class Program
    {
       
       
        static void Main(string[] args)
        {
            //create a client
            HttpClient client = new HttpClient();

            //set the URL address. 
            //BaseAdress is type URI
            client.BaseAddress = new Uri("https://cat-fact.herokuapp.com/facts/random");

            //call the API
            Task<HttpResponseMessage> response = client.GetAsync("");

            //Show how it's not done yet
            if (response.IsCompletedSuccessfully)
            {
                Console.WriteLine("THIS NEVER PRINTS");
            }

            //Used to wait for the Async (background running function) to finish
            response.Wait();

            //check to make sure that the response is completed
            if(response.IsCompletedSuccessfully)
            {
                Console.WriteLine("sucess");

                //get the data in string form
                Task<string> data = response.Result.Content.ReadAsStringAsync();


                //print results
                Console.WriteLine(data.Result);



                //convert string into a different data structure

                //try home made class to handle parsing
                JSONDictionary dict = JSONDictionary.JSONToDictionary(data.Result);

                Console.WriteLine("");
                Console.WriteLine("Home made parser");
                Console.WriteLine(dict["text"].ToString());
                Console.WriteLine("");
                Console.WriteLine(dict["status"].ToString());
                Console.WriteLine("");
                Console.WriteLine(dict.GetValue("status",true)["verified"]);   //add a index for overloaded get value! then done
                Console.WriteLine("---trying---");
                Console.WriteLine(dict["status"]["verified"].ToString());   //add a index for overloaded get value! then done
                Console.WriteLine("---done---");

                //found this, had to download System.Json
                JsonValue json = JsonObject.Parse(data.Result);



                Console.WriteLine("");
                Console.WriteLine("JsonValue Parser");
                Console.WriteLine(json["text"].ToString());
                Console.WriteLine("");
                Console.WriteLine(json["status"].ToString());
                Console.WriteLine("");
                Console.WriteLine(json["status"]["verified"].ToString());   






            }
        }
    }
}
