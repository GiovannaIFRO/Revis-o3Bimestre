using Revisão3Bimestre;

public class Program
{
    static void Main(string[] args)
    {
        //ExemploList();
        ExemploListaObjetos();
    }
   
    static void ExemploList()
    {

        List<string> listString = new List<string>();
        listString.Add("Elias");
        listString.Add("Julia");
        listString.Insert(0, "joão");//delimita a posição expecifica do dado
        listString.Add("Ana Maria");
        //index = posição

        //listString.Remove("Julia");
        listString.RemoveAt(1);//remove a posição expecifica
                               //listString.Clear(); //limpa toda a lista
        listString.Sort(); //comando responsal por ordenar a lista

        //listString.cont retorna o tamanho da lista nor for

        //o foreach percorre todos os elementos da lista, da primeira posição até a ultima 
        //para cada repetição, copia o endereço da posição atual da lista
        //ou seja, na primeira repetição a variável str recebe o valor da posição 0 da lista(Elias)
        //na segunda repetição, str recebe o valor da posição 1 da lista(joão)

        bool contem = listString.Contains("Elias");
        Console.WriteLine(contem);

        List<string> listab = new List<string> { "Maria a ", "Maria b" };
        listString.AddRange(listab);//adiciona a listab no filnal da listString

        foreach (string str in listString)//percorre todos os elementos da lista e armazena na variavel declarada 
        {
            Console.WriteLine(str);//imprime todos os elementos da lista 

        }

        List<int> listaInt = new List<int>();
        listaInt.Add(1);
        listaInt.Add(2);
        listaInt.Insert(1, 5);
        //listaInt.Sort();

        foreach (int i in listaInt)
        {
            Console.WriteLine(i);
        }

        //iniciando lista com elementos
        List<double> listaDouble = new List<double> { 2.5, 3, 8.2 };
        listaDouble.Add(1);

        Console.ReadKey();

    }

    static void ExemploListaObjetos()
    {
        List<Paciente> listaPacientes = new List<Paciente>();
        Paciente p1 = new Paciente(1, "Elias", "000.111.222-33", "elias@gami.com", new DateTime(1982, 07, 22));
        Paciente p2 = new Paciente(2, "Gio", "222.111.333-55", "gio@gami.com", new DateTime(2007, 01, 03)); 
        Paciente p3 = new Paciente(3, "vanessa", "265.565.151-33", "vanessa@gami.com", new DateTime(2006, 02, 01));
        Paciente p4 = new Paciente(4, "kauany", "050.004.062-75", "kauany@gami.com", new DateTime(2005, 12, 23));
        Paciente p5 = new Paciente(5, "shay", "542.989.257-59", "shay@gami.com", new DateTime(1448, 03, 12));
  
        listaPacientes.Add(p1);
        listaPacientes.Add(p2);
        listaPacientes.Add(p3);
        listaPacientes.Add(p4);
        listaPacientes.Add(p5);

        //o metodo orderBy ordena uma lista a partir de determinado atributo 
        //esse metodo retorna uma lista ordenda(precisa armazenar esse resultado )
        //ToList() converte o resultado para uma lista
        //caso queira apresentar a nova lista ordenada, somente percorre-la
        //no exemplo, x.nome especifica que irá ordernar pelo atributo nome, pode ser qualquer atribuyo do objeto
        List<Paciente> pOrdenaadas = listaPacientes.OrderBy(p => p.nome).ToList();


        //Recupera feterminado elemento que contem o valor passado na expressão.
        //np exemplo, recupera o paciente que contem o cpf 000
        Paciente pCpf0 = listaPacientes.SingleOrDefault(x => x.cpf == "000");
        if(pCpf0 != null)
        {
            Console.WriteLine(pCpf0.nome);
        }else
        {
            Console.WriteLine("Paciente não encontrado!");
        }

        //o metodo Where é utilizado para selecionar todos que atende alguma expressão
        //no exemprlo abaixo, seleciona e armazena na lista busca todos os pacientes que possuem o valor Id maior que 2
        string nomeBusca = Console.ReadLine();
        List<Paciente> busca = listaPacientes.Where(x => x.nome.ToUpper() == nomeBusca.ToUpper()).ToList();


        foreach (Paciente p in busca)
        {
            Console.WriteLine($"{p.nome}, {p.cpf}, {p.Id}, {p.email}, {p.DataNasc}");

            /*if(p.cpf == "000")
            {
                Paciente pcpf00 = p;
            }*/
        }

        Console.ReadKey();
    }
}
