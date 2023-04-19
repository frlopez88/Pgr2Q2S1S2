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