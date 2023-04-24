using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class FlashCardService
{
    private readonly FlashcardsDbContext _context;

    public FlashCardService(FlashcardsDbContext context)
    {
        _context = context;
    }

    public List<FlashCard> GetAllFlashCards()
    {
        return _context.FlashCards.ToList();
    }     

    public FlashCard PostFlashCards(FlashCard flashcard)
    {
        _context.FlashCards.Add(flashcard);
        _context.SaveChanges();
        return flashcard;
    }

    public FlashCard FlashCardbyId(int id)
    {
        return _context.FlashCards.FirstOrDefault(w => w.Id == id);
    }

    public FlashCard UpdateFlashCard(FlashCard flashcard)
    {
       _context.FlashCards.Update(flashcard);
        _context.SaveChanges();
        return flashcard;
    }

    public FlashCard DeleteFlashCard(FlashCard flashcard)
    {
        _context.FlashCards.Remove(flashcard);
        _context.SaveChanges();
        return flashcard;
    }
}