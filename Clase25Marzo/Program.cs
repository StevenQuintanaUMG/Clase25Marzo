
void Adivina()
{
    const int oportunidades = 4;
    int numcpu, numhumano;
    byte intentos, BanderaDeControl;
    //String linea;

    Random rand = new Random();

    numcpu = Convert.ToInt32(rand.Next(1, 20));

    //Proceso

    intentos = 1;
    BanderaDeControl = 0;

    do
    {
        Console.WriteLine("\nHola estoy pensando en un numero, cual crees que es? ");
        Console.Write("\n> ");
        numhumano = Convert.ToInt32(Console.ReadLine());

        if ((numhumano == numcpu))
        {
            Console.WriteLine("\nYes!, adivinaste");
            BanderaDeControl = 1;
        }
        else
        {
            if (numhumano > numcpu)
            {
                Console.WriteLine("\nTe pasaste");
            }
            else
            {
                Console.WriteLine("\nTe falto");
            }
        }
        intentos++;

    } while (((intentos <= oportunidades) & (BanderaDeControl == 0)));

    if (BanderaDeControl == 0)
    {
        Console.WriteLine("\nEl numero que pense era:" + numcpu + "\n");
    }
}

void buscarmayor()
{
    int mayor = 0;
    int menor = 100;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);

        Console.WriteLine("> " + numero);

        if (numero > mayor)
        {
            mayor = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("\nEl numero mayor es: " + mayor);
    Console.WriteLine("\nEl numero menor es: " + menor);

}

void arreglos()
{
    int[] notas = new int[10];
    double promedio = 0;
    int mayor = 0;

    Random rand = new Random();
    Console.WriteLine("\nCargando Informacion");

    for (int i = 0; i < notas.Length; i++)
    {
        notas[i] = rand.Next(100);
        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }
    }

    Console.WriteLine("\nDesplegando Informacion\n");

    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }

    promedio = notas.Average();

    Console.WriteLine("\nEl numero mayor es: " + mayor);
    Console.WriteLine("\nEl promedio es: " + promedio);
}

void nombres()
{
    int ganador1 = 0;
    int ganador2 = 0;

    string[] nombre = new string[10];
    Random rand = new Random();

    ganador1 = rand.Next(0, nombre.Length);

    while (ganador2 == ganador1)
    {
        ganador2 = rand.Next(0, nombre.Length);
    }

    nombre[0] = "Jairo";
    nombre[1] = "Brandon";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";
    nombre[6] = "Astrid";
    nombre[7] = "Mynor";
    nombre[8] = "Angel";
    nombre[9] = "Yefri";

    for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + ": " + nombre[i]);
    }

    Console.WriteLine("\nEl ganador 1 es " + nombre[ganador1]);
    Console.WriteLine("\nEl ganador 2 es " + nombre[ganador2]);
}


Adivina();
buscarmayor();
arreglos();
nombres();
