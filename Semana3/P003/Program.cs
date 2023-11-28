using P003.Exceptions;
using P003.Interface;
using System.Globalization;

CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-br");

List<(string code, string name, int quantity, double price)> products = new();
products.Add(("abc", "Computador", 15, 1500.00));

string option;

do {
    Console.Clear();
    option = Interface.menu();
    Console.Clear();
    switch (option) {
        case "1":
            registerProduct();
            Interface.pauseTerminal();
            break;
        case "2":
            consultProduct();
            Interface.pauseTerminal();
            break;
        case "3":
            updateStock();
            break;
        case "4":
            issueReports();
            break;
        case "0":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            Interface.pauseTerminal();
            break;
    }
} while(option != "0");

void registerProduct(){
    string code, name;
    int amount;
    double price;

    try {
        Console.Write("Código do produto: ");
        code = Console.ReadLine()!;

        if(string.IsNullOrWhiteSpace(code)) 
            throw new ArgumentException("O código do produto não pode ser uma string vazia! Tente novamente.");

        if(products.Any(p => p.code == code)){
            throw new RepeatProductCode("Já existe um produto cadastrado com esse código! Tente novamente.");
        }
    } catch (ArgumentException ex){
        Console.WriteLine(ex.Message);
        return;
    } catch (RepeatProductCode ex){
        Console.WriteLine(ex.Message);
        return;
    }

    try {
        Console.Write("Nome do produto: ");
        name = Console.ReadLine()!;

        if(string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("O nome do produto não pode ser uma string vazia! Tente novamente");
    } catch (ArgumentException ex) {
        Console.WriteLine(ex.Message);
        return;
    }
    Console.Write("Quantidade: ");
    amount = int.Parse(Console.ReadLine()!);
    Console.Write("Preço: ");
    price = double.Parse(Console.ReadLine()!);

    products.Add((code, name, amount, price));
    Console.WriteLine("Produto cadastrado com sucesso!");
}

void consultProduct(){
    string code;

    if(products.Count == 0) {
        Console.WriteLine("A lista de produtos está vazia! Cadastre um produto para poder consultá-lo.");
        return;
    }

    try {
        Console.Write("Digite o código do produto para consultar: ");
        code = Console.ReadLine()!;

        if(string.IsNullOrWhiteSpace(code)) 
            throw new ArgumentException("O código do produto não pode ser uma string vazia! Tente novamente");
    } catch (ArgumentException ex){
        Console.WriteLine(ex.Message);
        return;
    }

    var product = products.SingleOrDefault(p => p.code == code);

    if(product != default){
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("Detalhes do produto:");
        Console.WriteLine("Código: " + product.code);
        Console.WriteLine("Nome: " + product.name);
        Console.WriteLine("Quantidade em estoque: " + product.quantity);
        Console.WriteLine($"Preço: R${product.price:F2}");
        Console.WriteLine("----------------------------------------");

    } else {
        Console.WriteLine("Não foi encontrado nenhum produto com o código " + code);
    }
}

void updateStock(){
    string code;

    if(products.Count == 0) {
        Console.WriteLine("A lista de produtos está vaiza! Cadastre um produto para poder atualizar o estoque.");
        return;
    }

    try {
        Console.Write("Digite o código do produto que deseja atualizar: ");
        code = Console.ReadLine()!;

        if(string.IsNullOrWhiteSpace(code)) 
            throw new ArgumentException("O código do produto não pode ser uma string vazia! Tente novamente");
    } catch (ArgumentException ex){
        Console.WriteLine(ex.Message);
        return;
    }

    var product = products.SingleOrDefault(p => p.code == code);
    if(product == default) {
        Console.WriteLine("Não foi encontrado nenhum produto com o código " + code);
        Interface.pauseTerminal();
        return;
    }

    var i = products.IndexOf(product);
    string optionU; 

    do {
        Console.Clear();
        optionU = Interface.updateStockMenu(code);
        Console.Clear();

        switch(optionU) {
            case "1":
                Console.Write("Digite a quantidade de produtos para dar entrada no estoque: ");
                int quantityIn = int.Parse(Console.ReadLine()!);
                var updatedProduct = (product.code, product.name, products[i].quantity + quantityIn, product.price);
                products[i] = updatedProduct;
                Console.WriteLine("Produto atualizado com sucesso! Foram inseridos " + quantityIn + " no estoque");
                Interface.pauseTerminal();
                break;
            case "2":
                Console.Write("Digite a quantidade de produtos para dar retirada do estoque: ");
                int quantityOut = int.Parse(Console.ReadLine()!);
                if(products[i].quantity >= quantityOut) {
                    var updatedProduct2 = (product.code, product.name, product.quantity - quantityOut, product.price);
                    products[i] = updatedProduct2;
                    Console.WriteLine("Produto atualizado com sucesso! Foram removidos " + quantityOut + " do estoque");
                } else Console.WriteLine("Não foi possível atualizar o estoque, pois a quantidade fornecida é maior do que a quantidade cadastrada!");
                Interface.pauseTerminal();
                break;
            case "0":
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção inválida!");
                Interface.pauseTerminal();
                break;
        }
    } while(optionU != "0");
}

void issueReports(){
    string option;

    if(products.Count == 0) {
        Console.WriteLine("A lista de produtos está vaiza! Cadastre produtos para poder emitir relatórios.");
        return;
    }

    do {
        Console.Clear();
        option = Interface.reportsMenu();
        Console.Clear();

        switch (option) {
            case "1":
                Console.Write("Informe um valor limite para emitir o relatório: ");
                double limit = double.Parse(Console.ReadLine()!);
                var selectedProducts = products.Where(p => p.price < limit);

                Console.Clear();
                Console.WriteLine("Produtos com preço abaixo de R$" + limit + ":");
                foreach (var product in selectedProducts){
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Código: " + product.code);
                    Console.WriteLine("Nome: " + product.name);
                    Console.WriteLine("Quantidade em estoque: " + product.quantity);
                    Console.WriteLine($"Preço: R${product.price:F2}");
                }
                Console.WriteLine("----------------------------------------");
                Interface.pauseTerminal();
                break;
            case "2":
                Console.Write("Informe o valor mínimo para o preço: ");
                double minValue = double.Parse(Console.ReadLine()!);
                Console.Write("Informe o valor máximo para o preço: ");
                double maxValue = double.Parse(Console.ReadLine()!);
                var selectedProducts2 = products.Where(p => p.price >= minValue && p.price <= maxValue);

                Console.Clear();
                Console.WriteLine("Produtos com preço entre R$" + minValue + " e R$" + maxValue + ":");
                foreach (var product in selectedProducts2){
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Código: " + product.code);
                    Console.WriteLine("Nome: " + product.name);
                    Console.WriteLine("Quantidade em estoque: " + product.quantity);
                    Console.WriteLine($"Preço: R${product.price:F2}");
                }
                Console.WriteLine("----------------------------------------");
                Interface.pauseTerminal();
                break;
            case "3":
                var totalStockValue = products.Sum(p => p.price * p.quantity);
                Console.WriteLine($"Valor total do estoque: R${totalStockValue:F2}\n");
                foreach(var product in products){
                    var totalProductValue = product.price * product.quantity;
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Código: " + product.code);
                    Console.WriteLine("Nome: " + product.name);
                    Console.WriteLine($"Valor total em estoque: R${totalProductValue:F2}");
                }
                Console.WriteLine("----------------------------------------");
                Interface.pauseTerminal();
                break;
        }
    } while(option != "0");
}