using System;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        private double celsius;
        private const double MinTemperature = -30;
        private const double MaxTemperature = 200;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            //Initial temperature and update UI
            celsius = 0;
            UpdateUI();
        }
        private void UpdateUI()
        {
            // Update text boxes
            txtCelsius.Text = celsius.ToString();
            txtFahrenheit.Text = CelsiusToFahrenheit(celsius).ToString();
            UpdateGaugeLevel();
            UpdateColorIndicators();
        }
        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private bool IsTemperatureValid(double temperature)
        {
            return temperature >= MinTemperature && temperature <= MaxTemperature;
        }
        private void UpdateGaugeLevel()
        {
            // Calculate gauge level position based on the temperature range
            double normalizedPosition = (celsius - MinTemperature) / (MaxTemperature - MinTemperature);
            int gaugeTop = pictureBoxThermometer.Bottom - (int)(normalizedPosition * pictureBoxThermometer.Height);
            //moving gauge position
            labelGauge.Top = gaugeTop;
        }
        private void UpdateColorIndicators()
        {
            //Indication of hot and cold temperatures
            if (celsius < 0)
            {
                labelGauge.BackColor = Color.Blue; //Cold
            }
            else if (celsius > 100)
            {
                labelGauge.BackColor = Color.Red; //Hot
            }
            else
            {
                labelGauge.BackColor = Color.Green; //Normal
            }
        }
        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
            // Handle changes in Celsius text box
            if (double.TryParse(txtCelsius.Text, out double newCelsius))
            {
                // Validate temperature range
                if (IsTemperatureValid(newCelsius))
                {
                    // Update Celsius value and refresh UI
                    celsius = newCelsius;
                    UpdateUI();
                }
                else
                {
                    // Show error message
                    MessageBox.Show($"Temperature must be between {MinTemperature} and {MaxTemperature} degrees Celsius.", "Temperature out of range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void pictureBoxThermometer_MouseMove(object sender, MouseEventArgs e)
        {
            //Gauge level adjustment with drag-and-drop
            if (e.Button == MouseButtons.Left)
            {
                int mouseY = e.Y + pictureBoxThermometer.Top;
                // Calculate new Celsius value based on the mouse position
                double newCelsius = MinTemperature + ((pictureBoxThermometer.Bottom - mouseY) / (double)pictureBoxThermometer.Height) * (MaxTemperature - MinTemperature);
                celsius = newCelsius;
                UpdateUI();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}

