using Avaliacao;

List<Advogado> advogados = new();
List<Cliente> clientes = new();


try{
    Advogado ad = new Advogado();
    ad.Nome = "Fulano";
    ad.DataNascimento = new DateTime(21, 7, 1980);
    ad.Cpf = "01234567891";
    ad.CNA = "123";

    Colecoes.adicionaAdvogado(advogados, ad);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

//Advogado com cpf de tamanho inválido
try {
    Advogado ad = new Advogado();
    ad.Nome = "Beltrano";
    ad.DataNascimento = new DateTime(17, 11, 1985);
    ad.Cpf = "12345";
    ad.CNA = "12345";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

//Advogado com cpf repetido
try{
    Advogado ad = new Advogado();
    ad.Nome = "Cicrano";
    ad.DataNascimento = new DateTime(15, 12, 1998);
    ad.Cpf = "01234567891";
    ad.CNA = "12345";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex){
    Console.WriteLine(ex.Message);
}

//Advogado com CNA repetido
try{
    Advogado ad = new Advogado();
    ad.Nome = "Epaminondas";
    ad.DataNascimento = new DateTime(17, 7, 1999);
    ad.Cpf = "01234567892";
    ad.CNA = "123";
    Colecoes.adicionaAdvogado(advogados, ad);
} catch (Exception ex){
    Console.WriteLine(ex.Message);
}

try {
    Cliente cl = new Cliente();
    cl.Nome = "Ubirapildes";
    cl.DataNascimento = new DateTime(25, 3, 1995);
    cl.Cpf = "01234567893";
    cl.EstadoCivil = "Solteiro";
    cl.Profissao = "Programador";
    Colecoes.adicionaCliente(clientes, cl);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

try {
    Cliente cl = new Cliente();
    cl.Nome = "Clindoescléia";
    cl.DataNascimento = new DateTime(25, 10, 1975);
    cl.Cpf = "01234567894";
    cl.EstadoCivil = "Casado";
    cl.Profissao = "Engenheiro";
    Colecoes.adicionaCliente(clientes, cl);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

