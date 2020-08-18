using System;
using System.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace InClass_HTTP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create client
            HttpClient client = new HttpClient();

            //set the address
            client.BaseAddress = new Uri("https://cat-fact.herokuapp.com/");

            //call the servers function, this is the API call
            Task<HttpResponseMessage> APIRawReturn = client.GetAsync("facts/random?amount=5");


            //check to make sure it worked
            if (APIRawReturn.IsCompleted)
                Console.WriteLine("Sucess");
            else
                Console.WriteLine("Fail");

            //turns the Async effectively into a sync operation
            APIRawReturn.Wait();

            //check to make sure it worked
            if (APIRawReturn.IsCompleted)
                Console.WriteLine("Sucess");
            else
                Console.WriteLine("Fail");


            //save the response
            HttpResponseMessage APIResponse = APIRawReturn.Result;

            //convert the API response into a string
           string data = APIResponse.Content.ReadAsStringAsync().Result;

            JsonValue json = JsonValue.Parse(data);

            for (int i = 0; i<json.Count; i++)
            {
                Console.WriteLine(json[i]["text"].ToString());
                Console.WriteLine();
            }

        }
    }
}
