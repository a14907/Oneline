using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oneline
{
    public partial class FormOneline : Form
    {
        private readonly ContentWriterFactory _contentWriterFactory;
        private readonly IContentWriter _textBoxContentWriter;
        private readonly IContentWriter _clipBoardContentWriter;
        private readonly OnelineApp _app;
        private bool _textChange = false;

        public FormOneline(ContentWriterFactory contentWriterFactory
            , OnelineApp app)
        {
            InitializeComponent();

            _contentWriterFactory = contentWriterFactory;
            _textBoxContentWriter = _contentWriterFactory.Create(ContentWriterType.TextBox, txtContent);
            _clipBoardContentWriter = _contentWriterFactory.Create(ContentWriterType.ClipBoard, txtContent);
            _app = app;

            _app.ContentWriter = _textBoxContentWriter;
            _timerForAuto.Enabled = false;
            _timerForAuto.Tick += TimerForAuto_Tick;
        }

        private void TimerForAuto_Tick(object sender, EventArgs e)
        {
            if (_textChange)
            {
                _app.DoTransform(txtContent.Text);
                _textChange = false;
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            _app.DoTransform(txtContent.Text);
        }

        private void cbxAuto_CheckedChanged(object sender, EventArgs e)
        {
            _timerForAuto.Enabled = true;
        }

        private void cbxCopy_CheckedChanged(object sender, EventArgs e)
        {
            _app.ContentWriter = _clipBoardContentWriter;
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            _textChange = true;
        }
    }
}
