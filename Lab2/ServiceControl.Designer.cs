namespace Lab2
{
    partial class ServiceControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridService = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.startItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServicebtn = new System.Windows.Forms.Button();
            this.stopServicebtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridService
            // 
            this.dataGridService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridService.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridService.Location = new System.Drawing.Point(3, 70);
            this.dataGridService.Name = "dataGridService";
            this.dataGridService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridService.Size = new System.Drawing.Size(620, 439);
            this.dataGridService.TabIndex = 0;
            this.dataGridService.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridService_DataBindingComplete);
            this.dataGridService.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridService_MouseDown_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startItem,
            this.stopItem,
            this.updateItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 70);
            // 
            // startItem
            // 
            this.startItem.Name = "startItem";
            this.startItem.Size = new System.Drawing.Size(128, 22);
            this.startItem.Text = "Старт";
            this.startItem.Click += new System.EventHandler(this.startItem_Click);
            // 
            // stopItem
            // 
            this.stopItem.Name = "stopItem";
            this.stopItem.Size = new System.Drawing.Size(128, 22);
            this.stopItem.Text = "Стоп";
            this.stopItem.Click += new System.EventHandler(this.stopItem_Click);
            // 
            // updateItem
            // 
            this.updateItem.Name = "updateItem";
            this.updateItem.Size = new System.Drawing.Size(128, 22);
            this.updateItem.Text = "Обновить";
            this.updateItem.Click += new System.EventHandler(this.updateItem_Click);
            // 
            // startServicebtn
            // 
            this.startServicebtn.Location = new System.Drawing.Point(27, 30);
            this.startServicebtn.Name = "startServicebtn";
            this.startServicebtn.Size = new System.Drawing.Size(75, 23);
            this.startServicebtn.TabIndex = 1;
            this.startServicebtn.Text = "Start";
            this.startServicebtn.UseVisualStyleBackColor = true;
            this.startServicebtn.Click += new System.EventHandler(this.startServicebtn_Click);
            // 
            // stopServicebtn
            // 
            this.stopServicebtn.Location = new System.Drawing.Point(109, 30);
            this.stopServicebtn.Name = "stopServicebtn";
            this.stopServicebtn.Size = new System.Drawing.Size(75, 23);
            this.stopServicebtn.TabIndex = 2;
            this.stopServicebtn.Text = "Stop";
            this.stopServicebtn.UseVisualStyleBackColor = true;
            this.stopServicebtn.Click += new System.EventHandler(this.stopServicebtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(191, 30);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 3;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.stopServicebtn);
            this.Controls.Add(this.startServicebtn);
            this.Controls.Add(this.dataGridService);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(626, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridService)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridService;
        private System.Windows.Forms.Button startServicebtn;
        private System.Windows.Forms.Button stopServicebtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startItem;
        private System.Windows.Forms.ToolStripMenuItem stopItem;
        private System.Windows.Forms.ToolStripMenuItem updateItem;
    }
}
