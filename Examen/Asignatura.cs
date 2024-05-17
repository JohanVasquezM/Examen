﻿using Examen;

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string NombreAsignatura { get; set; }
        public string Horario { get; set; }
        public string NombreDocente { get; set; }

        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double CalcularNotaFinal(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if (notaFinal >= 90)
                return "Sobresaliente";
            else if (notaFinal >= 80)
                return "Muy Bueno";
            else if (notaFinal >= 60)
                return "Bueno";
            else
                return "Reprobado";
        }

        public void Imprimir()
        {
            double notaFinal = CalcularNotaFinal();
            double notaFinalConParametros = CalcularNotaFinal(N1, N2, N3);
            string mensajeFinal = MensajeNotaFinal(notaFinal);

            Console.WriteLine("******************************************");
            Console.WriteLine($"Nombre del estudiante: {NombreAlumno}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario: {Horario}");
            Console.WriteLine($"Nombre del docente: {NombreDocente}");
            Console.WriteLine($"Nota final: {notaFinal}% - {mensajeFinal}");
            Console.WriteLine($"Nota final: {notaFinalConParametros}% - {mensajeFinal}");
            Console.WriteLine("******************************************");
        }
    }

}
