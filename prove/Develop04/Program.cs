using System;

public class Activity
{
    // the main class is where the program starts, we need
    //a menu here 
    static void Main(string[] args)
    {
        Console.WriteLine("this is the beggin of the work!");
        //testando o retorno da classe breath
        //criando instancia para chamar o breath metodo
         Breath breathInstance = new Breath();

        // Chamando o método Breathe1 da instância criada
        breathInstance.Breathe1();
    }
}