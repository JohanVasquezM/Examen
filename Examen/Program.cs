using Examen;


        Asignatura asignatura = new Asignatura();

        try
        {
            Console.Write("Ingrese nombre del alumno: ");
            asignatura.NombreAlumno = Console.ReadLine();

            Console.Write("Ingrese número de cuenta: ");
            asignatura.NumeroCuenta = Console.ReadLine();

            Console.Write("Ingrese correo electrónico: ");
            asignatura.Email = Console.ReadLine();

            Console.Write("Ingrese nombre de la clase: ");
            asignatura.NombreAsignatura = Console.ReadLine();

            Console.Write("Ingrese horario de la clase: ");
            asignatura.Horario = Console.ReadLine();

            Console.Write("Ingrese nombre del docente: ");
            asignatura.NombreDocente = Console.ReadLine();

            Console.Write("Ingrese nota del primer parcial: ");
            asignatura.N1 = int.Parse(Console.ReadLine());
            if (asignatura.N1 > 30)
                throw new ArgumentOutOfRangeException("La nota del primer parcial no puede exceder el 30%.");

            Console.Write("Ingrese nota del segundo parcial: ");
            asignatura.N2 = int.Parse(Console.ReadLine());
            if (asignatura.N2 > 30)
                throw new ArgumentOutOfRangeException("La nota del segundo parcial no puede exceder el 30%.");

            Console.Write("Ingrese nota del tercer parcial: ");
            asignatura.N3 = int.Parse(Console.ReadLine());
            if (asignatura.N3 > 40)
                throw new ArgumentOutOfRangeException("La nota del tercer parcial no puede exceder el 40%.");

            asignatura.Imprimir();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: Ingrese un número entero válido.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    
