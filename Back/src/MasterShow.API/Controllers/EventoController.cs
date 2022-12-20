using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MasterShow.API.Models;

namespace MasterShow.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[]
            {
                new Evento() {
                    EventoId = 1,
                    Tema = "Teste frontend",
                    Local = "Araçatuba",
                    Lote = "1° lote TESTE",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },

                new Evento() {
                    EventoId = 2,
                    Tema = "Teste frontend 2",
                    Local = "Birigui",
                    Lote = "2° lote TESTE",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                }
        };
        

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
        return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
