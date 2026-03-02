using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class Rich_Controls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void calDOB_SelectionChanged(object sender, EventArgs e)
        {
            // Get selected DOB
            DateTime selectedDate = calDOB.SelectedDate;

            // Format date
            string dobFormatted = selectedDate.ToString("dd-MM-yyyy");

            // Set DOB in TextBox
            txtDOB.Text = dobFormatted;

            // Get Name
            string name = txtName.Text.Trim();

            // Get Uploaded File Name
            string fileName = fuProfile.HasFile ? fuProfile.FileName : "No file uploaded";

            // Display Output
            lblOutput.Text = $"Name: {name}, DOB: {dobFormatted}, File: {fileName}";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}