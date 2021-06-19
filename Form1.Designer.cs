
namespace Monitor_Serial
{
    partial class frm_main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_port = new System.Windows.Forms.Label();
            this.lbl_baudRate = new System.Windows.Forms.Label();
            this.lbl_parity = new System.Windows.Forms.Label();
            this.lbl_dataBit = new System.Windows.Forms.Label();
            this.lbl_stopBit = new System.Windows.Forms.Label();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.cmb_baudRate = new System.Windows.Forms.ComboBox();
            this.cmb_parity = new System.Windows.Forms.ComboBox();
            this.cmb_dataBit = new System.Windows.Forms.ComboBox();
            this.cmb_stopBit = new System.Windows.Forms.ComboBox();
            this.btn_openPort = new System.Windows.Forms.Button();
            this.btn_closePort = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.grb_config_port = new System.Windows.Forms.GroupBox();
            this.grb_transmitter = new System.Windows.Forms.GroupBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_clearRx = new System.Windows.Forms.Button();
            this.grb_recept = new System.Windows.Forms.GroupBox();
            this.txt_recept = new System.Windows.Forms.TextBox();
            this.grb_config_port.SuspendLayout();
            this.grb_transmitter.SuspendLayout();
            this.grb_recept.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Location = new System.Drawing.Point(3, 31);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(35, 13);
            this.lbl_port.TabIndex = 0;
            this.lbl_port.Text = "Porta:";
            // 
            // lbl_baudRate
            // 
            this.lbl_baudRate.AutoSize = true;
            this.lbl_baudRate.Location = new System.Drawing.Point(130, 31);
            this.lbl_baudRate.Name = "lbl_baudRate";
            this.lbl_baudRate.Size = new System.Drawing.Size(63, 13);
            this.lbl_baudRate.TabIndex = 1;
            this.lbl_baudRate.Text = "Velocidade:";
            // 
            // lbl_parity
            // 
            this.lbl_parity.AutoSize = true;
            this.lbl_parity.Location = new System.Drawing.Point(257, 31);
            this.lbl_parity.Name = "lbl_parity";
            this.lbl_parity.Size = new System.Drawing.Size(52, 13);
            this.lbl_parity.TabIndex = 2;
            this.lbl_parity.Text = "Paridade:";
            // 
            // lbl_dataBit
            // 
            this.lbl_dataBit.AutoSize = true;
            this.lbl_dataBit.Location = new System.Drawing.Point(389, 31);
            this.lbl_dataBit.Name = "lbl_dataBit";
            this.lbl_dataBit.Size = new System.Drawing.Size(71, 13);
            this.lbl_dataBit.TabIndex = 3;
            this.lbl_dataBit.Text = "Bit de Dados:";
            // 
            // lbl_stopBit
            // 
            this.lbl_stopBit.AutoSize = true;
            this.lbl_stopBit.Location = new System.Drawing.Point(484, 31);
            this.lbl_stopBit.Name = "lbl_stopBit";
            this.lbl_stopBit.Size = new System.Drawing.Size(74, 13);
            this.lbl_stopBit.TabIndex = 4;
            this.lbl_stopBit.Text = "Bit de Parada:";
            // 
            // cmb_port
            // 
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(6, 47);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(121, 21);
            this.cmb_port.TabIndex = 5;
            // 
            // cmb_baudRate
            // 
            this.cmb_baudRate.FormattingEnabled = true;
            this.cmb_baudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "230400",
            "256000"});
            this.cmb_baudRate.Location = new System.Drawing.Point(133, 47);
            this.cmb_baudRate.Name = "cmb_baudRate";
            this.cmb_baudRate.Size = new System.Drawing.Size(121, 21);
            this.cmb_baudRate.TabIndex = 6;
            // 
            // cmb_parity
            // 
            this.cmb_parity.FormattingEnabled = true;
            this.cmb_parity.Location = new System.Drawing.Point(260, 47);
            this.cmb_parity.Name = "cmb_parity";
            this.cmb_parity.Size = new System.Drawing.Size(110, 21);
            this.cmb_parity.TabIndex = 7;
            // 
            // cmb_dataBit
            // 
            this.cmb_dataBit.FormattingEnabled = true;
            this.cmb_dataBit.Location = new System.Drawing.Point(392, 47);
            this.cmb_dataBit.Name = "cmb_dataBit";
            this.cmb_dataBit.Size = new System.Drawing.Size(78, 21);
            this.cmb_dataBit.TabIndex = 8;
            // 
            // cmb_stopBit
            // 
            this.cmb_stopBit.FormattingEnabled = true;
            this.cmb_stopBit.Location = new System.Drawing.Point(487, 47);
            this.cmb_stopBit.Name = "cmb_stopBit";
            this.cmb_stopBit.Size = new System.Drawing.Size(72, 21);
            this.cmb_stopBit.TabIndex = 9;
            // 
            // btn_openPort
            // 
            this.btn_openPort.Location = new System.Drawing.Point(619, 48);
            this.btn_openPort.Name = "btn_openPort";
            this.btn_openPort.Size = new System.Drawing.Size(83, 33);
            this.btn_openPort.TabIndex = 10;
            this.btn_openPort.Text = "Abrir Porta";
            this.btn_openPort.UseVisualStyleBackColor = true;
            this.btn_openPort.Click += new System.EventHandler(this.btn_openPort_Click);
            // 
            // btn_closePort
            // 
            this.btn_closePort.Location = new System.Drawing.Point(619, 101);
            this.btn_closePort.Name = "btn_closePort";
            this.btn_closePort.Size = new System.Drawing.Size(83, 33);
            this.btn_closePort.TabIndex = 11;
            this.btn_closePort.Text = "Fechar Porta";
            this.btn_closePort.UseVisualStyleBackColor = true;
            this.btn_closePort.Click += new System.EventHandler(this.btn_closePort_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(619, 438);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(83, 37);
            this.btn_exit.TabIndex = 12;
            this.btn_exit.Text = "Sair";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // grb_config_port
            // 
            this.grb_config_port.Controls.Add(this.cmb_port);
            this.grb_config_port.Controls.Add(this.lbl_port);
            this.grb_config_port.Controls.Add(this.cmb_baudRate);
            this.grb_config_port.Controls.Add(this.lbl_baudRate);
            this.grb_config_port.Controls.Add(this.cmb_stopBit);
            this.grb_config_port.Controls.Add(this.lbl_stopBit);
            this.grb_config_port.Controls.Add(this.cmb_parity);
            this.grb_config_port.Controls.Add(this.cmb_dataBit);
            this.grb_config_port.Controls.Add(this.lbl_parity);
            this.grb_config_port.Controls.Add(this.lbl_dataBit);
            this.grb_config_port.Location = new System.Drawing.Point(27, 12);
            this.grb_config_port.Name = "grb_config_port";
            this.grb_config_port.Size = new System.Drawing.Size(580, 124);
            this.grb_config_port.TabIndex = 13;
            this.grb_config_port.TabStop = false;
            this.grb_config_port.Text = "Configuração";
            // 
            // grb_transmitter
            // 
            this.grb_transmitter.Controls.Add(this.btn_clearRx);
            this.grb_transmitter.Controls.Add(this.btn_send);
            this.grb_transmitter.Controls.Add(this.txt_send);
            this.grb_transmitter.Location = new System.Drawing.Point(27, 155);
            this.grb_transmitter.Name = "grb_transmitter";
            this.grb_transmitter.Size = new System.Drawing.Size(580, 123);
            this.grb_transmitter.TabIndex = 14;
            this.grb_transmitter.TabStop = false;
            this.grb_transmitter.Text = "Transmissão";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(467, 87);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(88, 24);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Enviar";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(6, 41);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(548, 20);
            this.txt_send.TabIndex = 0;
            // 
            // btn_clearRx
            // 
            this.btn_clearRx.Location = new System.Drawing.Point(6, 88);
            this.btn_clearRx.Name = "btn_clearRx";
            this.btn_clearRx.Size = new System.Drawing.Size(75, 23);
            this.btn_clearRx.TabIndex = 2;
            this.btn_clearRx.Text = "Limpar Rx";
            this.btn_clearRx.UseVisualStyleBackColor = true;
            this.btn_clearRx.Click += new System.EventHandler(this.btn_clearRx_Click);
            // 
            // grb_recept
            // 
            this.grb_recept.Controls.Add(this.txt_recept);
            this.grb_recept.Location = new System.Drawing.Point(27, 327);
            this.grb_recept.Name = "grb_recept";
            this.grb_recept.Size = new System.Drawing.Size(580, 138);
            this.grb_recept.TabIndex = 15;
            this.grb_recept.TabStop = false;
            this.grb_recept.Text = "Recepção";
            // 
            // txt_recept
            // 
            this.txt_recept.Location = new System.Drawing.Point(14, 25);
            this.txt_recept.Multiline = true;
            this.txt_recept.Name = "txt_recept";
            this.txt_recept.Size = new System.Drawing.Size(544, 97);
            this.txt_recept.TabIndex = 0;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 496);
            this.Controls.Add(this.grb_recept);
            this.Controls.Add(this.grb_transmitter);
            this.Controls.Add(this.grb_config_port);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_closePort);
            this.Controls.Add(this.btn_openPort);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.grb_config_port.ResumeLayout(false);
            this.grb_config_port.PerformLayout();
            this.grb_transmitter.ResumeLayout(false);
            this.grb_transmitter.PerformLayout();
            this.grb_recept.ResumeLayout(false);
            this.grb_recept.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.Label lbl_baudRate;
        private System.Windows.Forms.Label lbl_parity;
        private System.Windows.Forms.Label lbl_dataBit;
        private System.Windows.Forms.Label lbl_stopBit;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.ComboBox cmb_baudRate;
        private System.Windows.Forms.ComboBox cmb_parity;
        private System.Windows.Forms.ComboBox cmb_dataBit;
        private System.Windows.Forms.ComboBox cmb_stopBit;
        private System.Windows.Forms.Button btn_openPort;
        private System.Windows.Forms.Button btn_closePort;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.GroupBox grb_config_port;
        private System.Windows.Forms.GroupBox grb_transmitter;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_clearRx;
        private System.Windows.Forms.GroupBox grb_recept;
        private System.Windows.Forms.TextBox txt_recept;
    }
}

