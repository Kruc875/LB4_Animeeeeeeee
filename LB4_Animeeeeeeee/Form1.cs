using Microsoft.EntityFrameworkCore;
using AppContext = LB4_Animeeeeeeee.Models.AppContext;
namespace LB4_Animeeeeeeee
{
    public partial class Form1 : Form
    {
        private AppContext db;

        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTypes.Load();
            this.dataGridViewFill.DataSource = this.db.AnimeTypes.Local.OrderBy(o => o.AnimeOfType).ToList();
            //сокрытие некоторых столбцов
            dataGridViewFill.Columns["Id"].Visible = false;
            dataGridViewFill.Columns["AnimeTitles"].Visible = false;
            //изменение названий заголовка столбцов
            dataGridViewFill.Columns["AnimeOfType"].HeaderText = "Тип";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
