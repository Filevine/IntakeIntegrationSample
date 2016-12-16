using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilevineIntakeIntegrationDemo
{
    public partial class Form1 : Form
    {
        private readonly FilevineClient _api;
        private GetOrgListResult _orgListResult;
        private readonly Color _successColor = Color.DarkRed;
        private readonly Color _failureColor = Color.ForestGreen;

        public Form1()
        {
            InitializeComponent();
            _api = new FilevineClient();
        }

        private void tbxApiKey_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void cboFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProjectType.Items.Clear();

            SetButtons();

            if (cboFirm.SelectedItem != null)
            {
                var projectTypes = ((OrgMinimalResponse) cboFirm.SelectedItem).ProjectTypes;
                foreach (var projectType in projectTypes)
                    cboProjectType.Items.Add(projectType);
            }
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

            tbxGetOrgResult.Visible = false;
            tbxSendProjectResult.Visible = false;
        }

        private async void btnSendProject_Click(object sender, EventArgs e)
        {
            var result = await _api.SendProjectInfo(
                tbxApiKey.Text, 
                ((OrgMinimalResponse)cboFirm.SelectedItem).ID, 
                ((ProjectTypeMinimalResponse)cboProjectType.SelectedItem).ID, 
                tbxClientFirstName.Text, 
                tbxClientLastName.Text);

            if (result.Success)
            {
                tbxSendProjectResult.Text = $"SUCCESS - sent Project\r\n{result.Data.ProjectUrl}";
                tbxSendProjectResult.ForeColor = _successColor;
            }
            else
            {
                tbxSendProjectResult.Text = $"FAILED - {result.Message}";
                tbxSendProjectResult.ForeColor = _failureColor;
            }

            SetButtons();

            tbxSendProjectResult.Visible = true;
        }

        private async void btnGetList_Click(object sender, EventArgs e)
        {
            cboFirm.Items.Clear();
            cboProjectType.Items.Clear();

            _orgListResult = await _api.CallForOrgList(tbxApiKey.Text);
            if (_orgListResult.Success)
            {
                tbxGetOrgResult.Text = "SUCCESS - loaded Firms";
                tbxGetOrgResult.ForeColor = _successColor;

                foreach (var org in _orgListResult.Data)
                    cboFirm.Items.Add(org);
            }
            else
            {
                tbxGetOrgResult.Text = $"FAILED - {_orgListResult.Message}";
                tbxGetOrgResult.ForeColor = _failureColor;
            }

            SetButtons();

            tbxGetOrgResult.Visible = true;
        }
    }
}
