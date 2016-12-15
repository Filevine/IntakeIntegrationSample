using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace FilevineIntakeIntegrationDemo
{
    public partial class Form1 : Form
    {
        private readonly FilevineCalls _api;
        private List<OrgMinimalResponse> _orgList;

        public Form1()
        {
            InitializeComponent();
            _api = new FilevineCalls();
        }

        private void tbxApiKey_TextChanged(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void cboFirm_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProjectType.Items.Clear();

            SetButtons();

            if (cboFirm.SelectedValue != null)
            {
                var projectTypes = ((OrgMinimalResponse) cboFirm.SelectedValue).ProjectTypes;
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
        }

        private async void btnSendProject_Click(object sender, EventArgs e)
        {
            var result = await _api.SendProjectInfo(tbxApiKey.Text, (int)cboFirm.SelectedValue, (int)cboProjectType.SelectedValue, tbxClientFirstName.Text, tbxClientLastName.Text);
            //TODO show either projectID and "Success" or error
        }

        private async void btnGetList_Click(object sender, EventArgs e)
        {
            cboFirm.Items.Clear();

            _orgList = await _api.CallForOrgList(tbxApiKey.Text);

            foreach (var org in _orgList)
                cboFirm.Items.Add(org);

            //TODO show error
        }
    }
}
