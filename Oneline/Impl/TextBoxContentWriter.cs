using System.Windows.Forms;

namespace Oneline
{
    public class TextBoxContentWriter : IContentWriter
    {
        private readonly TextBox _textBox;

        public TextBoxContentWriter(TextBox textBox)
        {
            _textBox = textBox;
        }

        public void Write(string content)
        {
            _textBox.Text = content;
        }
    }
}
