    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

        // Sans cette ligne, GoToAsync lève une exception "route inconnue"
        Routing.RegisterRoute(nameof(ResultatPage), typeof(ResultatPage));
    }
}
