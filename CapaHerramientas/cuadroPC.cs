namespace CapaHerramientas
{
    public partial class cuadroPC : UserControl
    {
        string idPC = string.Empty;
        string tarifa = string.Empty;
        string estado = string.Empty;
        public Color borderColor = Color.Black;
        public int borderSize = 2;
        public string texto = String.Empty;
        public Color colorFondoOriginal;
        public Color colorTextoOriginal;
        public cuadroPC()
        {
            InitializeComponent();
            Size = new Size(100, 100);
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
                label1.BackColor = value;
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
        public string Texto
        {
            get
            {
                return texto;
            }

            set
            {
                texto = value;
                Invalidate();
            }
        }

        public string Tarifa
        {
            get
            {
                return tarifa;
            }

            set
            {
                tarifa = value;
                Invalidate();
            }
        }
        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
                Invalidate();
            }
        }
        public string IdPC
        {
            get
            {
                return idPC;
            }

            set
            {
                idPC = value;
                Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // Dibujar el borde con el color personalizado
            using (Pen pen = new Pen(BorderColor, borderSize))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, Width - 0.5F, Height - 0.5F);
            }

            // Centrar el texto en el Label
            using (StringFormat sf = new())
            {
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                using (SolidBrush brush = new(label1.ForeColor))
                {
                    e.Graphics.DrawString(texto, label1.Font, brush, ClientRectangle, sf);
                }
            }
            // Invocar el evento OnPaint del padre para dibujar el contenido del Label
            //base.OnPaint(e);
        }
    }
}
