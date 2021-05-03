
namespace UserControls.Controls
{
    partial class roomsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(roomsView));
            this.dgvRooms = new Zuby.ADGV.AdvancedDataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostelNumberRoomComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorNumberRoomComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.capacityRoomComboBox = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.roomListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnRooms = new System.Windows.Forms.BindingNavigator(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRooms)).BeginInit();
            this.bnRooms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRooms
            // 
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoGenerateColumns = false;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.hostelNumberRoomComboBox,
            this.roomNumberDataGridViewTextBoxColumn,
            this.floorNumberRoomComboBox,
            this.capacityRoomComboBox});
            this.dgvRooms.DataSource = this.roomListBindingSource;
            this.dgvRooms.FilterAndSortEnabled = true;
            this.dgvRooms.Location = new System.Drawing.Point(0, 37);
            this.dgvRooms.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvRooms.RowHeadersWidth = 51;
            this.dgvRooms.Size = new System.Drawing.Size(720, 394);
            this.dgvRooms.TabIndex = 0;
            this.dgvRooms.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dgvRooms_SortStringChanged);
            this.dgvRooms.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvRooms_DataError);
            this.dgvRooms.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.roomsDGV_DefaultValuesNeeded);
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
            // hostelNumberRoomComboBox
            // 
            this.hostelNumberRoomComboBox.DataPropertyName = "HostelNumber";
            this.hostelNumberRoomComboBox.HeaderText = "Номер общежития";
            this.hostelNumberRoomComboBox.MinimumWidth = 22;
            this.hostelNumberRoomComboBox.Name = "hostelNumberRoomComboBox";
            this.hostelNumberRoomComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.hostelNumberRoomComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.hostelNumberRoomComboBox.Width = 125;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // floorNumberRoomComboBox
            // 
            this.floorNumberRoomComboBox.DataPropertyName = "FloorNumber";
            this.floorNumberRoomComboBox.HeaderText = "Номер этажа";
            this.floorNumberRoomComboBox.MinimumWidth = 22;
            this.floorNumberRoomComboBox.Name = "floorNumberRoomComboBox";
            this.floorNumberRoomComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.floorNumberRoomComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.floorNumberRoomComboBox.Width = 125;
            // 
            // capacityRoomComboBox
            // 
            this.capacityRoomComboBox.DataPropertyName = "Capacity";
            this.capacityRoomComboBox.HeaderText = "Вместимость";
            this.capacityRoomComboBox.MinimumWidth = 22;
            this.capacityRoomComboBox.Name = "capacityRoomComboBox";
            this.capacityRoomComboBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.capacityRoomComboBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.capacityRoomComboBox.Width = 125;
            // 
            // roomListBindingSource
            // 
            this.roomListBindingSource.DataSource = typeof(DomainModel.Storage.DomainModel.RoomList);
            // 
            // bnRooms
            // 
            this.bnRooms.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnRooms.BindingSource = this.roomListBindingSource;
            this.bnRooms.CountItem = this.bindingNavigatorCountItem;
            this.bnRooms.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnRooms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bnRooms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bnRooms.Location = new System.Drawing.Point(0, 0);
            this.bnRooms.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnRooms.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnRooms.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnRooms.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnRooms.Name = "bnRooms";
            this.bnRooms.PositionItem = this.bindingNavigatorPositionItem;
            this.bnRooms.Size = new System.Drawing.Size(720, 27);
            this.bnRooms.TabIndex = 1;
            this.bnRooms.Text = "bnRooms";
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
            // roomsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bnRooms);
            this.Controls.Add(this.dgvRooms);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "roomsView";
            this.Size = new System.Drawing.Size(720, 431);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnRooms)).EndInit();
            this.bnRooms.ResumeLayout(false);
            this.bnRooms.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Zuby.ADGV.AdvancedDataGridView dgvRooms;
        public System.Windows.Forms.BindingSource roomListBindingSource;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn hostelNumberRoomComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn floorNumberRoomComboBox;
        private System.Windows.Forms.DataGridViewComboBoxColumn capacityRoomComboBox;
        internal System.Windows.Forms.BindingNavigator bnRooms;
    }
}
