namespace Avaliacao;
public static class Relatorios
{
    public static List<Advogado> advogadosComIdadeEntreValores(List<Advogado> advogados, int min, int max){
        return advogados.Where(a => a.Idade >= min && a.Idade <= max).ToList();
    }

    public static List<Cliente> clientesComIdadeEntreValores(List<Cliente> clientes, int min, int max){
        return clientes.Where(c => c.Idade >= min && c.Idade <= max).ToList();
    }

    public static List<Cliente> clientesComEstadoCivilInformado(List<Cliente> clientes, string ec){
        return clientes.Where(c => c.EstadoCivil == ec).ToList();
    }

    public static List<Cliente> clientesEmOrdemAlfabetica(List<Cliente> clientes){
        return clientes.OrderBy(c => c.Nome).ToList();
    }

    public static List<Cliente> clientesComProfissaoInformada(List<Cliente> clientes, string prof){
        return clientes.Where(c => c.Profissao.Contains(prof)).ToList();
    }

    public static List<Pessoa> aniversariantesDoMes(List<Cliente> clientes, List<Advogado> advogados, int mes){
        List<Pessoa> pessoas = advogados.Cast<Pessoa>().Concat(clientes).ToList();

        return pessoas.Where(p => p.DataNascimento.Month == mes).ToList();
    }
}
