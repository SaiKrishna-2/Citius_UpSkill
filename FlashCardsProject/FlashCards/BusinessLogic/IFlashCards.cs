using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLogic
{
    public interface IFlashCards
    {
        public IEnumerable<Flashcard> GetAllFlashcard();
        public Flashcard GetFlashcard(Guid id);
        public Flashcard AddFlashcard(Flashcard f);
        public Flashcard EditFlashcard(Flashcard f,Guid id);
        public Flashcard DeleteFlashcard(Guid id);
    }
}
