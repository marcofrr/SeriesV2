using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Series.Models;

namespace Series.API
{

    //devolve todas as Series

    public class SeriesController : ApiController
    {
        private AppDb db = new AppDb();

        [HttpGet, Route("api/series")]
        public IHttpActionResult GetSeries()
        {
            var resultado = db.Series
                .Select(Series => new { Series.SerieId, Series.nomeId, Series.NomeSerie, Series.SerieImg }).ToList();

            if (resultado.Count == 0)
                return NotFound();

            return Ok(resultado);
        }

        [HttpGet, Route("api/series/{nomeId}")]
        public IHttpActionResult GetSerieDetalhes(string nomeId)
        {
            int serie = db.Series
                .Where(m => m.nomeId.ToLower().Contains(nomeId.ToLower()))
                .Select(m => m.SerieId).SingleOrDefault();

            object serieListar = db.Detalhes.FirstOrDefault(m => m.SerieId.Equals(serie));

            return Ok(serieListar);
        }

        [HttpGet, Route("api/series/{nomeId}/episodios")]
        public IHttpActionResult GetSerieEpisodios(string nomeId)
        {
            int serie = db.Series
                .Where(m => m.nomeId.ToLower().Contains(nomeId.ToLower()))
                .Select(m => m.SerieId).SingleOrDefault();

            object episodios = db.Episodios.Where(m => m.SerieId == serie).ToList();

            return Ok(episodios);
        }
        [HttpGet, Route("api/series/pessoas/{nome}")]
        public IHttpActionResult GetPessoas(string nome)
        {
            IQueryable<Pessoas> query = db.Pessoas;

            if (nome != null)
            {
                query = query
                    .Where(m => m.PessoaNome.ToLower().Contains(nome.ToLower()));
            }
            object resultado = query
                .Select(m => new
                {
                    m.PessoaId,
                    m.PessoaNome,
                    m.DataNasc,
                    m.Role,
                    m.Texto,
                    m.ListaProjetos,
                    m.Img,
                    m.Link

                });
            return Ok(resultado);
        }

    }
}