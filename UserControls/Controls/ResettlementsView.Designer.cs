
namespace UserControls.Controls
{
    partial class resettlementsView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resettlementsView));
            this.dgvResettlements = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeBookNumberResettlementComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hostelNumberResettlementComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomResettlementComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chectOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resettlementListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResettlements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resettlementListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResettlements
            // 
            this.dgvResettlements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResettlements.AutoGenerateColumns = false;
            this.dgvResettlements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResettlements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.gradeBookNumberResettlementComboBox,
            this.hostelNumberResettlementComboBox,
            this.roomResettlementComboBox,
            this.checkInDateDataGridViewTextBoxColumn,
            this.chectOutDateDataGridViewTextBoxColumn});
            this.dgvResettlements.DataSource = this.resettlementListBindingSource;
            this.dgvResettlements.FilterAndSortEnabled = true;
            this.dgvResettlements.Location = new System.Drawing.Point(0, 37);
            this.dgvResettlements.Margin = new System.Windows.Forms.Padding(4);
            this.dgvResettlements.Name = "dgvResettlements";
            this.dgvResettlements.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvResettlements.RowHeadersWidth = 51;
            this.dgvResettlements.Size = new System.Drawing.Size(720, 394);
            this.dgvResettlements.TabIndex = 0;
            this.dgvResettlements.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvResettlements_SortStringChanged);
            this.dgvResettlements.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResettlements_CellValueChanged);
            this.dgvResettlements.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvResettlements_DataError);
            this.dgvResettlements.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvResettlements_DefaultValuesNeeded);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradeBookNumberResettlementComboBox
            // 
            this.gradeBookNumberResettlementComboBox.DataPropertyName = "GradeBookNumber";
            this.gradeBookNumberResettlementComboBox.DataSource = this.studentListBindingSource;
            this.gradeBookNumberResettlementComboBox.DisplayMember = "FullName";
            this.gradeBookNumberResettlementComboBox.HeaderText = "Студент";
            this.gradeBookNumberResettlementComboBox.MinimumWidth = 22;
            this.gradeBookNumberResettlementComboBox.Name = "gradeBookNumberResettlementComboBox";
            this.gradeBookNumberResettlementComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gradeBookNumberResettlementComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gradeBookNumberResettlementComboBox.ValueMember = "GradeBookNumber";
            this.gradeBookNumberResettlementComboBox.Width = 125;
            // 
            // studentListBindingSource
            // 
            this.studentListBindingSource.DataSource = typeof(DomainModel.Storage.DomainModel.StudentList);
            // 
            // hostelNumberResettlementComboBox
            // 
            this.hostelNumberResettlementComboBox.DataPropertyName = "HostelNumber";
            this.hostelNumberResettlementComboBox.HeaderText = "Номер общежития";
            this.hostelNumberResettlementComboBox.MinimumWidth = 22;
            this.hostelNumberResettlementComboBox.Name = "hostelNumberResettlementComboBox";
            this.hostelNumberResettlementComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hostelNumberResettlementComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hostelNumberResettlementComboBox.Width = 125;
            // 
            // roomResettlementComboBox
            // 
            this.roomResettlementComboBox.DataPropertyName = "RoomId";
            this.roomResettlementComboBox.DataSource = this.roomListBindingSource;
            this.roomResettlementComboBox.DisplayMember = "RoomNumber";
            this.roomResettlementComboBox.HeaderText = "Номер комнаты";
            this.roomResettlementComboBox.MinimumWidth = 22;
            this.roomResettlementComboBox.Name = "roomResettlementComboBox";
            this.roomResettlementComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomResettlementComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.roomResettlementComboBox.ValueMember = "Id";
            this.roomResettlementComboBox.Width = 125;
            // 
            // roomListBindingSource
            // 
            this.roomListBindingSource.DataSource = typeof(DomainModel.Storage.DomainModel.RoomList);
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "Дата вселения";
            this.checkInDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.checkInDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // chectOutDateDataGridViewTextBoxColumn
            // 
            this.chectOutDateDataGridViewTextBoxColumn.DataPropertyName = "ChectOutDate";
            this.chectOutDateDataGridViewTextBoxColumn.HeaderText = "Дата выселения";
            this.chectOutDateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.chectOutDateDataGridViewTextBoxColumn.Name = "chectOutDateDataGridViewTextBoxColumn";
            this.chectOutDateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.chectOutDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // resettlementListBindingSource
            // 
            this.resettlementListBindingSource.DataSource = typeof(DomainModel.Storage.DomainModel.ResettlementList);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.resettlementListBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(720, 27);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bnResettlements";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // resettlementsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dgvResettlements);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "resettlementsView";
            this.Size = new System.Drawing.Size(720, 431);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResettlements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resettlementListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvResettlements;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public System.Windows.Forms.BindingSource resettlementListBindingSource;
        internal System.Windows.Forms.BindingSource studentListBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn gradeBookNumberResettlementComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn hostelNumberResettlementComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn roomResettlementComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chectOutDateDataGridViewTextBoxColumn;
        internal System.Windows.Forms.BindingSource roomListBindingSource;
    }
}
