namespace InheritanceDistributionOfSweets
{
    public partial class Form1 : Form
    {
        List<Sweet> sweetList = new List<Sweet>();
        public Form1()
        {
            InitializeComponent();
            showInfo();
        }

        private void showInfo()
        {
            int chocolateCount = 0;
            int pastriesCount = 0;
            int cakeCount = 0;

            foreach (var sweet in this.sweetList)
            {
                if (sweet is Chocolate)
                {
                    chocolateCount += 1;
                }
                else if (sweet is Pastries)
                {
                    pastriesCount += 1;
                }
                else if (sweet is Cake)
                {
                    cakeCount += 1;
                }
            }

            txtInfo.Text = "Шоколад\tВыпечка\t\tТортик\n";
            txtInfo.Text += String.Format("{0}\t\t{1}\t\t{2}", chocolateCount, pastriesCount, cakeCount);
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            this.sweetList.Clear();
            for (int i = 0; i < 10; ++i)
            {
                switch (Sweet.rnd.Next() % 3)
                {
                    case 0:
                        this.sweetList.Add(Chocolate.Generate());
                        break;
                    case 1:
                        this.sweetList.Add(Pastries.Generate());
                        break;
                    case 2:
                        this.sweetList.Add(Cake.Generate());
                        break;
                }
            }

            showInfo();
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            if (this.sweetList.Count == 0)
            {
                txtOut.Text = "Пусто (";
                return;
            }

            var sweet = this.sweetList[0];
            this.sweetList.RemoveAt(0);

            txtOut.Text = sweet.getInfo();
            showInfo();
        }
    }
}
