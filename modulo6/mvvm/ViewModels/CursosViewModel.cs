using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using mvvm.Models;

namespace mvvm.ViewModels
{
    public class CursosViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Curso> cursos;

        public ObservableCollection<Curso> Cursos
        {
            get { return cursos; }
            set { cursos = value;
                RaisePropertyChanged();
            }
        }

        public CursosViewModel()
        {
            Cursos = new ObservableCollection<Curso>();
            Cursos.Add(new Curso()
            {
                Nombre = ".NET esencial",
                Autor = "Rodrigo Díaz Concha"
            });
            Cursos.Add(new Curso()
            {
                Nombre = ".NET Core esencial",
                Autor = "Rodrigo Díaz Concha"
            });
            Cursos.Add(new Curso()
            {
                Nombre = "ASP.NET Core esencial",
                Autor = "Rodrigo Díaz Concha"
            });
            Cursos.Add(new Curso()
            {
                Nombre = "Entity Framework Core esencial",
                Autor = "Rodrigo Díaz Concha"
            });
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
