namespace ConstructBids
{
    public partial class MainForm : Form
    {
        private string _proj_id;
        private int _proj_steps;
        private string _proj_desc;
        private int _proj_csize;
        private double _proj_hours;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            textID.Focus(); // focuses ID
            _proj_id = ""; _proj_steps = 1; _proj_desc = ""; _proj_csize = 0; _proj_hours = 0; // declares initial variable values
            labelStepNum.Text = "1"; // makes sure step number text is 1
            PROJ_ID.Visible = false;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            LaborEstimate(int.Parse(textCrewSize.Text), double.Parse(textHoursNeeded.Text));

            // Handles project ID
            PROJ_ID.Text = textID.Text;
            PROJ_ID.Visible = true;
            textID.Enabled = false;
            textID.Visible = false;

            // updates proj variables
            _proj_steps++;
            if (_proj_id == "") { _proj_id = textID.Text; }
            _proj_csize = _proj_csize + int.Parse(textCrewSize.Text);
            _proj_hours = _proj_hours + double.Parse(textHoursNeeded.Text);

            // resets form
            labelStepNum.Text = $"{_proj_steps}";
            ResetForm(false);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ProjectSummary();
            ResetForm(true);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void LaborEstimate(int csize, double hours)
        {
            MessageBox.Show($"This step will require {(csize * hours):F2} hours.", "Labor Estimate", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProjectSummary()
        {
            MessageBox.Show($"Project {_proj_id} consists of {_proj_steps} steps, and will require {(_proj_csize * _proj_hours):F2} man hours.",
                "Project Summary",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ResetForm(bool newProject)
        {
            if (newProject)
            {
                textID.Visible = true; // makes ID text box visible again
                textID.Enabled = true; // makes ID text box is enabled again
                textID.Focus(); // sets focus back to text box
                textID.Text = ""; // makes sure nothing is in the text box.
                PROJ_ID.Text = ""; // resets the label for the Project ID.
                PROJ_ID.Visible = false; // hides the label ID.
                labelStepNum.Text = "1"; // resets step number
                _proj_id = ""; _proj_steps = 1; _proj_desc = ""; _proj_csize = 0; _proj_hours = 0; // resets variables
            }
            else
            {
                textDesc.Focus(); // if this isn't a new project, just set focus on description.
            }

            textDesc.Text = "";
            textCrewSize.Text = "";
            textHoursNeeded.Text = "";
        }
    }
}
