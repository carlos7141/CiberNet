using iText.StyledXmlParser.Css.Util;

namespace CapaPresentacion
{
    public partial class FormInicio : Form
    {
        SimpleTcpServer? server;
        readonly Class_SQL_Usuario exe = new();
        readonly Class_SQL_Reporte executeReporte = new();
        readonly ClassGetIP execute = new();
        cuadroPC cuadro = new();

        TimeSpan inicioDeTiempo = TimeSpan.Zero;
        TimeSpan tiempoDeUso = TimeSpan.Zero;
        TimeSpan tiempoRestante = TimeSpan.Zero;
        decimal costoDeUso = 0.00m;

        public FormInicio()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }
        private void RelojTiempoReal_Tick(object sender, EventArgs e)
        {
            labelReloj.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(execute.GetLocalIpAddress() + @":7000");
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;
            server.Start();
            txtInfo.Text += $"Iniciando... {Environment.NewLine}";
            CrearPC();
            DatosVaciosPC();
        }
        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                string[] parts = e.IpPort.Split(':');
                string[] parts2 = Encoding.UTF8.GetString(e.Data).Split(':');

                if (parts2[0] == "Libre")
                {
                    cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == parts[0]);
                    if (cuadro != null)
                    {
                        cuadro.Estado = parts2[1];
                        CrearPC();
                        MsgBox.Show($"{parts2[2]}:{parts2[3]}");
                    }
                }
                else if (parts2[0] == "Prepago")
                {
                    cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == parts[0]);
                    if (cuadro != null)
                    {
                        cuadro.Estado = parts2[1];
                        CrearPC();
                    }
                }
                else if (parts2[0] == "Personal")
                {
                    cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == parts[0]);
                    if (cuadro != null)
                    {
                        cuadro.Estado = parts2[0];
                        CrearPC();
                    }
                }

                if (parts2[0] == "PrepagoR")
                {
                    string tiempo = $"{parts2[1]}:{parts2[2]}";
                    tiempoRestante = TimeSpan.ParseExact(tiempo, @"hh\:mm", null);
                }
                else if (parts2[0] == "LibreR")
                {
                    string tiempo = $"{parts2[1]}:{parts2[2]}";
                    tiempoDeUso = TimeSpan.ParseExact(tiempo, @"hh\:mm", null);
                    costoDeUso = decimal.Parse(parts2[3]);
                }
            });
        }
        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} desconectado.{Environment.NewLine}";
                string[] parts = e.IpPort.Split(':');
                string ip = parts[0];
                cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == ip);
                if (cuadro != null)
                {
                    cuadro.Estado = "Apagado";
                }
            });
        }
        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                string[] parts = e.IpPort.Split(':');
                string ip = parts[0];
                txtInfo.Text += $"{ip} Conectado.{Environment.NewLine}";
                bool ipRegistrada = exe.BuscarIP(ip);
                if (ipRegistrada)
                {
                    cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == ip);
                    if (cuadro != null)
                    {
                        cuadro.Name = e.IpPort;
                        cuadro.Estado = "Encendido";
                        CrearPC();
                    }
                }
            });
        }











        public void CrearPC()
        {
            SqlConnection cn = new(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);
            string consulta = "SELECT M.idPC, M.Nombre, M.ipAddress, T.PrecioPorHora FROM MAQUINA M INNER JOIN TARIFA T ON M.idTarifa = T.idTarifa";
            SqlDataAdapter adaptador = new(consulta, cn);
            DataTable tablaRegistros = new();
            adaptador.Fill(tablaRegistros);

            // Crear una lista de IPs presentes en la tabla MAQUINA
            List<string> ipsEnTabla = tablaRegistros.AsEnumerable().Select(fila => fila.Field<string>("ipAddress")).ToList();

            // Eliminar los cuadros cuyo Tag (IP) no está en la lista
            foreach (cuadroPC cuadroExistente in panelPC.Controls.OfType<cuadroPC>().ToList())
            {
                if (!ipsEnTabla.Contains(cuadroExistente.Tag.ToString()))
                {
                    panelPC.Controls.Remove(cuadroExistente);
                    cuadroExistente.Dispose(); // Liberar recursos
                }
            }

            // Crear o actualizar los cuadros basados en los registros de la tabla
            foreach (DataRow fila in tablaRegistros.Rows)
            {
                string? idPC = fila["idPC"].ToString();
                string? nombre = fila["Nombre"].ToString();
                string? ip = fila["ipAddress"].ToString();
                string? tarifa = fila["PrecioPorHora"].ToString();

                // Buscar si ya existe un cuadro con el mismo Tag
                cuadroPC cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.Tag.ToString() == ip);

                if (cuadro == null)
                {
                    cuadro = new cuadroPC
                    {
                        Size = new Size(70, 70),
                        BackColor = Color.Transparent,
                        ForeColor = Color.White,
                        BorderColor = Color.Gray,
                        BorderSize = 4,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        IdPC = idPC,
                        Texto = nombre,
                        Tag = ip,
                        Tarifa = tarifa,
                        Estado = "Apagado"
                    };
                    cuadro.Click += Cuadro_Click;
                    panelPC.Controls.Add(cuadro);
                }
                if (cuadro.Estado == "Apagado")
                {
                    cuadro.borderColor = Color.Gray; // Cambiar al color deseado
                }
                else if (cuadro.Estado == "Encendido")
                {
                    cuadro.borderColor = Color.Green; // Cambiar al color normal
                }
                else if (cuadro.Estado == "Prepago")
                {
                    cuadro.borderColor = Color.Purple;
                }
                else if (cuadro.Estado == "Libre")
                {
                    cuadro.borderColor = Color.FromArgb(245, 0, 135);
                }
                else if (cuadro.Estado == "Personal")
                {
                    cuadro.borderColor = Color.Aqua;
                }
            }
        }



        private int cuadrosSeleccionados = 0;
        public string[] PcSelect = new string[2];
        private async void Cuadro_Click(object sender, EventArgs e)
        {
            // Manejar el evento Click del cuadroPC aquí
            cuadro = (cuadroPC)sender;

            // Verificar si mostrar u ocultar el botón
            if (cuadro.BackColor == Color.White)
            {
                cuadro.BackColor = cuadro.colorFondoOriginal;
                cuadro.label1.ForeColor = cuadro.colorTextoOriginal;
                PcSelect[0] = string.Empty;
                PcSelect[1] = string.Empty;
                cuadrosSeleccionados--;
            }
            else
            {
                cuadro.colorFondoOriginal = cuadro.BackColor;
                cuadro.colorTextoOriginal = cuadro.label1.ForeColor;
                cuadro.BackColor = Color.White;
                cuadro.label1.ForeColor = Color.Black;
                PcSelect[0] = cuadro.Name.ToString();
                PcSelect[1] = cuadro.Tarifa;
                cuadrosSeleccionados++;
            }

            // Verificar si mostrar u ocultar el botón
            if (cuadrosSeleccionados >= 2 || cuadrosSeleccionados == 0)
            {
                BtnTiempoLibre.Visible = false;
                btnAddTime.Visible = false;
                DatosVaciosPC();
            }
            else
            {
                string Estado = string.Empty;
                cuadro = panelPC.Controls.OfType<cuadroPC>().FirstOrDefault(c => c.BackColor == Color.White);
                if (cuadro != null)
                {
                    Estado = cuadro.Estado;
                }
                else
                {
                    Estado = "Apagado";
                }
                if (Estado == "Libre")
                {
                    BtnTiempoLibre.Visible = true;
                    BtnTiempoLibre.Image = Properties.Resources.stop;
                    btnAddTime.Visible = false;
                    server.Send(PcSelect[0], $"{PcSelect[1]}:LibreS");
                    await Task.Delay(200);
                    DatosPC.Text =
                        $"Nombre de usuario:    {cuadro.Texto}\n" +
                        $"Inicio de Tiempo:     {inicioDeTiempo.ToString(@"hh\:mm")}\n" +
                        $"Tiempo de uso:        {tiempoDeUso.ToString(@"hh\:mm")}\n" +
                        $"Tiempo restante:      00:00\n" +
                        $"Costo de uso:         {Math.Round(costoDeUso, 2)}";
                }
                else if (Estado == "Prepago")
                {
                    btnAddTime.Visible = true;
                    BtnTiempoLibre.Visible = false;
                    server.Send(PcSelect[0], $"{PcSelect[1]}:PrepagoS");
                    await Task.Delay(200);
                    DatosPC.Text =
                        $"Nombre de usuario:    {cuadro.Texto}\n" +
                        $"Inicio de Tiempo:     {inicioDeTiempo.ToString(@"hh\:mm")}\n" +
                        $"Tiempo de uso:        {tiempoDeUso.ToString(@"hh\:mm")}\n" +
                        $"Tiempo restante:      {tiempoRestante.ToString(@"hh\:mm")}\n" +
                        $"Costo de uso:         {Math.Round(costoDeUso, 2)}";
                }
                else if (Estado == "Encendido")
                {
                    btnAddTime.Visible = true;
                    BtnTiempoLibre.Visible = true;
                    BtnTiempoLibre.Image = Properties.Resources.play;
                    PcSinTiempo(cuadro.Texto);
                }
                else if (Estado == "Apagado")
                {
                    btnAddTime.Visible = false;
                    BtnTiempoLibre.Visible = false;
                    PcSinTiempo(cuadro.Texto);
                }
            }
        }

        private async void btnAddTime_Click(object sender, EventArgs e)
        {
            if (server.IsListening && !string.IsNullOrEmpty(txtTarifa.Text) && !string.IsNullOrEmpty(PcSelect[0]))
            {
                DialogResult respuesta = MessageBox.Show("COnfirme para continuar");
                if (respuesta == DialogResult.OK)
                {

                }
                server.Send(PcSelect[0], $"{PcSelect[1]}:Prepago:{(txtTarifa.Text).Replace(".", ",")}");
                cuadro.Estado = "Prepago";
                CrearPC();
                txtTarifa.Clear();
                executeReporte.Add(DateTime.Now.ToString("dd-mm-yy"), "", "PrePago", "Maquina asignada por tiempo limitado", (txtTarifa.Text).Replace(".", ","), cuadro.IdPC);
            }
        }

        private void txtTarifa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Ignorar el carácter
            }

            // Si ya hay un punto y el carácter es un punto, o si ya hay dos decimales y no es un control o retroceso
            if ((e.KeyChar == '.' && txtTarifa.Text.Contains('.')) ||
                (txtTarifa.Text.Contains('.') && txtTarifa.Text.Split('.')[1].Length >= 2 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true; // Ignorar el carácter
            }
        }

        private void BtnTiempoLibre_Click(object sender, EventArgs e)
        {
            if (server.IsListening && !string.IsNullOrEmpty(PcSelect[0]))
            {
                if (cuadro.Estado == "Encendido")
                {
                    server.Send(PcSelect[0], $"{PcSelect[1]}:Libre:Play");
                    cuadro.Estado = "Libre";
                    BtnTiempoLibre.Image = Properties.Resources.stop;
                    CrearPC();
                }
                else if (cuadro.Estado == "Libre")
                {
                    BtnTiempoLibre.Image = Properties.Resources.play;
                    server.Send(PcSelect[0], $"{PcSelect[1]}:Libre:Stop");
                }
            }
        }

        private void DatosVaciosPC()
        {
            DatosPC.Text =
                    "Nombre de usuario:   N/A\n" +
                    "Inicio de Tiempo:  00:00\n" +
                    "Tiempo de uso:     00:00\n" +
                    "Tiempo restante:   00:00\n" +
                    $"Costo de uso:       Bs {Math.Round(costoDeUso, 2)}";
        }
        private void PcSinTiempo(string nombre)
        {
            DatosPC.Text =
                    $"Nombre de usuario:   {nombre}\n" +
                    "Inicio de Tiempo:  00:00\n" +
                    "Tiempo de uso:     00:00\n" +
                    "Tiempo restante:   00:00\n" +
                    $"Costo de uso:       Bs {Math.Round(costoDeUso, 2)}";

        }
    }
}
