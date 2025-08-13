byte idade ;
string nome = "";
Console.WriteLine(" Digite seu nome:");
nome = Console.ReadLine();
Console.Write("Digite sua idade");
idade = Convert.ToByte(Console.ReadLine());
Console.WriteLine("Ola " + nome + ". A idade informada foi {0}" , idade);