
void arreglos()
{
    string[] nombre = new string[]
    {
        "Fernanda", "Melvin", "Luis", "Brandon", "Yamileth"
    };

    //foreach (string n in nombre)
    //{
    //    Console.WriteLine(n);
    //}

    int[] notas = new int[]
    {
        70, 90, 43, 85, 30
    };

    //int promedio = 0;
    //foreach (int i in notas) 
    //{
    //    promedio += i;
    //}
    //promedio = promedio/notas.Length;
    //Console.WriteLine($"El Promedio es: {promedio}");

    int nummayor = notas.Max();
    int indmayor = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > notas[indmayor])
        {
            indmayor = i;
        }
    }

    Console.WriteLine(nummayor + " " + nombre[indmayor]);

}

arreglos();
