
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left = label1.Left + 10;
            if (label1.Left > 1000)
            {
                label1.Left = 0;
            }
        }
    

