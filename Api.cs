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
        public async void requestRandomJoke( Action<string> onJokeResponse )
        {
            // load joke via API
            string URL_ICND = "http://api.icndb.com/jokes/random";
            HttpClient client = new HttpClient();

            try
            {
                HttpResponseMessage response = await client.GetAsync( URL_ICND );
                HttpContent content = response.Content;
                {
                    string result = await content.ReadAsStringAsync();
                    RandomJoke randomJoke  = JsonConvert.DeserializeObject<RandomJoke>( result );

                    onJokeResponse( randomJoke.value.joke );
                }
            }
            catch ( Exception exception )
            {
                Console.WriteLine( exception.Message );

                onJokeResponse( "No joke this time .. an error occurred: " + exception.Message );
            }
        }
    }
}
