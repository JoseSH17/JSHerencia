using System;

namespace JSHerencia
{
    public class ClsCirculo : ClsElipse
    {
        private double radio = 0.0;
        public override void Imprimir() =>
            Console.WriteLine(string.Concat("Esta forma es un ", GetNombre(), " su color es ", GetColor(),
                " y sus radio mide ", GetRadio()));
        public void SetRadio(double radio)
        {
            this.radio = radio;
        }
        public double GetRadio() => radio;
        public new double CalcularArea() => Pi * (radio * radio);
        public new double CalcularPerimetro() => 2 * Pi * radio;
    }
}
