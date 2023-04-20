using System;



// Programa que suma dos numeros
int a = 0;
int b = 0;

Console.WriteLine("Ingrese el primer numero");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
b = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los numero es " + (a + b));

// int, double, float, bool, string, char

int a1 = 20;
double d1 = 20.00;
float f1 = 20.0f;
bool b1 = true;
string s1 = "Hola";
char c1 = 'c';


string cad1 = "20";
int conversion = int.Parse(cad1);

Console.WriteLine (conversion + 5);

//  + - * /
// +=

int h = 10;
h += 10;

Console.WriteLine( "Opeador += " +  h);

// -=

h -= 5;


Console.WriteLine("Opeador -= " + h);

// *=

h *= 2;

Console.WriteLine("Opeador *= " + h);

// /=

h /= 3;

Console.WriteLine("Opeador /= " + h);


if (b1 == true)
{

    Console.WriteLine("b1 contiene un valor verdadero");
}

if (b1 != true)
{

    Console.WriteLine("b1 contiene un valor falso");
}

string s11 = "Hola";
string s12 = "Mundo";
string s13 = s11 + s12; // Concatenacion de String

Console.WriteLine(s13);


int j = 8;
int k = 9;
bool p = j > k;
p = j == k;
p = j != k;

if (j > k) {
    Console.WriteLine("J es Mayor a K");
}

if (j  == k)
{
    Console.WriteLine("J igual K");
}

if (j != k  &&  j > k )
{
    Console.WriteLine("J es diferente de K 1");
}


if (j != k || j > k)
{
    Console.WriteLine("J es diferente de K 2");
}

// && y
// || O

// Ciclo es para repetir una rutina n cantidad de veces

int veces = 0;

Console.WriteLine("Cuantas veces quiere imprimir Hola Mundo en pantalla");
veces = int.Parse(Console.ReadLine());

for (int i = 0; i < veces; i++) {


    Console.WriteLine("Hola Mundo");

}



// Escriba un programa que reciba un numero del 1 al 7 y basado en el numero escrito
// va a retornar el nombre que representa según los dias de las semana
// 1 - Lunes
// 2 - Martes
// 3 - Miercoles

int dia = 0;
Console.WriteLine("Escriba el Numero del dia de la semana");
dia = int.Parse(Console.ReadLine());


if (dia == 1 )
{
    Console.WriteLine("Lunes");
}else
{

    if (dia == 2)
    {
        Console.WriteLine("Martes");
    }else
    {
        if (dia == 3)
        {
            Console.WriteLine("Miercoles");
        }else
        {
            if (dia == 4)
            {
                Console.WriteLine("Jueves");
            }else
            {
                if (dia == 5)
                {

                    Console.WriteLine("Viernes");
                    
                }else
                {
                    if (dia== 6)
                    {
                        Console.WriteLine("Sabado");
                    }
                    else
                    {
                        if(dia == 7)
                        {
                            Console.WriteLine("Domingo");
                        }
                        else
                        {

                            Console.WriteLine("Escriba un numero entre el 1 al 7");
                        }
                    }
                }
            }
        }
    }

}

switch (dia) {

    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Escriba un numero entre el 1 al 7");
        break;

}


char genero = 'K'; // 'F', 'M';

switch (genero)
{
    case 'F':
        Console.WriteLine("Femenimo");
        break;
    case 'M':
        Console.WriteLine("Masculino");
        break;

    default:
        Console.WriteLine("Genero no aplica");
        break;
}

// Las leyes en Honduras nos dicen que cuando una persona de Genero Femenimo tiene 60 años
// ya tiene derecho a jubilarse
// pero si es de genero Masculino debe tener 65 años.

int edad;
Console.WriteLine("Ingrese su Edad");
edad = int.Parse(Console.ReadLine());

char g = '0';
Console.WriteLine("Ingrese su Genero (F/M)");
g = char.Parse(Console.ReadLine());

bool tieneDerechoJubilacion = false;

switch (g) {

    case 'M':
        if (edad >= 65) {
            tieneDerechoJubilacion = true;
        }
        break;
    case 'F':
        if (edad >= 60) {
            tieneDerechoJubilacion = true;
        }
        break;
    default:
        Console.WriteLine("Genero no valiudo para Calculo de Jubilacion");
        break;
    
}

Console.WriteLine("La Persiona tiene derecho a Jubilacion " + tieneDerechoJubilacion);


bool seguirPeleando = true;

do
{

    Console.WriteLine("Quieres Irte de mi Mundo (Y/N)");
    char vl = char.Parse(Console.ReadLine());

    if (vl == 'Y')
    {

        seguirPeleando = false;

    }
    else {
        Console.WriteLine("Ok, seguiras en mi prision");
    }



} while (seguirPeleando == true);

Console.WriteLine("Te he liberado de mi prision de bucles");

// Se solicita que la persona ingrese un valor menor a 10 y sino ingresa un valor a 10
// no debe dejarlo continuar en el programa.

int valorIngresar = 11;
// Las variables que me rompen un ciclo, se les llama variables banderas
// si usted en medio del ciclo no modifica la variable bandera
// su ciclo sera infinito.


// Yo ejecuto el bucle al menos una vez
do
{

    Console.WriteLine("Ingrese un valor menor 10");
    valorIngresar = int.Parse(Console.ReadLine());

} while (valorIngresar >= 10);

// Ciclo While Voy a entrar al bucle si cumple la condicion. 

while (valorIngresar >= 10) {
    Console.WriteLine("Ingrese un valor menor 10");
    valorIngresar = int.Parse(Console.ReadLine());
}
