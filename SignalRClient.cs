using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CandidatesLogSignalR
{
    public partial class SignalRClient : Form
    {
        public SignalRClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void tbClientSignalRHubUrl_TextChanged(object sender, EventArgs e)
        {
            if (tbClientSignalRHubUrl.Text.Length > 0)
                lblClientSignalRHubUrlPleaceholder.Visible = true;
            else
                lblClientSignalRHubUrlPleaceholder.Visible=false;
        }
    }
}
