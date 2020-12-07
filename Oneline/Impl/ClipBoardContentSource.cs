using System.Windows.Forms;

namespace Oneline
{
    public class ClipBoardContentSource : IContentSource
    {
        private string _oldContent = string.Empty;

        public string GetContent()
        {
            if (Clipboard.ContainsText())
            {
                var result = Clipboard.GetText();
                if (result != _oldContent)
                {
                    _oldContent = result;
                    return result;
                }
            }
            return null;
        }
    }
}
