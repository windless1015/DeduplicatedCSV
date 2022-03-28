
namespace FindDifferentItems
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_mainCSV = new System.Windows.Forms.Button();
            this.btn_reference = new System.Windows.Forms.Button();
            this.lb_main = new System.Windows.Forms.Label();
            this.lb_ref = new System.Windows.Forms.Label();
            this.btn_compute = new System.Windows.Forms.Button();
            this.lv_same = new System.Windows.Forms.ListView();
            this.rowNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AD_GROUP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lb_same_lv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_different = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label_same_num = new System.Windows.Forms.Label();
            this.label_diff_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mainCSV
            // 
            this.btn_mainCSV.Location = new System.Drawing.Point(12, 12);
            this.btn_mainCSV.Name = "btn_mainCSV";
            this.btn_mainCSV.Size = new System.Drawing.Size(106, 38);
            this.btn_mainCSV.TabIndex = 0;
            this.btn_mainCSV.Text = "待修改CSV数据";
            this.btn_mainCSV.UseVisualStyleBackColor = true;
            this.btn_mainCSV.Click += new System.EventHandler(this.btn_mainCSV_Click);
            // 
            // btn_reference
            // 
            this.btn_reference.Location = new System.Drawing.Point(12, 67);
            this.btn_reference.Name = "btn_reference";
            this.btn_reference.Size = new System.Drawing.Size(106, 39);
            this.btn_reference.TabIndex = 0;
            this.btn_reference.Text = "参考数据";
            this.btn_reference.UseVisualStyleBackColor = true;
            this.btn_reference.Click += new System.EventHandler(this.btn_reference_Click);
            // 
            // lb_main
            // 
            this.lb_main.BackColor = System.Drawing.SystemColors.Menu;
            this.lb_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_main.Location = new System.Drawing.Point(125, 17);
            this.lb_main.Name = "lb_main";
            this.lb_main.Size = new System.Drawing.Size(529, 27);
            this.lb_main.TabIndex = 1;
            // 
            // lb_ref
            // 
            this.lb_ref.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ref.Location = new System.Drawing.Point(125, 74);
            this.lb_ref.Name = "lb_ref";
            this.lb_ref.Size = new System.Drawing.Size(529, 27);
            this.lb_ref.TabIndex = 1;
            // 
            // btn_compute
            // 
            this.btn_compute.Location = new System.Drawing.Point(331, 660);
            this.btn_compute.Name = "btn_compute";
            this.btn_compute.Size = new System.Drawing.Size(106, 39);
            this.btn_compute.TabIndex = 0;
            this.btn_compute.Text = "计算";
            this.btn_compute.UseVisualStyleBackColor = true;
            this.btn_compute.Click += new System.EventHandler(this.btn_compute_Click);
            // 
            // lv_same
            // 
            this.lv_same.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rowNo,
            this.AD_GROUP});
            this.lv_same.HideSelection = false;
            this.lv_same.Location = new System.Drawing.Point(12, 139);
            this.lv_same.Name = "lv_same";
            this.lv_same.Size = new System.Drawing.Size(345, 503);
            this.lv_same.TabIndex = 2;
            this.lv_same.UseCompatibleStateImageBehavior = false;
            this.lv_same.View = System.Windows.Forms.View.Details;
            // 
            // rowNo
            // 
            this.rowNo.Text = "行号";
            this.rowNo.Width = 40;
            // 
            // AD_GROUP
            // 
            this.AD_GROUP.Text = "ad_group";
            this.AD_GROUP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AD_GROUP.Width = 300;
            // 
            // lb_same_lv
            // 
            this.lb_same_lv.AutoSize = true;
            this.lb_same_lv.Location = new System.Drawing.Point(123, 124);
            this.lb_same_lv.Name = "lb_same_lv";
            this.lb_same_lv.Size = new System.Drawing.Size(77, 12);
            this.lb_same_lv.TabIndex = 3;
            this.lb_same_lv.Text = "相同行数展示";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "不同行数展示";
            // 
            // lv_different
            // 
            this.lv_different.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv_different.HideSelection = false;
            this.lv_different.Location = new System.Drawing.Point(423, 139);
            this.lv_different.Name = "lv_different";
            this.lv_different.Size = new System.Drawing.Size(345, 503);
            this.lv_different.TabIndex = 2;
            this.lv_different.UseCompatibleStateImageBehavior = false;
            this.lv_different.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "行号";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ad_group";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // label_same_num
            // 
            this.label_same_num.AutoSize = true;
            this.label_same_num.Location = new System.Drawing.Point(123, 660);
            this.label_same_num.Name = "label_same_num";
            this.label_same_num.Size = new System.Drawing.Size(0, 12);
            this.label_same_num.TabIndex = 3;
            // 
            // label_diff_num
            // 
            this.label_diff_num.AutoSize = true;
            this.label_diff_num.Location = new System.Drawing.Point(564, 660);
            this.label_diff_num.Name = "label_diff_num";
            this.label_diff_num.Size = new System.Drawing.Size(0, 12);
            this.label_diff_num.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 721);
            this.Controls.Add(this.label_diff_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_same_num);
            this.Controls.Add(this.lb_same_lv);
            this.Controls.Add(this.lv_different);
            this.Controls.Add(this.lv_same);
            this.Controls.Add(this.lb_ref);
            this.Controls.Add(this.lb_main);
            this.Controls.Add(this.btn_compute);
            this.Controls.Add(this.btn_reference);
            this.Controls.Add(this.btn_mainCSV);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mainCSV;
        private System.Windows.Forms.Button btn_reference;
        private System.Windows.Forms.Label lb_main;
        private System.Windows.Forms.Label lb_ref;
        private System.Windows.Forms.Button btn_compute;
        private System.Windows.Forms.ListView lv_same;
        private System.Windows.Forms.ColumnHeader rowNo;
        private System.Windows.Forms.ColumnHeader AD_GROUP;
        private System.Windows.Forms.Label lb_same_lv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_different;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label_same_num;
        private System.Windows.Forms.Label label_diff_num;
    }
}

