namespace words.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Language> Languages { get; set; }

        public List<Group> Groups { get; set; }

        public User(Guid id, string name, string login, string password, List<Language> languages, List<Group> groups)
        {
            Id = id;
            Name = name;
            Login = login;
            Password = password;
            Languages = languages;
            Groups = groups;
        }

        public string getInfo()
        {
            return $"{Name}\n{string.Join('\n', Languages.Select(l => l.ToString()))}";
        }
    }
}
