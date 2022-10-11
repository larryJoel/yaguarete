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
    int naci=0;
    string sex;
    public void YaguarReg(){
        Console.Write("Agrege nombre del felino: ");
        nombre = (Console.ReadLine());
        Console.Write("Agrege peso del felino: ");
        peso = float.Parse(Console.ReadLine());
        Console.Write("Agrege sexo del felino: ");
        sexo = Console.ReadLine();
        Console.Write("Agrege año de nacimiento del felino: ");
        anioNac = int.Parse(Console.ReadLine());
        naci = anioNac;
        sex=sexo;
        
        /*
        var hoy=DateTime.Today;
        var fecha = anioNac;
        var posible = hoy.Year - fecha;
        if (posible >= 3 && (sexo == "h"||sexo =="H"))
       {
        Console.WriteLine("El yaguar puede ser madre..!");
       }*/
    }

    public void madre(){
       var hoy=DateTime.Today;
        var fecha = naci;
        var posible = hoy.Year - fecha;
        if (posible >= 3 && (sexo == "h"||sex =="H"))
       {
        Console.WriteLine("El yaguar puede ser madre..!");
       }
    }

}