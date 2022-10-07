using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DesafioPottencial.Entities;
using DesafioPottencial.Context;

namespace DesafioPottencial.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioVendedorController : ControllerBase
    {
        private readonly TabelaVendedor _context;

        public UsuarioVendedorController(TabelaVendedor context)
        {
            _context = context;
        }
        
        [HttpPost]
        public IActionResult Create (CadastroVendedor cadastro)
        {
            _context.Add(cadastro);
            _context.SaveChanges();
            return Ok(cadastro);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            
            var TabelaVendedor = _context.Vendedores.Find(id);
            
            if (TabelaVendedor == null)
                return NotFound();
            
            return Ok(TabelaVendedor);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, CadastroVendedor cadastro)
        {
            var TabelaVendedor = _context.Vendedores.Find(id);
            if (TabelaVendedor == null)
                return NotFound();

            TabelaVendedor.Status = cadastro.Status;
            _context.Vendedores.Update(TabelaVendedor);
            _context.SaveChanges();
            return Ok(TabelaVendedor);
        }

    
    }
}