using DomainModel.Storage;
using System;
using System.Windows.Forms;

namespace Lab_2_4
{
    public partial class Form1 : Form
    {
        readonly Storage data = Storage.Instance;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileWindow.FileName = string.Empty;
            saveFileWindow.FileName = string.Empty;
            tabsContainer.Bind = data;
        }

        private void OnOpen()
        {
            var res = openFileWindow.ShowDialog();
            if (res == DialogResult.OK)
            {
                var result = Storage.Instance.Load(openFileWindow.FileName);
                if (result)
                    tabsContainer.UpdateData();
            }
        }

        private void OnSave(Storage.Format format)
        {
            var res = saveFileWindow.ShowDialog();
            if (res == DialogResult.OK)
                Storage.Instance.Save(saveFileWindow.FileName, format);
        }

        #region Open

        private void openJson_Click(object sender, EventArgs e)
        {
            openFileWindow.Filter = "JSON (*.json)|*.json|All files (*.*)|*.*";
            OnOpen();

        }

        private void openXml_Click(object sender, EventArgs e)
        {
            openFileWindow.Filter = "XML (*.xml)|*.xml|All files (*.*)|*.*";
            OnOpen();
        }

        private void openBin_Click(object sender, EventArgs e)
        {
            openFileWindow.Filter = "BIN (*.bin)|*.bin|All files (*.*)|*.*";
            OnOpen();
        }

        #endregion


        #region Save

        private void saveJson_Click(object sender, EventArgs e)
        {
            OnSave(Storage.Format.json);
        }

        private void saveXml_Click(object sender, EventArgs e)
        {
            OnSave(Storage.Format.xml);
        }

        private void saveBin_Click(object sender, EventArgs e)
        {
            OnSave(Storage.Format.bin);
        }

        private void saveWord_Click(object sender, EventArgs e)
        {
            OnSave(Storage.Format.docx);
        }

        private void saveExcel_Click(object sender, EventArgs e)
        {
            OnSave(Storage.Format.xlsx);
        }

        #endregion
    }
}
