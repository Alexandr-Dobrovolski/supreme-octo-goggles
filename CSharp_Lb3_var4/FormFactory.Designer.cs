
namespace CSharp_Lb3_Var4
{
    partial class FormFactory
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
            this.textBoxFactoryName = new System.Windows.Forms.TextBox();
            this.textBoxNumberWorkshops = new System.Windows.Forms.TextBox();
            this.textBoxAmountCraftsmen = new System.Windows.Forms.TextBox();
            this.textBoxAmountWorkers = new System.Windows.Forms.TextBox();
            this.textBoxProfitCraftsman = new System.Windows.Forms.TextBox();
            this.textBoxProfitWorker = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiringWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiringCraftsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firingWorkersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firingCraftsmenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFactoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxFactories = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.comboBoxFactoriesCopy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShowCopy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxCountDetais = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFactoryName
            // 
            this.textBoxFactoryName.Location = new System.Drawing.Point(172, 126);
            this.textBoxFactoryName.Name = "textBoxFactoryName";
            this.textBoxFactoryName.Size = new System.Drawing.Size(308, 23);
            this.textBoxFactoryName.TabIndex = 1;
            // 
            // textBoxNumberWorkshops
            // 
            this.textBoxNumberWorkshops.Location = new System.Drawing.Point(172, 155);
            this.textBoxNumberWorkshops.Name = "textBoxNumberWorkshops";
            this.textBoxNumberWorkshops.Size = new System.Drawing.Size(308, 23);
            this.textBoxNumberWorkshops.TabIndex = 2;
            // 
            // textBoxAmountCraftsmen
            // 
            this.textBoxAmountCraftsmen.Location = new System.Drawing.Point(172, 213);
            this.textBoxAmountCraftsmen.Name = "textBoxAmountCraftsmen";
            this.textBoxAmountCraftsmen.Size = new System.Drawing.Size(308, 23);
            this.textBoxAmountCraftsmen.TabIndex = 4;
            // 
            // textBoxAmountWorkers
            // 
            this.textBoxAmountWorkers.Location = new System.Drawing.Point(172, 184);
            this.textBoxAmountWorkers.Name = "textBoxAmountWorkers";
            this.textBoxAmountWorkers.Size = new System.Drawing.Size(308, 23);
            this.textBoxAmountWorkers.TabIndex = 3;
            // 
            // textBoxProfitCraftsman
            // 
            this.textBoxProfitCraftsman.Location = new System.Drawing.Point(172, 271);
            this.textBoxProfitCraftsman.Name = "textBoxProfitCraftsman";
            this.textBoxProfitCraftsman.Size = new System.Drawing.Size(308, 23);
            this.textBoxProfitCraftsman.TabIndex = 8;
            // 
            // textBoxProfitWorker
            // 
            this.textBoxProfitWorker.Location = new System.Drawing.Point(172, 242);
            this.textBoxProfitWorker.Name = "textBoxProfitWorker";
            this.textBoxProfitWorker.Size = new System.Drawing.Size(308, 23);
            this.textBoxProfitWorker.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataName,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(576, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(473, 302);
            this.dataGridView1.TabIndex = 15;
            // 
            // DataName
            // 
            this.DataName.HeaderText = "Назва";
            this.DataName.Name = "DataName";
            this.DataName.Width = 215;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дані";
            this.Data.Name = "Data";
            this.Data.Width = 215;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(271, 329);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(96, 51);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Додати інформацію";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.hiringToolStripMenuItem,
            this.firingToolStripMenuItem,
            this.copyFactoryToolStripMenuItem,
            this.comparisonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Вихід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hiringToolStripMenuItem
            // 
            this.hiringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiringWorkersToolStripMenuItem,
            this.hiringCraftsmenToolStripMenuItem});
            this.hiringToolStripMenuItem.Name = "hiringToolStripMenuItem";
            this.hiringToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hiringToolStripMenuItem.Text = "Найм";
            // 
            // hiringWorkersToolStripMenuItem
            // 
            this.hiringWorkersToolStripMenuItem.Name = "hiringWorkersToolStripMenuItem";
            this.hiringWorkersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hiringWorkersToolStripMenuItem.Text = "Працівників";
            this.hiringWorkersToolStripMenuItem.Click += new System.EventHandler(this.hiringWorkersToolStripMenuItem_Click);
            // 
            // hiringCraftsmenToolStripMenuItem
            // 
            this.hiringCraftsmenToolStripMenuItem.Name = "hiringCraftsmenToolStripMenuItem";
            this.hiringCraftsmenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.hiringCraftsmenToolStripMenuItem.Text = "Майстрів";
            this.hiringCraftsmenToolStripMenuItem.Click += new System.EventHandler(this.hiringCraftsmenToolStripMenuItem_Click);
            // 
            // firingToolStripMenuItem
            // 
            this.firingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firingWorkersToolStripMenuItem,
            this.firingCraftsmenToolStripMenuItem});
            this.firingToolStripMenuItem.Name = "firingToolStripMenuItem";
            this.firingToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.firingToolStripMenuItem.Text = "Звільнення";
            // 
            // firingWorkersToolStripMenuItem
            // 
            this.firingWorkersToolStripMenuItem.Name = "firingWorkersToolStripMenuItem";
            this.firingWorkersToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.firingWorkersToolStripMenuItem.Text = "Працівників";
            this.firingWorkersToolStripMenuItem.Click += new System.EventHandler(this.firingWorkersToolStripMenuItem_Click);
            // 
            // firingCraftsmenToolStripMenuItem
            // 
            this.firingCraftsmenToolStripMenuItem.Name = "firingCraftsmenToolStripMenuItem";
            this.firingCraftsmenToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.firingCraftsmenToolStripMenuItem.Text = "Майстрів";
            this.firingCraftsmenToolStripMenuItem.Click += new System.EventHandler(this.firingCraftsmenToolStripMenuItem_Click);
            // 
            // copyFactoryToolStripMenuItem
            // 
            this.copyFactoryToolStripMenuItem.Name = "copyFactoryToolStripMenuItem";
            this.copyFactoryToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.copyFactoryToolStripMenuItem.Text = "Копіювати завод";
            this.copyFactoryToolStripMenuItem.Click += new System.EventHandler(this.copyFactoryToolStripMenuItem_Click);
            // 
            // comparisonToolStripMenuItem
            // 
            this.comparisonToolStripMenuItem.Name = "comparisonToolStripMenuItem";
            this.comparisonToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.comparisonToolStripMenuItem.Text = "Порівняння заводів";
            this.comparisonToolStripMenuItem.Click += new System.EventHandler(this.comparisonToolStripMenuItem_Click);
            // 
            // comboBoxFactories
            // 
            this.comboBoxFactories.FormattingEnabled = true;
            this.comboBoxFactories.Location = new System.Drawing.Point(626, 67);
            this.comboBoxFactories.Name = "comboBoxFactories";
            this.comboBoxFactories.Size = new System.Drawing.Size(194, 23);
            this.comboBoxFactories.TabIndex = 11;
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(678, 96);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(86, 23);
            this.buttonShow.TabIndex = 12;
            this.buttonShow.Text = "Показати";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // comboBoxFactoriesCopy
            // 
            this.comboBoxFactoriesCopy.FormattingEnabled = true;
            this.comboBoxFactoriesCopy.Location = new System.Drawing.Point(826, 67);
            this.comboBoxFactoriesCopy.Name = "comboBoxFactoriesCopy";
            this.comboBoxFactoriesCopy.Size = new System.Drawing.Size(181, 23);
            this.comboBoxFactoriesCopy.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(626, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Основний вибір заводів";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Скопійовані заводи";
            // 
            // buttonShowCopy
            // 
            this.buttonShowCopy.Location = new System.Drawing.Point(872, 96);
            this.buttonShowCopy.Name = "buttonShowCopy";
            this.buttonShowCopy.Size = new System.Drawing.Size(86, 23);
            this.buttonShowCopy.TabIndex = 14;
            this.buttonShowCopy.Text = "Показати";
            this.buttonShowCopy.UseVisualStyleBackColor = true;
            this.buttonShowCopy.Click += new System.EventHandler(this.buttonShowCopy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Назва заводу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "К-сть цехів";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "К-сть робітників";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "К-сть майстрів";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Прибуток з працівника";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Прибуток з майстра";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "К-сть деталей";
            // 
            // textBoxCountDetais
            // 
            this.textBoxCountDetais.Location = new System.Drawing.Point(172, 300);
            this.textBoxCountDetais.Name = "textBoxCountDetais";
            this.textBoxCountDetais.Size = new System.Drawing.Size(308, 23);
            this.textBoxCountDetais.TabIndex = 9;
            // 
            // FormFactory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCountDetais);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonShowCopy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFactoriesCopy);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxFactories);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxProfitCraftsman);
            this.Controls.Add(this.textBoxProfitWorker);
            this.Controls.Add(this.textBoxAmountCraftsmen);
            this.Controls.Add(this.textBoxAmountWorkers);
            this.Controls.Add(this.textBoxNumberWorkshops);
            this.Controls.Add(this.textBoxFactoryName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormFactory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Завод";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFactoryName;
        private System.Windows.Forms.TextBox textBoxNumberWorkshops;
        private System.Windows.Forms.TextBox textBoxAmountCraftsmen;
        private System.Windows.Forms.TextBox textBoxAmountWorkers;
        private System.Windows.Forms.TextBox textBoxProfitCraftsman;
        private System.Windows.Forms.TextBox textBoxProfitWorker;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyFactoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFactories;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.ToolStripMenuItem hiringWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiringCraftsmenToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFactoriesCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonShowCopy;
        private System.Windows.Forms.ToolStripMenuItem comparisonToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem firingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firingWorkersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firingCraftsmenToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxCountDetais;
    }
}

