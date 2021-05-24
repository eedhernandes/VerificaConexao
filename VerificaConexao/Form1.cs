using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace VerificaConexao
{
    public partial class Form1 : Form
    {
        string status1 = "";
        readonly string ipDestino = "8.8.8.8";
        int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblIpDestino.Text = ipDestino;

            tmr1.Start();
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            try
            {
                System.Net.NetworkInformation.Ping ping = new System.Net.NetworkInformation.Ping();

                System.Net.NetworkInformation.PingReply pingStatus =
                    ping.Send(IPAddress.Parse(ipDestino), 1000);

                if (pingStatus.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    status1 = "Conectado";

                    cont = 0;
                }
                else
                {
                    status1 = "Desconectado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cabo de rede descontado ou sinal de WiFi perdido, verifique e tente novamente! " + ex, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            lblStatus.Text = status1;

            if (status1 == "Desconectado")
            {
                tmr1.Stop();

                if (cont != 1)
                {
                    DialogResult mensagem = MessageBox.Show("Você está desconectado da internet!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (mensagem == DialogResult.OK)
                    {
                        tmr1.Start();

                        cont = 1;
                    }
                }
                else
                {
                    tmr1.Start();
                }
            }
        }

        private void btnIniciarVerificacao_Click(object sender, EventArgs e)
        {
            tmr1.Stop();
            tmr1.Start();
        }

        private void btnPararVerificacao_Click(object sender, EventArgs e)
        {
            tmr1.Stop();

            lblStatus.Text = "Parado";
        }
    }
}
