using Entities.Entities;
using Microsoft.EntityFrameworkCore.Query;

namespace Entities
{
    public class EFRepo : IEFRepo
    {
        private readonly Project1Context context;
        public EFRepo(Project1Context context)
        {
            this.context = context;
        }
        public Flashcard AddFlashcard(Flashcard f)
        {
            context.Flashcards.Add(f);
            context.SaveChanges();
            return (f);
        }

        public Flashcard DeleteFlashcard(Guid id)
        {
            var card = context.Flashcards.Where(f => f.Id == id).FirstOrDefault();
            context.Flashcards.Remove(card);
            context.SaveChanges();
            return(card);
        }

        public Flashcard EditFlashcard(Flashcard f, Guid id)
        {
            context.Flashcards.Update(f);
            context.SaveChanges();
            return (f);
        }

        public IEnumerable<Flashcard> GetAllFlashcard()
        {
            return context.Flashcards;
        }

        public Flashcard GetFlashcard(Guid id)
        {
            return context.Flashcards.Where(f=>f.Id==id).FirstOrDefault();
        }
    }
}