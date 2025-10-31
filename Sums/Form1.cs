namespace Sums
{
    public partial class Form1 : Form
    {
         int sums = 0;
        public Form1()
        {
            InitializeComponent();
           int sum = GetSum();
              sums = sum;
            ShowSum(sums);

        }

        private void button1_Click(object sender, EventArgs e)
        {
           int sum = GetSum();
            ShowSum(sum);
        }
        private int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        private void ShowSum(int sum)
        {
            MessageBox.Show($"The sum is: {sum}", "Sum Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
