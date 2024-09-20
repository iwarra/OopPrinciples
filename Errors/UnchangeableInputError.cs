namespace OopPrinciples.Errors
{
    internal class UnchangeableInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to change a constant input. This fired an error!";
        }
    }
}
