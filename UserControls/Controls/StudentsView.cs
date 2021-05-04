using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DomainModel.Models;
using UserControls.Extensions;

namespace UserControls.Controls
{
    public partial class studentsView : UserControl
    {
        public studentsView()
        {
            InitializeComponent();
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
        }

        private void dgvStudents_SortStringChanged(object sender, Zuby.ADGV.AdvancedDataGridView.SortEventArgs e)
        {
            var m_dataGridBindingList = (IList<Student>)studentListBindingSource.List;

            try
            {
                if (string.IsNullOrEmpty(dgvStudents.SortString))
                    return;

                m_dataGridBindingList = m_dataGridBindingList.OrderBySortString(dgvStudents.SortString)
                                                             .ToList();

                dgvStudents.DataSource = m_dataGridBindingList;
                dgvStudents.Refresh();
            }
            catch { }
        }
    }
}

namespace UserControls.Controls
{
    public partial class studentsView
    {
        internal void UpdateBinding()
        {
            studentListBindingSource.ResetBindings(false);
        }

        internal void ClearData()
        {
            studentListBindingSource.Clear();
        }
    }
}
