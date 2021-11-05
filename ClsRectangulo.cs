using System;

namespace JSHerencia
{
    public class ClsRectangulo : ClsForma
    {
        private double ladoMayor = 0.0;
        private double ladoMenor = 0.0;        

        public override void Imprimir()
        {
            Console.WriteLine(string.Concat("Esta forma es un ", GetNombre(), " su color es ", GetColor(),
                " y sus lados son lado mayor que mide ", GetLadoMayor(), " y lado menor que mide ", GetLadoMenor()));
        }       
        public void SetLadoMayor(double ladoMayor)
        {
            this.ladoMayor = ladoMayor;
        }
        public void SetLadoMenor(double ladoMenor)
        {
            this.ladoMenor = ladoMenor;
        }
        public double GetLadoMayor() => ladoMayor;
        public double GetLadoMenor() => ladoMenor;
        public double CalcularArea() => ladoMenor * ladoMayor;
        public double CalcularPerimetro() => ladoMenor * 2 + ladoMayor * 2;
        public void CambiarTamaño(double escala)
        {
            SetLadoMayor(ladoMayor * escala);
            SetLadoMenor(ladoMenor * escala);
        }
    }
}
