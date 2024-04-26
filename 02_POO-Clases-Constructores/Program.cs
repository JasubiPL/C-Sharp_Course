// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Coche coche1 = new Coche();
Coche coche2 = new Coche();

Console.WriteLine(coche1.getInfoCoche());

Coche coche3 = new Coche(3.0, 2.0);
Console.WriteLine(coche3.getInfoCoche());

class Coche
{
    public Coche()
    {
        ruedas = 4;
        largo = 2.3;
        ancho = 1.7;
        
    }

    public Coche(double largoCoche, double anchoCoche)
    {
        ruedas = 4;
        largo = largoCoche;
        ancho = anchoCoche;
    }

    public String getInfoCoche()
    {
        return "Info del Coche: \n Ruedas: " + ruedas + " Ancho: " + ancho + " Largo: " + largo;
    }

    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
}