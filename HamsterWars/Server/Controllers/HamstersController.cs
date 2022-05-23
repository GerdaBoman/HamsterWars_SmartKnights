using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using HamsterWars.Shared.Models;
using DataAccess.Data;
using HamsterWars.Server.Repository;

namespace HamsterWars.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly IHamsterRepository _hamsterRepository;

        public HamstersController(IHamsterRepository hamsterRepository)
        {
            _hamsterRepository = hamsterRepository;
        }

        // GET: api/Hamsters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamster()
        {
          try
            {
                return Ok(await _hamsterRepository.GetHamsters());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        // GET: api/Hamsters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hamster>> GetHamster(int id)
        {
            try
            {
                var result = await _hamsterRepository.GetSingleHamster(id);
                if (result == null) return NotFound();
                return result;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        // GET: api/Hamsters/random
        [HttpGet("random")]
       
        public async Task<ActionResult<Hamster>> GetHamsterRandom()
        {
            try
            {
                var result = await _hamsterRepository.GetRandomHamster();
                if (result == null) return NotFound();
                return result;
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        // PUT: api/Hamsters/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Hamster>> UpdateHamster(int id, Hamster hamster)
        {
            try
            {
                if (id != hamster.Id)
                {
                    return BadRequest("Hamster ID does not match");
                }

                var updateHamster = await _hamsterRepository.GetSingleHamster(id);

                if(updateHamster.Id == null)
                {
                    return NotFound($"Hamster with ID = {id} not found");
                }

                return await _hamsterRepository.UpdateHamster(hamster);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating data");

            }
        }

        // POST: api/Hamsters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hamster>> CreateHamster(Hamster hamster)
        {
            try
            {
                if(hamster == null)
                {
                    return BadRequest();
                }
                var newHamster = await _hamsterRepository.CreateNewHamster(hamster);
                return CreatedAtAction(nameof(GetHamster),
                       new { id = newHamster.Id }, newHamster);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error creating new employee record");
            }
        }

        // DELETE: api/Hamsters/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Hamster>> DeleteHamster(int id)
        {
            try
            {
                var hamsterToDelete = await _hamsterRepository.GetSingleHamster(id);

                if (hamsterToDelete == null)
                {
                    return NotFound($"Hamster with Id = {id} not found");
                }

                return await _hamsterRepository.DelelteHamster(id);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
            }
        }

       
    }
}
