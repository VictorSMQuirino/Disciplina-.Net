namespace Avaliacao;
public class Pessoa
{
    private string? cpf;
    private DateTime dataNascimento;
    public string? Nome {get; set;}
    public DateTime DataNascimento {
        get {return dataNascimento;} 
        set {
            if(DateTime.TryParse(value.ToString(), out dataNascimento)){
            } else {
                throw new DataInvalidaException("Data invalida!");
            }
        }
    }

    // partial void setaData(string data){
    //     if(DateTime.TryParse(data, out dataNascimento)){
    //         DataNascimento = data;
    //     }
    // }

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
