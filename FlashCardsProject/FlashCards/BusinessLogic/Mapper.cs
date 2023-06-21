using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Entities;
using Models;

namespace BusinessLogic
{
    internal  class Mapper
    {
        public static Models.Flashcard FlashcardMapper(Entities.Entities.Flashcard f)
        {
            return new Models.Flashcard()
            {
                Id=f.Id,
                Question=f.Question,
                Answer=f.Answer,
            };
        }
        public static Entities.Entities.Flashcard FlashcardMapper(Models.Flashcard f)
        {
            return new Entities.Entities.Flashcard()
            {
                Id = f.Id,
                Question = f.Question,
                Answer = f.Answer,
            };
        }
    }
}
