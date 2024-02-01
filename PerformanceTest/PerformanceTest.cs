namespace PerformanceTest
{
    public partial class PerformanceTest : Form
    {
        public PerformanceTest()
        {
            InitializeComponent();
        }

        public static void BackgroundWork(object data)
        {
            PerformanceTest currentForm = (PerformanceTest)data;

            for (int i = 0; i < 10; i++)
            {
                currentForm.lstLog.Invoke(() =>
                {
                    currentForm.lstLog.Items.Add("Test");

                });
                Thread.Sleep(1000);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread background = new Thread(PerformanceTest.BackgroundWork);
            background.Start(this);
        }
    }
}