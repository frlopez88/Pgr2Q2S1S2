using System;

// Programa que suma dos numeros
/*int a = 0;
int b = 0;

Console.WriteLine("Ingrese el primer numero");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
b = int.Parse(Console.ReadLine());

Console.WriteLine("La suma de los numero es " + (a + b));*/

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
