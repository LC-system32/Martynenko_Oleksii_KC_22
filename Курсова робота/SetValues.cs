using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсова_робота
{
    public partial class SetValues : Form
    {
        private double positionY;
        private double speed;
        private double mass;
        private double wind;

        public SetValues()
        {
            InitializeComponent();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            SetPosition.KeyDown += TextBox_KeyDown;
            SetSpeed.KeyDown += TextBox_KeyDown;
            SetMass.KeyDown += TextBox_KeyDown;
            SetWind.KeyDown += TextBox_KeyDown;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (double.TryParse((sender as TextBox)?.Text, out double res))
                {
                    errorProvider.SetError(sender as TextBox, "");
                    AssignValueToProperty(sender, res);
                    CheckEmptyTextBoxes();
                }
                else
                {
                    errorProvider.SetError((sender as TextBox), "Введено невірне значення");
                }
            }
        }

        private void AssignValueToProperty(object sender, double value)
        {
            if (sender == SetPosition)
                positionY = value;
            else if (sender == SetSpeed)
                speed = value;
            else if (sender == SetMass)
                mass = value;
            else if (sender == SetWind)
                wind = value;
        }

        private void CheckEmptyTextBoxes()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Focus();
                    return;
                }
            }
            FreeFall freeFall = new FreeFall(positionY, speed, mass, wind);

            freeFall.Show();
            freeFall.FormClosed += FreeFall_FormClosed;
        }

        private void FreeFall_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void DefaultValues_Click(object sender, EventArgs e)
        {
            FreeFall freeFall = new FreeFall();

            freeFall.Show();
            freeFall.FormClosed += FreeFall_FormClosed;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ReadMe.txt");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"Файл не знайдено", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
