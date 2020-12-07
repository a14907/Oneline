using System.Text.RegularExpressions;

namespace Oneline
{
    public class TransformService : ITransformService
    {
        /// <summary>
        /// 换行
        /// </summary>
        public static readonly Regex _regexForWrap = new Regex("(?<![.])\n", RegexOptions.Compiled | RegexOptions.Multiline);
        /// <summary> 
        /// 单词截断 
        /// </summary>
        public static readonly Regex _regexForWordTruncation = new Regex("[-]\n", RegexOptions.Compiled | RegexOptions.Multiline);


        public string Transform(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                return content;
            }
            content = content.Replace("\r\n", "\n"); 
            content = _regexForWordTruncation.Replace(content, ""); 
            content = _regexForWrap.Replace(content, " ");
            return content;
        }
    }
}
