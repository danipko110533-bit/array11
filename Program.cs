//funcion de imprimir 
static void ImprimirNotas(int[] notas)
{
    for(int i =0; i<notas.Length;i++)
    {
        Console.WriteLine(notas[i]);
    }
}


int[] notas = { 15,18,12,17,20};

//imprimir las notas

ImprimirNotas(notas);