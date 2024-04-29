// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Coche coche1 = new Coche();
Coche coche2 = new Coche();

Console.WriteLine(coche1.getInfoCoche());

Coche coche3 = new Coche(3.0, 2.0);
Console.WriteLine(coche3.getInfoCoche());

Coche coche4 = new Coche();

coche4.setExtras(true, "tela");
Console.WriteLine(coche4.getExtras());

partial class Coche
{
    public Coche()
    {
        ruedas = 4;
        largo = 2.3;
        ancho = 1.7;
        tapiceria = "tela";

    }

    public Coche(double largoCoche, double anchoCoche)
    {
        ruedas = 4;
        largo = largoCoche;
        ancho = anchoCoche;
        tapiceria = "Licra";
    }

}

partial class Coche { 

    public String getInfoCoche()
    {
        return "Info del Coche: \n Ruedas: " + ruedas + " Ancho: " + ancho + " Largo: " + largo;
    }

    public void setExtras(bool climatizador, String tapiceria)
    {
        this.climatizador = climatizador;
        this.tapiceria = tapiceria;

        
    }

    public String getExtras()
    {
        return "Tiene climatizador: " + climatizador + " Tipo de tapiceria: " + tapiceria;
    }

    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private String tapiceria;
}