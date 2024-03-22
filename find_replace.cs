        string path;
        int pos;
        

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All RichText Files|*.rtf|*All Text Files|*.txt|*All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                richTextBox1.LoadFile(path, RichTextBoxStreamType.PlainText);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path == null)
            {
                saveFileDialog1.Filter = "All RichText Files|*.rtf|*All Text Files|*.txt|*All Files|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog1.FileName;
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                }
            }
            else
            {
                richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All RichText Files|*.rtf|All Text Files|*.txt|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
                richTextBox1.Undo();

        }

        private void rdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.CanRedo)
                richTextBox1.Redo();
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.SelectionFont, FontStyle.Bold);
            richTextBox1.SelectionFont = fnt;

        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.SelectionFont, FontStyle.Italic);
            richTextBox1.SelectionFont = fnt;

        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Font fnt = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            richTextBox1.SelectionFont = fnt;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = fontDialog1.Font;

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionColor = colorDialog1.Color;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pos = richTextBox1.Find(textBox1.Text, 0, richTextBox1.Text.Length - 1, RichTextBoxFinds.MatchCase);
            }
            else
            {
                pos = richTextBox1.Find(textBox1.Text, 0, richTextBox1.Text.Length - 1, RichTextBoxFinds.WholeWord);
            }
            if (pos >= 0)
            {
                richTextBox1.Select(pos, textBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                pos = richTextBox1.Find(textBox1.Text, pos + 1, richTextBox1.Text.Length - 1, RichTextBoxFinds.MatchCase);
            }
            else
            {
                pos = richTextBox1.Find(textBox1.Text, pos + 1, richTextBox1.Text.Length - 1, RichTextBoxFinds.WholeWord);
            }
            if (pos >= 0)
            {
                richTextBox1.Select(pos, textBox1.Text.Length);
                richTextBox1.SelectionColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = textBox2.Text;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pos = 0;
            button1.PerformClick();
            if (pos != 0)
            {
                button3.PerformClick();
                while (pos != -1)
                {
                    button2.PerformClick();
                    if (pos != -1)
                        button3.PerformClick();
                }
            }
        }
    

