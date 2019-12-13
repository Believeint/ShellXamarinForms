using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Threading.Tasks;
using ShellXamarinForms.Model;
using ShellXamarinForms.Data;

namespace ShellXamarinForms.Control
{
    public class ManipuladorPesquisaPrimata : SearchHandler
    {
        protected override void OnQueryChanged(string valorAntigo, string valorNovo)
        {
            base.OnQueryChanged(valorAntigo, valorNovo);
            if(string.IsNullOrWhiteSpace(valorNovo))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = PrimatasData.Primatas
                    .Where(primata => primata.Nome.ToLower().Contains(valorNovo.ToLower()))
                    .ToList<Animal>();
            }
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
            await Task.Delay(1000);

            // Nota: as strings serão codificadas em URL para navegação(por exemplo, "Blue Monkey" se torna "Blue% 20Monkey"). Portanto, decodifique no receptor.
            // Isso funciona porque os nomes das rotas são exclusivos neste aplicativo.
            await Shell.Current.GoToAsync($"detalhesprimata?nome={((Animal)item).Nome}");
            // A rota completa é mostrada abaixo
            // await Shell.Current.GotToAsync($"//animais/primatas/detalhesprimatas?nome={((Animal)item).Nome}");
        }
    }
}
