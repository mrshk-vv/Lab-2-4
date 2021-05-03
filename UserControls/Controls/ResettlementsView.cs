using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainModel.Models;
using DomainModel.Storage;
using UserControls.Extensions;

namespace UserControls.Controls
{
    public partial class resettlementsView : UserControl
    {
        public resettlementsView()
        {
            InitializeComponent();
            dgvResettlements.AllowUserToAddRows = false;
            dgvResettlements.AllowUserToDeleteRows = false;
            ;
            hostelNumberResettlementComboBox.BindToEnum<Hostel>();
        }

        private void ressettlementDGV_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                var currentDate = DateTime.Now;
                e.Row.Cells["CheckInDate"].Value = currentDate.AddYears(1).ToString();
                e.Row.Cells["CheckOutDate"].Value = currentDate.ToString();
            }
            catch (Exception ex)
            {
                ex.GetType();
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvResettlements_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            var m_dataGridBindingList = (IList<Resettlement>)resettlementListBindingSource.List;

            try
            {
                if (string.IsNullOrEmpty(dgvResettlements.SortString))
                    return;

                m_dataGridBindingList = m_dataGridBindingList.OrderBySortString(dgvResettlements.SortString)
                                                             .ToList();

                dgvResettlements.DataSource = m_dataGridBindingList;
                dgvResettlements.Refresh();
            }
            catch { }
        }

        private void dgvResettlements_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dgvResettlements.Rows?[e.RowIndex].Cells?[2];
            //    if (cb.Value != null)
            //    {
            //        if (cb.Value is Hostel)
            //        {
            //            roomsSetBindingSource.Clear();
            //            Storage.Instance.db.Rooms.Where(x => x.HostelNumber == (Hostel)cb.Value)
            //                                     .Select(r => new RoomItem { Id = r.Id, RoomNumber = r.RoomNumber })
            //                                     .ToList()
            //                                     .ForEach(x => roomsSetBindingSource.Add(x));
            //        }
            //    }
            //}
        }

        private void dgvResettlements_DataError(object sender, DataGridViewDataErrorEventArgs e){ }

        private void dgvResettlements_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            try
            {

                var currentDate = DateTime.Now;
                e.Row.Cells["CheckInDate"].Value = currentDate.AddYears(1).ToString();
                e.Row.Cells["CheckOutDate"].Value = currentDate.ToString();
            }
            catch (Exception ex)
            {
                ex.GetType();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
