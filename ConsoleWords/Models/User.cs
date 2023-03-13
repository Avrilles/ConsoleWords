namespace words.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Language> Languages { get; set; }

        public User(Guid id, string name, List<Language> languages)
        {
            Id = id;
            Name = name;
            Languages = languages;
        }
    }
}
