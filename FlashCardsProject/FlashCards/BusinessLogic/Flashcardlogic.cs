using Entities;
using Models;

namespace BusinessLogic
{
    public class Flashcardlogic : IFlashCards
    {
        private readonly IEFRepo repo;
        public Flashcardlogic(IEFRepo _repo)
        {
            repo = _repo;           
        }
        public Flashcard AddFlashcard(Flashcard f)
        {
            return Mapper.FlashcardMapper(repo.AddFlashcard(Mapper.FlashcardMapper(f)));
        }

        public Flashcard DeleteFlashcard(Guid id)
        {
            return Mapper.FlashcardMapper(repo.DeleteFlashcard(id));
        }

        public Flashcard EditFlashcard(Flashcard f, Guid id)
        {
            return Mapper.FlashcardMapper(repo.EditFlashcard(Mapper.FlashcardMapper(f),id));
        }

        public IEnumerable<Flashcard> GetAllFlashcard()
        {
            return Mapper.FlashcardMapper(repo.GetAllFlashcard());
        }

        public Flashcard GetFlashcard(Guid id)
        {
            return Mapper.FlashcardMapper(repo.GetFlashcard(id));

        }
    }
}