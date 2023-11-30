namespace Atividade;
public class Aluno
{
    public string? Nome {get; set;}
    public int Idade {get; set;}

    public Aluno(string nome = "Fulano", int idade = 20){
        Nome = nome;
        Idade = idade;
    }
}
