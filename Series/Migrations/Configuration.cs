namespace Series.Migrations
{
    using Series.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AppDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDb context)
        {

            var videos = new List<Videos>
            {
                new Videos
                {
                    VideoId=1,
                    Video="YQeUmSD1c3g",
                    Titulo="Dexter|Official Trailer|SHOWTIME Series",
                },
                new Videos
                {
                    VideoId=2,
                    Video="DU1VzaoW_DM",
                    Titulo="OfficialDexter:Slice Game Trailer SHOWTIME",
                },
                new Videos
                {
                    VideoId=3,
                    Video="6ER-0IPJf_0",
                    Titulo="Dexter | Behind Episode #412 'The Getaway' | SHOWTIME Series",
                },
                new Videos
                {
                    VideoId=4,
                    Video="KTu8iDynwNc",
                    Titulo="Lost Trailer (First Season)",
                },
                new Videos
                {
                    VideoId=5,
                    Video="x80aRLFK1x4",
                    Titulo="LOST Season 1 Trailer",
                },
                new Videos
                {
                    VideoId=6,
                    Video="72kQIIDBIUU",
                    Titulo="Lost Trailer",
                },
                new Videos
                {
                    VideoId=7,
                    Video="HhesaQXLuRY",
                    Titulo="Breaking Bad Trailer (First Season)",
                },
                new Videos
                {
                    VideoId=8,
                    Video="Xs6_vecSv2Y",
                    Titulo="Breaking Bad Greatest Moments",
                },
                new Videos
                {
                    VideoId=8,
                    Video="Hsvqk8NvEgs",
                    Titulo="MythBusters- Breaking Bad",
                },

            };
            videos.ForEach(zz => context.Videos.AddOrUpdate(z => z.VideoId, zz));
            context.SaveChanges();

            var series = new List<Series>
            {
                new Series{SerieId=1,nomeId="dexter",NomeSerie="Dexter",SerieImg="/img/img1.jpg"},
                new Series{SerieId=2,nomeId="lost",NomeSerie="Lost",SerieImg="/img/img2.jpg"},
                new Series{SerieId=3,nomeId="breakingBad",NomeSerie="Breaking Bad",SerieImg="/img/img3.jpg"},
                new Series{SerieId=4,nomeId="narcos",NomeSerie="Narcos",SerieImg="/img/img4.jpg"},
                new Series{SerieId=5,nomeId="personOfInterest",NomeSerie="Person Of Interest",SerieImg="/img/img5.jpg"},
                new Series{SerieId=6,nomeId="prisonBreak",NomeSerie="Prison Break",SerieImg="/img/img6.jpg"}
            };
            series.ForEach(aa => context.Series.AddOrUpdate(a => a.SerieId, aa));
            context.SaveChanges();



            var episodios = new List<Episodios>
            {
                new Episodios
                {
                    EpisodioId=1,
                    NEpisodio=1,
                    Temporada=1,
                    Img="/img/ep1.jpg",
                    SerieId=1,
                    Episodio="ej8-Rqo-VT4",
                    Titulo= "Dexter"

                },
                new Episodios
                {
                    EpisodioId=2,
                    NEpisodio=2,
                    Temporada=1,
                    Img="/img/ep2.jpg",
                    SerieId=1,
                    Episodio="gfu93WZ6HXQ",
                    Titulo= "Crocodile"

                },
                new Episodios
                {
                    EpisodioId=3,
                    NEpisodio=3,
                    Temporada=1,
                    Img="/img/ep3.jpg",
                    SerieId=1,
                    Episodio="XrWSsutP6ZY",
                    Titulo="Popping Cherry"

                },
                new Episodios
                {
                    EpisodioId=4,
                    NEpisodio=4,
                    Temporada=1,
                    Img="/img/ep4.jpg",
                    SerieId=1,
                    Episodio="hENKlm03uII",
                    Titulo="Let's Give the Boy a Hand"

                },
                new Episodios
                {
                    EpisodioId=5,
                    NEpisodio=5,
                    Temporada=1,
                    Img="/img/ep5.jpg",
                    SerieId=1,
                    Episodio="zsJt5jJB0bA",
                    Titulo="Love American Style"

                },
                new Episodios
                {
                    EpisodioId=6,
                    NEpisodio=1,
                    Temporada=1,
                    Img="/img/lostEp.jpg",
                    SerieId=2,
                    Episodio="luXl7AnGpKw",
                    Titulo="Pilot: Part 1"

                },
                new Episodios
                {
                    EpisodioId=7,
                    NEpisodio=2,
                    Temporada=1,
                    Img="/img/lostEp.jpg",
                    SerieId=2,
                    Episodio="gOTie7wKxlk",
                    Titulo="Pilot: Part 2"

                },
                new Episodios
                {
                    EpisodioId=8,
                    NEpisodio=3,
                    Temporada=1,
                    Img="/img/lostEp.jpg",
                    SerieId=2,
                    Episodio="luXl7AnGpKw",
                    Titulo="Tabula Rasa"

                },
                new Episodios
                {
                    EpisodioId=9,
                    NEpisodio=4,
                    Temporada=1,
                    Img="/img/lostEp.jpg",
                    SerieId=2,
                    Episodio="GdT8eqMO4qk",
                    Titulo="Walkaabout"

                },
                new Episodios
                {
                    EpisodioId=10,
                    NEpisodio=5,
                    Temporada=1,
                    Img="/img/lostEp.jpg",
                    SerieId=2,
                    Episodio="xlCAfYGwUmk",
                    Titulo="White Rabbit"

                },
                new Episodios
                {
                    EpisodioId=11,
                    NEpisodio=1,
                    Temporada=1,
                    Img="/img/ep6.jpg",
                    SerieId=3,
                    Episodio="KmooAO8eiKE",
                    Titulo="Pilot"

                },
                new Episodios
                {
                    EpisodioId=12,
                    NEpisodio=2,
                    Temporada=1,
                    Img="/img/ep7.jpg",
                    SerieId=3,
                    Episodio="0Mi3XFfAiCU",
                    Titulo="Cats in the Bag..."

                },
                new Episodios
                {
                    EpisodioId=13,
                    NEpisodio=3,
                    Temporada=1,
                    Img="/img/ep8.jpg",
                    SerieId=3,
                    Episodio="jY8MsF4vr9U",
                    Titulo="...And the Bags in the River"

                },
                new Episodios
                {
                    EpisodioId=14,
                    NEpisodio=4,
                    Temporada=1,
                    Img="/img/ep9.jpg",
                    SerieId=3,
                    Episodio="0DalqD-12NM",
                    Titulo="Cancer Man"

                },
                new Episodios
                {
                    EpisodioId=15,
                    NEpisodio=5,
                    Temporada=1,
                    Img="/img/ep10.jpg",
                    SerieId=3,
                    Episodio="qaaYEi9sxeQ",
                    Titulo="Gray Matter"

                }



            };
            episodios.ForEach(cc => context.Episodios.AddOrUpdate(c => c.EpisodioId, cc));
            context.SaveChanges();

            var detalhes = new List<Detalhes>
            {
                new Detalhes {SerieId=1,Nome="Dexter",Temporadas=8,NEpisodios=12, Realizador="James Manos Jr.", Elenco="Michael C. Hall, Jennifer Carpenter, David Zayas, James Remar.", Desc="Baseada na obra de Jeff Lindsay, " +
                "a série tem como protagonista um especialista " +
                "forense em amostras de sangue, que trabalha para o Departamento de Polícia de Miami.Ele também é um assassino serial que mata as pessoas que a polícia " +
                "não consegue prender. A dupla identidade tem de ser escondida de todos, " +
                "incluindo sua irmã e companheiros de trabalho.Na infância, órfão aos quatro anos, Dexter é adotado por um policial que logo detecta sua tendência homicida.",SerieImg="/img/img1.jpg",Rating=8,Link="https://www.imdb.com/title/tt0773262/",
                 ListaEpisodios=new List<Episodios>{episodios[0],episodios[1], episodios[2], episodios[3], episodios[4]},
                 ListaDeVideos=new List<Videos>{videos[0], videos[1] , videos[2] }
                },
                new Detalhes {SerieId=2,Nome="Lost",Temporadas=6,NEpisodios=118, Realizador="J.J. Abrams, Jeffrey Lieber, Damon Lindelof", Elenco=" Jorge Garcia, Josh Holloway, Yunjin Kim", Desc="O voo 815 da companhia aérea Oceanic Airlines,"+
                " cai na costa do que aparenta ser uma ilha tropical deserta, "+
                "forçando o grupo de estranhos a trabalhar em conjunto para se manterem vivos.No entanto, a sua sobrevivência é"+
                " ameaçada por vários mistérios, incluindo uma escotilha metálica enterrada no solo, uma criatura que vagueia pela selva e"+
                " os habitantes da ilha conhecidos como ,Os Outros.Os sobreviventes descobrem que um dos seus não é quem parece ser e encontram "+
                "uma mulher francesa chamada Danielle Rousseau, cuja equipe naufragou há 16 anos.",SerieImg="/img/img2.jpg",Rating=9,Link="https://www.imdb.com/title/tt0411008/",
                ListaDeVideos =new List<Videos>{videos[3], videos[4] , videos[5]},
                ListaEpisodios =new List<Episodios>{episodios[5],episodios[6], episodios[7], episodios[8], episodios[9]}},
                new Detalhes {SerieId=3,Nome="Breaking Bad",Temporadas=5,NEpisodios=62, Realizador="Vince Gilligan", Elenco="Aaron Paul, Anna Gunn, Bryan Cranston, Dean Norris,", Desc="Bryan Cranston, é a estrela da série no papel de Walter White, "+
                "um professor de química que leva uma vida difícil e luta para pagar as contas, sustentar a esposa"+
                " (Anna Gunn) e o filho, que tem dificuldades físicas (RJ Mitte). A sua vida inteira muda diante de um diagnóstico perturbador,"+
                " cancro do pulmão sem possibilidade de cura. Com poucos anos de vida e nada mais a perder, Walter usa os seus conhecimentos de química"+
                " para fazer e vender metanfetamina com um dos seus ex-alunos(Aaron Paul).",SerieImg="/img/img3.jpg", ListaDeVideos=new List<Videos>{videos[6], videos[7] , videos[8]},
                ListaEpisodios=new List<Episodios>{episodios[10],episodios[11], episodios[12], episodios[13], episodios[14]},Rating=9,Link="https://www.imdb.com/title/tt0903747/?ref_=nv_sr_1"},
                new Detalhes {SerieId=4,Nome="Narcos",Temporadas=3,NEpisodios=40, Realizador="Carlo Bernard, Chris Brancato, Doug Miro, Paul Eck", Elenco="Pedro Pascal, Wagner Moura, Boyd Holbrook, Joanna Christie", Desc="Narcos é a história real dos esforços dos Estados Unidos e Colômbia "+
                "para combater o temido cartel de Medellín, uma das organizações criminosas mais ricas e impiedosas da história. "+
                "A trama gira em torno no traficante Pablo Escobar (Wagner Moura), retratando a ascensão dele de um criminoso comum"+
                " para um dos homens mais perigosos, procurados e ricos do mundo.", SerieImg="/img/img4.jpg"},
                new Detalhes {SerieId=5,Nome="Person of Interest",Temporadas=5,NEpisodios=103, Realizador="Jonathan Nolan", Elenco="Jim Caviezel, Michael Emerson, Kevin Chapman, Taraji P. Henson", Desc="Após o ataque terrorista de 11 de setembro, Mr. Finch é chamado para desenvolver uma máquina "+
                "capaz de organizar informações e prevenir possíveis ameaças à segurança nacional em Nova York, ou seja, um equipamento "+
                "que «prevê crimes».Porém, a máquina descarta os crimes considerados irrelevantes. Para ajudar na tarefa de salvar aquelas"+
                " pessoas ligadas aos crimes menores, Finch contata John Reese, um antigo membro da CIA que, de acordo com informações oficiais, está morto.", SerieImg="/img/img5.jpg"},
                new Detalhes {SerieId=6,Nome="Prison Break",Temporadas=3,NEpisodios=40, Realizador="Carlo Bernard, Chris Brancato, Doug Miro, Paul Eck", Elenco="Pedro Pascal, Wagner Moura, Boyd Holbrook, Joanna Christie", Desc="Narcos é a história real dos esforços dos Estados Unidos e Colômbia "+
                "para combater o temido cartel de Medellín, uma das organizações criminosas mais ricas e impiedosas da história. "+
                "A trama gira em torno no traficante Pablo Escobar (Wagner Moura), retratando a ascensão dele de um criminoso comum"+
                " para um dos homens mais perigosos, procurados e ricos do mundo.",SerieImg="/img/img6.jpg"}



            };

            detalhes.ForEach(bb => context.Detalhes.AddOrUpdate(b => b.SerieId, bb));
            context.SaveChanges();

            var projetos = new List<Projetos>
            {
                new Projetos
                {
                    ProjetoId=1,
                    Ano="(2006-2013)",
                    Img="/img/img1.jpg",
                    Titulo="Dexter",
                    Link="https://www.imdb.com/title/tt0773262/?ref_=nm_knf_i1"

                },
                new Projetos
                {
                    ProjetoId=2,
                    Ano="(1999)",
                    Img="/img/img7.jpg",
                    Titulo="The Sopranos",
                    Link="https://www.imdb.com/title/tt0141842/?ref_=nm_knf_i2"

                },
                new Projetos
                {
                    ProjetoId=3,
                    Ano="(2002-2003)",
                    Img="/img/img8.jpg",
                    Titulo="The Shield",
                    Link="https://www.imdb.com/title/tt0286486/?ref_=nm_knf_i3"

                }
            };
            projetos.ForEach(hh => context.Projetos.AddOrUpdate(h => h.ProjetoId, hh));
            context.SaveChanges();


            var pessoas = new List<Pessoas>
            {
                new Pessoas{PessoaId=1,PessoaNome="Bryan Cranston",Role="Actor|Produtor|Argumentista",
                    Texto ="Bryan Lee Cranston (Los Angeles, 7 de março de 1956) é um premiado ator,diretor e produtor norte-americano, conhecido por interpretar Hal na " +
                    "série cómica da Fox Malcolm in the Middle, Dr. Tim Whatley na série da NBC Seinfield e Walter White na série dramática da AMC Breaking Bad," +
                    " pela qual ele venceu quatro Emmys do Primetime de Melhor Ator em Série Dramática.",DataNasc="Março 7, 1956 em Hollywood, California, USA",
                    

                },
                new Pessoas{PessoaId=2,PessoaNome="James Manos Jr.",Role="Actor|Produtor|Argumentista",
                    Texto ="James recebeu o diploma de diretor de teatro pela Universidade Colgate em Hamilton, Nova York, " +
                    "e mais tarde também na Real Academia de Arte Dramática, Londres, Inglaterra. Estudou teatro e mais tarde " +
                    "deu aulas de teatro em Nova York.Quando jovem, foi um jogador de destaque no basquete da Poly Prep Country Day School, no Brooklyn, New York.",DataNasc="Março 7, 1956 em Hollywood, California, USA",
                    ListaProjetos=new List<Projetos>{projetos[0], projetos[1], projetos[2]}, Link="https://www.imdb.com/name/nm0543612/?ref_=tt_ov_wr",Img="/img/img9.jpg",
                }

            };
            pessoas.ForEach(gg => context.Pessoas.AddOrUpdate(g => g.PessoaId, gg));
            context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
