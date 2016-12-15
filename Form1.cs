using System;
using System.Windows.Forms;

namespace FilevineIntakeIntegrationDemo
{
    public partial class Form1 : Form
    {
        private FilevineCalls api;
        public Form1()
        {
            InitializeComponent();
            api = new FilevineCalls();
        }

        private void tbxApiKey_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void cboFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void cboProjectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void tbxClientFirstName_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void tbxClientLastName_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void SetButtons()
        {
            btnGetList.Enabled =
                tbxApiKey.Text.Trim() != "";

            btnSendProject.Enabled =
                tbxApiKey.Text.Trim() != "" &&
                cboFirm.Items.Count > 0 && cboFirm.SelectedItem != null &&
                cboProjectType.Items.Count > 0 && cboProjectType.SelectedItem != null &&
                tbxClientFirstName.Text.Trim() != "" &&
                tbxClientLastName.Text.Trim() != "";
        }

        private void btnSendProject_Click(object sender, EventArgs e)
        {
            var result = api.SendProjectInfo(tbxApiKey.Text, (int)cboFirm.SelectedValue, (int)cboProjectType.SelectedValue, tbxClientFirstName.Text, tbxClientLastName.Text);
            //TODO show either projectID and "Success" or error
        }

        private void btnGetList_Click(object sender, EventArgs e)
        {
            var result = api.CallForOrgList(tbxApiKey.Text);
            //TODO load combos or show error
        }
    }
}
