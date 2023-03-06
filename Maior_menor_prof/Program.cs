internal class Program
{
    private static void Main(string[] args)
    {
        float[] numeros = new float[15];
        float maior, menor;
        int contador = 0; 

        do
        {
            Console.Write($" Informe o {contador + 1 }° numero ");  
            numeros[contador] = float.Parse(Console.ReadLine());
            contador++;

        } while (contador < 15);

        contador = 0;


        maior = numeros[0]; 
        menor = numeros[0];

        for( contador = 1;  contador < 15; contador++ )
        {
            if (maior < numeros[contador])
                maior = numeros[contador];
        }

        for (contador = 1; contador < 15; contador++)
        {
            if (menor > numeros[contador])
                menor = numeros[contador];
        }

        Console.WriteLine( " O maior valor é: " + maior);
        Console.WriteLine( " O menor valor é: " + menor);
    }
}