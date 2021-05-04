using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel;
using DomainModel.Models;
using UserControls.Extensions;
using static DomainModel.DataSeedingProvider;

namespace UserControls.Controls
{
    public partial class roomsView : UserControl
    {
        public roomsView()
        {
            InitializeComponent();
            dgvRooms.AllowUserToAddRows = false;
            dgvRooms.AllowUserToDeleteRows = false;

            hostelNumberRoomComboBox.BindToEnum<Hostel>();
            capacityRoomComboBox.BindToEnum<Capacity>();
            floorNumberRoomComboBox.BindToEnum<Floor>();
        }

        private void roomsDGV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                e.Row.Cells[4].Value = Capacity.Four.ToString();
                e.Row.Cells[3].Value = Floor.First.ToString();
                e.Row.Cells[2].Value = Hostel.First.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvRooms_DataError(object sender, DataGridViewDataErrorEventArgs e) { }

        private void dgvRooms_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            var m_dataGridBindingList = (IList<Room>)roomListBindingSource.List;
            try
            {
                if (string.IsNullOrEmpty(dgvRooms.SortString))
                    return;

                m_dataGridBindingList = m_dataGridBindingList.OrderBySortString(dgvRooms.SortString)
                                                             .ToList();

                dgvRooms.DataSource = m_dataGridBindingList;
                dgvRooms.Refresh();
            }
            catch { }
        }
    }
}

namespace UserControls.Controls
{
    public partial class roomsView
    {
        internal void UpdateBinding()
        {
            roomListBindingSource.ResetBindings(false);
        }

        internal void ClearData()
        {
            roomListBindingSource.Clear();
        }
    }
}

