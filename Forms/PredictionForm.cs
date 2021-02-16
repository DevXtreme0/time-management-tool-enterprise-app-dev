using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CourseWorkTwo.Models;

namespace CourseWorkTwo.Forms
{
    public partial class PredictionForm : UserControl
    {
        Prediction alignToPrediction = new Prediction();
        public PredictionForm()
        {
            InitializeComponent();
            //set all the fields hidden that is related to bottom information
            eventTimeUsageLabel.Visible = false;
            eventTimeUsageAndPredictionText.Visible = false;

            appointmentTimeUsageLabel.Visible = false;
            appointmentTimeUsageAndPredictionText.Visible = false;

            taskTimeUsageLabel.Visible = false;
            taskTimeUsageAndPredictionText.Visible = false;

            averageUsagePerDayLabel.Visible = false;
            averageUsagePerDayText.Visible = false;

            totalTimeUsageAndPredictionLabel.Visible = false;
            totalTimeUsageAndPredictionResultsLabel.Visible = false;

            timeUsageButton.Enabled = false;
            predictNowButton.Enabled = false;

        }

        private void timeUsageButton_Click_1(object sender, EventArgs e)
        {
            if (predictionFromDateBox.Text == "" || predictionToDateBox.Text == "" )
            {
                MessageBox.Show("Both date selections are required." + Environment.NewLine, "Time Usage View Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                alignToPrediction.EventTimeUsageDGV = eventTimeUsageDGV;
                alignToPrediction.AppointmentTimeUsageDGV = appointmentTimeUsageDGV;
                alignToPrediction.TaskTimeUsageDGV = taskTimeUsageDGV;
                alignToPrediction.PredictionFromDateBox = predictionFromDateBox;
                alignToPrediction.PredictionToDateBox = predictionToDateBox;
                alignToPrediction.EventTimeUsageAndPredictionText = eventTimeUsageAndPredictionText;
                alignToPrediction.AppointmentTimeUsageAndPredictionText = appointmentTimeUsageAndPredictionText;
                alignToPrediction.TaskTimeUsageAndPredictionText = taskTimeUsageAndPredictionText;
                alignToPrediction.AverageUsagePerDayText = averageUsagePerDayText;
                alignToPrediction.TotalTimeUsageAndPredictionResultsLabel = totalTimeUsageAndPredictionResultsLabel;

                alignToPrediction.viewTimeUsage();

            }
        }

        private void predictButton_Click(object sender, EventArgs e)
        {
            if (firstMonthSelectBox.Text == "" || firstMonthSelectBox.SelectedIndex == 0 || firstMonthSelectBox.SelectedIndex == -1 ||
                secondMonthSelectBox.Text == "" || secondMonthSelectBox.SelectedIndex == 0 || secondMonthSelectBox.SelectedIndex == -1)
            {
                MessageBox.Show("Two months required to predict." + Environment.NewLine , "Predict Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                alignToPrediction.EventPredictFullDGV = eventPredictFullDGV;
                alignToPrediction.EventPredictQuarterDGV = eventPredictQuarterDGV;
                alignToPrediction.AppointmentPredictFullDGV = appointmentPredictFullDGV;
                alignToPrediction.AppointmentPredictQuarterDGV = appointmentPredictQuarterDGV;
                alignToPrediction.TaskPredictFullDGV = taskPredictFullDGV;
                alignToPrediction.TaskPredictQuarterDGV = taskPredictQuarterDGV;

                alignToPrediction.EventTimeUsageAndPredictionText = eventTimeUsageAndPredictionText;
                alignToPrediction.AppointmentTimeUsageAndPredictionText = appointmentTimeUsageAndPredictionText;
                alignToPrediction.TaskTimeUsageAndPredictionText = taskTimeUsageAndPredictionText;
                alignToPrediction.AverageUsagePerDayText = averageUsagePerDayText;

                alignToPrediction.FirstMonthSelectBox = firstMonthSelectBox;
                alignToPrediction.SecondMonthSelectBox = secondMonthSelectBox;
                alignToPrediction.TotalTimeUsageAndPredictionResultsLabel = totalTimeUsageAndPredictionResultsLabel;

                alignToPrediction.EventTimeUsageAndPredictionText = eventTimeUsageAndPredictionText;
                alignToPrediction.AppointmentTimeUsageAndPredictionText = appointmentTimeUsageAndPredictionText;
                alignToPrediction.TaskTimeUsageAndPredictionText = taskTimeUsageAndPredictionText;
                alignToPrediction.AverageUsagePerDayText = averageUsagePerDayText;

                alignToPrediction.viewTimeUsagePrediction();
            }
        }

        private void findTimeUsageRButton_CheckedChanged(object sender, EventArgs e)
        {
            if (findTimeUsageRButton.Checked == true)
            {
                //changing label text
                predictedResultLabel.Text = "Allocated Time Usage";

                eventTimeUsageLabel.Text = "Total time usage for event(s):";
                eventTimeUsageLabel.Visible = true;
                eventTimeUsageAndPredictionText.Visible = true;
                eventTimeUsageAndPredictionText.Text = "";

                appointmentTimeUsageLabel.Text = "Total time usage for appointment(s):";
                appointmentTimeUsageLabel.Visible = true;
                appointmentTimeUsageAndPredictionText.Visible = true;
                appointmentTimeUsageAndPredictionText.Text = "";

                taskTimeUsageLabel.Text = "Total time usage for task(s):";
                taskTimeUsageLabel.Visible = true;
                taskTimeUsageAndPredictionText.Visible = true;
                taskTimeUsageAndPredictionText.Text = "";

                averageUsagePerDayLabel.Text = "Average time usage \n per event/appointent/task:";
                averageUsagePerDayLabel.Visible = true;
                averageUsagePerDayText.Visible = true;
                averageUsagePerDayText.Text = "";

                totalTimeUsageAndPredictionLabel.Text = "Total time usage \n for selected dates is:";
                totalTimeUsageAndPredictionLabel.Visible = true;
                totalTimeUsageAndPredictionResultsLabel.Visible = true;
                totalTimeUsageAndPredictionResultsLabel.Text = "Available Result...";


                firstMonthSelectBox.Enabled = false;
                secondMonthSelectBox.Enabled = false;

                predictionFromDateBox.Enabled = true;
                predictionToDateBox.Enabled = true;

                predictNowButton.Enabled = false;
                timeUsageButton.Enabled = true;


            }
            else
            {
                
            }
        }

        private void predictTimeUsage_CheckedChanged(object sender, EventArgs e)
        {
            if (predictTimeUsageRButton.Checked == true)
            {
                predictedResultLabel.Text = "Time Usage Prediction";

                eventTimeUsageLabel.Text = "Predicted time usage for event(s):";
                eventTimeUsageLabel.Visible = true;
                eventTimeUsageAndPredictionText.Visible = true;
                eventTimeUsageAndPredictionText.Text = "";

                appointmentTimeUsageLabel.Text = "Predicted time usage for appointment(s):";
                appointmentTimeUsageLabel.Visible = true;
                appointmentTimeUsageAndPredictionText.Visible = true;
                appointmentTimeUsageAndPredictionText.Text = "";

                taskTimeUsageLabel.Text = "Predicted time usage for task(s):";
                taskTimeUsageLabel.Visible = true;
                taskTimeUsageAndPredictionText.Visible = true;
                taskTimeUsageAndPredictionText.Text = "";

                averageUsagePerDayLabel.Text = "Predicted average time usage \n per event/appointent/task:";
                averageUsagePerDayLabel.Visible = true;
                averageUsagePerDayText.Visible = true;
                averageUsagePerDayText.Text = "";

                totalTimeUsageAndPredictionLabel.Text = "Predicted total time \n usage is:";
                totalTimeUsageAndPredictionLabel.Visible = true;
                totalTimeUsageAndPredictionResultsLabel.Visible = true;
                totalTimeUsageAndPredictionResultsLabel.Text = "Available Result...";

                firstMonthSelectBox.Enabled = true;
                secondMonthSelectBox.Enabled = true;

                predictionFromDateBox.Enabled = false;
                predictionToDateBox.Enabled = false;

                timeUsageButton.Enabled = false;
                predictNowButton.Enabled = true;
            }
            else
            {

            }
        }
    }
}
