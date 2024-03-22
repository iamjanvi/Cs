
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("C:\\C#\\image\\india.png");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("C:\\C#\\image\\us.png");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("C:\\C#\\image\\canada.png");
            }

        }


        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                pictureBox1.Image = Image.FromFile("C:\\C#\\image\\srilanka.png");
            }
        }


