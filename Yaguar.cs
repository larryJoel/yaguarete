class Yaguar{
    string? nombre="";
    float peso;
    string? sexo;
    int anioNac;
    public Yaguar(string n, float p, string sex, int anio){
        nombre=n;
        peso = p;
        sexo = sex;
        anioNac= anio;
    }
    public Yaguar(){}
    public void YaguarReg(){
        Console.Write("Agrege nombre del felino: ");
        nombre = (Console.ReadLine());
        Console.Write("Agrege peso del felino: ");
        peso = float.Parse(Console.ReadLine());
        Console.Write("Agrege sexo del felino: ");
        sexo = Console.ReadLine();
        Console.Write("Agrege año de nacimiento del felino: ");
        anioNac = int.Parse(Console.ReadLine());
        var hoy=DateTime.Today;
        var fecha = anioNac;
        var posible = hoy.Year - fecha;
        if (posible >= 3 && (sexo == "h"||sexo =="H"))
       {
        Console.WriteLine("El yaguar puede ser madre..!");
       }
    }

    public void madre(int anio, string sexo){
       if (anio >= 3 && sexo == "h")
       {
        Console.WriteLine("El yaguar puede ser madre..!");
       }
    }

}