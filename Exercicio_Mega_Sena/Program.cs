
const int MAX = 10;
float[] numeros = new float[MAX];
int i, j = (MAX - 1), maior = 0, op = 0;
float aux = 0;
float[] numeros_ordenados = new float[MAX];
float[] numeros_sem_repetir = new float[MAX];

// Criando Números ...

for (i = 0; i < MAX; i++)
{
    numeros[i] = new Random().Next(1, 60);
    numeros_ordenados[i] = numeros[i];
}

// Ordenando ...

do
{
    for (i = 0; i < j; i++)
    {
        if (numeros_ordenados[i] > numeros_ordenados[i + 1])
        {
            aux = numeros_ordenados[i + 1];
            numeros_ordenados[i + 1] = numeros_ordenados[i];
            numeros_ordenados[i] = aux;
        }
    }
    j--;
} while (j >= 0);

////REMOVENDO REPETIÇÕES...

j = 0;

for (i = 1; i < MAX; i++)
{
    if ((numeros_ordenados[i] != numeros_ordenados[i - 1]))
    {
        numeros_sem_repetir[j] = numeros_ordenados[i - 1];
        j++;
    }
    if (i == MAX - 1)
    {
        numeros_sem_repetir[j] = numeros_ordenados[i];
    }
}
Console.Write("\nOs números da Mega são: ");
for (i = 0; i < 6; i++)
{
    Console.Write($"{numeros_sem_repetir[i]}  ");
}
Console.WriteLine();