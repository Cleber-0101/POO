////CONCEITO DE MUSICA

////o que uma musica tem ?
////Nome 
////artista
////duração
////disponivel


//Criando uma musica de acordo com a classe de criação aonde contem os moldes que toda musica tem 
Musica  musica1 = new Musica();
musica1.NomedaMusca = "È ele";
musica1.Artista = "Banda Drop";
musica1.Duracao = 10;
musica1.Disponivel = true;
musica1.Possuiplano = true;
Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.NomedaMusca = "teste criação de musicas";
musica2.Artista = "Banda teste";
musica2.Duracao = 100;
musica2.Disponivel = false;
musica2.Possuiplano = true;

musica1.ExibirfichaTecnica();
musica2.ExibirfichaTecnica();

