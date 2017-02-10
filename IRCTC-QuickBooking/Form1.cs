using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QuickBookingLogic;
using System.Threading.Tasks;
using AutomationLogic;
using System.Data;
using LastRecord;
using Newtonsoft.Json;
using System.IO;

/**************************************************************************************************************
 * A Skill Developement Project by Debasis Mondal                                                             *
 **************************************************************************************************************/
namespace IRCTC_QuickBooking
{
    public partial class Form1 : Form
    {
        TimeSpan waitTimeSpan = new TimeSpan();
        AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
        List<string> journeyClass = new List<string>();

        public Form1()
        {
            GetStationCodes.PopulateStation();
            InitializeComponent();
            doj.MinDate = DateTime.Today;
            doj.MaxDate = doj.MinDate.AddDays(90);
            doj.Value = DateTime.Today;
            waitTimeSpan = TimeSpan.FromMilliseconds(50);
            for (int i = 1; i < 7; i++)
            {
                this.dataGridViewPassengerDetails.Rows.Add(i.ToString());
            }
            for (int i = 1; i < 3;i++ )
            {
                this.dataGridViewChildDetails.Rows.Add(i.ToString());
            }
            allowedTypes.AddRange(StationCodes.Stations);
            frmStn.AutoCompleteCustomSource = allowedTypes;
            frmStn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            frmStn.AutoCompleteMode = AutoCompleteMode.Suggest;
            toStn.AutoCompleteCustomSource = allowedTypes;
            toStn.AutoCompleteSource = AutoCompleteSource.CustomSource;
            toStn.AutoCompleteMode = AutoCompleteMode.Suggest;
            radioButtonTatkal.Checked = true;
            comboBoxJourneyClass.Items.AddRange(new string[] { "1A", "2A", "3A", "CC", "SL", "2S", "EC" });
            comboBoxPaymentMethod.SelectedIndex = 1;
            comboBoxBankName.SelectedIndex = 0;
            if(File.Exists("LastRecord.json"))
            {
                fillForm();
            }
        }

        private void fillForm()
        {
            var data = File.ReadAllText("LastRecord.json");
            Info result = JsonConvert.DeserializeObject<Info>(data);
            textBoxUserName.Text = result.usrName;
            textBoxPassword.Text = result.pwd;
            frmStn.Text = result.frmStn;
            toStn.Text = result.toStn;
            textBoxTrains.Text = result.trainInfo;
            comboBoxJourneyClass.Text = result.journeyClass;
            int i=0;
            foreach(DataRow row in result.passengerInfo.Rows)
            {
                for (int j = 1; j < 5; j++)
                {
                    dataGridViewPassengerDetails.Rows[i].Cells[j].Value = row[j].ToString();
                }
                if(row[5].ToString() == "True")
                {
                    dataGridViewPassengerDetails.Rows[i].Cells[5].Value = Convert.ToBoolean(row[5]);
                }
                i++;
            }
        }



        private void buttonTrainList_Click(object sender, EventArgs e)
        {
            if (frmStn.Text == "" || toStn.Text == "")
            {
                MessageBox.Show("Please select start and destination");
                return;
            }
            string postDatas = string.Format("pnrQ={0}&dest={1}", frmStn.Text.Substring(frmStn.Text.IndexOf('-') + 1), toStn.Text.Substring(toStn.Text.IndexOf('-') + 1));
            List<string> listOfTrains = new List<string>();
            pleaseWait1.Visible = true;
            buttonTrainList.Enabled = false;
            Task trainFillup = new Task(() =>
                {
                    TrainsForTheDay getListOfTrains = new TrainsForTheDay(new TrainLists() { postData = postDatas }, doj.Value.DayOfWeek.ToString());

                    listOfTrains = getListOfTrains.trainLists();
                }
            );
            trainFillup.ContinueWith((antecedent) =>
            {
                AutoCompleteStringCollection trainHints = new AutoCompleteStringCollection();
                trainHints.AddRange(listOfTrains.ToArray());
                textBoxTrains.Clear();

                textBoxTrains.AutoCompleteCustomSource = trainHints;
                textBoxTrains.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxTrains.AutoCompleteMode = AutoCompleteMode.Suggest;
                pleaseWait1.Visible = false;
                buttonTrainList.Enabled = true;
            }, TaskScheduler.FromCurrentSynchronizationContext()
            );
            trainFillup.Start();

        }

        private void buttonBookNow_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" || textBoxUserName.Text == "" || frmStn.Text == "" || toStn.Text == "")
            {
                MessageBox.Show("Please fill the necessary details");
                return;
            }
            if (dataGridViewPassengerDetails.Rows[0].Cells[1].Value == null || string.IsNullOrWhiteSpace(dataGridViewPassengerDetails.Rows[0].Cells[1].Value.ToString()))
            {
                MessageBox.Show("Please enter aleast one passenger detail");
                return;
            }

            DataTable childDetails = ChildDetailsDatatable();
            DataTable dt = PassengerDetailsDatatable();
            Info rec = new Info();
            saveInfo(rec, dt);
            SaveRecord.SaveData(rec);
            ControlPages.loginPage.Goto();
            ControlPages.loginPage.fillInDetails(textBoxUserName.Text.Trim(), textBoxPassword.Text.Trim());
            JourneyDets.fromStn = frmStn.Text.Trim();
            JourneyDets.toStn = toStn.Text.Trim();
            JourneyDets.doj = doj.Value.ToString("dd-MM-yyyy");
            ControlPages.loginPage.PlanJourney();
            string travelQuota = trvlQuota();
            string trainNumber = textBoxTrains.Text.Trim().Substring(0, 5);
            string journeyClass = comboBoxJourneyClass.Text;
            TrainAndQuota.SelectTrainAndQuota(travelQuota, trainNumber, journeyClass);


            
            if (textBoxBoardingPoint.Visible)
            {
                PassengerDetails.fillDetails(dt, childDetails, textBoxBoardingPoint.Text.Trim());
            }
            else
            {
                PassengerDetails.fillDetails(dt, childDetails, string.Empty);
            }
        }

        /// <summary>
        /// Populates info class with the values
        /// </summary>
        private void saveInfo(Info rec, DataTable passengerDetailsTable)
        {
            rec.usrName = textBoxUserName.Text.Trim();
            rec.pwd = textBoxPassword.Text.Trim();
            rec.frmStn = frmStn.Text.Trim();
            rec.toStn = toStn.Text.Trim();
            rec.trainInfo = textBoxTrains.Text.Trim();
            rec.journeyClass = comboBoxJourneyClass.Text.Trim();
            rec.passengerInfo = passengerDetailsTable;
        }

        /// <summary>
        /// Generates equivalent Datatable for Child Details Data Gridview
        /// </summary>
        /// <returns>DataTable</returns>
        private DataTable ChildDetailsDatatable()
        {
            DataTable childDetails;
            if (dataGridViewChildDetails.Rows[0].Cells[1].Value == null || string.IsNullOrWhiteSpace(dataGridViewChildDetails.Rows[0].Cells[1].Value.ToString()))
            {
                childDetails = null;
            }
            else
            {
                childDetails = new DataTable();
                foreach (DataGridViewColumn chldCol in dataGridViewChildDetails.Columns)
                {
                    childDetails.Columns.Add(chldCol.HeaderText);
                }
                foreach (DataGridViewRow row in dataGridViewChildDetails.Rows)
                {
                    if (row.Cells[1].Value == null || string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                    {
                        break;
                    }
                    DataRow cRow = childDetails.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cRow[cell.ColumnIndex] = cell.Value;
                    }
                    childDetails.Rows.Add(cRow);
                }
            }
            return childDetails;
        }


        /// <summary>
        /// Creates Equivalent DataTable for Passenger details
        /// </summary>
        /// <returns>DataTable</returns>
        private DataTable PassengerDetailsDatatable()
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewPassengerDetails.Columns)
            {
                dt.Columns.Add(col.HeaderText);
            }

            foreach (DataGridViewRow row in dataGridViewPassengerDetails.Rows)
            {
                if (row.Cells[1].Value == null || string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    break;
                }
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            return dt;
        }

        /// <summary>
        /// Returns the travelQuota text
        /// </summary>
        /// <returns></returns>
        private string trvlQuota()
        {
            if (radioButtonGen.Checked)
            {
                return radioButtonGen.Text;
            }
            else if (radioButtonLadies.Checked)
            {
                return radioButtonLadies.Text;
            }
            else if (radioButtonPhyHand.Checked)
            {
                return radioButtonPhyHand.Text;
            }
            else if (radioButtonPremTat.Checked)
            {
                return radioButtonPremTat.Text;
            }
            else if (radioButtonTatkal.Checked)
            {
                return radioButtonTatkal.Text;
            }
            else
            {
                return "GENERAL";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Visible = false;
            label9.Visible = true;
            textBoxBoardingPoint.Visible = true;
            textBoxBoardingPoint.AutoCompleteCustomSource = allowedTypes;
            textBoxBoardingPoint.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxBoardingPoint.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxBoardingPoint.Text = frmStn.Text;
        }

        private void comboBoxJourneyClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell dgvcc;
            List<string> popCell = new List<string>();

            if (comboBoxJourneyClass.Text == "CC" || comboBoxJourneyClass.Text == "2S" || comboBoxJourneyClass.Text == "EC")
            {
                popCell.AddRange(new string[] { "No Preference", "WINDOW SIDE" });
            }
            else
            {
                popCell.AddRange(new string[] { "No Preference", "LOWER", "MIDDLE", "UPPER", "SIDE LOWER", "SIDE UPPER" });
            }
            //dataGridViewPassengerDetails.Rows[0].Cells[4] = dgvcc;
            //dataGridViewPassengerDetails.Rows[1].Cells[4] = dgvcc;
            for (int i = 0; i < 6; ++i)
            {
                dgvcc = new DataGridViewComboBoxCell();
                dgvcc.Items.AddRange(popCell.ToArray());
                dataGridViewPassengerDetails.Rows[i].Cells[4] = dgvcc;
                dataGridViewPassengerDetails.Rows[i].Cells[4].Value = "No Preference";
                dataGridViewPassengerDetails.Rows[i].Cells[5].ToolTipText = "Please carry a valid ID proof for senior citizen";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxPaymentMethod_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxPaymentMethod.SelectedItem.ToString() == "Net Banking")
            {
                
            }
        }

        
    }
}
