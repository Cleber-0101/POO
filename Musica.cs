
using System.ComponentModel.Design;

class Musica
{
    public string NomedaMusca { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public bool Possuiplano { get; set; }

    //aplicando expressoes LAMBDA em C#
    //quero nessa expressão apenas informa 
    //propriedade somente de leitura que sera mostrada no Console 
    //Atribuindo somente o get tomamos o controle do codigo fazendo com que não consigam Atribuir valores a esse atributo 
    public string DescricaoResumida => $"A musica pertence a Banda {Artista}";


    //corportamento de uma musica criando um metodo
    public void ExibirfichaTecnica()
    {
        Console.WriteLine($"Nome: {NomedaMusca}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao} " + " min");  

        if (Disponivel)
        {
            Console.WriteLine($"A musica: ({NomedaMusca}) esta disponivel para dowload e em todas plataforma digitais");
        }
         if(Disponivel && Possuiplano)
        {
            Console.WriteLine("Livre acesso pra voce");
        }else
        {
            Console.WriteLine("voce não tem acesso a esta musica ");
        }
    }
}