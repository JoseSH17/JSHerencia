using System;

namespace JSHerencia
{
    public class ClsElipse : ClsForma
    {
        private double radioMayor = 0.0;
        private double radioMenor = 0.0;      

        public override void Imprimir() =>       
            Console.WriteLine(string.Concat("Esta forma es un ", GetNombre(), " su color es ", GetColor(),
                " y sus Radios son Radio mayor que mide ", GetRadioMayor(), " y Radio menor que mide ", GetRadioMenor()));               
        public void SetRadioMayor(double radioMayor)
        {
            this.radioMayor = radioMayor;
        }
        public void SetRadioMenor(double radioMenor)
        {
            this.radioMenor = radioMenor;
        }
        public double GetRadioMayor() => radioMayor;
        public double GetRadioMenor() => radioMenor;

        public double CalcularArea() => Pi * (radioMenor * radioMayor);
        public double CalcularPerimetro() => 2 * Pi * Math.Sqrt((radioMayor*radioMayor + radioMenor*radioMenor)/2);       
    }
}
