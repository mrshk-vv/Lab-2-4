
namespace UserControls.Controls
{
    partial class TabsContainer
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbCascadeDeleting = new System.Windows.Forms.CheckBox();
            this.studentsView1 = new UserControls.Controls.studentsView();
            this.roomsView1 = new UserControls.Controls.roomsView();
            this.resettlementsView1 = new UserControls.Controls.resettlementsView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.studentsView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(662, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomsView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(662, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resettlementsView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(662, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resettlements";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbCascadeDeleting
            // 
            this.cbCascadeDeleting.AutoSize = true;
            this.cbCascadeDeleting.Location = new System.Drawing.Point(3, 22);
            this.cbCascadeDeleting.Name = "cbCascadeDeleting";
            this.cbCascadeDeleting.Size = new System.Drawing.Size(206, 19);
            this.cbCascadeDeleting.TabIndex = 1;
            this.cbCascadeDeleting.Text = "Включить каскадное удаление";
            this.cbCascadeDeleting.UseVisualStyleBackColor = true;
            this.cbCascadeDeleting.Click += new System.EventHandler(this.cbCascadeDeleting_Click);
            // 
            // studentsView1
            // 
            this.studentsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsView1.Location = new System.Drawing.Point(-4, 0);
            this.studentsView1.Name = "studentsView1";
            this.studentsView1.Size = new System.Drawing.Size(666, 371);
            this.studentsView1.TabIndex = 0;
            // 
            // roomsView1
            // 
            this.roomsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomsView1.Location = new System.Drawing.Point(-4, 0);
            this.roomsView1.Name = "roomsView1";
            this.roomsView1.Size = new System.Drawing.Size(670, 368);
            this.roomsView1.TabIndex = 0;
            // 
            // resettlementsView1
            // 
            this.resettlementsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resettlementsView1.Location = new System.Drawing.Point(-4, 0);
            this.resettlementsView1.Name = "resettlementsView1";
            this.resettlementsView1.Size = new System.Drawing.Size(667, 367);
            this.resettlementsView1.TabIndex = 0;
            // 
            // TabsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCascadeDeleting);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabsContainer";
            this.Size = new System.Drawing.Size(673, 462);
            this.Load += new System.EventHandler(this.TabsContainer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private studentsView studentsView1;
        private System.Windows.Forms.TabPage tabPage2;
        private roomsView roomsView1;
        private System.Windows.Forms.TabPage tabPage3;
        private resettlementsView resettlementsView1;
        private System.Windows.Forms.CheckBox cbCascadeDeleting;
    }
}
