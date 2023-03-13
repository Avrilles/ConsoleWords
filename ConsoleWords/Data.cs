using words.Models;

namespace words
{
    static class Data
    {
        public static List<Language> getLanguageWithWords()
        {
            var engWords = new List<Word>()
            {
                new Word(Guid.NewGuid(), "Word", "Слово", 30, ""),
                new Word(Guid.NewGuid(), "Green", "Зелений", 10, ""),
                new Word(Guid.NewGuid(), "Red", "Червоний", 30, ""),
                new Word(Guid.NewGuid(), "Black", "Чорний", 0, ""),
            };

            var ukrWords = new List<Word>()
            {
                new Word(Guid.NewGuid(), "Слово", "Word", 60, ""),
                new Word(Guid.NewGuid(), "Зелений", "Green", 20, ""),
                new Word(Guid.NewGuid(), "Червоний", "Red", 0, ""),
                new Word(Guid.NewGuid(), "Чорний", "Black", 50, ""),
            };

            return new List<Language>()
            {
                new Language(Guid.NewGuid(), "English", engWords, engGroups),
                new Language(Guid.NewGuid(), "Ukrainian", ukrWords, ukrGroups),
            };
        }
    }
}
