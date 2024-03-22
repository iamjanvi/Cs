
        private void transfer_list2list_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Krishna");
            listBox1.Items.Add("Janvi");
            listBox1.Items.Add("kajal");
            listBox1.Items.Add("Bhagyashree");
            listBox1.Items.Add("Kush");
            listBox1.Items.Add("jaid");
            listBox1.Items.Add("Yug");
            listBox1.Items.Add("Dhruv");
            listBox1.Items.Add("Yagnesh");
            listBox1.Items.Add("Ruturaj");
            listBox1.Items.Add("Prince");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Select any item ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.SelectedIndices.Count;
            for (i = n - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox1.SelectedIndices.Count;
            for (i = n - 1; i >= 0; i--)
            {
                listBox2.Items.Add(listBox1.SelectedItems[i]);
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.Remove(listBox2.SelectedItem);

            }
            else
            {
                MessageBox.Show("select any item ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.SelectedIndices.Count;
            for (i = n - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, n;
            n = listBox2.SelectedIndices.Count;
            for (i = n - 1; i >= 0; i--)
            {
                listBox1.Items.Add(listBox2.SelectedItems[i]);
                listBox2.Items.Remove(listBox2.SelectedItems[i]);
            }
        }
    

