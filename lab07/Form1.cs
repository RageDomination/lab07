using lab07.Properties;

namespace lab07
{
    public partial class Form1 : Form
    {

        public class Town
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public string
            Region
            { get; set; }
            public int Population { get; set; }
            public double YearIncome
            {
                get; set;
            }
            public double Square { get; set; }
            public bool HasPort { get; set; }
            public
                bool HasAirport
            { get; set; }

            public double GetYearIncomePerInhabitant()
            {
                return YearIncome / Population;
            }

            public Town()
            {

            }

            public Town(string name, string country, string region, int population, double
            yearIncome, double square, bool hasPort, bool hasAirport)
            {
                Name = name;
                Country = country;
                Region = region;
                Population = population;
                YearIncome = yearIncome;
                Square = square; HasPort
                = hasPort; HasAirport =
                hasAirport;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Town town = new Town();
            fTown ft = new fTown(ref town);

            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcTowns.Add(town);
                gvTowns.Refresh();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Town town = (Town)bindSrcTowns.List[bindSrcTowns.Position];

            fTown ft = new fTown(ref town);
            if (ft.ShowDialog() == DialogResult.OK)

            {
                bindSrcTowns.List[bindSrcTowns.Position] = town;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvTowns.AutoGenerateColumns = false;

            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Name", Name = "Назва" });
            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Country", Name = "Країна" });
            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Region", Name = "Регіон" });
            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Population", Name = "Мешканців" });
            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "YearIncome", Name = "Річн. дохід" });
            gvTowns.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Square", Name = "Площа", Width = 80 });
            gvTowns.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "HasPort", Name = "Порт", Width = 60 });
            gvTowns.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "HasAirport", Name = "Аеропорт", Width = 60 });

            gvTowns.DataSource = bindSrcTowns;

            bindSrcTowns.Add(new Town("Львів", "Україна", "Львівська обл.", 800000, 2000000, 400, false, true));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            if (MessageBox.Show(
                "Закрити застосунок?",
                "Вихід з програми",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcTowns.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені",
                "Очищення даних",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcTowns.Clear();
            }
        }

    }
}