using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace words.Models
{
    internal class Language
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public List<Word> Words { get; set; }

        public Language(Guid id, string title, List<Word> words)
        {
            Id = id;
            Title = title;
            Words = words;
        }

        public double getAverageLevel()
        {
            double sum = 0;
            foreach(var word in Words)
            {
                sum += word.Level;
            }

            return sum / Words.Count;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
