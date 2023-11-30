using Avaliacao;

List<Advogado> advogados = new();
List<Cliente> clientes = new();

Console.Clear();

try{
    Advogado ad = new();
    ad.Nome = "Fulano";
    ad.DataNascimento = new DateTime(1980, 70, 21);
    ad.Cpf = "01234567891";
    ad.CNA = "123";

    Colecoes.adicionaAdvogado(advogados, ad);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

try{
    Advogado ad = new();
    ad.Nome = "Fulano";
    ad.DataNascimento = new DateTime(1980, 7, 21);
    ad.Cpf = "01234567891";
    ad.CNA = "123";

    Colecoes.adicionaAdvogado(advogados, ad);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

//Advogado com cpf de tamanho inválido
try {
    Advogado ad = new();
    ad.Nome = "Beltrano";
    ad.DataNascimento = new DateTime(1985, 11, 17);
    ad.Cpf = "12345";
    ad.CNA = "12345";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

//Advogado com cpf repetido
try{
    Advogado ad = new();
    ad.Nome = "Cicrano";
    ad.DataNascimento = new DateTime(1998, 12, 15);
    ad.Cpf = "01234567891";
    ad.CNA = "12345";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex){
    Console.WriteLine(ex.Message);
}

//Advogado com CNA repetido
try{
    Advogado ad = new();
    ad.Nome = "Epaminondas";
    ad.DataNascimento = new DateTime(1999, 7, 17);
    ad.Cpf = "01234567892";
    ad.CNA = "123";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex){
    Console.WriteLine(ex.Message);
}

try {
    Cliente cl = new();
    cl.Nome = "Ubirapildes";
    cl.DataNascimento = new DateTime(1995, 7, 25);
    cl.Cpf = "01234567893";
    cl.EstadoCivil = "Solteiro";
    cl.Profissao = "Programador";
    Colecoes.adicionaCliente(clientes, cl);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

try {
    Cliente cl = new();
    cl.Nome = "Clindoescléia";
    cl.DataNascimento = new DateTime(1975, 10, 25);
    cl.Cpf = "01234567894";
    cl.EstadoCivil = "Casado";
    cl.Profissao = "Engenheiro";
    Colecoes.adicionaCliente(clientes, cl);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

Relatorios.advogadosComIdadeEntreValores(advogados, 20, 50);
Console.WriteLine("-----------------------------------------------------------------------");
Relatorios.clientesComIdadeEntreValores(clientes, 20, 50);
Console.WriteLine("-----------------------------------------------------------------------");
Relatorios.clientesComEstadoCivilInformado(clientes, "Solteiro");
Console.WriteLine("-----------------------------------------------------------------------");
Relatorios.clientesEmOrdemAlfabetica(clientes);
Console.WriteLine("-----------------------------------------------------------------------");
Relatorios.clientesComProfissaoInformada(clientes, "Programador");
Console.WriteLine("-----------------------------------------------------------------------");
Relatorios.aniversariantesDoMes(clientes, advogados, 7);
