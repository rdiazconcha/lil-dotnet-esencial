using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace enlacededatos
{
    public class Curso : INotifyPropertyChanged
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }
        }

        private string autor;

        public string Autor
        {
            get { return autor; }
            set {
                autor = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
