namespace Proyecto03;


// Ejercicio 1: 

// Crear la clase Persona con diferentes constructores, para ello tendremos en cuenta las siguientes opciones: 

// Inicializar una clase Persona con atributos nombre, edad y dni.
// Crear un constructor sin parámetros que inicialice con valores por defecto.
// Inicializar la clase Persona con solo el nombre.
// Crear un constructor que reciba todos los atributos.
// Crear un método mostrarDatos() que imprima los atributos.

// Definir la edad como privado y crear un método de acceso (get) y un método para modificar su valor (set).


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        // ejercicio 1
        Persona Persona01 = new Persona();
        Persona01.mostrarDatos();

        // ejercicio 2 
        Calculadora Calc01 = new Calculadora();
        Console.WriteLine("--------- Clase CALCULADORA --------");
        int x = 0;
        do
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese el numero de opción para el cálculo deseado o 0 para salir");
            Console.WriteLine("1 - Sumar dos numeros enteros");
            Console.WriteLine("2 - Sumar tres numeros reales");
            Console.WriteLine("3 - Dejar un mensaje y sumar dos numeros enteros");
            Console.WriteLine("4 - Saber si un numero entero es par o impar");

            x = int.Parse(Console.ReadLine());
            

            switch (x)
            {
                case 1:
                Console.WriteLine("Ingrese el primer numero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("El resultado de la suma es : "+Calc01.SumarDos(a,b));
                break;

                case 2:
                Console.WriteLine("Ingrese el primer numero real");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero real");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer numero real");
                double e = double.Parse(Console.ReadLine());

                Console.WriteLine("El resultado de la suma es : "+Calc01.SumarTres(c,d,e));
                break;

                case 3:
                Console.WriteLine("Ingrese el mensaje a mostrar");
                string f = Console.ReadLine();
                Console.WriteLine("Ingrese el primer numero");
                int g = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero");
                int h = int.Parse(Console.ReadLine());

                Console.WriteLine("El resultado de la suma es : "+Calc01.MensajeSumarDos(f,g,h));
                break;

                case 4:
                Console.WriteLine("Ingrese el numero entero");
                int j = int.Parse(Console.ReadLine());

                Calc01.QueEs(j);
                break;
         
            }

        }
        while (x!= 0);
        
        


    }
}

class Persona
{
    public string nombre ;
    public int edad ;
    private int dni ;

    public Persona()
    {
        nombre = "Alguien";
        edad = 1;
        dni = 12345678;
    }

    public Persona(string nombre)
    {
        this.nombre = nombre;

    }

    public Persona(string nombre, int edad, int dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;

    }

    public void setDni(int dniNuevo)
        {
            this.dni = dniNuevo;
        }

        public int getDni()
        {
            return this.dni;
        }

    public void mostrarDatos()
    {
        Console.WriteLine("El nombre es : "+this.nombre);
        Console.WriteLine("La edad es : "+this.edad);
        Console.WriteLine("El DNI es : "+this.dni);
        setDni(22222222);
        Console.WriteLine("Pero ahora el DNI cambio a..."+getDni());

    }

}

// Ejercicio 2: 

// Crear una clase Calculadora.

// Crear un método sumar(int a, int b) que devuelva una suma.
// Crear un método sumar(double a, double b, double c) para sumar tres números.
// Crear un método sumar(string mensaje, int a, int b) que imprima el mensaje por consola y luego la suma.
// Crear un método que devuelva true si un número es par o false si es impar bool esPar(int a).
// Saludos! Buen martes.

class Calculadora
{

    public int SumarDos(int a, int b)
    {
        int x;
        x = a+b;
        return x;
    }

    // No devuelve con coma, no se porque .
    public double SumarTres(double a, double b, double c)
    {
        double x;
        x = a+b+c;
        return x;

    }

    public int MensajeSumarDos(string mensaje, int a, int b)
    {
        Console.WriteLine("Este es tu mensaje... "+mensaje);
        int x;
        x = a+b;
        return x;

    }

    public void QueEs(int a)
    {

        if (a % 2 == 0)
        {
            Console.WriteLine("El numero ingresado es par.");
        }
        else
        {
            Console.WriteLine("El numero ingresado es impar.");
        }
    }
}
