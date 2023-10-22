namespace CapaPresentacion
{
    partial class FormLoading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            barraProgreso1 = new BarraProgreso();
            label1 = new Label();
            timerBarra = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // barraProgreso1
            // 
            barraProgreso1.ChannelColor = Color.Transparent;
            barraProgreso1.ChannelHeight = 20;
            barraProgreso1.Dock = DockStyle.Bottom;
            barraProgreso1.ForeBackColor = Color.RoyalBlue;
            barraProgreso1.ForeColor = Color.White;
            barraProgreso1.Location = new Point(0, 431);
            barraProgreso1.Margin = new Padding(4, 3, 4, 3);
            barraProgreso1.Name = "barraProgreso1";
            barraProgreso1.ShowMaximun = false;
            barraProgreso1.ShowValue = TextPosition.None;
            barraProgreso1.Size = new Size(714, 27);
            barraProgreso1.SliderColor = Color.FromArgb(128, 255, 128);
            barraProgreso1.SliderHeight = 20;
            barraProgreso1.Style = ProgressBarStyle.Marquee;
            barraProgreso1.SymbolAfter = "";
            barraProgreso1.SymbolBefore = "";
            barraProgreso1.TabIndex = 4;
            barraProgreso1.Value = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(261, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 39);
            label1.TabIndex = 3;
            label1.Text = "Cargando...";
            // 
            // timerBarra
            // 
            timerBarra.Interval = 20;
            timerBarra.Tick += timerBarra_Tick;
            // 
            // FormLoading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 38, 44);
            ClientSize = new Size(714, 458);
            Controls.Add(barraProgreso1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoading";
            Text = "FormLoading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public BarraProgreso barraProgreso1;
        private Label label1;
        public System.Windows.Forms.Timer timerBarra;
    }
}