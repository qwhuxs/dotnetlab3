namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProcces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPotoks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.cb_priority = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnProcces,
            this.ColumnRAM,
            this.ColumnPriority,
            this.ColumnPotoks,
            this.ColumnDateTime});
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(713, 345);
            this.dataGridView.TabIndex = 0;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            this.ColumnId.Width = 125;
            // 
            // ColumnProcces
            // 
            this.ColumnProcces.HeaderText = "Name";
            this.ColumnProcces.MinimumWidth = 6;
            this.ColumnProcces.Name = "ColumnProcces";
            this.ColumnProcces.ReadOnly = true;
            this.ColumnProcces.Width = 125;
            // 
            // ColumnRAM
            // 
            this.ColumnRAM.HeaderText = "RAM";
            this.ColumnRAM.MinimumWidth = 6;
            this.ColumnRAM.Name = "ColumnRAM";
            this.ColumnRAM.ReadOnly = true;
            this.ColumnRAM.Width = 125;
            // 
            // ColumnPriority
            // 
            this.ColumnPriority.HeaderText = "Priority";
            this.ColumnPriority.MinimumWidth = 6;
            this.ColumnPriority.Name = "ColumnPriority";
            this.ColumnPriority.ReadOnly = true;
            this.ColumnPriority.Width = 125;
            // 
            // ColumnPotoks
            // 
            this.ColumnPotoks.HeaderText = "Flows";
            this.ColumnPotoks.MinimumWidth = 6;
            this.ColumnPotoks.Name = "ColumnPotoks";
            this.ColumnPotoks.ReadOnly = true;
            this.ColumnPotoks.Width = 125;
            // 
            // ColumnDateTime
            // 
            this.ColumnDateTime.HeaderText = "Time Start";
            this.ColumnDateTime.MinimumWidth = 6;
            this.ColumnDateTime.Name = "ColumnDateTime";
            this.ColumnDateTime.ReadOnly = true;
            this.ColumnDateTime.Width = 125;
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Start.Location = new System.Drawing.Point(12, 363);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(150, 59);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "Run";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.Location = new System.Drawing.Point(168, 363);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 58);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_change
            // 
            this.btn_change.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_change.Location = new System.Drawing.Point(500, 363);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(150, 58);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "Change Priority";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // cb_priority
            // 
            this.cb_priority.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_priority.FormattingEnabled = true;
            this.cb_priority.Location = new System.Drawing.Point(341, 377);
            this.cb_priority.Name = "cb_priority";
            this.cb_priority.Size = new System.Drawing.Size(142, 33);
            this.cb_priority.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 427);
            this.Controls.Add(this.cb_priority);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProcces;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPotoks;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateTime;
        private System.Windows.Forms.ComboBox cb_priority;
    }
}

