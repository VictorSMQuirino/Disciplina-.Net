namespace P003.Interface;

public class Interface {
    public static string menu(){
        Console.WriteLine("##### MENU #####");
        Console.WriteLine("1 - Cadastrar um produto");
        Console.WriteLine("2 - Consultar um produto");
        Console.WriteLine("3 - Atualizar estoque");
        Console.WriteLine("4 - Relatórios");
        Console.WriteLine("0 - Encerrar programa");
        Console.Write("Digite uma opção: ");

        string option = Console.ReadLine()!;

        return option;
    }

    public static string reportsMenu(){
        Console.WriteLine("#### RELATÓRIOS ####");
        Console.WriteLine("1 - Produtos com quantidade abaixo de um determinado valor");
        Console.WriteLine("2 - Produtos com valor entre um intervalo");
        Console.WriteLine("3 - Valor total do estoque");
        Console.WriteLine("0 - Retornar ao menu anterior");
        Console.Write("Digite uma opção: ");

        string option = Console.ReadLine()!;

        return option;
    }

    public static string updateStockMenu(string code){
        Console.WriteLine("### ATUALIZAR ESTOQUE - Código " + code + " ###");
        Console.WriteLine("1 - Entrada de produto");
        Console.WriteLine("2 - Saída de produto");
        Console.WriteLine("0 - Cancelar");
        Console.Write("Digite uma opção: ");

        string option = Console.ReadLine()!;

        return option;
    }

    public static void pauseTerminal(){
        Console.WriteLine("Tecle enter para continuar...");
        Console.Read();
    }
}