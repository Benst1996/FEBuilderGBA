using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace FEBuilderGBA
{
    public partial class PaletteClipboardForm : Form
    {
        public PaletteClipboardForm()
        {
            InitializeComponent();
            this.size = 16;
        }
        int size;

        public void SetPalText(string text)
        {
            this.PAL_TEXT.Text = text;
        }
        public string GetPalText()
        {
            return this.PAL_TEXT.Text;
        }
        public void SetPalSize(int size)
        {
            this.size = size;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (this.PAL_TEXT.Text.Length != 4 * this.size)
            {
                R.ShowStopError("文字列のサイズが{0}ではありません",4*this.size);
                return;
            }

            Log.Notify("Use Palette ClipbordCode:" + this.PAL_TEXT.Text);

            DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Close();
        }

        private void PaletteClipboardForm_Load(object sender, EventArgs e)
        {
            this.PAL_TEXT.Focus();
        }
    }
}
