using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    public static void Main(string[] args){

        List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

        List<int> numerosPares = numeros.Where(n => n % 2 == 0).ToList();

        Console.WriteLine("Números Pares: ");
        numerosPares.ForEach(n => Console.WriteLine(n));

        List<string> frutas = new List<string> {"Maça", "Banana", "Manga", "Abacaxi", "Melancia", "Jabuticaba"};

        List<string> frutasOrdenadas = frutas.OrderBy (f=> f).ToList();

        List<string> frutasComM = frutasOrdenadas.Where(f => f.StartsWith("M")).ToList();

        Console.WriteLine("Frutas ordenadas que começam com M: ");
        frutasComM.ForEach(f => Console.WriteLine(f));

        //Terceira Prática
        List<Pessoa> pessoas = new List<Pessoa>{
            new Pessoa("Rafael",33),
            new Pessoa("Cecília", 1),
            new Pessoa("Maria", 22),
            new Pessoa("Daniel", 55),
            new Pessoa("Roberta", 28),
        };

        List<Pessoa> pessoasFiltradas = pessoas.Where(p => p.Idade > 25).OrderBy(p => p.Nome).ToList();

        Console.WriteLine("Pessoas com idade maior que 25, ordenadas por nome:");
        pessoasFiltradas.ForEach(p => Console.WriteLine($"Nome: {p.Nome}, Idade{p.Idade}"));
    }
}