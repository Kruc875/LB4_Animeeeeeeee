using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
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
            //�������� ��������� ��������
            dataGridViewFill.Columns["Id"].Visible = false;
            dataGridViewFill.Columns["AnimeTitles"].Visible = false;
            //��������� �������� ��������� ��������
            dataGridViewFill.Columns["AnimeOfType"].HeaderText = "���";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
