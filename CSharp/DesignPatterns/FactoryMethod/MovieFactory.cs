namespace FactoryMethod
{
    public class MovieFactory
    {
        public IMovie NewMovie(string movie)
        {
            switch (movie)
            {
                case "ACTION":
                    return new Action();
                case "COMMEDY":
                    return new Commedy();
                case "TERROR":
                    return new Terror();
                default:
                    return null;
            }
        }
    }
}
