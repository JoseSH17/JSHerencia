using System;

namespace JSHerencia
{
    public class ClsCuadrado : ClsRectangulo
    {
        private double lado;      

        public override void Imprimir()
        {
            Console.WriteLine(string.Concat("Esta forma es un ", GetNombre(), " su color es ", GetColor(),
                " y su lado mide ", GetLado()));
        }
       
        public void SetLado(double lado)
        {
            this.lado = lado;
        }       
        public double GetLado() => lado;
        public new double CalcularArea() => lado * lado;
        public new double CalcularPerimetro() => lado * 4;
        public new void CambiarTamaño(double escala)
        {
            SetLado(lado * escala);
        }
    }
}
