namespace WebApplication1.Classes
{
    public class Question
    {
        private List<choice> choices;

        public string Id { get; set; }

        public string Caption { get; set; }

        public int QuestionType { get; set; }

        public List<choice> Choices { get => choices; set => choices = value; }
    }
}
