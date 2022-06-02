//1) Pida 10 números al usuario.
Console.WriteLine("Por favor ingrese 10 numeros:");
int[] num = new int[10];
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Numero {i+1}=");
    num[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("-------------------");
//2) Obtener la suma de todos los números ingresados.
int suma = 0;
for (int i = 0; i < num.Length; i++)
{
    suma += num[i];
    
}
Console.WriteLine($"La suma de todo los numeros es :{suma}");
Console.WriteLine("----------------------");

//3) Obtener cual es el mayor de todos los números.
int mayor = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > mayor)
    {
        mayor = num[i];
    }
}
Console.WriteLine($"El numero mayor de todos es el numero:{mayor}");
Console.WriteLine("------------------------");

//4) Obtener cual es el menor de todos los números.
int menor = num[0];
for (int i = 0; i < num.Length; i++)
{
    
    if (num[i] < menor)
    {
        menor = num[i];
    }
}
Console.WriteLine($"El numero menor de todos es:{menor}");
Console.WriteLine("--------------------------");

//5) Obtener el promedio de todos los números.
Console.WriteLine($"El promedio de todo los numeros es:{suma/num.Length}");
Console.WriteLine("---------------------------");

//6) Mostrar todos los números ingresados por pantalla.
Console.WriteLine("Los numeros ingresados son:");
for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine(num[i]);
}
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5.
Console.WriteLine("Los valores calculados son :");
Console.WriteLine($"Suma = {suma}");
Console.WriteLine($"Mayor = {mayor}");
Console.WriteLine($"Menor = {menor}");
Console.WriteLine($"Promedio = {suma/num.Length}");
