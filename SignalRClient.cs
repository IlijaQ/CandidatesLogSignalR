using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNetCore.SignalR.Client;

namespace CandidatesLogSignalR
{
    public partial class SignalRClient : Form
    {
        private HubConnection HubConnection { get; set; }

        public SignalRClient()
        {
            InitializeComponent();

            HubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:12345/NotificationHub")
                //.WithAutomaticReconnect()
                .Build();

            /// <summary>
            ///
            /// obsolete if you have .WithAutomaticReconnect() above
            /// but useful if you want to add logging ore some other actions when reconecting
            ///
            /// <summary>
            HubConnection.Closed += async (error) =>
            {
                await Task.Delay(new Random().Next(0, 5) * 1000);
                await HubConnection.StartAsync();
            };
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            HubConnection.On<string>("RecieveMessage", (message) =>
            {
                this.Invoke((MethodInvoker)delegate
                {
                    var newMessage = $"{DateTime.Now} {message}";
                    lbSignalRLogs.Items.Add(newMessage);
                });
            });

            try
            {
                await HubConnection.StartAsync();
                lbSignalRLogs.Items.Add($"{DateTime.Now} Connection started");
                btnConnect.Visible = false;
                lblConnected.Visible = true;
            }
            catch (Exception ex)
            {
                lbSignalRLogs.Items.Add($"{DateTime.Now} {ex.Message}");
            }
        }
    }
}
