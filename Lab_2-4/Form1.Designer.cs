
namespace Lab_2_4
{
    partial class Form1
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
            this.tabsContainer = new UserControls.Controls.TabsContainer();
            this.SuspendLayout();
            // 
            // tabsContainer
            // 
            this.tabsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsContainer.Location = new System.Drawing.Point(13, 13);
            this.tabsContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabsContainer.Name = "tabsContainer";
            this.tabsContainer.Size = new System.Drawing.Size(824, 548);
            this.tabsContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(850, 574);
            this.Controls.Add(this.tabsContainer);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.Controls.TabsContainer tabsContainer;
    }
}

