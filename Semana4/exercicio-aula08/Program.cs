using Atividade;

// #region exercicio 1
// var veiculo = new Veiculo();

// veiculo.Modelo = "Gol";
// veiculo.Ano = 2016;
// veiculo.Cor = "Prata";

// Console.WriteLine($"Veiculo criado: {veiculo.Modelo}, ano {veiculo.Ano}, cor {veiculo.Cor}");
// Console.WriteLine($"Idade do veiculo: {veiculo.IdadeVeiculo}");
// #endregion

#region exercicio 2
var conta = new ContaBancaria();
conta.Saldo = 250.00;
Console.WriteLine($"Saldo da conta: {conta.Saldo}");

try{
    conta.Saldo -= 300.00;
} catch(ArgumentException ex){
    Console.WriteLine(ex.Message);
}
#endregion