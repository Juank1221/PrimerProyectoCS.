// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int edad1 = 25;
int estudiante = 150;
Console.WriteLine(edad1);
Console.WriteLine(estudiante);



double precio = 19.99;
double promedio = 8.75;

Console.WriteLine(precio);
Console.WriteLine(promedio);

string nombre = "Juan";
string mensaje = "hola";

Console.WriteLine(nombre);
Console.WriteLine(mensaje);


bool esActivo = true;
bool completada = false;

Console.WriteLine(esActivo);
Console.WriteLine(completada);


const double PI = 3.14159;
const int DIAS_SEMANA = 7;
const string EMPRESA = "TechAcademy";

int numeroEntero = 42;
double numeroDecimal = numeroEntero; //Automatica
Console.WriteLine(numeroDecimal); //42.0

double precio1 = 29.95;
int precioRedondeado = (int) precio1;//29
//Se pierden los decimales
Console.WriteLine(precioRedondeado);

string texto = "123";
int numero = Convert.ToInt32(texto);
string resultado = numero.ToString();

int edad = 15;
 
if(edad >= 18)
{
    Console.WriteLine("Puedes votar");
    Console.WriteLine("Eres mayor de edad");

}
else
{
    Console.WriteLine("Aún no puedes votar");
    Console.WriteLine("Eres menor de edad");

}



int nota = 70;

if (nota >= 90)
{
    Console.WriteLine("Excelente");
}
else if (nota >= 80)
{
    Console.WriteLine("Muy bueno");
}
else if (nota >= 70)
{
    Console.WriteLine("Bueno");
}
else
{
    Console.WriteLine("Necesitas Mejorar");
}





