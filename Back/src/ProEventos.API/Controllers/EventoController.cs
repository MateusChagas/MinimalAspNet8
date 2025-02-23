using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {     
        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento() {
                EventoId = 1,
                Local = "Belo Horizonte",
                DataEvento = "20/08/2021",
                Tema = "Angular e .NET 5",
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImageURL = "foto.jpg"
            },
            new Evento() {
                EventoId = 2,
                Local = "São Paulo",
                DataEvento = "20/08/2021",
                Tema = "Angular e suas novidades",
                QtdPessoas = 350,
                Lote = "2º Lote",
                ImageURL = "foto.jpg"
            }
        };

        public EventoController()
        {            
        }

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
    }
}
