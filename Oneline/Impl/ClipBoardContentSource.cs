using System.Windows.Forms;

namespace Oneline
{
    public class ClipBoardContentSource : IContentSource
    {
        public string GetContent()
        {
            if (Clipboard.ContainsText())
            {
                return Clipboard.GetText();
            }
            return null;
        }
    }
}
