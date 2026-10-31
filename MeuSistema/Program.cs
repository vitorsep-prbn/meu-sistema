namespace MeuSistema;

class Program
{
    static void Main()
    {   
        Console.Clear();
        int opcao = -1;
        while (opcao != 0)
        {
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("0 - Sair");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Usuarios.Cadastrar(); break;
                case 2: Usuarios.Listar(); break;
            }
        }
    }
}
