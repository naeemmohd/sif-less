﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIFLess.Model;

namespace SIFLess.Controls
{
    public partial class FileControl: UserControl, IParameterControl
    {
        private readonly string _fieldName;
        private readonly string _defaultValue;
        private readonly string _description;

        public FileControl()
        {
            InitializeComponent();
        }

        public string Field { get; }

        public string FieldMap { get; }

        public string Value
        {
            get => valueTextBox.Text;
            set => valueTextBox.Text = value;
        }

        public FileControl(string fieldName, string fieldMapName, string description) : this()
        {
            Field = fieldName;
            _description = description;
            FieldMap = fieldMapName;
        }

        private void FileControl_Load(object sender, EventArgs e)
        {
            fieldLabel.Text = Field;
            fieldTip.SetToolTip(fieldLabel, _description);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                valueTextBox.Text = openFileDialog1.FileName;
            }

        }
    }
}
