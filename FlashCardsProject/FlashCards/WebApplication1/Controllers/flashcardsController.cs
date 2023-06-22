using BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class flashcardsController : ControllerBase
    {
        private readonly IFlashCards logic;
        public flashcardsController(IFlashCards fc)
        {
            logic = fc;
        }

        [HttpGet("getAll")]
        public IActionResult getAllFlashCards()
        {
            try
            {
                var result = logic.GetAllFlashcard();
                if (result != null)
                {
                    return Ok(result);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("getById")]
        public IActionResult getFlashCards(Guid id)
        {
            try
            {
                var result = logic.GetFlashcard(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
           
        }
        [HttpPost("add")]
        public IActionResult addFlashCard(Flashcard card)
        {
            try
            {
                var result = logic.AddFlashcard(card);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("edit")]
        public IActionResult editFlashCard([FromBody]Flashcard card,[FromHeader]Guid id)
        {
            try
            {
                var result = logic.EditFlashcard(card,id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete")]
        public IActionResult deleteFlashCard(Guid id)
        {
            try
            {
                var result = logic.DeleteFlashcard( id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                { return BadRequest(); }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
