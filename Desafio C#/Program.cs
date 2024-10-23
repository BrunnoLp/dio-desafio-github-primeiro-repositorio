using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Net.Http.Headers;
using System.Xml;

void ExibirLogo()
{    
    Console.WriteLine(@"
██████╗░███████╗░██████╗░█████╗░███████╗██╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔════╝██║██╔══██╗
██║░░██║█████╗░░╚█████╗░███████║█████╗░░██║██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██╔══██║██╔══╝░░██║██║░░██║
██████╔╝███████╗██████╔╝██║░░██║██║░░░░░██║╚█████╔╝
╚═════╝░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░");
}

void ExibirOpçoesDoMenu ()
{
    ExibirLogo();
    Console.WriteLine ("\nDesafio 1 = Introdução");
    Console.WriteLine ("Desafio 2 = Media e Lista de Linguagens");
    Console.WriteLine ("Desafio 3 = Operações Basicas e Lista de Bandas");
    Console.WriteLine ("Desafio 4 = Dicionario, Simulador, Quiz,  Sistema de Login e Media super carros");

    Console.Write ("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: Introducao();
            break;
        case 2: SegundoDesafio();
            break;
        case 3: TerceiroDesafio();
            break;
        case 4: QuartoDesafio(); 
            break;
        case -1: 
            break;
        default: 
            break;
    }
}

void Introducao()
{    
    string curso = ("\nCriando sua primeira aplicação com C#");
    Console.WriteLine("***************************************");
    Console.WriteLine(curso);
    Console.WriteLine("***************************************");

    string nomeSobrenome = ("\nBruno Lopes");
    Console.WriteLine (nomeSobrenome);

    Console.WriteLine ("\nDaniel Portugal e Guilherme Lima");
    Thread.Sleep(5000);
    Console.Clear();
    ExibirOpçoesDoMenu();
}
   
void SegundoDesafio()
{
    Console.Clear();
    ExibirTituloDaOpcao("Segundo Desafio");
    Console.WriteLine ("\n1 - Media para Aprovação");
    Console.WriteLine ("2 - Lista de Linguagens");
    Console.Write ("\nDigite a opção desejada: ");
    string opcaoEscolhida_Segundo = Console.ReadLine()!;
    int opcaoEscolhidaNumerica_Segundo = int.Parse(opcaoEscolhida_Segundo);

    switch (opcaoEscolhidaNumerica_Segundo)
    {
        case 1:ExercicioMedia() ;
            break;
        case 2:ListaDeLinguagens() ;
            break;
    }
    
    void ExercicioMedia () {int notaMedia = 5;
    Console.WriteLine("Digite sua nota");
    string notaAluno = Console.ReadLine()!;
    int notaAlunoNumerica = int.Parse(notaAluno);

    if (notaAlunoNumerica > notaMedia)
    {
            Console.WriteLine("Você foi aprovado!");
    }else Console.WriteLine("Você foi reprovado!");
    Thread.Sleep(5000);
    Console.Clear();
    ExibirOpçoesDoMenu();
    }


    void ListaDeLinguagens()
    {
        Console.WriteLine("\nLinguagens de Programação");
        Console.WriteLine("\nJava");
        Console.WriteLine("JavaScript");
        Console.WriteLine("C Sharp");
    }
    Console.WriteLine ("Digite uma tecla para voltar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}

void TerceiroDesafio()
{
    Console.Clear();
    ExibirTituloDaOpcao("Terceiro Desafio");
    Console.WriteLine ("\n1 - Operações Basicas");
    Console.WriteLine ("2 - Lista de Bandas");
    Console.WriteLine("3 - Soma de valores da lista");
    Console.Write ("\nDigite a opção desejada: ");
    string opcaoEscolhida_Terceiro = Console.ReadLine()!;
    int opcaoEscolhidaNumerica_Terceiro = int.Parse(opcaoEscolhida_Terceiro);

    switch (opcaoEscolhidaNumerica_Terceiro)
    {
        case 1:OperacoesBasicas() ;
            break;
        case 2:ListaDeBandas();
            break;
        case 3: SomaDeInterios();
            break;
    }

    void OperacoesBasicas()
    {
        float valorA = 2;
        float valorB = 5;

        Console.WriteLine ($"\nO Valor de A =  {valorA} e o Valor de B = {valorB}");

        float adicao = valorA + valorB;
        float subtracao= valorA - valorB;
        float divisao= valorA / valorB;
        float multiplicacao = valorA * valorB;

        Console.WriteLine($"\nAdição: {adicao}");
        Console.WriteLine($"\nSubtração: {subtracao}");
        Console.WriteLine($"\nDivisão: {divisao}");
        Console.WriteLine($"\nMultiplicação: {multiplicacao}\n");
        Console.WriteLine ("Digite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
    }
       
    void ListaDeBandas()
    {
        Console.Clear();
        List<string>bandas = new List<string>{"U2","The Beatles","Queen","Slipknot","A7x"};
        Console.WriteLine("***************************");
        Console.WriteLine("Lista de bandas registradas");
        Console.WriteLine("***************************\n");

        foreach (string banda in bandas)
        {
        Console.WriteLine($"Banda: {banda}");     
        }
        Console.WriteLine("\nDigite uma tela para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
    }

    void SomaDeInterios()
    {
        List<int> numerosInteiros = new List<int>{4,66,2,10,21,23,12};
        int somaValores = 0;
        foreach (int numero in numerosInteiros)
        {
            Console.WriteLine($"Numero: {numero}\n");
            Console.WriteLine();
            somaValores += numero;     
        }

        Console.WriteLine(somaValores);

        Console.WriteLine("\nDigite uma tecla para voltar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçoesDoMenu();
    }
}

void QuartoDesafio()
{
    Console.Clear();
    ExibirTituloDaOpcao("Quarto Desafio");
    Console.WriteLine ("\n1 - Dicionario de um aluno");
    Console.WriteLine ("2 - Estoque de Loja");
    Console.WriteLine("3 - Quiz");
    Console.WriteLine("4 - Sistema Login");
    Console.WriteLine("5 - Media super carros");
    Console.Write ("\nDigite a opção desejada: ");
    string opcaoEscolhida_Quarto = Console.ReadLine()!;
    int opcaoEscolhidaNumerica_Quarto = int.Parse(opcaoEscolhida_Quarto);

    switch (opcaoEscolhidaNumerica_Quarto)
    {
        case 1:Dicionario();
            break;
        case 2:EstoqueLoja();
            break;
        case 3:Quiz();
            break;
        case 4:SestemaLogin();
            break;
        case 5: MediaSuperCarros();
            break;
    }

void Dicionario()
{
    Dictionary<string, List<int>> aluno = new Dictionary<string, List<int>>{};
    aluno.Add("Matheus", new List<int>{});
    aluno["Matheus"].Add(9);
    aluno["Matheus"].Add(10);    
    aluno["Matheus"].Add(12);

    int soma = 0;
    foreach (int notas in aluno["Matheus"])
    {
        soma += notas;
    }

    int media = soma/aluno["Matheus"].Count;
    Console.WriteLine($"\nA media das notas é {media}");

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
};

void EstoqueLoja()
{
    List<string>produtoEmEstoque = new List<string>{"Arroz","Feijão","Macarrao","Sorvete","Uva","Banana","Batata","Inhame"};
    Console.Write("Digite o produto para saber se tem no estoque ou não.\n");
    string produtoPesquisa = Console.ReadLine()!;
    if (produtoEmEstoque.Contains(produtoPesquisa))
    {
        Console.WriteLine($"O produto {produtoPesquisa} está em nosso estoque");
    } else
    {
        Console.WriteLine($"O produto {produtoPesquisa} não tem em nosso estoque.");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
};

void Quiz()
{
    Dictionary<string, string>perguntasQuiz = new Dictionary<string, string>();
    CriarPerguntas(perguntasQuiz, "Ultimo planeta do sistema solar", "plutao");
    Jogar(perguntasQuiz);
   
    
    void CriarPerguntas(Dictionary<string, string>perguntaQuiz, string pergunta, string resposta)
    {
        perguntaQuiz.Add(pergunta, resposta);
        Console.WriteLine("Pergunta Criada");

    };
    void Jogar(Dictionary<string, string> perguntasQuiz)
    {
        foreach (string pergunta in perguntasQuiz.Keys)
        {
            Console.WriteLine(pergunta);
            Console.WriteLine("Qual é a resposta\n");
            string resposta = Console.ReadLine()!;

            if (resposta == perguntasQuiz[pergunta])
            {
                Console.WriteLine("\nCerta resposta");
            } else
            {
                Console.WriteLine("Voce errou!");
            }
        }
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu();
}

void SestemaLogin()
{
    Dictionary<string, string>usuario = new Dictionary<string, string>();
    usuario["pedro"]= "usuario123";
    usuario["bruno"]= "bruno123";
    usuario["anna"]= "anna123";

    Console.WriteLine("\nInformem seu login");
    string login = Console.ReadLine()!;

    Console.WriteLine("\nInforme sua senha");
    string senha = Console.ReadLine()!;

    if (usuario.ContainsKey(login) & usuario[login]==senha)
    {
        Console.WriteLine("\nVocê esta Logado");
    }else
    {
        Console.WriteLine("\nNão foi possivel efetuar o login!");
    }  

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu(); 
};

void MediaSuperCarros()
{
    Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> 
    {
        { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
        { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
        { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
        { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
        { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
    };

    double mediaVendasBugatti = vendasCarros["Bugatti Veyron"].Average();
    Console.WriteLine("\nA media de vendas do Bugatti é" + mediaVendasBugatti);

    double mediaAgera = vendasCarros["Koenigsegg Agera RS"].Average();
    Console.WriteLine("\nA media da vendas do é" +mediaAgera);   
    
    double mediaAventador = vendasCarros["Lamborghini Aventador"].Average();
    Console.WriteLine("\nA media da vendas do é" + mediaAventador);

    double mediaHuayra = vendasCarros["Pagani Huayra"].Average();
    Console.WriteLine("\nA media da vendas do é" +mediaHuayra);

    double mediaLaFerrari = vendasCarros["Ferrari LaFerrari"].Average();   
    Console.WriteLine("\nA media da vendas do é" + mediaLaFerrari);

    Console.WriteLine("\nDigite uma tecla para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçoesDoMenu(); 
}

};

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);    
    Console.WriteLine(asteriscos + "\n");
}
ExibirOpçoesDoMenu();


