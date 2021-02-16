using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CourseWorkTwo.Models
{
    class Prediction
    {
        public DataGridView eventTimeUsageDGV;
        public DataGridView appointmentTimeUsageDGV;
        public DataGridView taskTimeUsageDGV;

        public DataGridView eventPredictFullDGV;
        public DataGridView eventPredictQuarterDGV;
        public DataGridView appointmentPredictFullDGV;
        public DataGridView appointmentPredictQuarterDGV;
        public DataGridView taskPredictFullDGV;
        public DataGridView taskPredictQuarterDGV;

        private DateTimePicker predictionFromDateBox;
        private DateTimePicker predictionToDateBox;
        private TextBox eventTimeUsageAndPredictionText;
        private TextBox appointmentTimeUsageAndPredictionText;
        private TextBox taskTimeUsageAndPredictionText;
        private TextBox averageUsagePerDayText;

        private ComboBox firstMonthSelectBox;
        private ComboBox secondMonthSelectBox;
        private Label totalTimeUsageAndPredictionResultsLabel;
        public DataGridView EventTimeUsageDGV { get; set; }
        public DataGridView AppointmentTimeUsageDGV { get; set; }
        public DataGridView TaskTimeUsageDGV { get; set; }

        public DataGridView EventPredictFullDGV { get; set; }
        public DataGridView EventPredictQuarterDGV { get; set; }
        public DataGridView AppointmentPredictFullDGV { get; set; }
        public DataGridView AppointmentPredictQuarterDGV { get; set; }
        public DataGridView TaskPredictFullDGV { get; set; }
        public DataGridView TaskPredictQuarterDGV { get; set; }

        public DateTimePicker PredictionFromDateBox { get; set; }
        public DateTimePicker PredictionToDateBox { get; set; }
        public TextBox EventTimeUsageAndPredictionText { get; set; }
        public TextBox AppointmentTimeUsageAndPredictionText { get; set; }
        public TextBox TaskTimeUsageAndPredictionText { get; set; }
        public TextBox AverageUsagePerDayText { get; set; }


        public ComboBox FirstMonthSelectBox { get; set; }
        public ComboBox SecondMonthSelectBox { get; set; }
        public Label TotalTimeUsageAndPredictionResultsLabel { get; set; }


        public void viewTimeUsage()
        {
            eventTimeUsageDGV = EventTimeUsageDGV;
            appointmentTimeUsageDGV = AppointmentTimeUsageDGV;
            taskTimeUsageDGV = TaskTimeUsageDGV;
            predictionFromDateBox = PredictionFromDateBox;
            predictionToDateBox = PredictionToDateBox;
            eventTimeUsageAndPredictionText = EventTimeUsageAndPredictionText;
            appointmentTimeUsageAndPredictionText = AppointmentTimeUsageAndPredictionText;
            taskTimeUsageAndPredictionText = TaskTimeUsageAndPredictionText;
            averageUsagePerDayText = AverageUsagePerDayText;
            totalTimeUsageAndPredictionResultsLabel = TotalTimeUsageAndPredictionResultsLabel;

            try
            {
                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //Event time usage count startes here
                string eventTimeUsageCountQuery = "SELECT hours_count,minutes_count,seconds_count FROM event_prediction_purpose WHERE date_from BETWEEN '" + predictionFromDateBox.Text + "' AND '" + predictionToDateBox.Text + "' ;";

                SqlCommand eventTimeUsageCountCommand = new SqlCommand(eventTimeUsageCountQuery, databaseConnection);
                SqlDataAdapter eventTimeUsageCountDataAdapter = new SqlDataAdapter(eventTimeUsageCountCommand);
                DataTable eventTimeUsageCountDataTable = new DataTable();
                eventTimeUsageCountDataAdapter.Fill(eventTimeUsageCountDataTable);

                eventTimeUsageDGV.DataSource = new BindingSource(eventTimeUsageCountDataTable, null);

                //Calculating hours in available each row untill it come to the last row
                int eventHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in eventTimeUsageDGV.Rows)
                {
                    {
                        eventHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn11"].Value);
                    }
                }
                int eventMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in eventTimeUsageDGV.Rows)
                {
                    {
                        eventMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn11"].Value);
                    }
                }
                int eventSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in eventTimeUsageDGV.Rows)
                {
                    {
                        eventSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn11"].Value);
                    }
                }

                int eventSecondstoMinutes = eventSecondsUsage / 60;
                int eventMinutestoHours = (eventSecondstoMinutes + eventMinutesUsage) / 60;
                int eventTotalHoursUsage = eventMinutestoHours + eventHoursUsage;

                int eventSelectedDays = eventTimeUsageDGV.Rows.Count;

                eventTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", eventHoursUsage + " Minutes: " + eventMinutesUsage +
                                                        " Seconds: " + eventSecondsUsage + " = Total Hours : " + eventTotalHoursUsage);

                //Appointment time usage count startes here
                string appointmentTimeUsageCountQuery = "SELECT hours_count,minutes_count,seconds_count FROM appointment_prediction_purpose WHERE date_from BETWEEN '" + predictionFromDateBox.Text + "' AND '" + predictionToDateBox.Text + "' ;";

                SqlCommand appointmentTimeUsageCountCommand = new SqlCommand(appointmentTimeUsageCountQuery, databaseConnection);
                SqlDataAdapter appointmentTimeUsageCountDataAdapter = new SqlDataAdapter(appointmentTimeUsageCountCommand);
                DataTable appointmentTimeUsageCountDataTable = new DataTable();
                appointmentTimeUsageCountDataAdapter.Fill(appointmentTimeUsageCountDataTable);

                appointmentTimeUsageDGV.DataSource = new BindingSource(appointmentTimeUsageCountDataTable, null);

                //Calculating hours in available each row untill it come to the last row
                int appointmentHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentTimeUsageDGV.Rows)
                {
                    {
                        appointmentHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn10"].Value);
                    }
                }
                int appointmentMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentTimeUsageDGV.Rows)
                {
                    {
                        appointmentMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn10"].Value);
                    }
                }
                int appointmentSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentTimeUsageDGV.Rows)
                {
                    {
                        appointmentSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn10"].Value);
                    }
                }

                int appointmentSecondstoMinutes = appointmentSecondsUsage / 60;
                int appointmentMinutestoHours = (appointmentSecondstoMinutes + appointmentMinutesUsage) / 60;
                int appointmentTotalHoursUsage = appointmentMinutestoHours + appointmentHoursUsage;

                int appointmentSelectedDays = appointmentTimeUsageDGV.Rows.Count;

                appointmentTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", appointmentHoursUsage + " Minutes: " + appointmentMinutesUsage +
                                                        " Seconds: " + appointmentSecondsUsage + " = Total Hours : " + appointmentTotalHoursUsage);

                //Task time usage count startes here
                string taskTimeUsageCountQuery = "SELECT hours_count,minutes_count,seconds_count FROM task_prediction_purpose WHERE task_due_date BETWEEN '" + predictionFromDateBox.Text + "' AND '" + predictionToDateBox.Text + "' ;";

                SqlCommand taskTimeUsageCountCommand = new SqlCommand(taskTimeUsageCountQuery, databaseConnection);
                SqlDataAdapter taskTimeUsageCountDataAdapter = new SqlDataAdapter(taskTimeUsageCountCommand);
                DataTable taskTimeUsageCountDataTable = new DataTable();
                taskTimeUsageCountDataAdapter.Fill(taskTimeUsageCountDataTable);

                taskTimeUsageDGV.DataSource = new BindingSource(taskTimeUsageCountDataTable, null);

                int taskHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in taskTimeUsageDGV.Rows)
                {
                    {
                        taskHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn8"].Value);
                    }
                }
                int taskMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in taskTimeUsageDGV.Rows)
                {
                    {
                        taskMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn8"].Value);
                    }
                }
                int taskSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in taskTimeUsageDGV.Rows)
                {
                    {
                        taskSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn8"].Value);
                    }
                }

                int taskSecondstoMinutes = taskSecondsUsage / 60;
                int taskMinutestoHours = (taskSecondstoMinutes + taskMinutesUsage) / 60;
                int taskTotalHoursUsage = taskMinutestoHours + taskHoursUsage;

                int taskSelectedDays = taskTimeUsageDGV.Rows.Count;

                taskTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", taskHoursUsage + " Minutes: " + taskMinutesUsage +
                                                        " Seconds: " + taskSecondsUsage + " = Total Hours : " + taskTotalHoursUsage);

                int overallTotalSelectedDays = eventSelectedDays + appointmentSelectedDays + taskSelectedDays;
                int overallTotalHoursUsage = eventTotalHoursUsage + appointmentTotalHoursUsage + taskTotalHoursUsage;
                int averageHoursUsagePerDay = overallTotalHoursUsage / overallTotalSelectedDays;

                averageUsagePerDayText.Text = String.Format("Hours: {0:d}", averageHoursUsagePerDay);
                totalTimeUsageAndPredictionResultsLabel.Text = String.Format("Hours: {0:d}", overallTotalHoursUsage);
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Usage Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void viewTimeUsagePrediction()

        {
            eventPredictFullDGV = EventPredictFullDGV;
            eventPredictQuarterDGV = EventPredictQuarterDGV;
            appointmentPredictFullDGV = AppointmentPredictFullDGV;
            appointmentPredictQuarterDGV = AppointmentPredictQuarterDGV;
            taskPredictFullDGV = TaskPredictFullDGV;
            taskPredictQuarterDGV = TaskPredictQuarterDGV;

            eventTimeUsageAndPredictionText = EventTimeUsageAndPredictionText;
            appointmentTimeUsageAndPredictionText = AppointmentTimeUsageAndPredictionText;
            taskTimeUsageAndPredictionText = TaskTimeUsageAndPredictionText;
            averageUsagePerDayText = AverageUsagePerDayText;

            firstMonthSelectBox = FirstMonthSelectBox;
            secondMonthSelectBox = SecondMonthSelectBox;
            totalTimeUsageAndPredictionResultsLabel = TotalTimeUsageAndPredictionResultsLabel;

            try
            {

                SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;database=master");
                databaseConnection.Open();

                //Task hour count 100% starts from here
                string eventHundredPercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM event_prediction_purpose WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM event_prediction_purpose GROUP BY day HAVING COUNT(day) > 1)";

                SqlCommand eventHundredPercentCountCommand = new SqlCommand(eventHundredPercentCountQuery, databaseConnection);
                SqlDataAdapter eventHundredPercentCountDataAdapter = new SqlDataAdapter(eventHundredPercentCountCommand);
                DataTable eventHundredPercentCountDataTable = new DataTable();
                eventHundredPercentCountDataAdapter.Fill(eventHundredPercentCountDataTable);

                eventPredictFullDGV.DataSource = new BindingSource(eventHundredPercentCountDataTable, null);

                int eventHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in eventPredictFullDGV.Rows)
                {
                    {
                        eventHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn5"].Value);

                    }
                }
                int eventMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in eventPredictFullDGV.Rows)
                {
                    {
                       eventMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn5"].Value);
                    }
                }

                int eventSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in eventPredictFullDGV.Rows)
                {
                    {
                        eventSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn5"].Value);
                    }
                }

                int eventSecondstoMinutes = eventSecondsUsage / 60;
                int eventMinutestoHours = (eventSecondstoMinutes + eventMinutesUsage) / 60;
                int eventTotalHoursUsage = eventMinutestoHours + eventHoursUsage;

                int eventSelectedDatesMatched = eventPredictFullDGV.Rows.Count;

                ///Event hour count 25% starts from here
                string eventTwentyFivePercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM event_prediction_purpose WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM event_prediction_purpose GROUP BY day HAVING COUNT(day) = 1)";

                SqlCommand eventTwentyFivePercentCommand = new SqlCommand(eventTwentyFivePercentCountQuery, databaseConnection);
                SqlDataAdapter eventTwentyFivePercentDataAdapter = new SqlDataAdapter(eventTwentyFivePercentCommand);
                DataTable eventTwentyFivePercentDataTable = new DataTable();
                eventTwentyFivePercentDataAdapter.Fill(eventTwentyFivePercentDataTable);

                eventPredictQuarterDGV.DataSource = new BindingSource(eventTwentyFivePercentDataTable, null);

                int eventHoursUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in eventPredictQuarterDGV.Rows)
                {
                    {
                        eventHoursUsageTwo += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn13"].Value);
                    }
                }
                int eventMinutesUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in eventPredictQuarterDGV.Rows)
                {
                    {
                        eventMinutesUsageTwo += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn13"].Value);
                    }
                }

                int eventSecondsUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in eventPredictQuarterDGV.Rows)
                {
                    {
                        eventSecondsUsageTwo += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn13"].Value);
                    }
                }

                int eventSecondstoMinutesTwo = eventSecondsUsageTwo / 60;
                int eventMinutestoHoursTwo = (eventSecondstoMinutesTwo + eventMinutesUsageTwo) / 60;
                int eventTotalHoursUsageTwo = eventMinutestoHoursTwo + eventHoursUsageTwo;

                int eventTotalHoursUsageTwentyFivePercent = eventTotalHoursUsageTwo / 4;

                int eventTotalHoursUsageFiftyPercent = eventTotalHoursUsageTwentyFivePercent / 2;

                int finalTotalEventHours = eventTotalHoursUsage + eventTotalHoursUsageFiftyPercent + eventTotalHoursUsageTwentyFivePercent;

                eventTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", +finalTotalEventHours);

                int eventSelectedDatesNotMatched = eventPredictQuarterDGV.Rows.Count;

                //Appointment Predcition Calculation Part--------------------------------------------------------------------------------------------------------
                //appointment Calculation 100%

                string appointmentHundredPercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM appointment_prediction_purpose " +
                          "WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM appointment_prediction_purpose GROUP BY day HAVING COUNT(day) > 1)";

                SqlCommand appointmentHundredPercentCountCommand = new SqlCommand(appointmentHundredPercentCountQuery, databaseConnection);
                SqlDataAdapter appointmentHundredPercentCountDataAdapter = new SqlDataAdapter(appointmentHundredPercentCountCommand);
                DataTable appointmentHundredPercentCountDataTable = new DataTable();
                appointmentHundredPercentCountDataAdapter.Fill(appointmentHundredPercentCountDataTable);

                appointmentPredictFullDGV.DataSource = new BindingSource(appointmentHundredPercentCountDataTable, null);

                int appointmentHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictFullDGV.Rows)
                {
                    {
                        appointmentHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn12"].Value);

                    }
                }
                int appointmentMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictFullDGV.Rows)
                {
                    {
                        appointmentMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn12"].Value);
                    }
                }

                int appointmentSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictFullDGV.Rows)
                {
                    {
                        appointmentSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn12"].Value);
                    }
                }

                int appointmentSecondstoMinutes = appointmentSecondsUsage / 60;
                int appointmentMinutestoHours = (appointmentSecondstoMinutes + appointmentMinutesUsage) / 60;
                int appointmentTotalHoursUsage = appointmentMinutestoHours + appointmentHoursUsage;

                int appointmentSelectedDatesMatched = appointmentPredictFullDGV.Rows.Count;

                //Appointment 25% Calculation--

                string appointmentTwentyFivePercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM appointment_prediction_purpose " +
                          "WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM appointment_prediction_purpose GROUP BY day HAVING COUNT(day) = 1)";

                SqlCommand appointmentTwentyFivePercentCommand = new SqlCommand(appointmentTwentyFivePercentCountQuery, databaseConnection);
                SqlDataAdapter appointmentTwentyFivePercentDataAdapter = new SqlDataAdapter(appointmentTwentyFivePercentCommand);
                DataTable appointmentTwentyFivePercentDataTable = new DataTable();
                appointmentTwentyFivePercentDataAdapter.Fill(appointmentTwentyFivePercentDataTable);

                appointmentPredictQuarterDGV.DataSource = new BindingSource(appointmentTwentyFivePercentDataTable, null);

                int appointmentHoursUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictQuarterDGV.Rows)
                {
                    {
                        appointmentHoursUsageTwo += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn9"].Value);
                    }
                }
                int appointmentMinutesUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictQuarterDGV.Rows)
                {
                    {
                        appointmentMinutesUsageTwo += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn9"].Value);
                    }
                }

                int appointmentSecondsUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in appointmentPredictQuarterDGV.Rows)
                {
                    {
                        appointmentSecondsUsageTwo += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn9"].Value);
                    }
                }

                int appointmentSecondstoMinutesTwo = appointmentSecondsUsageTwo / 60;
                int appointmentMinutestoHoursTwo = (appointmentSecondstoMinutesTwo + appointmentMinutesUsageTwo) / 60;
                int appointmentTotalHoursUsageTwo = appointmentMinutestoHoursTwo + appointmentHoursUsageTwo;

                int appointmentTotalHoursUsageTwentyFivePercent = appointmentTotalHoursUsageTwo / 4;

                int appointmentTotalHoursUsageFiftyPercent = appointmentTotalHoursUsageTwentyFivePercent / 2;

                int finalTotalAppointmentHours = appointmentTotalHoursUsage + appointmentTotalHoursUsageFiftyPercent + appointmentTotalHoursUsageTwentyFivePercent;

                appointmentTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", +finalTotalAppointmentHours);

                int appointmentSelectedDatesNotMatched = appointmentPredictQuarterDGV.Rows.Count;

                //Task Predcition Calculation Part--------------------------------------------------------------------------------------------------------
                //Task hours Calculation 100%

                string taskHundredPercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM task_prediction_purpose " +
                          "WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM task_prediction_purpose GROUP BY day HAVING COUNT(day) > 1)";

                SqlCommand taskHundredPercentCountCommand = new SqlCommand(taskHundredPercentCountQuery, databaseConnection);
                SqlDataAdapter taskHundredPercentCountDataAdapter = new SqlDataAdapter(taskHundredPercentCountCommand);
                DataTable taskHundredPercentCountDataTable = new DataTable();

                taskHundredPercentCountDataAdapter.Fill(taskHundredPercentCountDataTable);

                taskPredictFullDGV.DataSource = new BindingSource(taskHundredPercentCountDataTable, null);

                int taskHoursUsage = 0;
                foreach (DataGridViewRow selectedRow in taskPredictFullDGV.Rows)
                {
                    Console.WriteLine(taskHoursUsage);
                    {
                        taskHoursUsage += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn7"].Value);
                    }
                }
                int taskMinutesUsage = 0;
                foreach (DataGridViewRow selectedRow in taskPredictFullDGV.Rows)
                {
                    {
                        taskMinutesUsage += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn7"].Value);
                    }
                }
                int taskSecondsUsage = 0;
                foreach (DataGridViewRow selectedRow in taskPredictFullDGV.Rows)
                {
                    {
                        taskSecondsUsage += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn7"].Value);
                    }
                }
                int taskSecondstoMinutes = taskSecondsUsage / 60;
                int taskMinutestoHours = (taskSecondstoMinutes + taskMinutesUsage) / 60;
                Console.WriteLine(taskHoursUsage);
                int taskTotalHoursUsage = taskMinutestoHours + taskHoursUsage;
                Console.WriteLine(taskTotalHoursUsage);
                int taskSelectedDatesMatched = taskPredictFullDGV.Rows.Count;


                //Task hour count 25% starts from here
                string taskTwentyFivePercentCountQuery = "SELECT day,month,hours_count,minutes_count,seconds_count FROM task_prediction_purpose " +
                          "WHERE month BETWEEN '" + firstMonthSelectBox.Text + "' AND '" + secondMonthSelectBox.Text + "' AND day " +
                          "IN( SELECT day  FROM task_prediction_purpose GROUP BY day HAVING COUNT(day) = 1)";

                SqlCommand taskTwentyFivePercentCommand = new SqlCommand(taskTwentyFivePercentCountQuery, databaseConnection);
                SqlDataAdapter taskTwentyFivePercentDataAdapter = new SqlDataAdapter(taskTwentyFivePercentCommand);
                DataTable taskTwentyFivePercentDataTable = new DataTable();
                taskTwentyFivePercentDataAdapter.Fill(taskTwentyFivePercentDataTable);

                taskPredictQuarterDGV.DataSource = new BindingSource(taskTwentyFivePercentDataTable, null);

               
                int taskHoursUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in taskPredictQuarterDGV.Rows)
                {
                    {
                        taskHoursUsageTwo += Convert.ToInt32(selectedRow.Cells["hourscountDataGridViewTextBoxColumn6"].Value);
                    }
                }
                int taskMinutesUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in taskPredictQuarterDGV.Rows)
                {
                    {
                        taskMinutesUsageTwo += Convert.ToInt32(selectedRow.Cells["minutescountDataGridViewTextBoxColumn6"].Value);
                    }
                }
                int taskSecondsUsageTwo = 0;
                foreach (DataGridViewRow selectedRow in taskPredictQuarterDGV.Rows)
                {
                    {
                        taskSecondsUsageTwo += Convert.ToInt32(selectedRow.Cells["secondscountDataGridViewTextBoxColumn6"].Value);
                    }
                }
                int taskSecondstoMinutesTwo = taskSecondsUsageTwo / 60;
                int taskMinutestoHoursTwo = (taskSecondstoMinutesTwo + taskMinutesUsageTwo) / 60;
                int taskTotalHoursUsageTwo = taskMinutestoHoursTwo + taskHoursUsageTwo;

                int taskTotalHoursUsageTwentyFivePercent = taskTotalHoursUsageTwo / 4;

                int taskTotalHoursUsageFiftyPercent = taskTotalHoursUsageTwentyFivePercent / 2;

                int finalTotalTaskHours = taskTotalHoursUsage + taskTotalHoursUsageFiftyPercent + taskTotalHoursUsageTwentyFivePercent;

                int taskSelectedDatesNotMatched = taskPredictQuarterDGV.Rows.Count;

                taskTimeUsageAndPredictionText.Text = String.Format("Hours: {0:d}", +finalTotalTaskHours);

                int overallTotalCountedDays = eventSelectedDatesMatched + eventSelectedDatesNotMatched +
                                             appointmentSelectedDatesMatched + appointmentSelectedDatesNotMatched +
                                             taskSelectedDatesMatched + taskSelectedDatesNotMatched;

                //overal total counted hours
                int overallTotalCountedHours = finalTotalEventHours + finalTotalAppointmentHours + finalTotalTaskHours;

                //average time preicted per day
                int averageTimePredictionPerDay = overallTotalCountedHours / overallTotalCountedDays;

                averageUsagePerDayText.Text = String.Format("Hours: {0:d}", +averageTimePredictionPerDay);
                
                totalTimeUsageAndPredictionResultsLabel.Text = String.Format("Hours: {0:d}", +overallTotalCountedHours);
            }
            catch (SqlException producedException)
            {
                MessageBox.Show("Failed function(s) detected." + Environment.NewLine + "Detailed Information: " + producedException.Message, "Prediction Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
