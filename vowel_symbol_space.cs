
       

        private void button1_Click(object sender, EventArgs e)
        {
            int vowel = 0, digits = 0, space = 0, consonent = 0, symbols = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                char ch = char.ToLower(textBox1.Text[i]);
                if (char.IsDigit(ch))
                {
                    digits++;
                }
                else if (ch == ' ')
                {
                    space++;
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    symbols++;
                }
                else if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    vowel++;
                }

                else
                {
                    consonent++;
                }

            }

            string str = "There are \n" + vowel + " Vowels \n" + consonent + " Consonents \n"
                + digits + " Digits \n" + symbols + " Symbols \n" + space + " Space";

            MessageBox.Show(str);
        }
    

