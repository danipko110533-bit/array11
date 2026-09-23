//funcion de imprimir 
using System.Numerics;

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


//calcular promedio de las notas


int suma=0;
for(int i =0; i<notas.Length;i++)
{
    suma+=notas[i];
}
double promedio = (double)suma/notas.Length;

Console.WriteLine("el promedio es {0} " ,promedio);






//funcion
static void promedioNotas(int[] notas)
{
    int suma = 0;
    for(int i =0; i<notas.Length;i++)
    {
        suma+=notas[i];
    }
    
    double promedio =  (double)suma/notas.Length;
    
}

promedioNotas(notas);


//imprimir las notas mayor  y menor 
int mayor = notas[0];
int menor = notas[0];
for(int i =0; i<notas.Length;i++)
{
    if(notas[i]>mayor)
    {
        mayor = notas[i];
    }
    if(notas[i]<menor)
    {
        menor = notas[i];
    }


}
Console.WriteLine($"la notas mayor es: {mayor}");
Console.WriteLine($"la nota menor es : {menor}");

