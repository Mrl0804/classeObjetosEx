using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classeObjetos
{
    public class Veiculo
    {
        private double _velocidade;

        public double Velocidade
        {
            get { return _velocidade; }
            set
            {
                // Valida se o valor atribuído está entre 0 e 200 km/h
                if (value >= 0 && value <= 200)
                {
                    _velocidade = value;
                }
                else
                {
                    Console.WriteLine($"Tentativa de atribuir {value} km/h é inválida! A velocidade mantém-se em {_velocidade} km/h.");
                }
            }
        }
    }
}