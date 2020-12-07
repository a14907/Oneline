using System.Windows.Forms;

namespace Oneline
{
    public class ClipBoardContentWriter : IContentWriter
    {
        private readonly IContentWriter _contentWriter;

        public ClipBoardContentWriter(IContentWriter contentWriter)
        {
            if (contentWriter is ClipBoardContentWriter)
            {
                throw new System.ArgumentException("参数类型错误");
            }
            _contentWriter = contentWriter;
        }
        public void Write(string content)
        {
            Clipboard.SetText(content);
            _contentWriter.Write(content);
        }
    }
}
