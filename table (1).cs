

    

        private void button1_Click(object sender, EventArgs e)
        {
            int i, num;
            num = Convert.ToInt16(numericUpDown1.Value);
            listBox1.Items.Clear();
            for(i=1;i<=10;i++)
            {
                listBox1.Items.Add(num +  "*"  +  i  +  "="  + num * i);
            }
        }
    

