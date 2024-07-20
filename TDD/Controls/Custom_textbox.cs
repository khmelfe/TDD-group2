using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class Custom_textbox : UserControl
    {
        /// <summary>
        /// fields
        /// </summary>
        private Color borderColor = Color.MediumSlateBlue;
        private int bordersize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;
        public Custom_textbox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Events
        /// </summary>
        public event EventHandler _TextChanged;//making the same event for this one.

        [Category("CustomButton")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Validate(); } }
        [Category("CustomButton")]
        public int Bordersize { get => bordersize; set { bordersize = value; this.Validate(); } }
        [Category("CustomButton")]
        public bool UnderlinedStyle { get => underlinedStyle; set { underlinedStyle = value; this.Validate(); } }
        [Category("CustomButton")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("CustomButton")]
        public bool Multline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("CustomButton")]
        public override Color BackColor { get => base.BackColor; set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("CustomButton")]
        public override Color ForeColor { get => base.ForeColor; set { base.ForeColor = value; textBox1.ForeColor = value; } }
        [Category("CustomButton")]
        public override Font Font { get => base.Font; set { base.Font = value; textBox1.Font = value; if (this.DesignMode) UpdateControlHeight(); } }
        [Category("CustomButton")]
        public string Texts { get { return textBox1.Text; } set { textBox1.Text = value; } }
        [Category("CustomButton")]

        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        //overide
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            // draw border
            using (Pen penBorder = new Pen(BorderColor, bordersize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void Custom_textbox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}
