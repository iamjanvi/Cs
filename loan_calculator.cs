
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 8)
                return;
            if (e.KeyChar == '.' && textBox1.Text.IndexOf(".") >= 0)
                e.Handled = true;
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 8)
                return;
            if(!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Invalid input..");
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double amt, insamt, rofint;
            amt = Convert.ToSingle(textBox1.Text);
            rofint = Convert.ToSingle(textBox3.Text);
            Int16 nper;
            nper = Convert.ToInt16(textBox2.Text);
            if (checkBox1.Checked == true)
                insamt = Financial.Pmt(rofint / (12 * 100), nper, -amt, 0, DueDate.BegOfPeriod);
            else
                insamt = Financial.Pmt(rofint / (12 * 100), nper, -amt, 0, DueDate.EndOfPeriod);
            textBox4.Text = Convert.ToString(insamt);
        }
    

