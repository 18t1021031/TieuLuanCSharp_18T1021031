namespace QLXM
{
    partial class TimkiemTTKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTKH = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTrove = new System.Windows.Forms.Button();
            this.btHienhet = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.rdTenkh = new System.Windows.Forms.RadioButton();
            this.rdMakh = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "TRA CỨU THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTKH);
            this.groupBox1.Location = new System.Drawing.Point(18, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 261);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách khách hàng";
            // 
            // dgvTTKH
            // 
            this.dgvTTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTTKH.Location = new System.Drawing.Point(15, 25);
            this.dgvTTKH.Name = "dgvTTKH";
            this.dgvTTKH.Size = new System.Drawing.Size(691, 219);
            this.dgvTTKH.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaKH";
            this.Column1.HeaderText = "Mã KH";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenKH";
            this.Column2.HeaderText = "Tên KH";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.Name = "Column5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btTrove);
            this.groupBox2.Controls.Add(this.btHienhet);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.rdTenkh);
            this.groupBox2.Controls.Add(this.rdMakh);
            this.groupBox2.Location = new System.Drawing.Point(18, 70);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(707, 163);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(549, 103);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 28);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTrove
            // 
            this.btTrove.Image = global::QLXM.Properties.Resources.iconfinder_Undo_27885;
            this.btTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrove.Location = new System.Drawing.Point(549, 44);
            this.btTrove.Name = "btTrove";
            this.btTrove.Size = new System.Drawing.Size(100, 28);
            this.btTrove.TabIndex = 8;
            this.btTrove.Text = "Trở về";
            this.btTrove.UseVisualStyleBackColor = true;
            this.btTrove.Click += new System.EventHandler(this.btTrove_Click);
            // 
            // btHienhet
            // 
            this.btHienhet.Image = global::QLXM.Properties.Resources.iconfinder_Preview_27868;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(391, 103);
            this.btHienhet.Margin = new System.Windows.Forms.Padding(4);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(100, 28);
            this.btHienhet.TabIndex = 5;
            this.btHienhet.Text = "Hiện hết";
            this.btHienhet.UseVisualStyleBackColor = true;
            this.btHienhet.Click += new System.EventHandler(this.btHienhet_Click);
            // 
            // btTim
            // 
            this.btTim.Image = global::QLXM.Properties.Resources.search__1_;
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(391, 44);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(100, 28);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // rdTenkh
            // 
            this.rdTenkh.AutoSize = true;
            this.rdTenkh.Location = new System.Drawing.Point(41, 103);
            this.rdTenkh.Margin = new System.Windows.Forms.Padding(4);
            this.rdTenkh.Name = "rdTenkh";
            this.rdTenkh.Size = new System.Drawing.Size(122, 23);
            this.rdTenkh.TabIndex = 1;
            this.rdTenkh.TabStop = true;
            this.rdTenkh.Text = "Tên khách hàng";
            this.rdTenkh.UseVisualStyleBackColor = true;
            // 
            // rdMakh
            // 
            this.rdMakh.AutoSize = true;
            this.rdMakh.Location = new System.Drawing.Point(41, 49);
            this.rdMakh.Margin = new System.Windows.Forms.Padding(4);
            this.rdMakh.Name = "rdMakh";
            this.rdMakh.Size = new System.Drawing.Size(120, 23);
            this.rdMakh.TabIndex = 0;
            this.rdMakh.TabStop = true;
            this.rdMakh.Text = "Mã khách hàng";
            this.rdMakh.UseVisualStyleBackColor = true;
            // 
            // TimkiemTTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(759, 524);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimkiemTTKH";
            this.Text = "TimkiemTTKH";
            this.Load += new System.EventHandler(this.TimkiemTTKH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTKH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdTenkh;
        private System.Windows.Forms.RadioButton rdMakh;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTrove;
    }
}