using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Monitor_Serial
{
    public partial class frm_main : Form
    {
        // instancia de SerialPort
        SerialPort serialCom = new SerialPort();

        // var para armazenar dado recebido pela porta
        string bfRecebe = string.Empty;

        // função FDelegate para trabalharmos com 'threads'
        public delegate void FDelegate(string a);

        public frm_main()
        {
            InitializeComponent();
            serialCom.DataReceived += new SerialDataReceivedEventHandler(serialCom_DataReceived);
        }

        void serialCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            bfRecebe = serialCom.ReadExisting();

            this.BeginInvoke(new FDelegate(recebe_serial), new object[] { bfRecebe });
        }

        public void recebe_serial(string a)
        {
            txt_recept.Text += a;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            int i = 0; // usada para pré selecionar porta caso exista

            #region carrega portas
            // ao inicializar carregar portas disponíveis
            foreach (string str in SerialPort.GetPortNames()) 
            { 
                cmb_port.Items.Add(str);

                if (str != "") cmb_port.SelectedIndex = i;
                i++;
            }
            #endregion

            // pré selecionando a velocidade
            cmb_baudRate.SelectedText = "9600";

            #region carrega paridade
            i = 0;

            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                cmb_parity.Items.Add(str);

                if (str == "None")
                    cmb_parity.SelectedIndex = i;
                i++;
            }
            #endregion

            // pré selecionando o Data Bit
            cmb_dataBit.SelectedText = "8";

            #region carrega stop Bit
            i = 0;

            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                cmb_stopBit.Items.Add(str);

                if (str == "One") 
                    cmb_stopBit.SelectedIndex = i;
                
                i++;

            }
            #endregion
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_openPort_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen == true) serialCom.Close();

            serialCom.PortName = cmb_port.Text;
            serialCom.BaudRate = Int32.Parse(cmb_baudRate.Text);
            serialCom.Parity = (Parity)cmb_parity.SelectedIndex;
            serialCom.DataBits = Int32.Parse(cmb_dataBit.Text);
            serialCom.StopBits = (StopBits)cmb_stopBit.SelectedIndex;

            try
            {
                serialCom.Open();
                btn_openPort.Enabled = false;
                btn_closePort.Enabled = true;
                btn_exit.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Não foi possível abrir porta selecionada...");
                btn_openPort.Enabled = true;
                btn_closePort.Enabled = false;
                btn_exit.Enabled = true;
            }
        }

        private void btn_closePort_Click(object sender, EventArgs e)
        {
            serialCom.Close();
            btn_openPort.Enabled = true;
            btn_closePort.Enabled = false;
            btn_exit.Enabled = true;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen)
            {
                serialCom.Write(txt_send.Text);
            }
        }

        private void btn_clearRx_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen)
            {
                txt_send.Text= "";
            }

        }
    }
}
