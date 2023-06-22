using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;

namespace Entities
{
    public interface IEFRepo
    {
        IEnumerable<Flashcard> GetAllFlashcard();
        Flashcard GetFlashcard(Guid id);
        Flashcard AddFlashcard(Flashcard f);
        Flashcard EditFlashcard(Flashcard f, Guid id);
        Flashcard DeleteFlashcard(Guid id);
    }
}

