
namespace OopPrinciples
{
    internal abstract class UserError
    {
        public abstract string UEMessage();
       
    }

    internal class NumericInputError : UserError 
    { 
        public override string UEMessage() 
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        } 
    }

    internal class TextInputError : UserError 
    { 
        public override string UEMessage() 
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        } 
    }

    internal class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an empty input in a required field. This fired an error!";
        }
    }

    internal class UnchangeableInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to change a constant input. This fired an error!";
        }
    }

    internal class TestInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your provided input was not correct. This fired an error!";
        }
    }
}
