using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Activo { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Activo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
