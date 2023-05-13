namespace FormAppYUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Good_Click(object sender, EventArgs e)
        {
            if (Good.BackColor == Color.Brown)
            { 
                Good.BackColor = Color.YellowGreen;
                if (Cheap.BackColor == Color.YellowGreen)
                    Fast.BackColor = Color.Brown;
            }

            else if (Good.BackColor == Color.YellowGreen)
                Good.BackColor = Color.Brown;
        }

        private void Cheap_Click(object sender, EventArgs e)
        {
            if (Cheap.BackColor == Color.Brown)
            { 
                Cheap.BackColor = Color.YellowGreen;
                if (Fast.BackColor == Color.YellowGreen)
                    Good.BackColor = Color.Brown;
            }

            else if (Cheap.BackColor == Color.YellowGreen)
                Cheap.BackColor = Color.Brown;
        }

        private void Fast_Click(object sender, EventArgs e)
        {
            if (Fast.BackColor == Color.Brown)
            { 
                Fast.BackColor = Color.YellowGreen;
                if (Good.BackColor == Color.YellowGreen)
                    Cheap.BackColor = Color.Brown;
            }

            else if (Fast.BackColor == Color.YellowGreen)
                Fast.BackColor = Color.Brown;
        }

        void ColorChange(TrackBar nesne)
        {
            nesne.BackColor = nesne.Value == 0 ? Color.Brown : Color.YellowGreen;
        }
        private void trackBarGood_ValueChanged(object sender, EventArgs e)
        {
            ColorChange(trackBarGood);
            
            if (trackBarGood.Value == 1 && trackBarCheap.Value == 1)
            { 
                trackBarFast.Value = 0;
            }
        }

        private void trackBarCheap_ValueChanged(object sender, EventArgs e)
        {
            ColorChange(trackBarCheap);


            if (trackBarCheap.Value == 1 && trackBarFast.Value == 1)
            {
                trackBarGood.Value = 0;
            }
        }

        private void trackBarFast_ValueChanged(object sender, EventArgs e)
        {
            ColorChange(trackBarFast);

            if (trackBarFast.Value == 1 && trackBarGood.Value == 1)
                    trackBarCheap.Value = 0;

        }
    }
}