namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.lb_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Location = new System.Drawing.Point(13, 13);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(245, 20);
            this.cbBox.TabIndex = 0;
            this.cbBox.SelectedIndexChanged += new System.EventHandler(this.CbBox_SelectedIndexChanged);
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bt_start.Location = new System.Drawing.Point(265, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(75, 23);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "담그기!";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.Bt_start_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("돋움", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_time.Location = new System.Drawing.Point(13, 52);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(70, 20);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "시간 : ";
            this.lb_time.Click += new System.EventHandler(this.Lb_time_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 92);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.cbBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Label lb_time;
    }
}

