using ShellXamarinForms.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShellXamarinForms.Data
{
    public static class ElefantesData
    {
        public static IList<Animal> Elefantes { get; private set; }
        static ElefantesData()
        {
            Elefantes = new List<Animal>();
        }
    }
}
