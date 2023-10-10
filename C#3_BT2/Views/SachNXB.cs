using C_3_BT2.DomainClass;
using C_3_BT2.Services;

namespace C_3_BT2
{
    public partial class SachNXB : Form
    {
        SachXBService _service = new();
        Guid? _idCellClick = null;
        List<Sach> _ListObj = new();

        public SachNXB()
        {
            InitializeComponent();
        }
        private void SachNXB_Load(object sender, EventArgs e)
        {

            LoadComBoBox();
        }
        private void LoadDgrid(string textSearch)
        {
            SachNXBGrid.Rows.Clear();
            SachNXBGrid.ColumnCount = 4;
            SachNXBGrid.Columns[0].Name = "STT";
            SachNXBGrid.Columns[1].Name = "Mã Sách";
            SachNXBGrid.Columns[2].Name = "Tên Sách";
            SachNXBGrid.Columns[3].Name = "Nhà xuất bản";

            _ListObj = _service.GetSach(textSearch);
            foreach (var item in _ListObj)
            {
                SachNXBGrid.Rows.Add((_ListObj.IndexOf(item) + 1), item.Ma, item.Ten, (item.IdNxb == null ? "Buôn lậu" : _service.Getnxbs().Where(x => x.Id == item.IdNxb).Select(x => x.Ten).First()));
            }

        }
        private void themBtn_Click(object sender, EventArgs e)
        {
            if (_service.CheckDuplic(maText.Text))
            {
                MessageBox.Show("Trùng mã. Mời nhập mã khác.");
            }
            else
            {
                var sachAdd = new Sach()
                {
                    Ma = maText.Text,
                    Ten = tenText.Text,
                    IdNxb = CheckNXB(CmbNXB.Text)
                };
                var resultAdd = _service.Add(sachAdd);
                if (resultAdd)
                {
                    MessageBox.Show("Add Succeeded.");
                    LoadDgrid(string.Empty);
                }
            }
        }
        private Guid? CheckNXB(string tenNXB)
        {
            var obj = _service.Getnxbs().FirstOrDefault(x => x.Ten == tenNXB);
            if (obj == null)
            {
                return null;
            }
            return obj.Id;
        }

        private void SuaBtn_Click(object sender, EventArgs e)
        {

            if (_idCellClick != null)
            {
                var str = _service.GetAll().FirstOrDefault(x => x.Id == _idCellClick);
                if (_service.Update((Guid)_idCellClick, str))
                {
                    str.Ma = maText.Text;
                    str.Ten = tenText.Text;
                    str.IdNxb = CheckNXB(CmbNXB.Text);
                    MessageBox.Show("Update Succeeded.");
                }
                else
                {
                    MessageBox.Show("Update Failed.");
                }
            }
            else
            {
                MessageBox.Show("Please Choose Data for Update.");
            }
        }

        private void hienThiBtn_Click(object sender, EventArgs e)
        {
            LoadDgrid(string.Empty);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            maText.Clear();
            tenText.Clear();
            statusCon.Checked = false;
            statusHet.Checked = false;
        }
        private void LoadComBoBox()
        {
            foreach (var nxb in _service.Getnxbs().ToList())
            {
                CmbNXB.Items.Add(nxb.Ten);
            }
        }

        private void SachNXBGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var objclick = _ListObj[index];
            _idCellClick = objclick.Id;
        }

        private void statusCon_CheckedChanged(object sender, EventArgs e)
        {
            if (statusCon.Checked)
            {
                statusHet.Checked = false;
            }
        }

        private void statusHet_CheckedChanged(object sender, EventArgs e)
        {
            if (statusHet.Checked)
            {
                statusCon.Checked = false;
            }
        }

        private void timKiemText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(timKiemText.Text))
            {
                LoadDgrid(timKiemText.Text);
            }
              
        }
    }
}