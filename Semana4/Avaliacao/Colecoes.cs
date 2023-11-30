namespace Avaliacao;
public class Colecoes
{
    public static void adicionaAdvogado(List<Advogado> lista, Advogado ad){
        if(lista.Any(a => a.Cpf == ad.Cpf)){
            throw new ArgumentException($"Ja existe um advogado com o cpf {ad.Cpf}");
        }
    }
}
