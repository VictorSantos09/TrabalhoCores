namespace TrabalhoCores
{
    public class Methods
    {
        public void RegisterColor(string[] coresHexadecimal, string[] cores)
        {
            int contador = 1;
            Console.Clear();
            Console.WriteLine($"Limite Maximo: 5\nDigite a quantidade de cores para cadastrar");
            string userInputQtdCorST = IsNullOrEmpty.EmptyST(Console.ReadLine());
            int userInputQtdCor = Convert.ToInt32(userInputQtdCorST);
            if (userInputQtdCor > 5)
            {
                Console.WriteLine("Quantia indisponivel");
            }
            else
            {
                userInputQtdCor = userInputQtdCor + 5;
                for (int i = 5; i < userInputQtdCor; i++)
                {
                    // VERIFICAR SE A CONDICAO É VAZIA PARA ATRIBUIR CASO O USER DECIDA COLOCAR 1 POR EXEMPLO, IRA INDICAR ERRO POIS NAO BATE COM A CONDICAO DO FOR
                    Console.WriteLine($"Digite o nome da cor {contador} para cadastrar");
                    cores[i] = IsNullOrEmpty.EmptyST(Console.ReadLine());
                    Console.WriteLine($"Digite o hexadecimal da cor {contador} para cadastrar");
                    coresHexadecimal[i] = IsNullOrEmpty.EmptyST(Console.ReadLine());
                    contador++;
                }
            }
        }
        public void Colors(string[] cores, string[] coresHexadecimal)
        {
            Console.Clear();
            Console.WriteLine("Cores Disponíveis: \n");
            for (int i = 0; i < cores.Length; i++)
            {
                if (cores[i] == null)
                {
                }
                else
                {
                    Console.WriteLine($"{cores[i]} {coresHexadecimal[i]}");
                }
            }
        }
        public void PaintObj(string[] cores, string userObject)
        {
            int contador = 1;
            Console.WriteLine($"Escolha a cor para pintar {userObject}");
            for (int i = 0; i < cores.Length; i++)
            {
                if (cores[i] == null)
                {

                }
                else
                {
                    Console.WriteLine($"{contador} - {cores[i]}");
                    contador++;
                }
            }
            string userInputColorObj = IsNullOrEmpty.EmptyST(Console.ReadLine());
            if (userInputColorObj == "1")
            {
                PaintPattern(0, userObject, cores);
            }
            if (userInputColorObj == "2")
            {
                PaintPattern(1, userObject, cores);
            }
            if (userInputColorObj == "3")
            {
                PaintPattern(2, userObject, cores);
            }
            if (userInputColorObj == "4")
            {
                PaintPattern(3, userObject, cores);
            }
            if (userInputColorObj == "5")
            {
                PaintPattern(4, userObject, cores);
            }
            if (userInputColorObj == "6")
            {
                PaintPattern(5, userObject, cores);
            }
            if (userInputColorObj == "7")
            {
                PaintPattern(6, userObject, cores);
            }
            if (userInputColorObj == "8")
            {
                PaintPattern(7, userObject, cores);
            }
            if (userInputColorObj == "9")
            {
                PaintPattern(8, userObject, cores);
            }
            if (userInputColorObj == "10")
            {
                PaintPattern(9, userObject, cores);
            }
        }
        public void PaintPattern(int choice, string userObject, string[] cores)
        {
            Console.WriteLine($"{userObject} foi pintado de {cores[choice]}");
        }
    }
}