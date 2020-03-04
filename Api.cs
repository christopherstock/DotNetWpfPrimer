using System;
using System.Net.Http;
using Newtonsoft.Json;

namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    Manages HTTP Requests and Responses.
    *******************************************************************************************************************/
    public abstract class Api
    {
        /***************************************************************************************************************
        *    Requests a random joke from the ICNDB and passes it to the closure when ready.
        *
        *    @param onJokeResponse Callback to invoke and pass the joke to.
        ***************************************************************************************************************/
        public static async void RequestRandomJoke( Action<string> onJokeResponse )
        {
            // load joke via API
            var client = new HttpClient();

            try
            {
                var response = await client.GetAsync( GetRandomJokeUrl() );
                var content = response.Content;
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

        /***************************************************************************************************************
        *    Receives the URL of the ICNDB that delivers a random joke.
        *
        *    @return The RandomJoke URL of the International Chuck Norris Database.
        ***************************************************************************************************************/
        public static string GetRandomJokeUrl()
        {
            return "http://api.icndb.com/jokes/random";
        }
    }
}
