namespace Avaliacao;
public static class Atividade
{
    public static List<Advogado> advogadosComIdadeEntreValores(List<Advogado> advogados, int min, int max){
        return advogados.Where(a => a.Idade >= min && a.Idade <= max);
    }
}
