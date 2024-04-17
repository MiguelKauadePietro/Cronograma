using static System.Console;


using System;

class CronogramaEstudoDetalhado
{
    static void Main(string[] args)
    {
        // Define o conteúdo de estudo para cada nível e linguagem
        Dictionary<string, Dictionary<string, string[]>> conteudoEstudo = new Dictionary<string, Dictionary<string, string[]>>()
        {
            { "Basico", new Dictionary<string, string[]>() //Nova chave-valor da dificuldade "Basico"
            {
                { "C#", new string[] { "Variáveis", "Tipos de dados", "Operadores", "Estruturas de controle" } },
                { "Python", new string[] { "Funções", "Módulos", "Listas", "Dicionários" } },
                { "Node.js", new string[] { "JavaScript", "DOM", "Eventos", "Bibliotecas" } },
                { "Java", new string[] { "Classes", "Objetos", "Herança", "Interfaces" } }
            }},
            { "Intermediario", new Dictionary<string, string[]>() //Nova chave-valor da dificuldade "Intermediario"
            {
                { "C#", new string[] { "POO (Programação Orientada a Objetos)", "Delegates e Eventos", "Gerenciamento de Memória" } },
                { "Python", new string[] { "Expressões Regulares", "Manipulação de Arquivos", "Módulos Avançados" } },
                { "Node.js", new string[] { "Express.js", "MongoDB", "Async/Await" } },
                { "Java", new string[] { "Coleções", "Multithreading", "Swing" } }
            }},
            { "Avancado", new Dictionary<string, string[]>() //Nova chave-valor da dificuldade "Avancado"
            {
                { "C#", new string[] { "APIs e Integrações", "WPF", "ASP.NET Core" } },
                { "Python", new string[] { "Django", "Flask", "Web Scraping", "FastAPI" } },
                { "Node.js", new string[] { "RESTful APIs", "Socket.io", "Cloud Computing" } },
                { "Java", new string[] { "Spring Framework", "Hibernate", "JEE" } }
            }}
        };

        // Interacao com o usuario
        WriteLine("Escolha o nível de estudo:");
        WriteLine("1 - Básico");
        WriteLine("2 - Intermediário");
        WriteLine("3 - Avançado");
        Write("Digite o número do nível: ");

        int escolhaNivel = int.Parse(ReadLine());

        WriteLine("\nEscolha a linguagem de programação para estudar:");
        WriteLine("1 - C#");
        WriteLine("2 - Python");
        WriteLine("3 - Node.js");
        WriteLine("4 - Java");
        Write("Digite o número da linguagem: ");

        int escolhaLinguagem = int.Parse(ReadLine());

        static string GetNomeLinguagem(int numeroLinguagem) //Escolha qual linguagem o usuario quer saber segundo a variavel escolhaLinguagem
        {
            switch (numeroLinguagem)
            {
                case 1:
                    return "C#";
                case 2:
                    return "Java";
                case 3:
                    return "Python";
                default:
                    return "NodeJS";
            }
        }

        if (conteudoEstudo.ContainsKey(GetNomeNivel(escolhaNivel)) && conteudoEstudo[GetNomeNivel(escolhaNivel)].ContainsKey(GetNomeLinguagem(escolhaLinguagem))) //Verificando se a linguagem e o nivel estao nos dicionarios
        {
            string[] topicosEstudo = conteudoEstudo[GetNomeNivel(escolhaNivel)][GetNomeLinguagem(escolhaLinguagem)]; // se for true, mostrar a linguagem e seu topico ao lado

            WriteLine("\nVocê escolheu estudar " + GetNomeNivel(escolhaNivel) + " em " + GetNomeLinguagem(escolhaLinguagem) + ":"); //mostrando o nivel e a linguagem
            foreach (string topico in topicosEstudo)   //iterando e mostrando no console o topico
            {
                WriteLine(" - " + topico);
            }
        }
        else
        {
            WriteLine("Nível ou linguagem inválidos. Por favor, escolha números válidos."); //se nem o nivel nem a linguagem estiverem no dicionario retornar invalido
        }
    }

    static string GetNomeNivel(int numeroNivel) //Escolhendo o nivel atraves da variavel numeroNivel 
    {
        switch (numeroNivel)
        {
            case 1:
                return "Basico";
            case 2:
                return "Intermediario";
            case 3:
                return "Avancado";
            default:
                return "Nivel desconhecido";
        }
    }
}
