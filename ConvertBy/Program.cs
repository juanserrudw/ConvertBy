



using ConvertBy;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string e1 = "\u263A";
string e2 = "\ud801";
string sal =  string.Empty;
Console.WriteLine($" ConvertBy{e1}\n " +
    $" Convierta numeros decimales a binarios");

do
{
    Console.WriteLine($"Seleciona{e2}");
    Console.WriteLine($"1) Convertir de decimal a binario{e2}. \n2) Convertir de  binario a decimal{e2}.");
    int eVal = MethBy.entradaValidacion(1, 2);
    

    switch (eVal)
    {
        case 1:
            Console.WriteLine($"Ingrese un numero decimal{e2}.");
            var num = MethBy.entradaValidacion(1, Int32.MaxValue);
            MethBy.numeroBinario(num);
            break;

        case 2:
            Console.WriteLine($"Ingrese un numero en binario{e2}.");
            ValorBinario binaryI = new ValorBinario();
            var binario = MethBy.validarCadenaBy(ref binaryI);
            MethBy.numBinario(binario, ref binaryI);
            break;


    }

    Console.WriteLine("\nOperacion concluida \n  Escribe 's'  para salir");
    sal = Console.ReadLine();
} while (!sal.Contains("s") && !sal.Contains("s"));

