using Entities;
using Entities.Entities;
using Models;
using Entities.Entities;

namespace BusinessLogic
{
    public class Flashcardlogic : IFlashCards
    {
        private readonly IEFRepo repo;
        private readonly Project1Context context;

        public Flashcardlogic(IEFRepo _repo, Project1Context _context)
        {
            repo = _repo;
            context = _context;
        }
        public Models.Flashcard AddFlashcard(Models.Flashcard f)
        {
            return Mapper.FlashcardMapper(repo.AddFlashcard(Mapper.FlashcardMapper(f)));
        }

        public Models.Flashcard DeleteFlashcard(Guid id)
        {
            return Mapper.FlashcardMapper(repo.DeleteFlashcard(id));
        }

        public Models.Flashcard EditFlashcard(Models.Flashcard f, Guid id)
        {
            var card = context.Flashcards.Where(f => f.Id == id).FirstOrDefault();
            card.Answer = f.Answer;
            card.Question = f.Question;
            return Mapper.FlashcardMapper(repo.EditFlashcard(card));
        }

        public IEnumerable<Models.Flashcard> GetAllFlashcard()
        {
            return Mapper.FlashcardMapper(repo.GetAllFlashcard());
        }

        public Models.Flashcard GetFlashcard(Guid id)
        {
            return Mapper.FlashcardMapper(repo.GetFlashcard(id));

        }
    }
}