using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    Manages HTTP Requests and Responses.
    *******************************************************************************************************************/
    public class Api
    {
        /*******************************************************************************************************************
        *    Requests a random joke from the ICNDB and passes it to the closure when ready.
        *
        *    @param onJokeResponse Callback to invoke and pass the joke to.
        *******************************************************************************************************************/
        public async void RequestRandomJoke( Action<string> onJokeResponse )
        {
            // load joke via API
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync( GetRandomJokeURL() );
                HttpContent content = response.Content;
                {
                    var result = await content.ReadAsStringAsync();
                    var randomJoke  = JsonConvert.DeserializeObject<RandomJoke>( result );

                    onJokeResponse( randomJoke.value.joke );
                }
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception.Message );

                onJokeResponse( "No joke this time .. an error occurred: " + exception.Message );
            }
        }

        public static string GetRandomJokeURL()
        {
            return "http://api.icndb.com/jokes/random";
        }
    }
}
