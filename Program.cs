// See https://aka.ms/new-console-template for more information

using static System.Runtime.InteropServices.JavaScript.JSType;

int opcion = 0;
do
{
    
    Console.WriteLine("Escoja una opción:");
    Console.WriteLine(" 1. Determinar si el número ingresado por el usuario es positivo, negativo o cero.\n" +
                      " Esta funcionalidad debe implementarse con una función\n" +
                      " 2. Imprimir un mensaje según el día de la semana ingresado por el usuario.\n"+
                      "  Este proceso debe implementarse como un procedimiento\n" +
                      " 3. Calcular la suma de los 100 primeros numeros naturales.\n" +
                      "  Este calculo debe implementarse como una funcion\n" +
                      " 4. Imprimir todos los números desde el 1 hasta el número ingresado por el usuario.\n" +
                      "  Este proceso debe implementarse como un procedimiento\n" +
                      " 5. Calcular el area de un circulo utilizando el radio ingresado por el usuario.\n" +
                      "  Este calculo debe implementarse como una funcion\n" + 
                      " 6. Mostrar los elementos de un arreglo unidimensional predifinido.\n" +
                      "  Este proceso debe implementarse como un procedimiento\n" +
                      " 7. Mostrar nombres de personas almacenadas en una lista predefinida.\n" +
                      "  Este proceso debe implementarse como un procedimiento\n"+
                      " 8. Salir"
                      );

    opcion = Convert.ToInt32(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Programa1();
            break;
        case 2:
            Programa2();
            break;
        case 3:
            Programa3();
            break;            
        case 4:
            Programa4();
            break;
        case 5:
            Programa5();
            break;
        case 6:
            Programa6();
            break;
        case 7:
            Programa7();
            break;
        default:
            break;
    }


    

} while (opcion!=8);

void Programa1()
{
    double numero = 0;
    Console.WriteLine("=======================PROGRAMA 1===============================");
    Console.WriteLine($"Ingrese un número:");
    numero=Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(verificaNumero(numero));
    Console.WriteLine("========================FIN PROGRAMA 1================================");
}

string verificaNumero(double numero)
{
    if (numero > 0)
    {
        return "El número es mayor a cero.";
    }else if(numero < 0)
    {
        return "El número es menor a cero.";
    }
    else
    {
        return "El número es cero.";
    }           
}

void Programa2()
{
    int diasemana = 0;
    Console.WriteLine("=======================PROGRAMA 2===============================");
    Console.WriteLine($"Ingrese un día de la semana:");
    diasemana = Convert.ToInt32(Console.ReadLine());
    MostrarDiaSemana(diasemana);
    Console.WriteLine("========================FIN PROGRAMA 2================================");
}

void MostrarDiaSemana(int dia)
{
    string respta = "";
    switch (dia)
    {
        case 1:
            respta = "El dia es lunes";
            break;
        case 2:
            respta = "El dia es martes";
            break;
        case 3:
            respta = "El dia es miercoles";
            break;
        case 4:
            respta = "El dia es jueves";
            break;
        case 5:
            respta = "El dia es viernes";
            break;
        case 6:
            respta = "El dia es sabado";
            break;
        case 7:
            respta = "El dia es domingo";
            break;
        default:
            respta = "día incorrecto";
            break;
    }
    Console.WriteLine(respta);
}

void Programa3()
{
    double sumanumeros = 0;
    Console.WriteLine("=======================PROGRAMA 3===============================");    
    sumanumeros = SumaNumerosNaturales();
    Console.WriteLine($"Calculo de los 100 primeros numeros naturales: {sumanumeros}");
    Console.WriteLine("========================FIN PROGRAMA 3================================");
}

double SumaNumerosNaturales()
{
    double suma = 0;
    for (int i = 1; i <= 100; i++)
    {
        suma +=i;
    }
    return suma;
}

void Programa4()
{
    int numero = 0;
    Console.WriteLine("=======================PROGRAMA 4===============================");
    
    Console.WriteLine("ingrese un número: ");
    numero = Convert.ToInt32(Console.ReadLine());
    sumaNumeros(numero);    
    Console.WriteLine("========================FIN PROGRAMA 4================================");
}

void sumaNumeros(int numero)
{
    int suma = 0;

    for (int i = 1; i <= numero; i++)
    {
        suma +=i;
    }
    Console.WriteLine($"La suma de los primeros {numero} numeros es: {suma}");
}

void Programa5()
{
    double radio = 0;
    double area = 0;
    Console.WriteLine("=======================PROGRAMA 5===============================");

    Console.WriteLine("ingrese el radio del circulo: ");
    radio = Convert.ToDouble(Console.ReadLine());
    area= CalculaAreaCircunferencia(radio);
    Console.WriteLine($"El area de la circunferencia es: {area}");
    Console.WriteLine("========================FIN PROGRAMA 5================================");
}

double CalculaAreaCircunferencia(double radio)
{
    double valorpi = Math.PI;
    double area=valorpi*Math.Pow(radio,2);  
    return area;    
}

void Programa6()
{
    
    Console.WriteLine("=======================PROGRAMA 6===============================");

    Console.WriteLine("Mostrar arreglos:");
    MostrarArreay();
    Console.WriteLine("========================FIN PROGRAMA 6================================");
}

void MostrarArreay()
{
    string[] nombres= new string[5];

    nombres[0] = "Cindy";
    nombres[1] = "Angie";
    nombres[2] = "Jhon";
    nombres[3] = "Victor";
    nombres[4] = "Bruno";

    for(int i = 0; i < nombres.Length-1; i++)
    {
        Console.WriteLine($"Elemento {i}: {nombres[i]}" );
    }

}


void Programa7()
{

    Console.WriteLine("=======================PROGRAMA 7===============================");

    Console.WriteLine("Mostrar arreglos:");
    MostrarLista();
    Console.WriteLine("========================FIN PROGRAMA 7================================");
}

void MostrarLista()
{
    List<string> nombres = new List<string>();
    nombres.Add("Juan Aguilar");
    nombres.Add("Victor Bautista");
    nombres.Add("Cindy Caldas");
    nombres.Add("Carlos Arroyo");
    nombres.Add("Jhon Bautista");

    foreach (var item in nombres)
    {
        Console.WriteLine(item);
    }

}

//Console.ReadLine();
