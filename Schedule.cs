using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Driving_school_login_form
{
    public partial class Schedule : Form
    {
        private static readonly string ConnectionString = global::Driving_school_login_form.Properties.Settings.Default.GroupWst27ConnectionString;

        private Button _selectedSlot = null;
        private readonly List<Button> _timeSlotButtons = new List<Button>();

        // Slot colours
        private readonly Color ColorAvailable = Color.FromArgb(245, 248, 250);
        private readonly Color ColorAvailableText = Color.FromArgb(44, 62, 80);
        private readonly Color ColorTaken = Color.FromArgb(231, 76, 60);
        private readonly Color ColorSelected = Color.FromArgb(46, 204, 113);

        public Schedule()
        {
            InitializeComponent();
            CollectTimeSlotButtons();
            StyleTimeSlotButtons();
        }

        // ──────────────────────────────────────────────
        //  Find ALL time slot buttons (recursive)
        // ──────────────────────────────────────────────
        private void CollectTimeSlotButtons()
        {
            _timeSlotButtons.Clear();
            FindTimeSlotButtons(this);
        }

        private void FindTimeSlotButtons(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn && btn.Tag != null && btn.Tag.ToString() == "TimeSlot")
                {
                    _timeSlotButtons.Add(btn);
                }
                if (ctrl.HasChildren)
                {
                    FindTimeSlotButtons(ctrl);
                }
            }
        }

        private void StyleTimeSlotButtons()
        {
            foreach (Button btn in _timeSlotButtons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor = Color.FromArgb(189, 195, 199);
                btn.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                btn.Size = new Size(70, 32);
                btn.Cursor = Cursors.Hand;
                btn.BackColor = ColorAvailable;
                btn.ForeColor = ColorAvailableText;

                btn.MouseEnter += (s, e) =>
                {
                    if (btn.BackColor == ColorAvailable)
                        btn.BackColor = Color.FromArgb(220, 230, 240);
                };
                btn.MouseLeave += (s, e) =>
                {
                    if (btn.BackColor == Color.FromArgb(220, 230, 240))
                        btn.BackColor = ColorAvailable;
                };
            }
        }

        // ──────────────────────────────────────────────
        //  Form Load
        // ──────────────────────────────────────────────
        private void Schedule_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            LoadLessonTypes();
            LoadDurations();
            MarkBookedSlots(dateTimePicker1.Value);
        }

        // ──────────────────────────────────────────────
        //  Load Lesson Types from Database
        // ──────────────────────────────────────────────
        private void LoadLessonTypes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT DISTINCT LessonType FROM Lesson ORDER BY LessonType";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        cmbLessontype.Items.Clear();
                        while (reader.Read())
                        {
                            cmbLessontype.Items.Add(reader["LessonType"].ToString());
                        }
                    }
                }

                if (cmbLessontype.Items.Count == 0)
                {
                    cmbLessontype.Items.Add("Parking Practice");
                    cmbLessontype.Items.Add("Road Driving");
                    cmbLessontype.Items.Add("Highway Driving");
                    cmbLessontype.Items.Add("Night Driving");
                    cmbLessontype.Items.Add("Yard Practice");
                }

                cmbLessontype.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lesson types: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLessontype.Items.Add("Standard Lesson");
                cmbLessontype.SelectedIndex = 0;
            }
        }

        // ──────────────────────────────────────────────
        //  Load Duration Options (60 and 120 only)
        // ──────────────────────────────────────────────
        private void LoadDurations()
        {
            cboDuration.Items.Clear();
            cboDuration.Items.Add("60 minutes");
            cboDuration.Items.Add("120 minutes");
            cboDuration.SelectedIndex = 0;
        }

        // ──────────────────────────────────────────────
        //  Mark Booked Slots — checks Booking AND Lesson tables
        // ──────────────────────────────────────────────
        private void MarkBookedSlots(DateTime selectedDate)
        {
            var bookedHours = new HashSet<int>();

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    // Check Booking table
                    string bookingQuery =
                        "SELECT DISTINCT DATEPART(HOUR, ScheduledDateTime) AS HourSlot " +
                        "FROM Booking " +
                        "WHERE CAST(ScheduledDateTime AS DATE) = @SelectedDate " +
                        "AND BookingStatus IN ('Confirmed', 'Pending')";

                    using (SqlCommand cmd = new SqlCommand(bookingQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bookedHours.Add(Convert.ToInt32(reader["HourSlot"]));
                            }
                        }
                    }

                    // Check Lesson table
                    string lessonQuery =
                        "SELECT DISTINCT DATEPART(HOUR, LessonDateTime) AS HourSlot " +
                        "FROM Lesson " +
                        "WHERE CAST(LessonDateTime AS DATE) = @SelectedDate2 " +
                        "AND Status IN ('Confirmed', 'Pending', 'Rescheduled')";

                    using (SqlCommand cmd = new SqlCommand(lessonQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate2", selectedDate.Date);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                bookedHours.Add(Convert.ToInt32(reader["HourSlot"]));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking availability: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            _selectedSlot = null;

            foreach (Button btn in _timeSlotButtons)
            {
                int hour = GetHourFromButton(btn);
                bool isBooked = bookedHours.Contains(hour);

                if (isBooked)
                {
                    btn.BackColor = ColorTaken;
                    btn.ForeColor = Color.White;
                    btn.Enabled = false;
                    btn.Cursor = Cursors.No;
                }
                else
                {
                    btn.BackColor = ColorAvailable;
                    btn.ForeColor = ColorAvailableText;
                    btn.Enabled = true;
                    btn.Cursor = Cursors.Hand;
                }
            }
        }

        private int GetHourFromButton(Button btn)
        {
            string text = btn.Text.Trim();
            if (text.Length >= 2 && int.TryParse(text.Substring(0, 2), out int hour))
                return hour;
            return 0;
        }

        // ──────────────────────────────────────────────
        //  Time Slot Click — Select / Deselect
        // ──────────────────────────────────────────────
        private void timeSlot_Click(object sender, EventArgs e)
        {
            Button clickedBtn = (Button)sender;

            if (!clickedBtn.Enabled || clickedBtn.BackColor == ColorTaken)
            {
                MessageBox.Show("This time slot is already booked.\nPlease choose another slot.",
                    "Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_selectedSlot != null && _selectedSlot != clickedBtn)
            {
                _selectedSlot.BackColor = ColorAvailable;
                _selectedSlot.ForeColor = ColorAvailableText;
            }

            if (_selectedSlot == clickedBtn)
            {
                clickedBtn.BackColor = ColorAvailable;
                clickedBtn.ForeColor = ColorAvailableText;
                _selectedSlot = null;
            }
            else
            {
                clickedBtn.BackColor = ColorSelected;
                clickedBtn.ForeColor = Color.White;
                _selectedSlot = clickedBtn;
            }

            StudentData.SelectedSlotButton = _selectedSlot;
            lblSlotError.Visible = false;
        }

        // ──────────────────────────────────────────────
        //  Date Changed → Recheck Availability
        // ──────────────────────────────────────────────
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value.Date;

            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("You cannot select a past date. Please choose today or a future date.",
                    "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.Value = DateTime.Today;
                return;
            }

            MarkBookedSlots(selectedDate);
        }

        // ──────────────────────────────────────────────
        //  CONTINUE BUTTON
        // ──────────────────────────────────────────────
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            bool valid = true;

            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                lblDateError.Text = "Cannot select a past date";
                lblDateError.ForeColor = Color.Red;
                lblDateError.Visible = true;
                valid = false;
            }
            else
            {
                lblDateError.Visible = false;
            }

            if (cboDuration.SelectedIndex == -1)
            {
                lblDurationError.Text = "Please select a duration";
                lblDurationError.ForeColor = Color.Red;
                lblDurationError.Visible = true;
                valid = false;
            }
            else
            {
                lblDurationError.Visible = false;
            }

            if (_selectedSlot == null)
            {
                lblSlotError.Text = "Please select a time slot";
                lblSlotError.ForeColor = Color.Red;
                lblSlotError.Visible = true;
                valid = false;
            }
            else
            {
                lblSlotError.Visible = false;
            }

            if (cmbLessontype.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a lesson type.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valid = false;
            }

            if (!valid)
            {
                MessageBox.Show("Please complete all fields before continuing.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string durationText = cboDuration.SelectedItem.ToString();
            int duration = int.Parse(durationText.Split(' ')[0]);

            StudentData.Date = dateTimePicker1.Value;
            StudentData.Time = _selectedSlot.Text.Trim();
            StudentData.Duration = duration;
            StudentData.LessonType = cmbLessontype.SelectedItem.ToString();

            InstructorVehicleSelection vehicleInstruForm = new InstructorVehicleSelection();
            vehicleInstruForm.Show();
            this.Hide();
        }

        // ──────────────────────────────────────────────
        //  BACK BUTTON
        // ──────────────────────────────────────────────
        private void roundedButton2_Click(object sender, EventArgs e)
        {
            NewBooking newBooking = new NewBooking();
            newBooking.Show();
            this.Hide();
        }

        private void cboDuration_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDurationError.Visible = false;
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}