namespace HotelReservations
{
    public partial class Form1 : Form
    {
        const double ST2Q_PRICE = 85.95;
        const double STKING_PRICE = 89.95;
        const double SU2Q_PRICE = 125.95;
        const double SUKING_PRICE = 129.95;
        double totalCost = 0;
        int nightsReserved = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            int numRooms = int.Parse(numRoomsIn.Text);
            int numNights = int.Parse(numNightsIn.Text);
            double reserveCharge = 0;

            string summary = $"{nameIn.Text} has reserved ";
            if (ST2Q.Checked)
            {
                reserveCharge = (ST2Q_PRICE * numRooms) * numNights;
                summary += $"{numRoomsIn.Text} Standard(s) with 2 queen-size beds for {numNightsIn.Text} night(s).";
                summary += $"\n\nThe total charge for this reservation is {reserveCharge:C2}.";
            }
            else if (STKING.Checked)
            {
                reserveCharge = (STKING_PRICE * numRooms) * numNights;
                summary += $"{numRoomsIn.Text} Standard(s) with a king-sized bed for {numNightsIn.Text} night(s).";
                summary += $"\n\nThe total charge for this reservation is {reserveCharge:C2}.";
            }
            else if (SU2Q.Checked)
            {
                reserveCharge = (SU2Q_PRICE * numRooms) * numNights;
                summary += $"{numRoomsIn.Text} Suite(s) with 2 queen-size beds for {numNightsIn.Text} night(s).";
                summary += $"\n\nThe total charge for this reservation is {reserveCharge:C2}.";
            }
            else if (SUKING.Checked)
            {
                reserveCharge = (SUKING_PRICE * numRooms) * numNights;
                summary += $"{numRoomsIn.Text} Suite(s) with a king-sized beds for {numNightsIn.Text} night(s).";
                summary += $"\n\nThe total charge for this reservation is {reserveCharge:C2}.";
            }

            totalCost += reserveCharge;
            nightsReserved += (numNights * numRooms);

            MessageBox.Show(summary, "Reservation Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nameIn.Clear();
            nameIn.Focus();
            checkinIn.Clear();
            numNightsIn.Clear();
            numRoomsIn.Clear();
            ST2Q.Checked = true;
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{nightsReserved} room-nights of reservations were placed today.\n\n" +
                            $"The total amount due for these reservations is {totalCost:C2}.",
                            "Daily Reservation Summary",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
