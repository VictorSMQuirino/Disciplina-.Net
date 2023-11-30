namespace Avaliacao;
public class Pessoa
{
    private string? cpf;
    public string? Nome {get; set;}
    public DateTime DataNascimento {get; set;}
    public int Idade {
        get{
            int idade = DateTime.Now.Year - DataNascimento.Year;
            if(DataNascimento.Date > DateTime.Now.Date) idade --;

            return idade;
        }
    }
    public string? Cpf {
        get{return cpf;} 
        set{
            if(value.Length == 11){
                cpf = value;
            } else throw new ArgumentException("CPF inválido!");
        }
    }

}
