namespace CapaHerramientas
{
    public partial class BoxText : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        public BoxText()
        {
            InitializeComponent();
        }
        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }

            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (DesignMode)
                    UpdateControlHeight();
            }
        }
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }

            set
            {
                borderFocusColor = value;
            }
        }

        public string PlaceholderText
        {
            get
            {
                return textBox1.PlaceholderText;
            }

            set
            {
                textBox1.PlaceholderText = value;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);

                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
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
        private void BoxText_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void BoxText_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();

        }
        public event EventHandler EnterKeyPressed;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                e.Handled = true;
            }
        }
        public event EventHandler TextChanged;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextChanged?.Invoke(this, e);
        }
        public void Clear()
        {
            textBox1.Clear();
        }
    }
}
