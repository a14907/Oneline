using System;

namespace Oneline
{
    public class OnelineApp
    {
        private IContentWriter _contentWriter = NullContentWriter.Instance;
        private readonly ITransformService _transformService;
        private int _transformCount = 0;

        public OnelineApp(ITransformService transformService)
        {
            _transformService = transformService;
        }

        public IContentWriter ContentWriter
        {
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                _contentWriter = value;
            }
        }

        public int TransformCount { get { return _transformCount; } }

        public void DoTransform(string content)
        {
            content = content.Trim();
            if (string.IsNullOrEmpty(content))
            {
                return;
            }

            var result = _transformService.Transform(content);
            _contentWriter.Write(result);
            _transformCount++;
        }
    }
}
