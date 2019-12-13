using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using ShellXamarinForms.Model;
using ShellXamarinForms.Data;

namespace ShellXamarinForms.ViewModel
{
    [QueryProperty("NomePrimata", "nome")]
    public class PrimatasDetalhesViewModel : INotifyPropertyChanged
    {
        public string NomePrimata
        {
            set
            {
                Animal primata = PrimatasData.Primatas.FirstOrDefault(p => p.Nome == Uri.UnescapeDataString(value));

                if(primata != null)
                {
                    Nome = primata.Nome;
                    Localizacao = primata.Localizacao;
                    Detalhes = primata.Detalhes;
                    UrlImagem = primata.UrlImagem;
                    OnPropertyChanged("Nome");
                    OnPropertyChanged("Localizacao");
                    OnPropertyChanged("Detalhes");
                    OnPropertyChanged("UrlImagem");
                }
            }
        }

        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Detalhes { get; set; }
        public string UrlImagem { get; set; }

        #region "INotifyPropertyChanged"
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propNome = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propNome));
        }
        
        #endregion

    }
}
