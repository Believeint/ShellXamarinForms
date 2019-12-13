using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Linq;
using ShellXamarinForms.View.Detalhes;

namespace ShellXamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppShell : Shell
    {
        Random rand = new Random();
        Dictionary<string, Type> rotas = new Dictionary<string, Type>();
        public Dictionary<string, Type> Rotas { get { return rotas; } }

        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand RandomPageCommand => new Command(async () => await NavegarPaginaAleatoriaAsync());
        public AppShell()
        {
            InitializeComponent();
            RegistrarRotas();
        }

        void RegistrarRotas()
        {
            rotas.Add("detalhesprimatas", typeof(DetalhesPrimatas));
            rotas.Add("detalhesursos", typeof(DetalhesUrsos));
            rotas.Add("detalhesgatos", typeof(DetalhesGatos));
            rotas.Add("detalhescaes", typeof(DetalhesCaes));
            rotas.Add("detalheselefantes", typeof(DetalhesElefantes));

            foreach(var item in rotas)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }

        async Task NavegarPaginaAleatoriaAsync()
        {
            string rotaDestino = rotas.ElementAt(rand.Next(0, rotas.Count)).Key;
            string animalNome = null;

            switch(rotaDestino)
            {
                            }
        }
    }
}