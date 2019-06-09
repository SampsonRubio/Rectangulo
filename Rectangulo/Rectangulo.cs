using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Rectangulo
{
    class Rectangulo : INotifyPropertyChanged
    {
        private string x1;
        private string x2;
        private string y1;
        private string y2;
        private string distancia;
        private string bas;
        private string altura;
        private string perimetro;
        private string area;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
      


    }
}
