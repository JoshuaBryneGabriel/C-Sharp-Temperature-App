namespace PracticeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxThermometer = new PictureBox();
            txtCelsius = new TextBox();
            txtFahrenheit = new TextBox();
            labelGauge = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThermometer).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxThermometer
            // 
            pictureBoxThermometer.Location = new Point(58, 83);
            pictureBoxThermometer.Name = "pictureBoxThermometer";
            pictureBoxThermometer.Size = new Size(276, 31);
            pictureBoxThermometer.TabIndex = 0;
            pictureBoxThermometer.TabStop = false;
            pictureBoxThermometer.MouseMove += pictureBoxThermometer_MouseMove;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(118, 210);
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(157, 23);
            txtCelsius.TabIndex = 1;
            txtCelsius.TextChanged += txtCelsius_TextChanged;
            // 
            // txtFahrenheit
            // 
            txtFahrenheit.Location = new Point(118, 262);
            txtFahrenheit.Name = "txtFahrenheit";
            txtFahrenheit.Size = new Size(157, 23);
            txtFahrenheit.TabIndex = 2;
            // 
            // labelGauge
            // 
            labelGauge.AutoSize = true;
            labelGauge.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGauge.Location = new Point(156, 83);
            labelGauge.Name = "labelGauge";
            labelGauge.Size = new Size(76, 21);
            labelGauge.TabIndex = 3;
            labelGauge.Text = "Indicator";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 210);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 4;
            label1.Text = "Celsius:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 264);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 5;
            label2.Text = "Fahrenheit:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 192);
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(319, 405);
            button1.Name = "button1";
            button1.Size = new Size(96, 33);
            button1.TabIndex = 6;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.MouseClick += exit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(120, 0);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelGauge);
            Controls.Add(txtFahrenheit);
            Controls.Add(txtCelsius);
            Controls.Add(pictureBoxThermometer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Temperature App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxThermometer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxThermometer;
        private TextBox txtCelsius;
        private TextBox txtFahrenheit;
        private Label labelGauge;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
