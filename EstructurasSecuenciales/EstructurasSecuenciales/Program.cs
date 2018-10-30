using System;

namespace EstructurasSecuenciales
{
    class Program
    {
        static void Main(string[] args)
        {
            banco(2000);
            comisiones(100, 150, 280, 930);
            descuento(1500);
            calificacion(12, 14, 15.5, 13.5, 18.3);
            estudiantes(20, 13);
            edad(1995);
            tipoCambio(3000, 3.35);
            valorAbsoluto(-30);
            calcularMasa(300, 150, 80);
            pulsaciones(23);
            salario(3000);
            hospital(1500000);
            tienda(230);
            semanaCorre(30, 40, 50);
            fundaEmpresa(15000, 23450, 8973);
            promedio(matematicas(17.5, 13, 14, 15), fisica(14.3, 15.6, 13.9), quimica(19, 15.4, 13.3, 20));
            persona(23, 9);
            apellido("Quispe");
            conversorPiesMetros(35);
        }

        static void banco(int ahorro)//Ejercicio 1
        {
            double interesMensual = ahorro * 0.02;
            Console.WriteLine($"El dinero que ganara el primer mes es : {interesMensual}");
        }

        static void comisiones(int v1, int v2, int v3, int sueldo)//Ejercicio 2
        {
            double comMes = (v1 * 0.1) + (v2 * 0.1) + (v3 * 0.1);
            double sueldoTotal = sueldo + comMes;
            Console.WriteLine($"Ud, recibira {comMes} por comisiones");
            Console.WriteLine($"Ud, recibira {sueldoTotal} este mes");
        }

        static void descuento(int precio)//Ejercicio 3
        {
            double dscto = precio * 0.15;
            Console.WriteLine($"Usted pagará {precio-dscto} por el producto");
        }

        static void calificacion(double p1, double p2, double p3, double ef, double tf)//Ejercicio 4
        {
            double parciales = (((p1 + p2 + p3) / 3) * 0.55);
            double examen = ef * 0.3;
            double trabajo = tf * 0.15;
            Console.WriteLine($"Su calificación final es: {parciales + examen + trabajo}");
        }

        static void estudiantes(int hombres, int mujeres)//Ejercicio 5
        {
            int total = hombres + mujeres;//24+1=25
            double porcentajeHombres = (hombres * 100) / total;
            double porcentajeMujeres = (mujeres * 100) / total;
            Console.WriteLine($"El porcentaje de hombres es: {porcentajeHombres} y el de mujeres es: {porcentajeMujeres}");
        }

        static void edad(int año)//Ejercicio 6
        {
            int e = 2018 - año;
            Console.WriteLine($"Usted tiene {e} años");
        }

        static void tipoCambio(double soles, double cambio)//Ejercicio 7
        {
            double dolares = soles / cambio;
            Console.WriteLine($"El cambio es de {dolares} dolares");
        }

        static void valorAbsoluto(int numero)//Ejercicio 8
        {
            Console.WriteLine($"El valor absoluto es {Math.Abs(numero)}");
        }

        static void calcularMasa(int presion, int volumen, int temperatura)//Ejercicio 9
        {
            double masa = (presion * volumen) / (0.37 * (temperatura + 460));
            Console.WriteLine($"El resultado es {masa}");
        }

        static void pulsaciones(int edad)//Ejercicio 10
        {
            double numPulsaciones = (220 - edad) / 10;
            Console.WriteLine($"Las pulsaciones de la persona deben ser de {numPulsaciones}");
        }

        static void salario(int salario)//Ejercicio 11
        {
            Console.WriteLine("Su nuevo salario es " + salario * 1.25);
        }

        static void hospital(double presupuesto)//Ejercicio 12 y 13
        {
            double ginecologia = presupuesto * 0.4;
            double traumatologia = presupuesto * 0.3;
            double pediatria = presupuesto * 0.3;
            Console.WriteLine($"Ginecologia = {ginecologia}, Traumatologia = {traumatologia}, Pediatria = {pediatria}");
        }

        static void tienda(double precio)//Ejercicio 14
        {
            Console.WriteLine($"Nuevo precio : {precio * 1.3}");
        }

        static void semanaCorre(int t1, int t2, int t3)//Ejercicio 15 
        {
            double tiempoPromedio = (t1 + t2 + t3) / 3;
            Console.WriteLine($"El tiempo promedio es : {tiempoPromedio}");
            
        }

        static void fundaEmpresa(double c1, double c2, double c3)//Ejercicio 16
        {
            double capital = c1 + c2 + c3;
            double partC1 = c1 * 100 / capital;
            double partC2 = c2 * 100 / capital;
            double partC3 = c3 * 100 / capital;
            Console.WriteLine($"Participacion Persona 1 : {partC1}, Persona 2 : {partC2}, Persona 3 : {partC3}");
        }

        /*Ejercicio 17*/
        static double matematicas(double examen, double t1, double t2, double t3)
        {
            double pMat = (examen * 0.9) + ((t1 + t2 + t3) / 3) * 0.1;
            return pMat;
        }
        static double fisica(double examen, double t1, double t2)
        {
            double pFis = (examen * 0.8) + ((t1 + t2) / 2) * 0.2;
            return pFis;
        }
        static double quimica(double examen, double t1, double t2, double t3)
        {
            double pQui = (examen * 0.85) + ((t1 + t2 + t3) / 3) * 0.15;
            return pQui;
        }
        static void promedio(double mat, double fis, double qui)
        {
            double pGeneral = (mat + fis + qui) / 3;
            Console.WriteLine($"Promedio General : {pGeneral}");
            Console.WriteLine($"Promedio Matemática : {mat}");
            Console.WriteLine($"Promedio Física : {fis}");
            Console.WriteLine($"Promedio Química : {qui}");
        }

        static void persona(int años, int meses)//Ejercicio 18
        {
            Console.WriteLine($"La persona tiene : {(años * 12) + meses} meses");
        }

        static void apellido(string apellido)//Ejercicio 19
        {
            Console.WriteLine($"Profesor {apellido}");
        }

        static void conversorPiesMetros(double pie)//Ejercicio 20
        {
            Console.WriteLine($"Son {pie * 30.48} metros");
        }
    }
}
