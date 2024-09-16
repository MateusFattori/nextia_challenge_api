using Microsoft.AspNetCore.Mvc;
using nextia_challenge_api.Models;
using nextia_challenge_api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nextia_challenge_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocaoController : ControllerBase
    {
        private readonly IPromocaoRepository _promocaoRepository;

        public PromocaoController(IPromocaoRepository promocaoRepository)
        {
            _promocaoRepository = promocaoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Promocao>>> GetPromocoes()
        {
            var promocoes = await _promocaoRepository.GetAllAsync();
            return Ok(promocoes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Promocao>> GetPromocao(int id)
        {
            var promocao = await _promocaoRepository.GetByIdAsync(id);
            if (promocao == null)
            {
                return NotFound();
            }
            return Ok(promocao);
        }

        [HttpPost]
        public async Task<ActionResult<Promocao>> CreatePromocao(Promocao promocao)
        {
            if (promocao == null)
            {
                return BadRequest();
            }

            await _promocaoRepository.AddAsync(promocao);
            return CreatedAtAction(nameof(GetPromocao), new { id = promocao.Id }, promocao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePromocao(int id, Promocao promocao)
        {
            if (id != promocao.Id)
            {
                return BadRequest();
            }

            await _promocaoRepository.UpdateAsync(promocao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePromocao(int id)
        {
            await _promocaoRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
