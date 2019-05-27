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
            this.components = new System.ComponentModel.Container();
            this.teaComboList = new System.Windows.Forms.ComboBox();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.btnTea = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // teaComboList
            // 
            this.teaComboList.Font = new System.Drawing.Font("굴림", 12F);
            this.teaComboList.FormattingEnabled = true;
            this.teaComboList.Location = new System.Drawing.Point(12, 12);
            this.teaComboList.Name = "teaComboList";
            this.teaComboList.Size = new System.Drawing.Size(241, 24);
            this.teaComboList.TabIndex = 0;
            // 
            // txtCountDown
            // 
            this.txtCountDown.Font = new System.Drawing.Font("굴림", 15F);
            this.txtCountDown.Location = new System.Drawing.Point(13, 155);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(241, 30);
            this.txtCountDown.TabIndex = 1;
            this.txtCountDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTea
            // 
            this.btnTea.Location = new System.Drawing.Point(13, 82);
            this.btnTea.Name = "btnTea";
            this.btnTea.Size = new System.Drawing.Size(241, 49);
            this.btnTea.TabIndex = 2;
            this.btnTea.Text = "담그기!";
            this.btnTea.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "2019.05.27 3501 강지현";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("굴림", 12F);
            this.Time.Location = new System.Drawing.Point(12, 48);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(145, 16);
            this.Time.TabIndex = 4;
            this.Time.Text = "차를 담그는 시간 : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 225);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTea);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.teaComboList);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "차 마시기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teaComboList;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.Button btnTea;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Time;
    }
}

