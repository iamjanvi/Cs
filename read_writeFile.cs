
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("C:\\C#\\myfile.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs);
            sw.Write(textBox1.Text);
            MessageBox.Show("Data is written to the file successfully:", "Info:");
            sw.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.FileStream fs = new System.IO.FileStream("C:\\C#\\myfile.txt", System.IO.FileMode.OpenOrCreate);
            System.IO.StreamReader sr = new System.IO.StreamReader(fs);
            textBox2.Text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
        }


      
    


