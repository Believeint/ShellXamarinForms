using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Linq;
using System.Collections.ObjectModel;
using ShellXamarinForms.Model;
using ShellXamarinForms.Data;

namespace ShellXamarinForms.ViewModel
{
    public class UrsosViewModel
    {
        public ObservableCollection<Animal> ResultadosBusca { get; private set; }
        public ICommand SearchCommand => new Command<string>(ItemsBusca);

        void ItemsBusca(string query)
        {
            if(string.IsNullOrWhiteSpace(query))
            {
                ResultadosBusca = null;
            }
            else
            {
                var itemsFiltrados = UrsosData.Ursos
                    .Where(urso => urso.Nome.ToLower().Contains(query.ToLower()))
                    .ToList();
                ResultadosBusca = new ObservableCollection<Animal>(itemsFiltrados);
            }
        }

    }
}
