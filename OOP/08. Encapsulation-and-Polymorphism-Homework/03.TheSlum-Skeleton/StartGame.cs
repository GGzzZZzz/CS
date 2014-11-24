namespace TheSlum
{
    using TheSlum.GameEngine;

    public class StartGame
    {
        public static void Main()
        {
            Engine engine = new ExtendedEngine();
            engine.Run();
        }
    }
}