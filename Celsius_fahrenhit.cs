

       

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt16(e.KeyChar) == 8)
                return;
            if (e.KeyChar == '.' && textBox1.Text.IndexOf(".") >= 0)
            {
                e.Handled = true;

            }

            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float f, c;
            if (radioButton1.Checked == true)
            {
                f = Convert.ToSingle(textBox1.Text);
                c = (5 * (f - 32)) / 9;
                MessageBox.Show(Convert.ToString(f) + "fahrenhit is equal to " + Convert.ToString(c) + "celsius");
            }

            else
            {
                c = Convert.ToSingle(textBox1.Text);
                f = ((9 * c) / 5) + 32;
                MessageBox.Show(Convert.ToString(c) + "celsius is equal to " + Convert.ToString(f) + "farenhit");
            }
            textBox1.Text = "";


        }
    

