
namespace VehicleLicenseTax
{
    partial class VihicelLicenseTaxForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.rbtYear = new System.Windows.Forms.RadioButton();
            this.rbtDeadline = new System.Windows.Forms.RadioButton();
            this.cbxTrafficType = new System.Windows.Forms.ComboBox();
            this.cbxCC = new System.Windows.Forms.ComboBox();
            this.lblCCMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.lblDateMsg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlDate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(87, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "使用期間 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(87, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "交通種類 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(3, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "汽缸CC數 / 馬達馬力:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalculate.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalculate.Location = new System.Drawing.Point(143, 279);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 49);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "計算稅額";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(341, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "取消重填";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbtYear
            // 
            this.rbtYear.AutoSize = true;
            this.rbtYear.Checked = true;
            this.rbtYear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtYear.Location = new System.Drawing.Point(194, 78);
            this.rbtYear.Name = "rbtYear";
            this.rbtYear.Size = new System.Drawing.Size(82, 26);
            this.rbtYear.TabIndex = 5;
            this.rbtYear.TabStop = true;
            this.rbtYear.Text = "全年度";
            this.rbtYear.UseVisualStyleBackColor = true;
            // 
            // rbtDeadline
            // 
            this.rbtDeadline.AutoSize = true;
            this.rbtDeadline.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbtDeadline.Location = new System.Drawing.Point(289, 79);
            this.rbtDeadline.Name = "rbtDeadline";
            this.rbtDeadline.Size = new System.Drawing.Size(82, 26);
            this.rbtDeadline.TabIndex = 6;
            this.rbtDeadline.Text = "依期限";
            this.rbtDeadline.UseVisualStyleBackColor = true;
            this.rbtDeadline.CheckedChanged += new System.EventHandler(this.rbtDeadline_CheckedChanged);
            // 
            // cbxTrafficType
            // 
            this.cbxTrafficType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTrafficType.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxTrafficType.FormattingEnabled = true;
            this.cbxTrafficType.Items.AddRange(new object[] {
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
            this.cbxTrafficType.Location = new System.Drawing.Point(194, 149);
            this.cbxTrafficType.Name = "cbxTrafficType";
            this.cbxTrafficType.Size = new System.Drawing.Size(224, 30);
            this.cbxTrafficType.TabIndex = 7;
            this.cbxTrafficType.SelectedIndexChanged += new System.EventHandler(this.cbxTrafficType_SelectedIndexChanged);
            // 
            // cbxCC
            // 
            this.cbxCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCC.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCC.FormattingEnabled = true;
            this.cbxCC.Location = new System.Drawing.Point(194, 209);
            this.cbxCC.Name = "cbxCC";
            this.cbxCC.Size = new System.Drawing.Size(224, 30);
            this.cbxCC.TabIndex = 8;
            // 
            // lblCCMsg
            // 
            this.lblCCMsg.AutoSize = true;
            this.lblCCMsg.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCCMsg.ForeColor = System.Drawing.Color.Red;
            this.lblCCMsg.Location = new System.Drawing.Point(191, 191);
            this.lblCCMsg.Name = "lblCCMsg";
            this.lblCCMsg.Size = new System.Drawing.Size(14, 18);
            this.lblCCMsg.TabIndex = 10;
            this.lblCCMsg.Text = "-";
            this.lblCCMsg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(13, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "從";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(13, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "到";
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtStart.Location = new System.Drawing.Point(46, 11);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(188, 30);
            this.dtStart.TabIndex = 13;
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtEnd.Location = new System.Drawing.Point(46, 59);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(188, 30);
            this.dtEnd.TabIndex = 14;
            // 
            // lblDateMsg
            // 
            this.lblDateMsg.AutoSize = true;
            this.lblDateMsg.Font = new System.Drawing.Font("微軟正黑體", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDateMsg.ForeColor = System.Drawing.Color.Red;
            this.lblDateMsg.Location = new System.Drawing.Point(367, 24);
            this.lblDateMsg.Name = "lblDateMsg";
            this.lblDateMsg.Size = new System.Drawing.Size(14, 18);
            this.lblDateMsg.TabIndex = 18;
            this.lblDateMsg.Text = "-";
            this.lblDateMsg.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBoxResult.Location = new System.Drawing.Point(186, 362);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.Size = new System.Drawing.Size(439, 265);
            this.txtBoxResult.TabIndex = 20;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.label6);
            this.pnlDate.Controls.Add(this.dtStart);
            this.pnlDate.Controls.Add(this.dtEnd);
            this.pnlDate.Controls.Add(this.label7);
            this.pnlDate.Location = new System.Drawing.Point(370, 43);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(255, 100);
            this.pnlDate.TabIndex = 17;
            this.pnlDate.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtBoxResult);
            this.groupBox1.Controls.Add(this.pnlDate);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDateMsg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblCCMsg);
            this.groupBox1.Controls.Add(this.rbtYear);
            this.groupBox1.Controls.Add(this.rbtDeadline);
            this.groupBox1.Controls.Add(this.cbxCC);
            this.groupBox1.Controls.Add(this.cbxTrafficType);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 681);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "牌照稅試算表";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(87, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "試算結果 :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // VihicelLicenseTaxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 696);
            this.Controls.Add(this.groupBox1);
            this.Name = "VihicelLicenseTaxForm";
            this.Text = "VehicleLicenseTax";
            this.Load += new System.EventHandler(this.VihicelLicenseTaxForm_Load);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rbtYear;
        private System.Windows.Forms.RadioButton rbtDeadline;
        private System.Windows.Forms.ComboBox cbxTrafficType;
        private System.Windows.Forms.ComboBox cbxCC;
        private System.Windows.Forms.Label lblCCMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label lblDateMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
    }
}

