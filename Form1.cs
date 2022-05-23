namespace PropertyChangedEventTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private string JumbleString(string s)
        {
            var r = new Random();
            var result = "";
            while(s.Length > 0)
            {
                var i = r.Next(s.Length-1);
                result += s[i];
                s = s.Remove(i, 1);
            }
            return result;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = JumbleString(label1.Text);
            label2.Text += " T";
        }
    }
}