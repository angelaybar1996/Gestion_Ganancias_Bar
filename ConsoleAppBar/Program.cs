using System;
using Entidades.Botella;
using Entidades.Establecimieto;

namespace ConsoleAppBar
{
    class Program
    {
        static void Main(string[] args)
        {
            Agua a1 = new Agua("Glaciar", 75, TipoAgua.Mineral);
            Agua a2 = new Agua("Glaciar", 75, 500, TipoAgua.Mineral);
            Agua a3 = new Agua("Glaciar", 75, 750, TipoAgua.Mineral);
            Agua a4 = new Agua("Villa del sur", 90, TipoAgua.ConGas);
            Agua a5 = new Agua("Villa Vicencio", 200, 500, TipoAgua.SinGas);

            Cerveza c1 = new Cerveza("Quilmes", 175, 910, TipoCerveza.Rubia);
            Cerveza c2 = new Cerveza("Schneider", 250, 710, TipoCerveza.Lager, 710);
            Cerveza c3 = new Cerveza("Quilmes", 175, 910, TipoCerveza.Negra);
            Cerveza c4 = new Cerveza("Villa Vicencio", 200, 500, TipoCerveza.Lager, 500);

            if( ! (a5 == c4))
            {
                Console.WriteLine("Son distintos");
            }

            if ( ! a5.Equals(c4))
            {
                Console.WriteLine("Son distintos");
            }

            Bar b = new Bar(8, "Lo de Carlo");

            Console.WriteLine(b.MostrarBar);

            b += a1;
            b += a2; // repetida.
            b += a3;
            b += a4;
            b += a5;

            b += c1;
            b += c2;
            b += c3;
            b += c4;

            Console.WriteLine(b.MostrarBar);

            b -= a1;
            b -= a2;//No esta
            b -= a3;
            b -= a4;
            b -= a5;

            Console.WriteLine(b.MostrarBar);

            b -= c1;
            b -= c1;
            b -= c1;
            b -= c1;//no hay más
 
            b -= c2;
            b -= c3;
            b -= c4;

            Console.WriteLine(b.MostrarBar);

            b.OrdenarBotellas(Ordenamiento.Marca);
            Console.WriteLine(b.MostrarBar);

            b.OrdenarBotellas(Ordenamiento.Ganancia);
            Console.WriteLine(b.MostrarBar);

            b.OrdenarBotellas(Ordenamiento.PorcentajeContenido);
            Console.WriteLine(b.MostrarBar);


            Console.ReadLine();


        }
    }
}
