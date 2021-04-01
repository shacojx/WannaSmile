// Decompiled with JetBrains decompiler
// Type: explori.Form1
// Assembly: explori, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53B7CCDE-6B3E-4F99-BDEC-93401BE53DE5
// Assembly location: C:\Users\Admin\Desktop\WannaSmile\wannaSmile.exe

using explori.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace explori
{
  public class Form1 : Form
  {
    private int i;
    private int r = 1000;
    private int temp;
    private IContainer components;
    private Panel panel1;
    private PictureBox pictureBox1;
    private Panel panel3;
    private Panel panel2;
    private Button button1;
    private Label label1;
    private Label label2;
    private Panel panel4;
    private Button btnCheck;
    private Label label3;
    private TextBox textBox2;
    private TextBox textBox1;
    private TextBox tCheck;
    private ListBox listBox1;
    private Button bntKey;

    public Form1() => this.InitializeComponent();

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btnCheck_Click(object sender, EventArgs e)
    {
      if (this.tCheck.Text.Equals("20000228"))
      {
        Application.Exit();
      }
      else
      {
        int num = (int) MessageBox.Show("Bạn Nhập Sai Key Vui Lòng Nhập Lại !");
      }
    }

    private void btnCheck_MouseClick(object sender, MouseEventArgs e)
    {
    }

    private void bntKey_Click(object sender, EventArgs e)
    {
      ++this.i;
      this.temp = this.r - this.i;
      int num1 = (int) MessageBox.Show("Bạn Đã Nhấn vào " + (object) this.i + " lần \r Cố lên còn " + (object) this.temp + " lần nữa thôi !");
      if (this.i != 1000)
        return;
      int num2 = (int) MessageBox.Show("Key mở khóa dữ liệu của bạn là : 20000228 \rNhập vào khung key để mở khóa");
    }

    private void tCheck_TextChanged(object sender, EventArgs e)
    {
    }

    private void btnCheck_TextChanged(object sender, EventArgs e)
    {
    }

    private void button1_MouseClick(object sender, MouseEventArgs e)
    {
      int num = (int) MessageBox.Show("Mã Thẻ Sai Rồi \rGiữ Lấy mà Sài !");
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.panel1 = new Panel();
      this.panel4 = new Panel();
      this.tCheck = new TextBox();
      this.btnCheck = new Button();
      this.label3 = new Label();
      this.panel3 = new Panel();
      this.textBox2 = new TextBox();
      this.textBox1 = new TextBox();
      this.label2 = new Label();
      this.label1 = new Label();
      this.button1 = new Button();
      this.panel2 = new Panel();
      this.bntKey = new Button();
      this.listBox1 = new ListBox();
      this.pictureBox1 = new PictureBox();
      this.panel1.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      ((ISupportInitialize) this.pictureBox1).BeginInit();
      this.SuspendLayout();
      this.panel1.Controls.Add((Control) this.panel4);
      this.panel1.Controls.Add((Control) this.panel3);
      this.panel1.Controls.Add((Control) this.panel2);
      this.panel1.Controls.Add((Control) this.pictureBox1);
      this.panel1.Location = new Point(2, 1);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(495, 220);
      this.panel1.TabIndex = 0;
      this.panel4.Controls.Add((Control) this.tCheck);
      this.panel4.Controls.Add((Control) this.btnCheck);
      this.panel4.Controls.Add((Control) this.label3);
      this.panel4.Location = new Point(213, 181);
      this.panel4.Name = "panel4";
      this.panel4.Size = new Size(279, 39);
      this.panel4.TabIndex = 3;
      this.tCheck.Location = new Point(59, 15);
      this.tCheck.Name = "tCheck";
      this.tCheck.PasswordChar = '*';
      this.tCheck.Size = new Size(131, 20);
      this.tCheck.TabIndex = 2;
      this.tCheck.TextChanged += new EventHandler(this.tCheck_TextChanged);
      this.btnCheck.Location = new Point(201, 11);
      this.btnCheck.Name = "btnCheck";
      this.btnCheck.Size = new Size(75, 23);
      this.btnCheck.TabIndex = 0;
      this.btnCheck.Text = "Ok";
      this.btnCheck.UseVisualStyleBackColor = true;
      this.btnCheck.TextChanged += new EventHandler(this.btnCheck_TextChanged);
      this.btnCheck.Click += new EventHandler(this.btnCheck_Click);
      this.btnCheck.MouseClick += new MouseEventHandler(this.btnCheck_MouseClick);
      this.label3.AutoSize = true;
      this.label3.Location = new Point(19, 16);
      this.label3.Name = "label3";
      this.label3.Size = new Size(31, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Key :";
      this.panel3.Controls.Add((Control) this.textBox2);
      this.panel3.Controls.Add((Control) this.textBox1);
      this.panel3.Controls.Add((Control) this.label2);
      this.panel3.Controls.Add((Control) this.label1);
      this.panel3.Controls.Add((Control) this.button1);
      this.panel3.Location = new Point(213, 100);
      this.panel3.Name = "panel3";
      this.panel3.Size = new Size(279, 75);
      this.panel3.TabIndex = 2;
      this.textBox2.Location = new Point(59, 42);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new Size(140, 20);
      this.textBox2.TabIndex = 5;
      this.textBox1.Location = new Point(59, 13);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new Size(140, 20);
      this.textBox1.TabIndex = 4;
      this.label2.AutoSize = true;
      this.label2.Location = new Point(3, 49);
      this.label2.Name = "label2";
      this.label2.Size = new Size(47, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Số Seri :";
      this.label1.AutoSize = true;
      this.label1.Location = new Point(3, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(50, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Mã Thẻ :";
      this.button1.Location = new Point(201, 26);
      this.button1.Name = "button1";
      this.button1.Size = new Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Gửi thẻ";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.button1.MouseClick += new MouseEventHandler(this.button1_MouseClick);
      this.panel2.Controls.Add((Control) this.bntKey);
      this.panel2.Controls.Add((Control) this.listBox1);
      this.panel2.Location = new Point(213, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new Size(279, 94);
      this.panel2.TabIndex = 1;
      this.bntKey.Location = new Point(201, 71);
      this.bntKey.Name = "bntKey";
      this.bntKey.Size = new Size(75, 23);
      this.bntKey.TabIndex = 2;
      this.bntKey.Text = "Nhận Key";
      this.bntKey.UseVisualStyleBackColor = true;
      this.bntKey.Click += new EventHandler(this.bntKey_Click);
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Items.AddRange(new object[7]
      {
        (object) "Do hôm nay mình không đủ tiền mua chó husky",
        (object) "nên đành gắn con RansomWave này vào máy bạn",
        (object) "Lưu ý trước khi nhập key mở khóa dữ liệu đừng tắt ",
        (object) "máy nhé không thì không cứu được nữa đâu ;) ",
        (object) "Bạn vui lòng gửi cho mình 20k để lấy lại dữ liệu",
        (object) "hoặc nhấn 1000 lần vào nút Nhận Key để nhận key ",
        (object) "miễn phí nhé !"
      });
      this.listBox1.Location = new Point(0, 0);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new Size(276, 69);
      this.listBox1.TabIndex = 1;
      this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
      this.pictureBox1.BackgroundImage = (Image) Resources.FaviconLoli1;
      this.pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
      this.pictureBox1.Location = new Point(3, 3);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(204, 214);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.AutoValidate = AutoValidate.EnablePreventFocusChange;
      this.ClientSize = new Size(498, 220);
      this.ControlBox = false;
      this.Controls.Add((Control) this.panel1);
      this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.ImeMode = ImeMode.On;
      this.IsMdiContainer = true;
      this.Name = nameof (Form1);
      this.RightToLeft = RightToLeft.No;
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Wanna Smile V1.0";
      this.TopMost = true;
      this.TransparencyKey = Color.Black;
      this.panel1.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      ((ISupportInitialize) this.pictureBox1).EndInit();
      this.ResumeLayout(false);
    }
  }
}
