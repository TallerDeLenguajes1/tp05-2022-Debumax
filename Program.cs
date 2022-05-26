bool resultado;
int numero;
int cont=0;
int num=0;
int resto=0;
int multiplicador=0;
int invertido=0;

Console.WriteLine("ingrese un valor");
var cadena= Console.ReadLine();

Console.WriteLine($"{Environment.NewLine}el valor es {cadena}!");


resultado= Int32.TryParse(cadena,out numero);
if(resultado){
    Console.WriteLine("se conviertio en un entero de 32");
}
else Console.WriteLine("no se pudo convertir en entero");
num=numero;
while (num>0)
{
    num=num/10;
    cont=cont+ 1;
    //cuento cuantas veces se dividio
}
num=numero;
int potencia=cont-1;
for (int i=0;i<cont;i++)
{
    resto=num%10;
    multiplicador=(int)(Math.Pow(10,potencia));
    invertido=invertido + resto*multiplicador;    
    potencia--;
    num=num/10;
    
}

Console.WriteLine($"valor de num {numero} valor invertido {invertido}");

/*Console.Write($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);*/