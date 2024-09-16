#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private Label label;
        private Button button;
        private TextBox textBox;
        private CheckBox checkBox;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox radioGroup;
        private ComboBox comboBox;
        private ProgressBar progressBar;
        private TableLayoutPanel tableLayoutPanel;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Ejemplo de UI en Windows Forms";
            this.BackColor = Color.WhiteSmoke;

            // Initialize controls
            label = new Label
            {
                Text = "Mi primer UI!",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.Black
            };

            textBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12),
                BorderStyle = BorderStyle.FixedSingle
            };

            button = new Button
            {
                Text = "Haz clic aquí",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.DarkGray
            };
            button.Click += new EventHandler(Button_Click);

            checkBox = new CheckBox
            {
                Text = "Acepto los términos y condiciones",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12)
            };

            // GroupBox for radio buttons with horizontal layout
            radioGroup = new GroupBox
            {
                Text = "Opciones",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12, FontStyle.Bold),
                Padding = new Padding(10),
                BackColor = Color.LightGray
            };

            FlowLayoutPanel radioLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown, // Organiza las opciones en una columna vertical
                AutoSize = true,
                BackColor = Color.LightGray
            };

            radioButton1 = new RadioButton
            {
                Text = "Opción 1",
                Font = new Font("Arial", 12),
                AutoSize = true,
                BackColor = Color.LightCyan
            };
            radioButton1.Click += new EventHandler(RadioButton1_Click);

            radioButton2 = new RadioButton
            {
                Text = "Opción 2",
                Font = new Font("Arial", 12),
                AutoSize = true,
                BackColor = Color.LightCyan
            };

            radioLayoutPanel.Controls.Add(radioButton1);
            radioLayoutPanel.Controls.Add(radioButton2);
            radioGroup.Controls.Add(radioLayoutPanel);

            // ComboBox and ProgressBar
            comboBox = new ComboBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 12)
            };
            comboBox.Items.AddRange(new string[] { "Item 1", "Item 2", "Item 3" });

            progressBar = new ProgressBar
            {
                Dock = DockStyle.Fill,
                Minimum = 0,
                Maximum = 100,
                Value = 50
            };

            // TableLayoutPanel for better layout
            tableLayoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 6
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));

            // Add controls to TableLayoutPanel
            tableLayoutPanel.Controls.Add(label, 0, 0);
            tableLayoutPanel.SetColumnSpan(label, 2);

            tableLayoutPanel.Controls.Add(textBox, 0, 1);
            tableLayoutPanel.SetColumnSpan(textBox, 2);

            tableLayoutPanel.Controls.Add(button, 0, 2);
            tableLayoutPanel.SetColumnSpan(button, 2);

            tableLayoutPanel.Controls.Add(checkBox, 0, 3);
            tableLayoutPanel.SetColumnSpan(checkBox, 2);

            tableLayoutPanel.Controls.Add(radioGroup, 0, 4);
            tableLayoutPanel.SetColumnSpan(radioGroup, 2);

            tableLayoutPanel.Controls.Add(comboBox, 0, 5);
            tableLayoutPanel.Controls.Add(progressBar, 1, 5);

            // Add TableLayoutPanel to the form
            this.Controls.Add(tableLayoutPanel);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Por favor, ingresa un texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                label.Text = "¡Botón clicado!";
                progressBar.Value = (progressBar.Value + 10) % 100;
            }
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = false;
        }
    }
}

