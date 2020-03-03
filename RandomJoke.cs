namespace DotNetWpfPrimer
{
    /*******************************************************************************************************************
    *    Represents the application's main window.
    *******************************************************************************************************************/
    public class RandomJoke
    {
        public string type;

        public Value value;

        public class Value
        {
            public int id;
            public string joke;
            public string[] categories;
        }
    }
}
