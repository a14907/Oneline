namespace Oneline
{
    public class NullContentWriter : IContentWriter
    {
        private NullContentWriter()
        {

        }
        public static readonly NullContentWriter Instance = new NullContentWriter();

        public void Write(string content)
        {
        }
    }
}
