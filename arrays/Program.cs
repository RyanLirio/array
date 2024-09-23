using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Familia();   
        }

        static void Familia()
        {
            var integrantes = new Integrante[5];
            integrantes[0] = new Integrante() {Nome = "Ryan", Idade = 18, Altura = 1.73F};
            integrantes[1] = new Integrante() {Nome = "Pai", Idade = 49, Altura = 1.73F};
            integrantes[2] = new Integrante() {Nome = "Mãe", Idade = 52, Altura = 1.58F};
            integrantes[3] = new Integrante() {Nome = "Fê", Idade = 17, Altura = 1.63F};
            integrantes[4] = new Integrante() {Nome = "Tomtom", Idade = 0.7, Altura = 0.80F};

            foreach (var Integrante in integrantes)
            {
                Console.WriteLine($"Nome: {Integrante.Nome}");
                Console.WriteLine($"Idade: {Integrante.Idade} anos");
                Console.WriteLine($"Altura: {Integrante.Altura}m"); 
                Thread.Sleep(1000);
                Console.WriteLine("");    
            }
        }
    }
    public struct Integrante
    {       
    public string Nome {get; set;}     
    public double Idade {get; set;}
    public float Altura {get; set;}
 
    }
}