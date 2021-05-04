
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
            this.studentsView1 = new UserControls.Controls.studentsView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.roomsView1 = new UserControls.Controls.roomsView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.resettlementsView1 = new UserControls.Controls.resettlementsView();
            this.cbCascadeDeleting = new System.Windows.Forms.CheckBox();
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
            this.tabControl1.Location = new System.Drawing.Point(4, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 603);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.studentsView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1001, 574);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Students";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // studentsView1
            // 
            this.studentsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.studentsView1.Location = new System.Drawing.Point(0, 1);
            this.studentsView1.Margin = new System.Windows.Forms.Padding(5);
            this.studentsView1.Name = "studentsView1";
            this.studentsView1.Size = new System.Drawing.Size(1001, 577);
            this.studentsView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.roomsView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1001, 574);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // roomsView1
            // 
            this.roomsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomsView1.Location = new System.Drawing.Point(-5, 0);
            this.roomsView1.Margin = new System.Windows.Forms.Padding(5);
            this.roomsView1.Name = "roomsView1";
            this.roomsView1.Size = new System.Drawing.Size(1006, 574);
            this.roomsView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.resettlementsView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1001, 574);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Resettlements";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // resettlementsView1
            // 
            this.resettlementsView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resettlementsView1.Location = new System.Drawing.Point(-5, 0);
            this.resettlementsView1.Margin = new System.Windows.Forms.Padding(5);
            this.resettlementsView1.Name = "resettlementsView1";
            this.resettlementsView1.Size = new System.Drawing.Size(1006, 578);
            this.resettlementsView1.TabIndex = 0;
            // 
            // cbCascadeDeleting
            // 
            this.cbCascadeDeleting.AutoSize = true;
            this.cbCascadeDeleting.Location = new System.Drawing.Point(4, 4);
            this.cbCascadeDeleting.Margin = new System.Windows.Forms.Padding(4);
            this.cbCascadeDeleting.Name = "cbCascadeDeleting";
            this.cbCascadeDeleting.Size = new System.Drawing.Size(234, 21);
            this.cbCascadeDeleting.TabIndex = 1;
            this.cbCascadeDeleting.Text = "Включить каскадное удаление";
            this.cbCascadeDeleting.UseVisualStyleBackColor = true;
            this.cbCascadeDeleting.Click += new System.EventHandler(this.cbCascadeDeleting_Click);
            // 
            // TabsContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbCascadeDeleting);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TabsContainer";
            this.Size = new System.Drawing.Size(1017, 636);
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
