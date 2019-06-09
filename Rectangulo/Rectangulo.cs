﻿using System;
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

        public string X1
        {
            get { return x1; }
            set
            {
                int numero;
                bool resultado = int.TryParse(value, out numero);
                bool distancia = int.TryParse(value, out numero);
                bool bas = int.TryParse(value, out numero);
                bool altura = int.TryParse(value, out numero);
                bool perimetro = int.TryParse(value, out numero);
                bool area = int.TryParse(value, out numero);
                if (resultado && distancia && bas && altura && perimetro && area) x1 = value;
                OnPropertyChanged("X1");
                OnPropertyChanged("Distancia");
                OnPropertyChanged("Base");
                OnPropertyChanged("Altura");
                OnPropertyChanged("Perimetro");
                OnPropertyChanged("Area");
            }
        }


    }
}
