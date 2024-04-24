// See https://aka.ms/new-console-template for more information
Console.WriteLine("Area de un circulo");


Circulo miCirculo;

miCirculo = new Circulo(); //Instancia de clase

Console.WriteLine(miCirculo.calculoArea(5));

Circulo miCirculo2 = new Circulo();// Forma corta de instanciar 

Console.WriteLine(miCirculo2.calculoArea(9));

class Circulo
{
    const double pi = 3.1416; //Propiedad

    public double calculoArea(int radio) //Metodo de clase
    {
        return pi * radio * radio;
    }

}