
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Enabled = false;
                gujratuniversity_2 frm = new gujratuniversity_2();
                frm.Show();
                this.Hide();

            }
        }


       
    

