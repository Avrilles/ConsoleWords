namespace words.Models
{
    internal class Word
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Translation { get; set; }
        public float Level { get; set; }
        public string Example { get; set; }

        public Word(Guid id, string title, string translation, float level, string example)
        {
            Id = id;
            Title = title;
            Translation = translation;
            Level = level;
            Example = example;
        }

        public override string ToString()
        {
            return $"{Title} - {Translation} : {Level}%";
        }
    }
}
