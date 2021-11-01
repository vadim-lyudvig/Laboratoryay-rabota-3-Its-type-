using System;
using System.Windows.Forms;

namespace СС
{
    public partial class Form1 : Form
    {
        bool isStart = true;
        public Form1()
        {
            InitializeComponent();
            cmbAction.SelectedIndex = 0;
            cmbResultAfter.SelectedIndex = 0;
            cmbNumAfter1.SelectedIndex = 0;
            cmbNumAfter2.SelectedIndex = 0;
            isStart = false;
        }

        CountingSystem result;

        private void cmbResultAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isStart)
            {
                return;
            }
            if (txtResult.Text.Equals("Верно") || txtResult.Text.Equals("Не верно"))
            {
                return;
            }
            if (txtResult.Text.Equals(""))
            {
                return;
            }
            string message = result.ConvertNumber(cmbResultAfter.Text);
            if (!message.Equals(""))
            {
                MessageBox.Show(message);
                return;
            }
            txtResult.Text = result.number;
            cmbResultAfter.Text = result.ss;
        }
        void ConvertNum()
        {
            if (isStart)
            {
                return;
            }
            if (txtNum1.Text.Equals("") || txtNum2.Text.Equals(""))
            {
                return;
            }
            var ss1 = new CountingSystem();
            var ss2 = new CountingSystem();
            ss1.ss = cmbNumAfter1.Text;
            ss2.ss = cmbNumAfter2.Text;
            ss1.number = txtNum1.Text;
            ss2.number = txtNum2.Text;
            string message = ss1.ConvertNumber("10");
            if (!message.Equals(""))
            {
                MessageBox.Show(message + " у первого числа");
                return;
            }
            message = ss2.ConvertNumber("10");
            if (!message.Equals(""))
            {
                MessageBox.Show(message + " у второго числа");
                return;
            }
            result = new CountingSystem();
            result.ss = "10";
            switch (cmbAction.Text)
            {
                case "+":
                    {
                        result = ss1 + ss2;
                    }
                    break;
                case "-":
                    {
                        result = ss1 - ss2;
                    }
                    break;
                case "*":
                    {
                        result = ss1 * ss2;
                    }
                    break;
                case ">":
                    {
                        if (ss1 > ss2)
                        {
                            txtResult.Text = "Верно";
                        }
                        else
                        {
                            txtResult.Text = "Не верно";
                        }
                        return;
                    }
                case "<":
                    {
                        if (ss1 < ss2)
                        {
                            txtResult.Text = "Верно";
                        }
                        else
                        {
                            txtResult.Text = "Не верно";
                        }
                        return;
                    }
                case "=":
                    {
                        if (ss1 == ss2)
                        {
                            txtResult.Text = "Верно";
                        }
                        else
                        {
                            txtResult.Text = "Не верно";
                        }
                        return;
                    }
            }
            txtResult.Text = result.number;
            cmbResultAfter.SelectedIndex = 2;
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            switch (cmbNumAfter1.Text)
            {
                case "2":
                    {
                        if (e.KeyChar != '0' && e.KeyChar != '1' && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "8":
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "10":
                    {
                        if (!Char.IsDigit(number) && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "16":
                    {
                        if (!Char.IsDigit(number) && number != 'A' && number != 'B'
                            && number != 'C' && number != 'D' && number != 'E' && number != 'F' && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
            }

        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            switch (cmbNumAfter2.Text)
            {
                case "2":
                    {
                        if (e.KeyChar != '0' && e.KeyChar != '1' && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "8":
                    {
                        if ((e.KeyChar <= 47 || e.KeyChar >= 56) && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "10":
                    {
                        if (!Char.IsDigit(number) && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
                case "16":
                    {
                        if (!Char.IsDigit(number) && number != 'A' && number != 'B'
                            && number != 'C' && number != 'D' && number != 'E' && number != 'F' && number != 8)
                        {
                            e.Handled = true;
                        }
                    }
                    break;
            }
        }
        private void cmbAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertNum();
        }
        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            ConvertNum();
        }
        private void txtNum2_TextChanged(object sender, EventArgs e)
        {
            ConvertNum();
        }

        private void cmbNumAfter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertNum();
        }

        private void cmbNumAfter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertNum();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }
    }
}
