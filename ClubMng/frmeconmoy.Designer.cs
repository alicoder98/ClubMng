namespace ClubMng
{
    partial class frmeconmoy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nUD_pay = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_tamdid = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_total_ec = new System.Windows.Forms.TextBox();
            this.txt_expir_ec = new System.Windows.Forms.TextBox();
            this.txt_lpay_ec = new System.Windows.Forms.TextBox();
            this.txt_status_ec = new System.Windows.Forms.TextBox();
            this.txt_nid_ec = new System.Windows.Forms.TextBox();
            this.txt_fnam_ec = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_econo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTPAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_pay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_econo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nUD_pay);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.btn_tamdid);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_total_ec);
            this.groupBox1.Controls.Add(this.txt_expir_ec);
            this.groupBox1.Controls.Add(this.txt_lpay_ec);
            this.groupBox1.Controls.Add(this.txt_status_ec);
            this.groupBox1.Controls.Add(this.txt_nid_ec);
            this.groupBox1.Controls.Add(this.txt_fnam_ec);
            this.groupBox1.Location = new System.Drawing.Point(449, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nUD_pay
            // 
            this.nUD_pay.Location = new System.Drawing.Point(59, 277);
            this.nUD_pay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nUD_pay.Name = "nUD_pay";
            this.nUD_pay.Size = new System.Drawing.Size(120, 20);
            this.nUD_pay.TabIndex = 13;
            this.nUD_pay.ThousandsSeparator = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(150, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "ریال";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "ریال";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "مبلغ پرداختی";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(208, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "مهلت جدید";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "نوع عضویت";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(104, 336);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "بازگشت";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(59, 250);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 214);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_tamdid
            // 
            this.btn_tamdid.Location = new System.Drawing.Point(104, 307);
            this.btn_tamdid.Name = "btn_tamdid";
            this.btn_tamdid.Size = new System.Drawing.Size(75, 23);
            this.btn_tamdid.TabIndex = 6;
            this.btn_tamdid.Text = "تمدید";
            this.btn_tamdid.UseVisualStyleBackColor = true;
            this.btn_tamdid.Click += new System.EventHandler(this.btn_tamdid_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "مجموع پرداخت ها";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "مهلت باقی مانده";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "آخرین پرداخت";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "وضعیت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام و نام خانوادگی";
            // 
            // txt_total_ec
            // 
            this.txt_total_ec.Location = new System.Drawing.Point(6, 117);
            this.txt_total_ec.Name = "txt_total_ec";
            this.txt_total_ec.ReadOnly = true;
            this.txt_total_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_total_ec.TabIndex = 3;
            // 
            // txt_expir_ec
            // 
            this.txt_expir_ec.Location = new System.Drawing.Point(6, 169);
            this.txt_expir_ec.Name = "txt_expir_ec";
            this.txt_expir_ec.ReadOnly = true;
            this.txt_expir_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_expir_ec.TabIndex = 3;
            // 
            // txt_lpay_ec
            // 
            this.txt_lpay_ec.Location = new System.Drawing.Point(6, 143);
            this.txt_lpay_ec.Name = "txt_lpay_ec";
            this.txt_lpay_ec.ReadOnly = true;
            this.txt_lpay_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_lpay_ec.TabIndex = 3;
            // 
            // txt_status_ec
            // 
            this.txt_status_ec.Location = new System.Drawing.Point(6, 91);
            this.txt_status_ec.Name = "txt_status_ec";
            this.txt_status_ec.ReadOnly = true;
            this.txt_status_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_status_ec.TabIndex = 2;
            // 
            // txt_nid_ec
            // 
            this.txt_nid_ec.Location = new System.Drawing.Point(6, 65);
            this.txt_nid_ec.Name = "txt_nid_ec";
            this.txt_nid_ec.ReadOnly = true;
            this.txt_nid_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_nid_ec.TabIndex = 1;
            // 
            // txt_fnam_ec
            // 
            this.txt_fnam_ec.Location = new System.Drawing.Point(6, 36);
            this.txt_fnam_ec.Name = "txt_fnam_ec";
            this.txt_fnam_ec.ReadOnly = true;
            this.txt_fnam_ec.Size = new System.Drawing.Size(173, 20);
            this.txt_fnam_ec.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_econo);
            this.groupBox2.Location = new System.Drawing.Point(5, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 424);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgv_econo
            // 
            this.dgv_econo.AllowUserToAddRows = false;
            this.dgv_econo.AllowUserToDeleteRows = false;
            this.dgv_econo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_econo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FULLNAME,
            this.NID,
            this.status,
            this.LASTPAY,
            this.expired,
            this.total,
            this.id,
            this.mydate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_econo.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_econo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_econo.Location = new System.Drawing.Point(3, 16);
            this.dgv_econo.Name = "dgv_econo";
            this.dgv_econo.ReadOnly = true;
            this.dgv_econo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_econo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_econo.Size = new System.Drawing.Size(432, 405);
            this.dgv_econo.TabIndex = 0;
            this.dgv_econo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_econo_CellClick);
            this.dgv_econo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(380, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "پرداخت شده";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(307, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "پرداخت نشده";
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "fullName";
            this.FULLNAME.HeaderText = "نام و نام خانوادگی";
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.ReadOnly = true;
            // 
            // NID
            // 
            this.NID.DataPropertyName = "nID";
            this.NID.HeaderText = "کدملی";
            this.NID.Name = "NID";
            this.NID.ReadOnly = true;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "وضعیت";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // LASTPAY
            // 
            this.LASTPAY.DataPropertyName = "lastpay";
            this.LASTPAY.HeaderText = "آخرین پرداخت";
            this.LASTPAY.Name = "LASTPAY";
            this.LASTPAY.ReadOnly = true;
            // 
            // expired
            // 
            this.expired.DataPropertyName = "expired";
            this.expired.HeaderText = "مهلت باقی مانده(روز)";
            this.expired.Name = "expired";
            this.expired.ReadOnly = true;
            this.expired.ToolTipText = "تعداد روز های باقی مانده به اتمام";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "مجموع پرداختی";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "athlete_Id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // mydate
            // 
            this.mydate.DataPropertyName = "mydate";
            this.mydate.HeaderText = "تاریخ پایان";
            this.mydate.Name = "mydate";
            this.mydate.ReadOnly = true;
            // 
            // frmeconmoy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmeconmoy";
            this.Text = "شهریه ها";
            this.Load += new System.EventHandler(this.frmeconmoy_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_pay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_econo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_econo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_expir_ec;
        private System.Windows.Forms.TextBox txt_lpay_ec;
        private System.Windows.Forms.TextBox txt_status_ec;
        private System.Windows.Forms.TextBox txt_nid_ec;
        private System.Windows.Forms.TextBox txt_fnam_ec;
        private System.Windows.Forms.Button btn_tamdid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_total_ec;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUD_pay;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NID;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTPAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn expired;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mydate;
    }
}