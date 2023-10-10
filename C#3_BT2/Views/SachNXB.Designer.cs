namespace C_3_BT2
{
    partial class SachNXB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tenText = new TextBox();
            maText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            statusCon = new CheckBox();
            statusHet = new CheckBox();
            CmbNXB = new ComboBox();
            themBtn = new Button();
            SuaBtn = new Button();
            hienThiBtn = new Button();
            clearBtn = new Button();
            label5 = new Label();
            timKiemText = new TextBox();
            SachNXBGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)SachNXBGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên";
            // 
            // tenText
            // 
            tenText.Location = new Point(133, 17);
            tenText.Name = "tenText";
            tenText.Size = new Size(383, 27);
            tenText.TabIndex = 1;
            // 
            // maText
            // 
            maText.Location = new Point(133, 65);
            maText.Name = "maText";
            maText.Size = new Size(383, 27);
            maText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 68);
            label2.Name = "label2";
            label2.Size = new Size(30, 20);
            label2.TabIndex = 2;
            label2.Text = "Mã";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 117);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Trạng thái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 158);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 5;
            label4.Text = "Nhà xuất bản";
            // 
            // statusCon
            // 
            statusCon.AutoSize = true;
            statusCon.Location = new Point(193, 117);
            statusCon.Name = "statusCon";
            statusCon.Size = new Size(98, 24);
            statusCon.TabIndex = 6;
            statusCon.Text = "Còn hàng ";
            statusCon.UseVisualStyleBackColor = true;
            statusCon.CheckedChanged += statusCon_CheckedChanged;
            // 
            // statusHet
            // 
            statusHet.AutoSize = true;
            statusHet.Location = new Point(350, 117);
            statusHet.Name = "statusHet";
            statusHet.Size = new Size(92, 24);
            statusHet.TabIndex = 7;
            statusHet.Text = "Hết hàng";
            statusHet.UseVisualStyleBackColor = true;
            statusHet.CheckedChanged += statusHet_CheckedChanged;
            // 
            // CmbNXB
            // 
            CmbNXB.FormattingEnabled = true;
            CmbNXB.Location = new Point(165, 155);
            CmbNXB.Name = "CmbNXB";
            CmbNXB.Size = new Size(351, 28);
            CmbNXB.TabIndex = 8;
            CmbNXB.Text = "...";
            // 
            // themBtn
            // 
            themBtn.Location = new Point(545, 3);
            themBtn.Name = "themBtn";
            themBtn.Size = new Size(243, 46);
            themBtn.TabIndex = 9;
            themBtn.Text = "Thêm";
            themBtn.UseVisualStyleBackColor = true;
            themBtn.Click += themBtn_Click;
            // 
            // SuaBtn
            // 
            SuaBtn.Location = new Point(545, 55);
            SuaBtn.Name = "SuaBtn";
            SuaBtn.Size = new Size(243, 46);
            SuaBtn.TabIndex = 10;
            SuaBtn.Text = "Sửa";
            SuaBtn.UseVisualStyleBackColor = true;
            SuaBtn.Click += SuaBtn_Click;
            // 
            // hienThiBtn
            // 
            hienThiBtn.Location = new Point(545, 107);
            hienThiBtn.Name = "hienThiBtn";
            hienThiBtn.Size = new Size(243, 46);
            hienThiBtn.TabIndex = 11;
            hienThiBtn.Text = "Hiển thị";
            hienThiBtn.UseVisualStyleBackColor = true;
            hienThiBtn.Click += hienThiBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(545, 159);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(243, 46);
            clearBtn.TabIndex = 12;
            clearBtn.Text = "Xóa form";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 219);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 13;
            label5.Text = "Tìm kiếm";
            // 
            // timKiemText
            // 
            timKiemText.Location = new Point(101, 216);
            timKiemText.Name = "timKiemText";
            timKiemText.PlaceholderText = "Nhập tên để tìm kiếm ";
            timKiemText.Size = new Size(687, 27);
            timKiemText.TabIndex = 14;
            timKiemText.TextChanged += timKiemText_TextChanged;
            // 
            // SachNXBGrid
            // 
            SachNXBGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SachNXBGrid.Location = new Point(1, 249);
            SachNXBGrid.Name = "SachNXBGrid";
            SachNXBGrid.RowHeadersWidth = 51;
            SachNXBGrid.RowTemplate.Height = 29;
            SachNXBGrid.Size = new Size(797, 247);
            SachNXBGrid.TabIndex = 15;
            SachNXBGrid.CellClick += SachNXBGrid_CellClick;
            // 
            // SachNXB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(SachNXBGrid);
            Controls.Add(timKiemText);
            Controls.Add(label5);
            Controls.Add(clearBtn);
            Controls.Add(hienThiBtn);
            Controls.Add(SuaBtn);
            Controls.Add(themBtn);
            Controls.Add(CmbNXB);
            Controls.Add(statusHet);
            Controls.Add(statusCon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(maText);
            Controls.Add(label2);
            Controls.Add(tenText);
            Controls.Add(label1);
            Name = "SachNXB";
            Text = "Form1";
            Load += SachNXB_Load;
            ((System.ComponentModel.ISupportInitialize)SachNXBGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tenText;
        private TextBox maText;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox statusCon;
        private CheckBox statusHet;
        private ComboBox CmbNXB;
        private Button themBtn;
        private Button SuaBtn;
        private Button hienThiBtn;
        private Button clearBtn;
        private Label label5;
        private TextBox timKiemText;
        private DataGridView SachNXBGrid;
    }
}