namespace LB4_Animeeeeeeee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanelTop = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelFill = new Panel();
            dataGridViewFill = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(button3);
            flowLayoutPanelTop.Controls.Add(button2);
            flowLayoutPanelTop.Controls.Add(button1);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1257, 80);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(310, 10);
            button3.Name = "button3";
            button3.Size = new Size(150, 60);
            button3.TabIndex = 3;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(160, 10);
            button2.Name = "button2";
            button2.Size = new Size(150, 60);
            button2.TabIndex = 2;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(150, 60);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewFill);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 80);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1257, 670);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewFill
            // 
            dataGridViewFill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewFill.BackgroundColor = Color.White;
            dataGridViewFill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFill.Dock = DockStyle.Fill;
            dataGridViewFill.Location = new Point(10, 10);
            dataGridViewFill.MultiSelect = false;
            dataGridViewFill.Name = "dataGridViewFill";
            dataGridViewFill.ReadOnly = true;
            dataGridViewFill.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFill.Size = new Size(1237, 650);
            dataGridViewFill.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Пользователи";
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFill).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel flowLayoutPanelTop;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panelFill;
        private DataGridView dataGridViewFill;
    }
}
