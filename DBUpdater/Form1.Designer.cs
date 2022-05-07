
namespace DBUpdater
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCnt = new System.Windows.Forms.Label();
            this.lvRecipelist = new System.Windows.Forms.ListView();
            this.lvColumnDevice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvColumnPpid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(12, 58);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(775, 39);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "CHECK";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Recipe :";
            // 
            // lblTotalCnt
            // 
            this.lblTotalCnt.AutoSize = true;
            this.lblTotalCnt.Location = new System.Drawing.Point(117, 31);
            this.lblTotalCnt.Name = "lblTotalCnt";
            this.lblTotalCnt.Size = new System.Drawing.Size(0, 15);
            this.lblTotalCnt.TabIndex = 3;
            // 
            // lvRecipelist
            // 
            this.lvRecipelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvColumnDevice,
            this.lvColumnPpid});
            this.lvRecipelist.HideSelection = false;
            this.lvRecipelist.Location = new System.Drawing.Point(12, 104);
            this.lvRecipelist.Name = "lvRecipelist";
            this.lvRecipelist.ShowGroups = false;
            this.lvRecipelist.Size = new System.Drawing.Size(776, 292);
            this.lvRecipelist.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvRecipelist.TabIndex = 4;
            this.lvRecipelist.UseCompatibleStateImageBehavior = false;
            this.lvRecipelist.View = System.Windows.Forms.View.Details;
            // 
            // lvColumnDevice
            // 
            this.lvColumnDevice.Text = "Device";
            this.lvColumnDevice.Width = 232;
            // 
            // lvColumnPpid
            // 
            this.lvColumnPpid.Text = "PPID";
            this.lvColumnPpid.Width = 540;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.lvRecipelist);
            this.Controls.Add(this.lblTotalCnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCnt;
        private System.Windows.Forms.ListView lvRecipelist;
        private System.Windows.Forms.ColumnHeader lvColumnDevice;
        private System.Windows.Forms.ColumnHeader lvColumnPpid;
    }
}

