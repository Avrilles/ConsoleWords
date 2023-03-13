namespace words.Models
{
    internal class Word
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Translation { get; set; }
        public float Level { get; set; }

        public Word(Guid id, string title, string translation, float level)
        {
            Id = id;
            Title = title;
            Translation = translation;
            Level = level;
        }

        public override string ToString()
        {
            return $"{Title} - {Translation}";
        }
    }
}
