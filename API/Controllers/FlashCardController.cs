using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
using DataAccess.Entities;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]

public class FlashCardController : ControllerBase
{
    private readonly ILogger<FlashCardController> _logger;

    private readonly FlashCardService _repo;

    public FlashCardController(ILogger<FlashCardController> logger, FlashCardService repo)
    {
        _logger = logger;
        _repo = repo;
    }

    [HttpGet("All")]
    public List<FlashCard> GetAllFlashCard()
    {
        return _repo.GetAllFlashCards();
    }

    [HttpPost("add")]
    public FlashCard AddFlashCard(FlashCard flashcard)
    {
        return _repo.PostFlashCards(flashcard);
    }

    [HttpGet("{id}")]
    public FlashCard GetFlashCardbyId(int id)
    {
        return _repo.FlashCardbyId(id);
    }

    [HttpPut("update")]
    public FlashCard UpdateFlashCardbyId(FlashCard flashcard)
    {
        return _repo.UpdateFlashCard(flashcard);
    }

    [HttpDelete("delete")]
    public FlashCard DeleteFlashCardbyId(FlashCard flashcard)
    {
        return _repo.DeleteFlashCard(flashcard);
    }
}
