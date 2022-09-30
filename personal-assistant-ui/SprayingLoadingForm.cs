using personal_assistant_ui.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personal_assistant_ui
{
    public partial class SprayingLoadingForm : Form
    {
        public SprayingLoadingForm()
        {
            InitializeComponent();
        }

        private void timer_spraying_Tick(object sender, EventArgs e)
        {
            if (progress_bar_spraying.Value <= progress_bar_spraying.Maximum - 25) // loading <= 90%..
            {
                progress_bar_spraying.Value += 25;
                SoundPlayer sp = new SoundPlayer(Resources.spray_shoes);
                sp.Play();
            } else // loading is 100%..
            {
                progress_bar_spraying.Visible = false;
                lbl_spraying_done.Visible = true;
                checkMarkImage.Visible = true;
                btn_back.Visible = true;
                btn_back1.Visible = true;
                lbl_spraying_time.Visible = false;
                this.UseWaitCursor = false;
                this.Cursor = Cursors.Arrow;
            }
        }

        private void btn_back1_Click(object sender, EventArgs e)
        {
            this.Closed += (s, AssemblyLoadEventArgs) => Close();
            this.Hide();
            (this.Owner as ShoeRackForm).Enabled = true;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Closed += (s, AssemblyLoadEventArgs) => Close();
            this.Hide();
            (this.Owner as ShoeRackForm).Enabled = true;
        }

        private void SprayingLoadingForm_Load(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
        }
    }
}
