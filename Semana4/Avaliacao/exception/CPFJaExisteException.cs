namespace Avaliacao;
public class CPFJaExisteException : ArgumentException
{
    public CPFJaExisteException(string message) : base(message){

    }
}
