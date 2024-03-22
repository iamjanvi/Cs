        
        private void arithmetic_operation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("ADD");
            comboBox1.Items.Add("SUB");
            comboBox1.Items.Add("MUL");
            comboBox1.Items.Add("DIV");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = Convert.ToInt32(e.KeyChar);
            if (e.KeyChar == '.' && textBox1.Text.IndexOf('.') >= 0)
            {
                e.Handled = true;
            }
            if (i >= 48 && i < 58 || i == 8 || i == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int i = Convert.ToInt32(e.KeyChar);
            if (e.KeyChar == '.' && textBox2.Text.IndexOf('.') >= 0)
            {
                e.Handled = true;
            }
            if (i >= 48 && i < 58 || i == 8 || i == 46)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2;
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);

            if (comboBox1.Text == "ADD")
            {
                label4.Text = "result is " + (num1 + num2).ToString();
            }
            else if (comboBox1.Text == "SUB")
            {
                label4.Text = "result is " + (num1 - num2).ToString();
            }
            else if (comboBox1.Text == "MUL")
            {
                label4.Text = "result is " + (num1 * num2).ToString();
            }
            else if (comboBox1.Text == "DIV")
            {
                if (Convert.ToDouble(textBox2.Text) != 0)
                {
                    label4.Text = "result is " + (num1 / num2).ToString();
                }
                else
                {
                    label4.Text = "invalid textBox2";
                }
            }
        }

        
    

