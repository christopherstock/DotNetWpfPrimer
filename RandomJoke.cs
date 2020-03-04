// ReSharper disable all
namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    The model class that represents a RandomJoke model from a response JSON body.
    *******************************************************************************************************************/
    public class RandomJoke
    {
        public string type;

        public Value  value;

        public class Value
        {
            public int      id;
            public string   joke;
            public string[] categories;
        }
    }
}
