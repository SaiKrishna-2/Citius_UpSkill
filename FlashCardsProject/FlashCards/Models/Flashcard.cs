﻿namespace Models
{
    public class Flashcard
    {
        public Guid Id { get; set; }

        public string? Question { get; set; }

        public string? Answer { get; set; }
    }
}