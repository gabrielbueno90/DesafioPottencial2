using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPottencial.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesafioPottencial.Context
{
    public class TabelaVendedor : DbContext
    {
       public TabelaVendedor (DbContextOptions<TabelaVendedor> options) : base(options) 
       {
         
       }  

       public DbSet<CadastroVendedor> Vendedores { get; set; }
       
    }
}