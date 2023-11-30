namespace Avaliacao;
public static class Relatorios
{
    public static void advogadosComIdadeEntreValores(List<Advogado> advogados, int min, int max){
        var lista = advogados.Where(a => a.Idade >= min && a.Idade <= max).ToList();

        Console.WriteLine($"Advogados com a idade entre {min} e {max}:");
        lista.ForEach(a => {
            Console.WriteLine($"{a.Nome} - {a.Cpf}");
        });
    }

    public static void clientesComIdadeEntreValores(List<Cliente> clientes, int min, int max){
        var lista = clientes.Where(c => c.Idade >= min && c.Idade <= max).ToList();
        Console.WriteLine($"Clientes com a idade entre {min} e {max}:");
        lista.ForEach(c => {
            Console.WriteLine($"{c.Nome} - {c.Cpf}");
        });
    }

    public static void clientesComEstadoCivilInformado(List<Cliente> clientes, string ec){
        var lista = clientes.Where(c => c.EstadoCivil == ec).ToList();
        Console.WriteLine($"Clientes com o estado civil {ec}");
        lista.ForEach( c => Console.WriteLine($"{c.Nome} - {c.Cpf}"));
    }

    public static void clientesEmOrdemAlfabetica(List<Cliente> clientes){
        var lista = clientes.OrderBy(c => c.Nome).ToList();
        Console.WriteLine("Clientes ordenados:");
        lista.ForEach(c => Console.WriteLine($"{c.Nome} - {c.Cpf}"));
    }

    public static void clientesComProfissaoInformada(List<Cliente> clientes, string prof){
        var lista = clientes.Where(c => c.Profissao.ToLower().Contains(prof.ToLower())).ToList();
        Console.WriteLine($"Clientes com a profissao {prof}");
        lista.ForEach(c => Console.WriteLine($"{c.Nome} - {c.Cpf}"));
    }

    public static void aniversariantesDoMes(List<Cliente> clientes, List<Advogado> advogados, int mes){
        string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};
        List<Pessoa> pessoas = advogados.Cast<Pessoa>().Concat(clientes).ToList();
        var lista = pessoas.Where(p => p.DataNascimento.Month == mes).ToList();

        Console.WriteLine($"Aniversariantes do mes de {meses[mes-1]}");
        lista.ForEach(p => Console.WriteLine($"{p.Nome} - {p.Cpf}"));
    }
}
