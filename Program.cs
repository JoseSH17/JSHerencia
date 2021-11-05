using System;

namespace JSHerencia
{
    class Program
    {
        private const string _Rectangulo = nameof(ClsRectangulo);
        private const string _Elipse = nameof(ClsElipse);
        private const string _Cuadrado = nameof(ClsCuadrado);
        private const string _Circulo = nameof(ClsCirculo);
        static void Main(string[] args)
        {

            #region Private variables
            string _AreaMayor = string.Empty;
            double _AreaActual = 0.0;
            #endregion
            
            //Pruebas Rectágulo
            Console.WriteLine("Prueba de Rectágulo");
            ClsRectangulo rect1 = new();
            rect1.SetLadoMayor(10);
            rect1.SetLadoMenor(5);
            rect1.SetColor("Rojo");
            rect1.SetNombre("Rectangulo");            

            rect1.Imprimir();
            Console.WriteLine("El área de esta forma es de {0}", rect1.CalcularArea());
            Console.WriteLine("El perímetro de esta forma es de {0} ", rect1.CalcularPerimetro());
            Console.WriteLine("\n");
            Console.WriteLine("Cambiando tamaño de forma en 0.5");
            rect1.CambiarTamaño(0.5);           
            rect1.Imprimir();
            Console.WriteLine("La nueva área de esta forma es de {0}", rect1.CalcularArea());
            Console.WriteLine("El nuevo perímetro de esta forma es de {0}", rect1.CalcularPerimetro());
            Console.ReadLine();

            //Prueba Elipse
            Console.Clear();
            Console.WriteLine("Prueba de Elipse");
            ClsElipse elip1 = new();
            elip1.SetRadioMayor(3);
            elip1.SetRadioMenor(2);
            elip1.SetColor("Verde");
            elip1.SetNombre("Elipse");

            elip1.Imprimir();
            Console.WriteLine("El área de esta forma es de {0}", elip1.CalcularArea());
            Console.WriteLine("El perímetro de esta forma es de {0}", elip1.CalcularPerimetro());
            Console.ReadLine();

            //Prueba de Cuadrado
            Console.Clear();
            Console.WriteLine("Prueba de Cuadrado");
            ClsCuadrado cuad1 = new();

            cuad1.SetLado(10);
            cuad1.SetColor("Azul");
            cuad1.SetNombre("Cuadrado");

            cuad1.Imprimir();
            Console.WriteLine("El área de esta forma es de {0}", cuad1.CalcularArea());
            Console.WriteLine("El perímetro de esta forma es de {0} ", cuad1.CalcularPerimetro());
            Console.WriteLine("\n");
            Console.WriteLine("Cambiando tamaño de forma en 0.5");
            cuad1.CambiarTamaño(0.5);
            cuad1.Imprimir();
            Console.WriteLine("La nueva área de esta forma es de {0}", cuad1.CalcularArea());
            Console.WriteLine("El nuevo perímetro de esta forma es de {0}", cuad1.CalcularPerimetro());
            Console.ReadLine();

            //Prueba Círculo
            Console.Clear();
            Console.WriteLine("Prueba de Círculo");
            ClsCirculo circ1 = new();
            circ1.SetRadio(3);
            circ1.SetColor("Amarillo");
            circ1.SetNombre("Círculo");

            circ1.Imprimir();
            Console.WriteLine("El área de esta forma es de {0}", circ1.CalcularArea());
            Console.WriteLine("El perímetro de esta forma es de {0}", circ1.CalcularPerimetro());
            Console.ReadLine();


            //Array
            ClsForma[] formas = { rect1, elip1, circ1, cuad1 };            
            for (int i = 0; i < formas.Length; i++)
            {                
                //Definiendo color en común Negro
                formas[i].SetColor("Negro");
                //Revisando el tipo de forma antes de imprimir y calcular el área
                switch(formas[i].GetType().Name)
                {
                    case _Rectangulo:
                        var r = (ClsRectangulo)formas[i];
                        r.Imprimir();
                        CompararAreas(r.CalcularArea(), r); //Determina quién tiene el área mayor
                        Console.WriteLine("El área de esta forma es de {0}", r.CalcularArea());
                        break;
                    case _Elipse:
                        var e = (ClsElipse)formas[i];
                        e.Imprimir();
                        CompararAreas(e.CalcularArea(), e); //Determina quién tiene el área mayor
                        Console.WriteLine("El área de esta forma es de {0}", e.CalcularArea());
                        break;
                    case _Cuadrado:
                        var q = (ClsCuadrado)formas[i];
                        q.Imprimir();
                        CompararAreas(q.CalcularArea(), q); //Determina quién tiene el área mayor
                        Console.WriteLine("El área de esta forma es de {0}", q.CalcularArea());
                        break;
                    case _Circulo:
                        var c = (ClsCirculo)formas[i];
                        c.Imprimir();
                        CompararAreas(c.CalcularArea(), c); //Determina quién tiene el área mayor
                        Console.WriteLine("El área de esta forma es de {0}", c.CalcularArea());
                        break;
                    default:
                        Console.WriteLine("Forma no reconocida");
                        break;
                }
            }
            Console.WriteLine("\n" + _AreaMayor);

            void CompararAreas(double a, ClsForma f)
            {
                if (_AreaActual < a)
                {
                    _AreaActual = a;
                    _AreaMayor = "El área más grande es la del " + f.GetNombre() + " con un área de " + a;
                }
            }
        }
        
    }
}
