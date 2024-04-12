namespace WebApplication1.Classes
{
    public class Questionnaire
    {


        public static List<Question> CreateQuestionnaire()
        {
            var question1 = new Question
            {
                Id = "1",
                Caption = "What is the capital of France?",
                QuestionType = 1,
                Choices = new List<choice>
                {
                    new choice { Id = "1", Caption = "Paris",  BooleanValue = false, IsValid = true, SortOrder = 1 },
                    new choice { Id = "2", Caption = "London", BooleanValue = false, IsValid = true, SortOrder = 2 },
                    new choice { Id = "3", Caption = "Berlin", BooleanValue = false, IsValid = true, SortOrder = 3 },
                    new choice { Id = "4", Caption = "Madrid", BooleanValue = false, IsValid = true, SortOrder = 4 }
                }
            };

            var question2 = new Question
            {
                Id = "2",
                Caption = "Which planet is known as the Red Planet?",
                QuestionType = 1,
                Choices = new List<choice>
                {
                    new choice { Id = "1", Caption = "Earth",   BooleanValue = false, IsValid = true, SortOrder = 1 },
                    new choice { Id = "2", Caption = "Mars",    BooleanValue = false, IsValid = true, SortOrder = 2 },
                    new choice { Id = "3", Caption = "Jupiter", BooleanValue = false, IsValid = true, SortOrder = 3 },
                    new choice { Id = "4", Caption = "Saturn",  BooleanValue = false, IsValid = true, SortOrder = 4 }
                }
            };

            var question3 = new Question
            {
                Id = "3",
                Caption = "Who is the author of 'To Kill a Mockingbird'?",
                QuestionType = 2,
                Choices = new List<choice>
                {
                    new choice { Id = "1", Caption = "", StringValue = "", IsValid = true, SortOrder = 1 },
                }
            };

            var question4 = new Question
            {
                Id = "4",
                Caption = "the largest ocean?",
                QuestionType = 2,
                Choices = new List<choice>
                {
                    new choice  { Id = "1", Caption = "", StringValue="" , IsValid = true, SortOrder = 1 },
                }
            };


            var questions = new List<Question> { question1, question2, question3, question4 };

            return questions;
        }


    }
}
