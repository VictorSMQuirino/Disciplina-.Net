List<Task> tasks = new();
int ids = 1;

int option;

int menu (){
    Console.Clear();
    Console.WriteLine("\nSelecione uma opção:");
    Console.WriteLine("1 - Criar tarefa");
    Console.WriteLine("2 - Excluir tarefa");
    Console.WriteLine("3 - Listar tarefas");
    Console.WriteLine("4 - Exibir estatísticas");
    Console.WriteLine("5 - Marcar tarefa como concluída");

    Console.Write("Opção: ");
    int op;
    string entrada = Console.ReadLine();
    op = int.Parse(entrada);
    return op;
}

void pauseTerminal(){
    Console.WriteLine("Pressione enter para continuar...");
    Console.ReadLine();
}

bool isListEmpty(){
    if(tasks.Count == 0){
        Console.WriteLine("A lista de tarefas está vazia!");
        pauseTerminal();
        return true;
    }

    return false;
}

do {
    option = menu();
    switch (option) {
        case 1:
            Console.Clear();
            Console.Write("Nome da tarefa: ");
            string taskName = Console.ReadLine();
            Console.WriteLine("Descrição da tarefa: ");
            string taskDescription = Console.ReadLine();
            Console.WriteLine("Prazo da tarefa:");
            Console.Write("Dia: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime taskExpirationDate = new DateTime(year, month, day);
            Task task = new Task(ids, taskName, taskDescription, taskExpirationDate);

            tasks.Add(task);
            ids++;
            break;
        case 2:
            Console.Clear();
            if(isListEmpty()) break;

            Console.Write("Digite o id da tarefa a ser excluída: ");
            int id = Console.Read();
            foreach(Task t in tasks){
                if(t.Id == id){
                    tasks.Remove(t);
                    Console.WriteLine("Tarefa removida com successo!");
                    pauseTerminal();
                }
            }
            Console.WriteLine("Não existe uma tarefa com esse id!");
            pauseTerminal();
            break;
        case 3:
            Console.Clear();
            if(isListEmpty()) break;

            Console.WriteLine("\nLista de tarefas:");
            foreach(Task t in tasks){
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Id: " + t.Id);
                Console.WriteLine("Nome: " + t.Name);
                Console.WriteLine("Descrição: " + t.Description);
                Console.WriteLine("Prazo: " + t.ExpirationDate.Day + "/" + t.ExpirationDate.Month + "/" + t.ExpirationDate.Year);
                Console.WriteLine("Concluida: ");
                if(t.Completed) Console.WriteLine("Sim");
                else Console.WriteLine("Nao");
            }
            Console.WriteLine("--------------------------------");
            pauseTerminal();
            break;
        case 4:
            Console.Clear();
            if(isListEmpty()) break;

            int completeds = 0, incompleteds = 0;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Estatísticas:");
            foreach(Task t in tasks) {
                if(t.Completed) completeds++;
                else incompleteds++;
            }
            Task oldestTask = tasks.OrderBy(t => t.ExpirationDate).FirstOrDefault();
            Task newestTask = tasks.OrderByDescending(t => t.ExpirationDate).FirstOrDefault();

            Console.WriteLine("Tarefas concluídas: " + completeds);
            Console.WriteLine("Tarefas não concluídas: " + incompleteds);
            Console.WriteLine("Número total de tarefas: " + tasks.Count);
            Console.WriteLine("\nTarefa mais antiga:");
            Console.WriteLine("Id: " + oldestTask.Id);
            Console.WriteLine("Nome: " + oldestTask.Name);
            Console.WriteLine("Descrição: " + oldestTask.Description);
            Console.WriteLine("Prazo: " + oldestTask.ExpirationDate.Day + "/" + oldestTask.ExpirationDate.Month + "/" + oldestTask.ExpirationDate.Year);
            Console.Write("Concluida: ");
            if(oldestTask.Completed) Console.WriteLine("Sim");
            else Console.WriteLine("Nao");

            Console.WriteLine("\nTarefa mais recente:");
            Console.WriteLine("Id: " + newestTask.Id);
            Console.WriteLine("Nome: " + newestTask.Name);
            Console.Write("Descrição: " + newestTask.Description);
            Console.WriteLine("Prazo: " + newestTask.ExpirationDate.Day + "/" + newestTask.ExpirationDate.Month + "/" + newestTask.ExpirationDate.Year);
            Console.Write("Concluida: ");
            if(newestTask.Completed) Console.WriteLine("Sim");
            else Console.WriteLine("Nao");

            pauseTerminal();
            break;
        case 5:
            Console.Clear();
            if(isListEmpty()) break;

            Console.Write("Digite o id da tarefa para marca-la como concluida: ");
            id = int.Parse(Console.ReadLine());

            foreach(Task t in tasks){
                if(t.Id == id){
                    t.CompleteTask();
                    Console.WriteLine("Tarefa marcada como concluida!");
                    pauseTerminal();
                    break;
                }
            }
            Console.WriteLine("Nao existe uma tarefa com esse id!");
            pauseTerminal();

            break;
        case 0:
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida!");
            pauseTerminal();
            break;
    }
} while(option != 0);

public class Task {
    private int id;
    private string name;
    private string description;
    private DateTime expirationDate;
    private bool completed;

    public Task(int id, string name, string description, DateTime expirationDate){
        this.id = id;
        this.name = name;
        this.description = description;
        this.expirationDate = expirationDate;
        completed = false;
    }

    public int Id {
        get => id;
    }

    public string Name {
        get => name;
    }

    public string Description {
        get => description;
    }

    public DateTime ExpirationDate {
        get => expirationDate;
    }

    public bool Completed {
        get => completed;
    }

    public void CompleteTask() {
        completed = true;
    }
}