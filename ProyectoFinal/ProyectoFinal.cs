using System;

namespace ProyectoFinal
{
    public class CalculadoraPrestamos1
    {
        public float Monto,Tasa_Anual;
        public int Plazo;

        public float monto
        {
            get{return Monto;}
            set{Monto = value;}
        }

        public float tasa_anual
        {
            get{return Tasa_Anual;}
            set{Tasa_Anual = value;}
        }

        public int plazo
        {
            get{return Plazo;}
            set{Plazo = value;}
        }

        public void cal()
        {
            float Cuota, Interes, Amortizacion, tasa_mensual=0;
            int Anual,i;

            tasa_mensual = (Tasa_Anual / 100) / 12;

            Cuota = tasa_mensual + 1;
            Cuota = (float)Math.Pow(Cuota, Plazo);
            Cuota = Cuota - 1;
            Cuota = tasa_mensual / Cuota;
            Cuota = tasa_mensual + Cuota;
            Cuota = Monto * Cuota;

            Cuota = tasa_mensual + 1;
            Cuota = (float)Math.Pow(Cuota, Plazo);
            Cuota = Cuota - 1;
            Cuota = tasa_mensual / Cuota;
            Cuota = tasa_mensual + Cuota;
            Cuota = Monto * Cuota;
            Console.WriteLine();
            Anual = 1;
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\tAño \t");
            Console.Write("\tCuota \t");
            Console.Write("\tIntereses \t");
            Console.Write("\tAmortizacion \t");
            Console.Write("\tCapital vivo \t");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t{0}", Monto);
            for (i = 1; i <= Plazo; i++)
            {
                Console.Write("\t{0}\t\t", Anual);
                Console.Write("{0}\t",Cuota);
                Interes = tasa_mensual * Monto;
                Console.Write("{0}\t",Interes);
                Amortizacion = Cuota - Interes;
                Console.Write("\t{0}\t",Amortizacion);
                Monto = Monto - Amortizacion;
                Console.Write("\t{0}\t",Monto);
                Anual = Anual + 1;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class Calculador
    {
        static void Main(string[] args)
        {
            CalculadoraPrestamos1 obj = new CalculadoraPrestamos1();
            Console.Write("Introduzca el Monto: ");
            obj.Monto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca la Tasa de interes anual: ");
            obj.Tasa_Anual = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduzca el Plazo: ");
            obj.Plazo = Convert.ToInt32(Console.ReadLine());
            obj.cal();
            
        }
    }    
    
}
