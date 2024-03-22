
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int r, g, b;
            r = hScrollBar1.Value;
            g = hScrollBar2.Value;
            b = hScrollBar3.Value;

            label4.Text = Convert.ToString(r);
            label5.Text = Convert.ToString(g);
            label6.Text = Convert.ToString(b);
            pictureBox1.BackColor = Color.FromArgb(255, r, g, b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = pictureBox1.BackColor;
        }
    

