using M1s02ex6;
Filme NovoFilme = new Filme();
Console.WriteLine("Insira o nome do filme"); 
NovoFilme.NomeFilme = Console.ReadLine();
Console.WriteLine("Insira o gênero do filme");
NovoFilme.Cartegoria= Console.ReadLine();
Console.WriteLine($"Filme: {NovoFilme.NomeFilme}, Cartergoria: {NovoFilme.Cartegoria}"); 