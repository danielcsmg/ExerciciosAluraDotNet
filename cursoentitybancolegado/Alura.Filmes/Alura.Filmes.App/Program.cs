using System;
using System.Data.SqlClient;
using System.Linq;
using Alura.Filmes.App.Dados;
using Alura.Filmes.App.Extensions;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AluraFilmesContexto())
            {
                //Método de extensão para mostrar o log da query SQL
                contexto.LogSQLToConsole();

                //var actor = new Ator
                //{
                //    PrimeiroNome = "Tom",
                //    UltimoNome = "Holland"
                //};
                //É possível inserir uma Shadow Property assim
                //contexto.Entry(actor).Property("last_update").CurrentValue = DateTime.Now;

                //contexto.Atores.Add(actor);
                //contexto.SaveChanges();

                //----------***----------------
                // Consulta

                //var ator = contexto.Filmes
                //    .Include(f => f.Atores)
                //    .ThenInclude(fa => fa.Ator)
                //    .First();


                //var dataUpdate = contexto.Entry(ator).Property("last_update").CurrentValue;
                //Console.WriteLine(ator + " - " + dataUpdate);

                //foreach(var item in ator.Atores)
                //{
                //    Console.WriteLine(item.Ator);
                //}

                //var filmesEIdiomas = contexto.Idiomas
                //                        .Include(i => i.FilmesFalados)
                //                        .ToList();

                //foreach (var idioma in filmesEIdiomas)
                //{
                //    Console.WriteLine(idioma);

                //    foreach (var filme in idioma.FilmesFalados)
                //    {
                //        Console.WriteLine(filme);
                //    }
                //    Console.WriteLine();
                //}
                //var texto = Classificacao.MaiorQue13.ParaString().ParaValor();

                var filme = new Filme
                {
                    Titulo = "Senhor dos Aneis 3",
                    Descricao = "Description",
                    Duracao = 120,
                    AnoLancamento = "2000",
                    Classificacao = Classificacao.Livre, // Só aceita a regra da Migration CriarSQLRestriction
                    IdiomaFalado = contexto.Idiomas.First()
                };
                contexto.Entry(filme).Property("last_update").CurrentValue = DateTime.Now;

                contexto.Filmes.Add(filme);
                contexto.SaveChanges();

                Console.WriteLine("Clientes:");
                foreach (var cliente in contexto.Cliente)
                {
                    Console.WriteLine(cliente);
                }

                Console.WriteLine("\nFuncionários");
                foreach (var func in contexto.Funcionarios)
                {
                    Console.WriteLine(func);
                }

                //var sql = @"select a.*
                //            from actor a
                //            inner join top5_most_starred_actors
                //            filmes on filmes.actor_id = a.actor_id";

                //var atoresMaisAtuantes = contexto.Atores
                //    .FromSql(sql)
                //    .Include(a => a.Filmografia);

                //foreach (var ator in atoresMaisAtuantes)
                //{
                //    Console.WriteLine($"O ator {ator.PrimeiroNome} {ator.UltimoNome} atuou em {ator.Filmografia.Count} filmes");
                //};

                //var categ = "Action"; //36

                //var paramCateg = new SqlParameter("category_name", categ);

                //var paramTotal = new SqlParameter
                //{
                //    ParameterName = "@total_actors",
                //    Size = 4,
                //    Direction = System.Data.ParameterDirection.Output
                //};

                //                contexto.Database
                //                    .ExecuteSqlCommand("total_actors_from_given_category @category_name, @total_actors OUT", paramCateg, paramTotal);

                //System.Console.WriteLine($"O total de atores na categoria {categ} é de {paramTotal.Value}.");
            }
        }
    }
}