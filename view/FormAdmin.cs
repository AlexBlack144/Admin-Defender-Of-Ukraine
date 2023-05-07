using Game_Kursak_Admin.controller;
using Game_Kursak_Admin.model;
using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;

namespace Game_Kursak_Admin
{
    public partial class FormAdmin : Form
    {
        Controller controller = new Controller();
        public List<SaveResult> list_result_client = new List<SaveResult>();

        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.server = new SimpleTcpServer(controller.server_paraments.HOST_PORT);
            controller.server.Events.ClientConnected += Events_ClientConnected;
            controller.server.Events.ClientDisconnected += Events_ClientDisconnected;
            controller.server.Events.DataReceived += Events_DataReceived;

            controller.ShowDB(dataGridView_Results, dataGridView_Bans);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void start_server_btn_Click(object sender, EventArgs e)
        {
            this.label_online.ForeColor = Color.Green;
            controller.StartServer(stop_server_btn, start_server_btn );
        }

        private void stop_server_btn_Click(object sender, EventArgs e)
        {
            controller.StopServer(stop_server_btn, start_server_btn);
            this.label_online.ForeColor = Color.Red;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            controller.DeleteFromDB(dataGridView_Results.SelectedCells[0].Value.ToString());
            controller.ShowDB(dataGridView_Results, dataGridView_Bans);
            
        }

        private void button_ban_Click(object sender, EventArgs e)
        {
            string id = dataGridView_Results.SelectedCells[0].Value.ToString();
            controller.AddToBan(id);
            controller.ShowDB(dataGridView_Results, dataGridView_Bans);
        }



        private void Events_DataReceived(object sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
               
                string msg = $"{Encoding.UTF8.GetString(e.Data.Array)}";
                if (msg.Contains("Name: "))
                {
                    msg += $"IP Port: {e.IpPort}";
                    listBox_IP_clients.Items.Add(msg);
                }
                else 
                {
                    controller.AddToDB(msg);
                    controller.server.Send(e.IpPort, controller.ConverDBtoJson());
                }
                controller.ShowDB(dataGridView_Results, dataGridView_Bans);
            });

           
        }

        private void Events_ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                string ipPort = $"{e.IpPort}";
                for (int i = 0; i < listBox_IP_clients.Items.Count; i++)
                {
                    if (listBox_IP_clients.Items[i].ToString().Contains(ipPort))
                    {
                        listBox_IP_clients.Items.RemoveAt(i);
                    }
                }
                
               
            });
        }

        private void Events_ClientConnected(object sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
            });
        }

        private void button_delete_ban_Click(object sender, EventArgs e)
        {
            controller.DeleteFromBan(dataGridView_Bans.SelectedCells[0].Value.ToString());
            controller.ShowDB(dataGridView_Results, dataGridView_Bans);
        }
    }
}
