using System;
using System.Windows.Forms;

namespace Oneline
{
    public class ContentWriterFactory
    {
        public IContentWriter Create(ContentWriterType writerType, TextBox textBox = null)
        {
            IContentWriter contentWriter = null;
            switch (writerType)
            {
                default:
                case ContentWriterType.TextBox:
                    if (textBox == null)
                    {
                        throw new ArgumentNullException(nameof(TextBox));
                    }
                    contentWriter = new TextBoxContentWriter(textBox);
                    break;
                case ContentWriterType.ClipBoard:
                    contentWriter = new ClipBoardContentWriter(new TextBoxContentWriter(textBox));
                    break;
            }
            return contentWriter;
        }
    }
}
