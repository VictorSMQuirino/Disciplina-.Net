namespace Atividade;
public class ContaBancaria
{
    private double saldo;
    public double Saldo {
        get{ return saldo;}
        set{
            if(Saldo - value < 0){
                throw new ArgumentException("Saldo não pode ser negativo!");
            }
        }
    }
}
