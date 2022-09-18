using TrabalhoCores;
Methods methods = new Methods();

string[] cores = new string[10];
string[] coresHexadecimal = new string[10];
cores[0] = "Azul";
coresHexadecimal[0] = "FFF010101";
cores[1] = "Rosa";
coresHexadecimal[1] = "FFF020202";
cores[2] = "Preto";
coresHexadecimal[2] = "FFF030303";
cores[3] = "Vermelho";
coresHexadecimal[3] = "FFF040404";
cores[4] = "Laranja";
coresHexadecimal[4] = "FFF050505";

Console.WriteLine("Hastin Colors");
bool userUsing = true;
while (userUsing)
{
    Console.WriteLine("\n1 - Ver cores em estoque\n2 - Cadastrar Cor\n3 - Cadastrar e Pintar objeto\n4 - Encerrar");
    var userInputChoice = IsNullOrEmpty.EmptyST(Console.ReadLine());
    if (userInputChoice == "1")
    {
        methods.Colors(cores, coresHexadecimal);
    }
    if (userInputChoice == "2")
    {
        methods.RegisterColor(coresHexadecimal, cores);
    }
    if (userInputChoice == "3")
    {
        Console.Clear();
        Console.WriteLine("Digite o nome do objeto para cadastrar");
        string userObject = IsNullOrEmpty.EmptyST(Console.ReadLine());
        Console.WriteLine($"{userObject} cadastrado com sucesso");
        methods.PaintObj(cores, userObject);
    }
    if (userInputChoice == "4")
    {
        Console.WriteLine("Encerrando...");
        userUsing = false;
    }
}