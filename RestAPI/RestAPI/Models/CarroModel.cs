using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestAPI.Models
{
    public class CarroModel
    {
        public CarroModel()
        {
        }

        public CarroModel(int codigo, string marca, string modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.modelo = modelo;
        }

        public int codigo;

        public string marca;

        public string modelo;

    }
}