using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DesafioPottencial.Entities.StattusCompra;

namespace DesafioPottencial.Entities
{
    public class CadastroVendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public string ItemVendido { get; set; }
        public EnumStattusCompra Status { get; set; }
    }
}