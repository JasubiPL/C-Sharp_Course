// See https://aka.ms/new-console-template for more information
Console.WriteLine("Area de un circulo");


Circulo miCirculo;

miCirculo = new Circulo(); //Instancia de clase

Console.WriteLine(miCirculo.CalculoArea(5));

Circulo miCirculo2 = new Circulo();// Forma corta de instanciar 

Console.WriteLine(miCirculo2.CalculoArea(9));

ConversorEuroDolar convierteEuroDolar = new ConversorEuroDolar();

convierteEuroDolar.CambiarValorEuro(2.5);
Console.WriteLine( "Conversion: " + convierteEuroDolar.Convierte(50.0));

class Circulo
{
    private const double pi = 3.1416; //Propiedad

    public double CalculoArea(int radio) //Metodo de clase
    {
        return pi * radio * radio;
    }

}

class ConversorEuroDolar
{
    private double euro = 1.23;

    public double Convierte(double dolar)
    {
        return euro * dolar;
    }

    public void CambiarValorEuro(double nuevoValor)
    {
        if (nuevoValor < 0)
        {
            euro = 1.23;
        }else
        {
            euro = nuevoValor ;
        }
    }
}