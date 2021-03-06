﻿using System;
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
        private readonly IContentSource _contentSource;
        private bool _textChange = false;

        public FormOneline(ContentWriterFactory contentWriterFactory
            , OnelineApp app
            , IContentSource contentSource)
        {
            InitializeComponent();

            _contentWriterFactory = contentWriterFactory;
            _textBoxContentWriter = _contentWriterFactory.Create(ContentWriterType.TextBox, txtContent);
            _clipBoardContentWriter = _contentWriterFactory.Create(ContentWriterType.ClipBoard, txtContent);
            _app = app;
            _contentSource = contentSource;
            _app.ContentWriter = _textBoxContentWriter;
            _timerForAuto.Enabled = false;
            _timerForAuto.Tick += TimerForAuto_AutoGetContent;
            _timerForAuto.Tick += TimerForAuto_Transform;
        }

        private void TimerForAuto_AutoGetContent(object sender, EventArgs e)
        {
            if (cbxAuto.Checked)
            {
                //持续获取待翻译文本
                var content = _contentSource.GetContent();
                if (!string.IsNullOrEmpty(content))
                {
                    txtContent.Text = content;
                }
            }
        }

        private void TimerForAuto_Transform(object sender, EventArgs e)
        {
            if (_textChange)
            {
                _app.DoTransform(txtContent.Text);
                _textChange = false;
                lbCount.Text = _app.TransformCount.ToString();
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            _app.DoTransform(txtContent.Text);
        }

        private void cbxAuto_CheckedChanged(object sender, EventArgs e)
        {
            _timerForAuto.Enabled = cbxAuto.Checked;
            txtContent.Enabled = !cbxAuto.Checked;
        }

        private void cbxCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCopy.Checked)
            {
                _app.ContentWriter = _clipBoardContentWriter;
            }
            else
            {
                _app.ContentWriter = _textBoxContentWriter;
            }
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            _textChange = true;
        }
    }
}
