using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ShellXamarinForms.Model;
using System.Linq;
using Xamarin.Forms;

namespace ShellXamarinForms.Control
{
    public class ManipuladorPesquisaAnimal : SearchHandler
    {
        public IList<Animal> Animais { get; set; }
        public Type ItemSelecionadoNavegacao { get; set; }

        protected override void OnQueryChanged(string valorAntigo, string valorNovo)
        {
            base.OnQueryChanged(valorAntigo, valorNovo);
            if(string.IsNullOrWhiteSpace(valorNovo))
            {
                ItemsSource = null;
            } else
            {
                ItemsSource = Animais
                     .Where(animais => animais.Nome.ToLower().Contains(valorNovo.ToLower()))
                     .ToList();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

           // Nota: as strings serão codificadas em URL para navegação(por exemplo, "Blue Monkey" se torna "Blue% 20Monkey"). Portanto, decodifique no receptor.
           // Isso funciona porque os nomes das rotas são exclusivos neste aplicativo.

           ShellNavigationState estado = (App.Current.MainPage as Shell).CurrentState;
            await Shell.Current.GoToAsync($"{GetAlvoNavegacao()}?nome={((Animal)item).Nome}");
        }

        string GetAlvoNavegacao()
        {
            string = "";
        }
    }
}
