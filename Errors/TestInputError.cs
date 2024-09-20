namespace OopPrinciples.Errors
{
    internal class TestInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your provided input was not correct. This fired an error!";
        }
    }
}
