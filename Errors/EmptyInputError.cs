namespace OopPrinciples.Errors
{
    internal class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use an empty input in a required field. This fired an error!";
        }
    }
}
