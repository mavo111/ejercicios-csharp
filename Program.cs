﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        {
            Console.WriteLine("\n=== MENÚ DE EJERCICIOS ===");
            Console.WriteLine("1. Elevar al cuadrado si es positivo");
            Console.WriteLine("2. Calcular el doble o el triple");
            Console.WriteLine("3. Raíz o cuadrado");
            Console.WriteLine("4. Perímetro del círculo");
            Console.WriteLine("5. Día de la semana");
            Console.WriteLine("6. Rango de números");
            Console.WriteLine("7. Calcular factorial");
            Console.WriteLine("8. Contar números positivos");
            Console.WriteLine("9. Suma de números hasta N");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("11. Promedio de notas");
            Console.WriteLine("12. Números pares hasta N");
            Console.WriteLine("13. Serie de Fibonacci");
            Console.WriteLine("14. Invertir un número");
            Console.WriteLine("15. Validar número dentro de rango");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");

            try
            {
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Ejercicio1(); break;
                    case 2: Ejercicio2(); break;
                    case 3: Ejercicio3(); break;
                    case 4: Ejercicio4(); break;
                    case 5: Ejercicio5(); break;
                    case 6: Ejercicio6(); break;
                    case 7: Ejercicio7(); break;
                    case 8: Ejercicio8(); break;
                    case 9: Ejercicio9(); break;
                    case 10: Ejercicio10(); break;
                    case 11: Ejercicio11(); break;
                    case 12: Ejercicio12(); break;
                    case 13: Ejercicio13(); break;
                    case 14: Ejercicio14(); break;
                    case 15: Ejercicio15(); break;
                    case 0: Console.WriteLine("Saliendo..."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Por favor ingrese un número válido.");
            }

        } while (opcion != 0);
    }

    static void Ejercicio1()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0) Console.WriteLine($"El cuadrado es {n * n}");
        else Console.WriteLine("El número no es positivo");
    }

    static void Ejercicio2()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0) Console.WriteLine($"El doble es {n * 2}");
        else Console.WriteLine($"El triple es {n * 3}");
    }

    static void Ejercicio3()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 0) Console.WriteLine($"La raíz cuadrada es {Math.Sqrt(n)}");
        else Console.WriteLine($"El cuadrado es {n * n}");
    }

    static void Ejercicio4()
    {
        Console.Write("Ingrese el radio del círculo: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine($"El perímetro es {2 * Math.PI * r}");
    }

    static void Ejercicio5()
    {
        Console.Write("Ingrese un número de 1 a 7: ");
        int d = int.Parse(Console.ReadLine());
        string[] dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        if (d >= 1 && d <= 7) Console.WriteLine($"El día es {dias[d - 1]}");
        else Console.WriteLine("Número inválido");
    }

    static void Ejercicio6()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= 100) Console.WriteLine("El número está en el rango [1,100]");
        else Console.WriteLine("Número fuera de rango");
    }

    static void Ejercicio7()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
        Console.WriteLine($"El factorial es {fact}");
    }

    static void Ejercicio8()
    {
        int count = 0, n;
        Console.WriteLine("Ingrese números (0 para terminar):");
        do
        {
            n = int.Parse(Console.ReadLine());
            if (n > 0) count++;
        } while (n != 0);
        Console.WriteLine($"Cantidad de positivos: {count}");
    }

    static void Ejercicio9()
    {
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        int suma = 0;
        for (int i = 1; i <= N; i++) suma += i;
        Console.WriteLine($"La suma de 1 hasta {N} es {suma}");
    }

    static void Ejercicio10()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }

    static void Ejercicio11()
    {
        Console.Write("Ingrese cantidad de notas: ");
        int c = int.Parse(Console.ReadLine());
        double suma = 0;
        for (int i = 1; i <= c; i++)
        {
            Console.Write($"Nota {i}: ");
            suma += double.Parse(Console.ReadLine());
        }
        Console.WriteLine($"El promedio es {suma / c}");
    }

    static void Ejercicio12()
    {
        Console.Write("Ingrese un número N: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 2; i <= N; i += 2)
            Console.Write($"{i} ");
        Console.WriteLine();
    }

    static void Ejercicio13()
    {
        Console.Write("Ingrese cantidad de términos: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.Write("Serie: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{a} ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();
    }

    static void Ejercicio14()
    {
        Console.Write("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());
        int invertido = 0;
        while (n > 0)
        {
            invertido = invertido * 10 + n % 10;
            n /= 10;
        }
        Console.WriteLine($"Número invertido: {invertido}");
    }

    static void Ejercicio15()
    {
        Console.Write("Ingrese un número entre 10 y 50: ");
        int n = int.Parse(Console.ReadLine());
        if (n >= 10 && n <= 50) Console.WriteLine("Número válido");
        else Console.WriteLine("Número fuera del rango");
    }
}
