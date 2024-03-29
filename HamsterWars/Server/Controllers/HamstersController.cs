﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAccess.Data;
using HamsterWars.Shared.Entity;
using HamsterWars.Server.Interface;

namespace HamsterWars.Server.Controllers
{
    [Route("matches")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly IHamsterRepository _hamsterRepository;

        public HamstersController(IHamsterRepository hamsterRepository)
        {
            _hamsterRepository = hamsterRepository;
        }

        // GET: matches
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hamster>>> GetHamster()
        {
          try
            {
                return Ok(await _hamsterRepository.GetHamsters());
            }
            catch
            {
                return StatusCode(StatusCodes.Status404NotFound,
                    "No hamsters found in database");
            }
        }

        // GET: matches/5
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
                return StatusCode(StatusCodes.Status404NotFound,
                     "No hamster with that ID found in database");
            }
        }

        // GET: matches/random
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
                return StatusCode(StatusCodes.Status404NotFound,
                     "No hamsters found in database");
            }
        }

        // PUT: matches/5
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

        // POST: matches
    
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
                "Error creating new hamster");
            }
        }

        // DELETE: matches/5
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
                return StatusCode(StatusCodes.Status404NotFound,
                    "No hamster with that ID found in database");
            }
        }


        [HttpGet("losers")]
     
        public async Task<IEnumerable<Hamster>> GetTo5Losers()
        {
            var hamsterList = await _hamsterRepository.GetTop5Losers();
            var losers = hamsterList.OrderByDescending(h => h.Losses/h.Games)
                                                   .Take(5).ToList();
            return losers;
        }

        [HttpGet("winners")]

        public async Task<IEnumerable<Hamster>> GetTo5Winners()
        {
            var hamsterList = await _hamsterRepository.GetTop5Winners();
            var winners = hamsterList.OrderByDescending(h => h.Wins/h.Games)
                                                   .Take(5).ToList();
            return winners;
        }


    }
}
