using Atividade;

var veiculo = new Veiculo();

veiculo.Modelo = "Gol";
veiculo.Ano = 2016;
veiculo.Cor = "Prata";

Console.WriteLine($"Veiculo criado: {veiculo.Modelo}, ano {veiculo.Ano}, cor {veiculo.Cor}");
Console.WriteLine($"Idade do veiculo: {veiculo.IdadeVeiculo}");