using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace BusinessLogic
{
    internal interface IFlashCards
    {
        Flashcard GetALlFlashcard();
        Flashcard GetFlashcard(Guid id);
        Flashcard AddFlashcard(Flashcard f);
        Flashcard EditFlashcard(Flashcard f,Guid id);
        Flashcard DeleteFlashcard(Guid id);
    }
}
