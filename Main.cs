using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltronPOSCR
{
    public partial class Main : Form
    {
        private long total, rate, discount = 0;
        private int sizeY, qty, sequence, totalUnites = 0;
        DataTable _currentBillTable = new DataTable();
        private void SizeY_ValueChanged(object sender, EventArgs e)
        {
            sizeY = (int)SizeY.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }

        private void RateTxt_ValueChanged(object sender, EventArgs e)
        {
            rate = (int)RateTxt.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }

        private void DiscTxt_ValueChanged(object sender, EventArgs e)
        {
            discount = (int)DiscTxt.Value;
            totalUnites = (int)QtyNum.Value * (int)SizeY.Value;
            TotalUnits.Text = (totalUnites).ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();
        }


        private long Calculate(int _qty, int _sizeY, long _rate, long _discount)
        {
            long ttl = _qty * _sizeY * _rate;
            long discount_ = _qty * _sizeY * _discount;
            ttl = ttl - discount_;
            return ttl;
        }

        private void UnitTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UnitTxt.SelectedIndex == 0)
            {
                RatePerLbl.Text = "ریٹ فی میٹر";
            }
            else RatePerLbl.Text = "ریٹ فی گز";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            sequence++;
            DataRow _item = _currentBillTable.NewRow();
            _item[0] = sequence;
            _item[1] = qty;
            _item[2] = String.Format("{4} {3} = {2} x {1} - {0}",
                DescriptionTxtOpt.Text, QtyNum.Value, SizeY.Value, totalUnites, UnitTxt.Text);
            _item[3] = totalUnites;
            _item[4] = RateTxt.Value;
            _item[5] = DiscTxt.Value;
            _item[6] = total;
            if (total != 0)
            {
                _currentBillTable.Rows.Add(_item);
                dataGridViewMain.DataSource = _currentBillTable;
                dataGridViewMain.Columns["تفصیل"].Width = 250;
                Clear();
            }
            else
            {
                MessageBox.Show("values can't be zero!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeteleRowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMain.Rows.Count > 0)
                    //int selecteRow = dataGridViewMain.SelectedRows[0].Index;
                    dataGridViewMain.Rows.Remove(dataGridViewMain.SelectedRows[0]);
                else { }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNewBill_Click(object sender, EventArgs e)
        {
            sequence = 0;
            _currentBillTable.Rows.Clear();

        }

        public Main()
        {
            InitializeComponent();
        }
        private void Clear()
        {
            total = rate = discount = sizeY = qty = sequence = totalUnites = 0;
            DiscTxt.Value = 0;
            QtyNum.Value = 0;
            RateTxt.Value = 0;
            DescriptionTxtOpt.Text = "";
            SizeY.Value = 0;
            SizeX.Text = "";
            TotalUnits.Text = "";
            TotalTxt.Text = "";



        }
        private void Main_Load(object sender, EventArgs e)
        {
            UnitTxt.SelectedIndex = 0;
            UnitTxt.Focus();
            _currentBillTable.Columns.Clear();
            _currentBillTable.Rows.Clear();
            //** adding Columns
            _currentBillTable.Columns.Add("#", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("تعداد", Type.GetType("System.Int32"));
            //_currentBillTable.Columns.Add("یونٹ", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("تفصیل", Type.GetType("System.String"));
            _currentBillTable.Columns.Add("صافی", Type.GetType("System.Int32"));
            _currentBillTable.Columns.Add("ریٹ", Type.GetType("System.Decimal"));
            _currentBillTable.Columns.Add("ڈسکاؤنٹ", Type.GetType("System.Decimal"));
            _currentBillTable.Columns.Add("ٹوٹل", Type.GetType("System.Decimal"));
            dataGridViewMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMain.MultiSelect = false;
            dataGridViewMain.AllowUserToAddRows = false;
        }

        private void QtyNum_ValueChanged(object sender, EventArgs e)
        {
            qty = (int)QtyNum.Value;

            TotalUnits.Text = (QtyNum.Value * SizeY.Value).ToString();
            SizeX.Text = QtyNum.Value.ToString();
            total = Calculate(qty, sizeY, rate, discount);
            TotalTxt.Text = (total).ToString();

        }
    }
}
