namespace Avaliacao;
public class CnaJaExisteException : ArgumentException
{
    public CnaJaExisteException(string message) : base(message){
        
    }
}
