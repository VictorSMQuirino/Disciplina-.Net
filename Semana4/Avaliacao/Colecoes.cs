namespace Avaliacao;
public class Colecoes
{
    public static void adicionaAdvogado(List<Advogado> lista, Advogado ad){
        if(lista.Any(a => a.Cpf == ad.Cpf)){
            throw new CPFJaExisteException($"Ja existe um advogado com o cpf {ad.Cpf}");
        } else if(lista.Any(a => a.CNA == ad.CNA)){
            throw new CnaJaExisteException("Ja existe um advogado com esse CNA!");
        } else {
            lista.Add(ad);
        }
    }

    public static void adicionaCliente(List<Cliente> lista, Cliente cl){
        if(lista.Any(c => c.Cpf == cl.Cpf)){
            throw new CPFJaExisteException("Ja existe um cliente com esse cpf!");
        } else {
            lista.Add(cl);
        }
    }
}
