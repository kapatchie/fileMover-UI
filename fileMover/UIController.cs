namespace ConsoleUI
{
    public sealed class UIController
    {
        private static readonly UIController instance = new UIController();

        static UIController()
        {
        }
        private UIController()
        {
        }
        public static UIController Instance
        {
            get
            { return instance; }
        }
        public string text { get; set; }
    }
}

