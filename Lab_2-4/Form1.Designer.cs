
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openJson = new System.Windows.Forms.ToolStripMenuItem();
            this.openXml = new System.Windows.Forms.ToolStripMenuItem();
            this.openBin = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveJson = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXml = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBin = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWord = new System.Windows.Forms.ToolStripMenuItem();
            this.saveExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
            this.saveFileWindow = new System.Windows.Forms.SaveFileDialog();
            this.tabsContainer = new UserControls.Controls.TabsContainer();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openJson,
            this.openXml,
            this.openBin});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // openJson
            // 
            this.openJson.Name = "openJson";
            this.openJson.Size = new System.Drawing.Size(127, 26);
            this.openJson.Text = "JSON";
            this.openJson.Click += new System.EventHandler(this.openJson_Click);
            // 
            // openXml
            // 
            this.openXml.Name = "openXml";
            this.openXml.Size = new System.Drawing.Size(127, 26);
            this.openXml.Text = "XML";
            this.openXml.Click += new System.EventHandler(this.openXml_Click);
            // 
            // openBin
            // 
            this.openBin.Name = "openBin";
            this.openBin.Size = new System.Drawing.Size(127, 26);
            this.openBin.Text = "BIN";
            this.openBin.Click += new System.EventHandler(this.openBin_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveJson,
            this.saveXml,
            this.saveBin,
            this.saveWord,
            this.saveExcel});
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // saveJson
            // 
            this.saveJson.Name = "saveJson";
            this.saveJson.Size = new System.Drawing.Size(224, 26);
            this.saveJson.Text = "JSON";
            this.saveJson.Click += new System.EventHandler(this.saveJson_Click);
            // 
            // saveXml
            // 
            this.saveXml.Name = "saveXml";
            this.saveXml.Size = new System.Drawing.Size(224, 26);
            this.saveXml.Text = "XML";
            this.saveXml.Click += new System.EventHandler(this.saveXml_Click);
            // 
            // saveBin
            // 
            this.saveBin.Name = "saveBin";
            this.saveBin.Size = new System.Drawing.Size(224, 26);
            this.saveBin.Text = "BIN";
            this.saveBin.Click += new System.EventHandler(this.saveBin_Click);
            // 
            // saveWord
            // 
            this.saveWord.Name = "saveWord";
            this.saveWord.Size = new System.Drawing.Size(224, 26);
            this.saveWord.Text = "WORD";
            this.saveWord.Click += new System.EventHandler(this.saveWord_Click);
            // 
            // saveExcel
            // 
            this.saveExcel.Name = "saveExcel";
            this.saveExcel.Size = new System.Drawing.Size(224, 26);
            this.saveExcel.Text = "EXCEL";
            this.saveExcel.Click += new System.EventHandler(this.saveExcel_Click);
            // 
            // openFileWindow
            // 
            this.openFileWindow.FileName = "openFileDialog1";
            // 
            // tabsContainer
            // 
            this.tabsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsContainer.Location = new System.Drawing.Point(13, 49);
            this.tabsContainer.Margin = new System.Windows.Forms.Padding(4);
            this.tabsContainer.Name = "tabsContainer";
            this.tabsContainer.Size = new System.Drawing.Size(824, 512);
            this.tabsContainer.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(850, 574);
            this.Controls.Add(this.tabsContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.TabsContainer tabsContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openJson;
        private System.Windows.Forms.ToolStripMenuItem openXml;
        private System.Windows.Forms.ToolStripMenuItem openBin;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveJson;
        private System.Windows.Forms.ToolStripMenuItem saveXml;
        private System.Windows.Forms.ToolStripMenuItem saveBin;
        private System.Windows.Forms.OpenFileDialog openFileWindow;
        private System.Windows.Forms.SaveFileDialog saveFileWindow;
        private System.Windows.Forms.ToolStripMenuItem saveWord;
        private System.Windows.Forms.ToolStripMenuItem saveExcel;
    }
}

