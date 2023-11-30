namespace Avaliacao;
public class Cliente : Pessoa
{
    private string? estadoCivil;
    public string? EstadoCivil {
        get{return estadoCivil;} 
        set{
            if(value != "solteiro" && value != "casado")
                throw new ArgumentException("O estado civil deve ser igual a 'solteiro' ou 'casado'");
            else estadoCivil = value;
        }
    }
}
