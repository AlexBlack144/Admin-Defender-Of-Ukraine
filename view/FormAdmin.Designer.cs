namespace Game_Kursak_Admin
{
    partial class FormAdmin
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.label_online = new System.Windows.Forms.Label();
            this.label_кating_result = new System.Windows.Forms.Label();
            this.label_ban = new System.Windows.Forms.Label();
            this.listBox_IP_clients = new System.Windows.Forms.ListBox();
            this.dataGridView_Results = new System.Windows.Forms.DataGridView();
            this.dataGridView_Bans = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_ban = new System.Windows.Forms.Button();
            this.button_delete_ban = new System.Windows.Forms.Button();
            this.stop_server_btn = new System.Windows.Forms.Button();
            this.start_server_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bans)).BeginInit();
            this.SuspendLayout();
            // 
            // label_online
            // 
            this.label_online.AutoSize = true;
            this.label_online.BackColor = System.Drawing.Color.Transparent;
            this.label_online.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_online.ForeColor = System.Drawing.Color.White;
            this.label_online.Location = new System.Drawing.Point(84, 20);
            this.label_online.Name = "label_online";
            this.label_online.Size = new System.Drawing.Size(95, 44);
            this.label_online.TabIndex = 10;
            this.label_online.Text = "Online";
            // 
            // label_кating_result
            // 
            this.label_кating_result.AutoSize = true;
            this.label_кating_result.BackColor = System.Drawing.Color.Transparent;
            this.label_кating_result.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_кating_result.ForeColor = System.Drawing.Color.White;
            this.label_кating_result.Location = new System.Drawing.Point(435, 19);
            this.label_кating_result.Name = "label_кating_result";
            this.label_кating_result.Size = new System.Drawing.Size(174, 44);
            this.label_кating_result.TabIndex = 11;
            this.label_кating_result.Text = "Rating result";
            // 
            // label_ban
            // 
            this.label_ban.AutoSize = true;
            this.label_ban.BackColor = System.Drawing.Color.Transparent;
            this.label_ban.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_ban.ForeColor = System.Drawing.Color.White;
            this.label_ban.Location = new System.Drawing.Point(867, 20);
            this.label_ban.Name = "label_ban";
            this.label_ban.Size = new System.Drawing.Size(66, 44);
            this.label_ban.TabIndex = 12;
            this.label_ban.Text = "Ban";
            // 
            // listBox_IP_clients
            // 
            this.listBox_IP_clients.BackColor = System.Drawing.Color.Gray;
            this.listBox_IP_clients.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_IP_clients.ForeColor = System.Drawing.Color.White;
            this.listBox_IP_clients.FormattingEnabled = true;
            this.listBox_IP_clients.ItemHeight = 18;
            this.listBox_IP_clients.Location = new System.Drawing.Point(12, 67);
            this.listBox_IP_clients.Name = "listBox_IP_clients";
            this.listBox_IP_clients.Size = new System.Drawing.Size(254, 256);
            this.listBox_IP_clients.TabIndex = 14;
            // 
            // dataGridView_Results
            // 
            this.dataGridView_Results.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView_Results.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Results.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_Results.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Results.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_Results.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Results.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Results.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Results.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_Results.Location = new System.Drawing.Point(282, 66);
            this.dataGridView_Results.Name = "dataGridView_Results";
            this.dataGridView_Results.ReadOnly = true;
            this.dataGridView_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_Results.Size = new System.Drawing.Size(468, 278);
            this.dataGridView_Results.TabIndex = 16;
            // 
            // dataGridView_Bans
            // 
            this.dataGridView_Bans.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red;
            this.dataGridView_Bans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Bans.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridView_Bans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_Bans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridView_Bans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Bans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Bans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Bans.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Bans.GridColor = System.Drawing.Color.Gray;
            this.dataGridView_Bans.Location = new System.Drawing.Point(770, 67);
            this.dataGridView_Bans.Name = "dataGridView_Bans";
            this.dataGridView_Bans.ReadOnly = true;
            this.dataGridView_Bans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Bans.Size = new System.Drawing.Size(265, 278);
            this.dataGridView_Bans.TabIndex = 17;
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.DarkRed;
            this.button_delete.Location = new System.Drawing.Point(406, 352);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(138, 72);
            this.button_delete.TabIndex = 18;
            this.button_delete.Text = "Delete from DB";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_ban
            // 
            this.button_ban.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_ban.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ban.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ban.ForeColor = System.Drawing.Color.DarkRed;
            this.button_ban.Location = new System.Drawing.Point(560, 352);
            this.button_ban.Name = "button_ban";
            this.button_ban.Size = new System.Drawing.Size(78, 72);
            this.button_ban.TabIndex = 19;
            this.button_ban.Text = "Ban";
            this.button_ban.UseVisualStyleBackColor = false;
            this.button_ban.Click += new System.EventHandler(this.button_ban_Click);
            // 
            // button_delete_ban
            // 
            this.button_delete_ban.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_delete_ban.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_delete_ban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_ban.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete_ban.ForeColor = System.Drawing.Color.DarkRed;
            this.button_delete_ban.Location = new System.Drawing.Point(853, 352);
            this.button_delete_ban.Name = "button_delete_ban";
            this.button_delete_ban.Size = new System.Drawing.Size(113, 72);
            this.button_delete_ban.TabIndex = 20;
            this.button_delete_ban.Text = "Delete from Ban";
            this.button_delete_ban.UseVisualStyleBackColor = false;
            this.button_delete_ban.Click += new System.EventHandler(this.button_delete_ban_Click);
            // 
            // stop_server_btn
            // 
            this.stop_server_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.stop_server_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.stop_server_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop_server_btn.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_server_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.stop_server_btn.Location = new System.Drawing.Point(159, 352);
            this.stop_server_btn.Name = "stop_server_btn";
            this.stop_server_btn.Size = new System.Drawing.Size(88, 72);
            this.stop_server_btn.TabIndex = 21;
            this.stop_server_btn.Text = "Stop Server";
            this.stop_server_btn.UseVisualStyleBackColor = false;
            this.stop_server_btn.Click += new System.EventHandler(this.stop_server_btn_Click);
            // 
            // start_server_btn
            // 
            this.start_server_btn.BackColor = System.Drawing.SystemColors.Desktop;
            this.start_server_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_server_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_server_btn.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_server_btn.ForeColor = System.Drawing.Color.DarkRed;
            this.start_server_btn.Location = new System.Drawing.Point(25, 352);
            this.start_server_btn.Name = "start_server_btn";
            this.start_server_btn.Size = new System.Drawing.Size(88, 72);
            this.start_server_btn.TabIndex = 22;
            this.start_server_btn.Text = "Start Server";
            this.start_server_btn.UseVisualStyleBackColor = false;
            this.start_server_btn.Click += new System.EventHandler(this.start_server_btn_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Kursak_Admin.Properties.Resources.kamuflyag;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 434);
            this.Controls.Add(this.start_server_btn);
            this.Controls.Add(this.stop_server_btn);
            this.Controls.Add(this.button_delete_ban);
            this.Controls.Add(this.button_ban);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.dataGridView_Bans);
            this.Controls.Add(this.dataGridView_Results);
            this.Controls.Add(this.listBox_IP_clients);
            this.Controls.Add(this.label_ban);
            this.Controls.Add(this.label_кating_result);
            this.Controls.Add(this.label_online);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Admin Defender of Ukraine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Bans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_online;
        private System.Windows.Forms.Label label_кating_result;
        private System.Windows.Forms.Label label_ban;
        private System.Windows.Forms.ListBox listBox_IP_clients;
        private System.Windows.Forms.DataGridView dataGridView_Results;
        private System.Windows.Forms.DataGridView dataGridView_Bans;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_ban;
        private System.Windows.Forms.Button button_delete_ban;
        private System.Windows.Forms.Button stop_server_btn;
        private System.Windows.Forms.Button start_server_btn;
    }
}

