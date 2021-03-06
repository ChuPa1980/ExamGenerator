﻿using ExamGenerator.Export.MSWord;
using ExamGenerator.Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamGenerator
{
    public partial class ResultForm : Form
    {
        internal Exam exam;

        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            this.rtbResult.Text = exam?.ToString();
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(exam?.ToQuestionsString());
            ExportToMSWord.CreateFromClipboard();
        }
    }
}
