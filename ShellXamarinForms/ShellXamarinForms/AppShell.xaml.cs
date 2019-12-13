using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Linq;
using ShellXamarinForms.View.Detalhes;
using ShellXamarinForms.Data;

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
            BindingContext = this;
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
                case "detalhesprimatas":
                    animalNome = PrimatasData.Primatas.ElementAt(rand.Next(0, PrimatasData.Primatas.Count)).Nome;
                    break;
                case "detalhesgatos":
                    animalNome = GatosData.Gatos.ElementAt(rand.Next(0, GatosData.Gatos.Count)).Nome;
                    break;
                case "detalhescaes":
                    animalNome = CaesData.Caes.ElementAt(rand.Next(0, CaesData.Caes.Count)).Nome;
                    break;
                case "detalheselefantes":
                    animalNome = ElefantesData.Elefantes.ElementAt(rand.Next(0, ElefantesData.Elefantes.Count)).Nome;
                    break;
                case "detalhesursos":
                    animalNome = UrsosData.Ursos.ElementAt(rand.Next(0, UrsosData.Ursos.Count)).Nome;
                    break;
            }

            ShellNavigationState estado = Shell.Current.CurrentState;
            await Shell.Current.GoToAsync($"{estado.Location}/{rotaDestino}?nome={animalNome}");
            Shell.Current.FlyoutIsPresented = false;

        }

        void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            // Cancelar Navegação anterior
            //if (e.Source == ShellNavigationSource.Pop)
            //{
            //    e.Cancel();
            //}
        }

        void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
        }
    }
}