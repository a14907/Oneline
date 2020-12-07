using System.Windows.Forms;

namespace Oneline
{
    public class ClipBoardContentWriter : IContentWriter
    {
        private readonly TextBoxContentWriter _textBoxContentWriter;

        public ClipBoardContentWriter(TextBoxContentWriter textBoxContentWriter)
        {
            _textBoxContentWriter = textBoxContentWriter;
        }
        public void Write(string content)
        {
            Clipboard.SetText(content);
            _textBoxContentWriter.Write(content);
        }
    }
}
