using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var now = GetKoreanTime();

            Clock.Text = now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void StartTime_Click(object sender, EventArgs e)
        {
            var now = GetKoreanTime();

            StartTime.Text = now.ToString("HH:mm:ss");
        }

        private void EndTime_Click(object sender, EventArgs e)
        {
            var now = GetKoreanTime();

            EndTime.Text = now.ToString("HH:mm:ss");
        }
        private DateTime GetKoreanTime()
        {
            var now = DateTime.UtcNow;

            // Get Korean Standard Time
            TimeZoneInfo koreaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Korea Standard Time");
            return TimeZoneInfo.ConvertTime(now, koreaTimeZone);
        }
    }
}
