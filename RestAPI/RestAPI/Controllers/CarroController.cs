using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestAPI.Controllers
{
    [RoutePrefix("api/carro")]
    public class CarroController : ApiController
    {
        private static List<CarroModel> listaCarros = new List<CarroModel>();

        [AcceptVerbs("POST")]
        [Route("CadastraCarro")]
        public string CadastrarUsuario(CarroModel usuario)
        {
            listaCarros.Add(usuario);

            return "Usuário cadastrado com sucesso!";
        }

        [AcceptVerbs("PUT")]
        [Route("AlterarCarro")]
        public string AlterarUsuario(CarroModel carro)
        {
            listaCarros.Where(n => n.codigo == carro.codigo)
                         .Select(s =>
                         {
                             s.codigo = carro.codigo;
                             s.marca = carro.marca;
                             s.modelo = carro.modelo;

                             return s;

                         }).ToList();



            return "Usuário alterado com sucesso!";
        }

        [AcceptVerbs("DELETE")]
        [Route("ExcluirCarro/{codigo}")]
        public string ExcluirUsuario(int codigo)
        {
            CarroModel carro = listaCarros.Where(n => n.codigo == codigo)
                                                .Select(n => n)
                                                .First();

            listaCarros.Remove(carro);

            return "Registro excluido com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarCarroPorCodigo/{codigo}")]
        public CarroModel ConsultarUsuarioPorCodigo(int codigo)
        {
            CarroModel carro = listaCarros.Where(n => n.codigo == codigo)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return carro;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarCarros")]
        public List<CarroModel> ConsultarUsuarios()
        {
            return listaCarros;
        }
    }
}
