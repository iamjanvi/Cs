
       
        public int fact(int num)
        {
            int ans, i;
            ans = 1;
            for (i = 1; i <= num; i++)
                ans = ans * i;
            return ans;
        }

        
        public void checkEveorOdd(int num)
        {
            if (num % 2 == 0)
                MessageBox.Show(Convert.ToString(num) + " Is an Even number:");
            else
                MessageBox.Show(Convert.ToString(num) + " Is an Odd number:");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int result;
            result = fact(Convert.ToInt16(textBox1.Text));
            MessageBox.Show("Factorial of " + textBox1.Text + " is = " + Convert.ToString(result));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            checkEveorOdd(Convert.ToInt16(textBox2.Text));
        }
    

