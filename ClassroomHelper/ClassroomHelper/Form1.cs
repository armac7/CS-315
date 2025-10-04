namespace ClassroomHelper
{
    public partial class Form1 : Form
    {
        int totalStudents = 0;
        int totalPassed = 0;
        double totalAvg = 0;
        double highestAvg = 0;
        double lowestAvg = 101;

        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string result;
            if (string.IsNullOrWhiteSpace(exam1In.Text) || string.IsNullOrWhiteSpace(exam2In.Text) || string.IsNullOrWhiteSpace(exam3In.Text))
            {
                result = "Please input data into each field.";
                MessageBox.Show(result, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(exam1In.Text, out int exam1Grade) || !int.TryParse(exam2In.Text, out int exam2Grade) || !int.TryParse(exam3In.Text, out int exam3Grade)) 
            {
                result = "All exam values must be a non-decimal number.";
                MessageBox.Show(result, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] grades = { exam1Grade, exam2Grade, exam3Grade };
            Array.Sort(grades);

            //MessageBox.Show($"{grades[0]}, {grades[1]}, {grades[2]}");
            double studentFinalAvg = (grades[0] + (grades[1] * 2) + (grades[2] * 3)) / 6.0;
            totalAvg += (studentFinalAvg);
            totalStudents++;

            if (studentFinalAvg >= 72) totalPassed++;

            if (studentFinalAvg > highestAvg) highestAvg = studentFinalAvg;
            if (studentFinalAvg < lowestAvg) lowestAvg = studentFinalAvg;

            MessageBox.Show($"{nameIn.Text} had an average of {studentFinalAvg:F1}", "Student Average Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameIn.Clear();
            exam1In.Clear();
            exam2In.Clear();
            exam3In.Clear();
            nameIn.Focus();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            totalAvg = totalAvg / totalStudents;
            MessageBox.Show($"Total Students: {totalStudents}\n" +
                $"Total Students Passed: {totalPassed}\n" +
                $"Total Average: {totalAvg:F1}\n" +
                $"\tHighest Average: {highestAvg:F1}\n" +
                $"\tLowest Average: {lowestAvg:F1}",
                "Classroom Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.Exit();
        }

    }
}
