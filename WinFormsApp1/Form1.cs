

        public Form1()
         {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* Trying different Tests such as:
             * a == b
             * a < b
             * a <= b
             * a > b
             * a >= b
             * a != b
             * a != a
             * */
            int a = 10;
            int b = 10;
            if (a <= b) { 
                textBox1.Text = "Test is true";
            } else
            {
                textBox1.Text = "Test is false";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}