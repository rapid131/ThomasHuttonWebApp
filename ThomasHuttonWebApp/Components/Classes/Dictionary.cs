namespace ThomasHuttonWebApp.Components.Classes
{
    public class Dictionary
    {
        public string word { get; set; }
        public List<Phonetic> phonetics { get; set; }
        public List<Meaning> meanings { get; set; }
        public class Phonetic
        {
            public string audio { get; set; }
            public string sourceUrl { get; set; }
        }
        public class Meaning
        {
            public List<Definition> definitions { get; set; }
        }
        public class Definition
        {
            public string definition {  get; set; }
        }
    }

}
