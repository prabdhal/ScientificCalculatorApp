
namespace CalculatorApp
{
  partial class calculatorForm
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.MainColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.equalBtn = new System.Windows.Forms.Button();
      this.exponentBtn = new System.Windows.Forms.Button();
      this.ansBtn = new System.Windows.Forms.Button();
      this.subtractionBtn = new System.Windows.Forms.Button();
      this.threeBtn = new System.Windows.Forms.Button();
      this.twoBtn = new System.Windows.Forms.Button();
      this.oneBtn = new System.Windows.Forms.Button();
      this.squareRootBtn = new System.Windows.Forms.Button();
      this.tanBtn = new System.Windows.Forms.Button();
      this.eBtn = new System.Windows.Forms.Button();
      this.multiplicationBtn = new System.Windows.Forms.Button();
      this.sixBtn = new System.Windows.Forms.Button();
      this.fiveBtn = new System.Windows.Forms.Button();
      this.fourBtn = new System.Windows.Forms.Button();
      this.logBtn = new System.Windows.Forms.Button();
      this.cosBtn = new System.Windows.Forms.Button();
      this.piBtn = new System.Windows.Forms.Button();
      this.divisionBtn = new System.Windows.Forms.Button();
      this.nineBtn = new System.Windows.Forms.Button();
      this.eightBtn = new System.Windows.Forms.Button();
      this.sevenBtn = new System.Windows.Forms.Button();
      this.lnBtn = new System.Windows.Forms.Button();
      this.sinBtn = new System.Windows.Forms.Button();
      this.shiftBtn = new System.Windows.Forms.Button();
      this.clearBtn = new System.Windows.Forms.Button();
      this.backspaceBtn = new System.Windows.Forms.Button();
      this.rightBracketBtn = new System.Windows.Forms.Button();
      this.leftBracketBtn = new System.Windows.Forms.Button();
      this.factorialBtn = new System.Windows.Forms.Button();
      this.radDegBtn = new System.Windows.Forms.Button();
      this.expBtn = new System.Windows.Forms.Button();
      this.percentBtn = new System.Windows.Forms.Button();
      this.additionBtn = new System.Windows.Forms.Button();
      this.periodBtn = new System.Windows.Forms.Button();
      this.zeroBtn = new System.Windows.Forms.Button();
      this.outputTextBox = new System.Windows.Forms.RichTextBox();
      this.inputTextBox = new System.Windows.Forms.RichTextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainColumn
      // 
      this.MainColumn.HeaderText = "Column1";
      this.MainColumn.Name = "MainColumn";
      // 
      // dataGridView1
      // 
      this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MainColumn});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.Location = new System.Drawing.Point(5, 5);
      this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 25;
      this.dataGridView1.Size = new System.Drawing.Size(492, 542);
      this.dataGridView1.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.outputTextBox, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.inputTextBox, 0, 1);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 544);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tableLayoutPanel2.ColumnCount = 7;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
      this.tableLayoutPanel2.Controls.Add(this.equalBtn, 5, 4);
      this.tableLayoutPanel2.Controls.Add(this.exponentBtn, 2, 4);
      this.tableLayoutPanel2.Controls.Add(this.ansBtn, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.subtractionBtn, 6, 3);
      this.tableLayoutPanel2.Controls.Add(this.threeBtn, 5, 3);
      this.tableLayoutPanel2.Controls.Add(this.twoBtn, 4, 3);
      this.tableLayoutPanel2.Controls.Add(this.oneBtn, 3, 3);
      this.tableLayoutPanel2.Controls.Add(this.squareRootBtn, 2, 3);
      this.tableLayoutPanel2.Controls.Add(this.tanBtn, 1, 3);
      this.tableLayoutPanel2.Controls.Add(this.eBtn, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.multiplicationBtn, 6, 2);
      this.tableLayoutPanel2.Controls.Add(this.sixBtn, 5, 2);
      this.tableLayoutPanel2.Controls.Add(this.fiveBtn, 4, 2);
      this.tableLayoutPanel2.Controls.Add(this.fourBtn, 3, 2);
      this.tableLayoutPanel2.Controls.Add(this.logBtn, 2, 2);
      this.tableLayoutPanel2.Controls.Add(this.cosBtn, 1, 2);
      this.tableLayoutPanel2.Controls.Add(this.piBtn, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.divisionBtn, 6, 1);
      this.tableLayoutPanel2.Controls.Add(this.nineBtn, 5, 1);
      this.tableLayoutPanel2.Controls.Add(this.eightBtn, 4, 1);
      this.tableLayoutPanel2.Controls.Add(this.sevenBtn, 3, 1);
      this.tableLayoutPanel2.Controls.Add(this.lnBtn, 2, 1);
      this.tableLayoutPanel2.Controls.Add(this.sinBtn, 1, 1);
      this.tableLayoutPanel2.Controls.Add(this.shiftBtn, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.clearBtn, 6, 0);
      this.tableLayoutPanel2.Controls.Add(this.backspaceBtn, 5, 0);
      this.tableLayoutPanel2.Controls.Add(this.rightBracketBtn, 4, 0);
      this.tableLayoutPanel2.Controls.Add(this.leftBracketBtn, 3, 0);
      this.tableLayoutPanel2.Controls.Add(this.factorialBtn, 2, 0);
      this.tableLayoutPanel2.Controls.Add(this.radDegBtn, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.expBtn, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.percentBtn, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.additionBtn, 6, 4);
      this.tableLayoutPanel2.Controls.Add(this.periodBtn, 3, 4);
      this.tableLayoutPanel2.Controls.Add(this.zeroBtn, 4, 4);
      this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 165);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 5;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 376);
      this.tableLayoutPanel2.TabIndex = 0;
      // 
      // equalBtn
      // 
      this.equalBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.equalBtn.BackColor = System.Drawing.Color.DarkOrange;
      this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.equalBtn.Location = new System.Drawing.Point(347, 303);
      this.equalBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.equalBtn.Name = "equalBtn";
      this.equalBtn.Size = new System.Drawing.Size(65, 70);
      this.equalBtn.TabIndex = 33;
      this.equalBtn.Text = "=";
      this.equalBtn.UseVisualStyleBackColor = false;
      this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
      // 
      // exponentBtn
      // 
      this.exponentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.exponentBtn.BackColor = System.Drawing.Color.Gray;
      this.exponentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.exponentBtn.Location = new System.Drawing.Point(140, 303);
      this.exponentBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.exponentBtn.Name = "exponentBtn";
      this.exponentBtn.Size = new System.Drawing.Size(65, 70);
      this.exponentBtn.TabIndex = 30;
      this.exponentBtn.Text = "xʸ";
      this.exponentBtn.UseVisualStyleBackColor = false;
      this.exponentBtn.Click += new System.EventHandler(this.exponentBtn_Click);
      // 
      // ansBtn
      // 
      this.ansBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ansBtn.BackColor = System.Drawing.Color.Gray;
      this.ansBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.ansBtn.Location = new System.Drawing.Point(2, 303);
      this.ansBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.ansBtn.Name = "ansBtn";
      this.ansBtn.Size = new System.Drawing.Size(65, 70);
      this.ansBtn.TabIndex = 28;
      this.ansBtn.Text = "ans";
      this.ansBtn.UseVisualStyleBackColor = false;
      this.ansBtn.Click += new System.EventHandler(this.ansBtn_Click);
      // 
      // subtractionBtn
      // 
      this.subtractionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.subtractionBtn.BackColor = System.Drawing.Color.DarkOrange;
      this.subtractionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.subtractionBtn.Location = new System.Drawing.Point(416, 228);
      this.subtractionBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.subtractionBtn.Name = "subtractionBtn";
      this.subtractionBtn.Size = new System.Drawing.Size(70, 69);
      this.subtractionBtn.TabIndex = 27;
      this.subtractionBtn.Text = "-";
      this.subtractionBtn.UseVisualStyleBackColor = false;
      this.subtractionBtn.Click += new System.EventHandler(this.subtractionBtn_Click);
      // 
      // threeBtn
      // 
      this.threeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.threeBtn.BackColor = System.Drawing.Color.Silver;
      this.threeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.threeBtn.Location = new System.Drawing.Point(347, 228);
      this.threeBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.threeBtn.Name = "threeBtn";
      this.threeBtn.Size = new System.Drawing.Size(65, 69);
      this.threeBtn.TabIndex = 26;
      this.threeBtn.Text = "3";
      this.threeBtn.UseVisualStyleBackColor = false;
      this.threeBtn.Click += new System.EventHandler(this.threeBtn_Click);
      // 
      // twoBtn
      // 
      this.twoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.twoBtn.BackColor = System.Drawing.Color.Silver;
      this.twoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.twoBtn.Location = new System.Drawing.Point(278, 228);
      this.twoBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.twoBtn.Name = "twoBtn";
      this.twoBtn.Size = new System.Drawing.Size(65, 69);
      this.twoBtn.TabIndex = 25;
      this.twoBtn.Text = "2";
      this.twoBtn.UseVisualStyleBackColor = false;
      this.twoBtn.Click += new System.EventHandler(this.twoBtn_Click);
      // 
      // oneBtn
      // 
      this.oneBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.oneBtn.BackColor = System.Drawing.Color.Silver;
      this.oneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.oneBtn.Location = new System.Drawing.Point(209, 228);
      this.oneBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.oneBtn.Name = "oneBtn";
      this.oneBtn.Size = new System.Drawing.Size(65, 69);
      this.oneBtn.TabIndex = 24;
      this.oneBtn.Text = "1";
      this.oneBtn.UseVisualStyleBackColor = false;
      this.oneBtn.Click += new System.EventHandler(this.oneBtn_Click);
      // 
      // squareRootBtn
      // 
      this.squareRootBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.squareRootBtn.BackColor = System.Drawing.Color.Gray;
      this.squareRootBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.squareRootBtn.Location = new System.Drawing.Point(140, 228);
      this.squareRootBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.squareRootBtn.Name = "squareRootBtn";
      this.squareRootBtn.Size = new System.Drawing.Size(65, 69);
      this.squareRootBtn.TabIndex = 23;
      this.squareRootBtn.Text = "√";
      this.squareRootBtn.UseVisualStyleBackColor = false;
      this.squareRootBtn.Click += new System.EventHandler(this.squareRootBtn_Click);
      // 
      // tanBtn
      // 
      this.tanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tanBtn.BackColor = System.Drawing.Color.Gray;
      this.tanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.tanBtn.Location = new System.Drawing.Point(71, 228);
      this.tanBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.tanBtn.Name = "tanBtn";
      this.tanBtn.Size = new System.Drawing.Size(65, 69);
      this.tanBtn.TabIndex = 22;
      this.tanBtn.Text = "tan";
      this.tanBtn.UseVisualStyleBackColor = false;
      this.tanBtn.Click += new System.EventHandler(this.tanBtn_Click);
      // 
      // eBtn
      // 
      this.eBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.eBtn.BackColor = System.Drawing.Color.Gray;
      this.eBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.eBtn.Location = new System.Drawing.Point(2, 228);
      this.eBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.eBtn.Name = "eBtn";
      this.eBtn.Size = new System.Drawing.Size(65, 69);
      this.eBtn.TabIndex = 21;
      this.eBtn.Text = "e";
      this.eBtn.UseVisualStyleBackColor = false;
      this.eBtn.Click += new System.EventHandler(this.eBtn_Click);
      // 
      // multiplicationBtn
      // 
      this.multiplicationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.multiplicationBtn.BackColor = System.Drawing.Color.DarkOrange;
      this.multiplicationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.multiplicationBtn.Location = new System.Drawing.Point(416, 153);
      this.multiplicationBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.multiplicationBtn.Name = "multiplicationBtn";
      this.multiplicationBtn.Size = new System.Drawing.Size(70, 69);
      this.multiplicationBtn.TabIndex = 20;
      this.multiplicationBtn.Text = "×";
      this.multiplicationBtn.UseVisualStyleBackColor = false;
      this.multiplicationBtn.Click += new System.EventHandler(this.multiplicationBtn_Click);
      // 
      // sixBtn
      // 
      this.sixBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sixBtn.BackColor = System.Drawing.Color.Silver;
      this.sixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.sixBtn.Location = new System.Drawing.Point(347, 153);
      this.sixBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.sixBtn.Name = "sixBtn";
      this.sixBtn.Size = new System.Drawing.Size(65, 69);
      this.sixBtn.TabIndex = 19;
      this.sixBtn.Text = "6";
      this.sixBtn.UseVisualStyleBackColor = false;
      this.sixBtn.Click += new System.EventHandler(this.sixBtn_Click);
      // 
      // fiveBtn
      // 
      this.fiveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fiveBtn.BackColor = System.Drawing.Color.Silver;
      this.fiveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.fiveBtn.Location = new System.Drawing.Point(278, 153);
      this.fiveBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.fiveBtn.Name = "fiveBtn";
      this.fiveBtn.Size = new System.Drawing.Size(65, 69);
      this.fiveBtn.TabIndex = 18;
      this.fiveBtn.Text = "5";
      this.fiveBtn.UseVisualStyleBackColor = false;
      this.fiveBtn.Click += new System.EventHandler(this.fiveBtn_Click);
      // 
      // fourBtn
      // 
      this.fourBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fourBtn.BackColor = System.Drawing.Color.Silver;
      this.fourBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.fourBtn.Location = new System.Drawing.Point(209, 153);
      this.fourBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.fourBtn.Name = "fourBtn";
      this.fourBtn.Size = new System.Drawing.Size(65, 69);
      this.fourBtn.TabIndex = 17;
      this.fourBtn.Text = "4";
      this.fourBtn.UseVisualStyleBackColor = false;
      this.fourBtn.Click += new System.EventHandler(this.fourBtn_Click);
      // 
      // logBtn
      // 
      this.logBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.logBtn.BackColor = System.Drawing.Color.Gray;
      this.logBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.logBtn.Location = new System.Drawing.Point(140, 153);
      this.logBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.logBtn.Name = "logBtn";
      this.logBtn.Size = new System.Drawing.Size(65, 69);
      this.logBtn.TabIndex = 16;
      this.logBtn.Text = "log";
      this.logBtn.UseVisualStyleBackColor = false;
      this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
      // 
      // cosBtn
      // 
      this.cosBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cosBtn.BackColor = System.Drawing.Color.Gray;
      this.cosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.cosBtn.Location = new System.Drawing.Point(71, 153);
      this.cosBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.cosBtn.Name = "cosBtn";
      this.cosBtn.Size = new System.Drawing.Size(65, 69);
      this.cosBtn.TabIndex = 15;
      this.cosBtn.Text = "cos";
      this.cosBtn.UseVisualStyleBackColor = false;
      this.cosBtn.Click += new System.EventHandler(this.cosBtn_Click);
      // 
      // piBtn
      // 
      this.piBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.piBtn.BackColor = System.Drawing.Color.Gray;
      this.piBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.piBtn.Location = new System.Drawing.Point(2, 153);
      this.piBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.piBtn.Name = "piBtn";
      this.piBtn.Size = new System.Drawing.Size(65, 69);
      this.piBtn.TabIndex = 14;
      this.piBtn.Text = "π";
      this.piBtn.UseVisualStyleBackColor = false;
      this.piBtn.Click += new System.EventHandler(this.piBtn_Click);
      // 
      // divisionBtn
      // 
      this.divisionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.divisionBtn.BackColor = System.Drawing.Color.DarkOrange;
      this.divisionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.divisionBtn.Location = new System.Drawing.Point(416, 78);
      this.divisionBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.divisionBtn.Name = "divisionBtn";
      this.divisionBtn.Size = new System.Drawing.Size(70, 69);
      this.divisionBtn.TabIndex = 13;
      this.divisionBtn.Text = "÷";
      this.divisionBtn.UseVisualStyleBackColor = false;
      this.divisionBtn.Click += new System.EventHandler(this.divisionBtn_Click);
      // 
      // nineBtn
      // 
      this.nineBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nineBtn.BackColor = System.Drawing.Color.Silver;
      this.nineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.nineBtn.Location = new System.Drawing.Point(347, 78);
      this.nineBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.nineBtn.Name = "nineBtn";
      this.nineBtn.Size = new System.Drawing.Size(65, 69);
      this.nineBtn.TabIndex = 12;
      this.nineBtn.Text = "9";
      this.nineBtn.UseVisualStyleBackColor = false;
      this.nineBtn.Click += new System.EventHandler(this.nineBtn_Click);
      // 
      // eightBtn
      // 
      this.eightBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.eightBtn.BackColor = System.Drawing.Color.Silver;
      this.eightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.eightBtn.Location = new System.Drawing.Point(278, 78);
      this.eightBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.eightBtn.Name = "eightBtn";
      this.eightBtn.Size = new System.Drawing.Size(65, 69);
      this.eightBtn.TabIndex = 11;
      this.eightBtn.Text = "8";
      this.eightBtn.UseVisualStyleBackColor = false;
      this.eightBtn.Click += new System.EventHandler(this.eightBtn_Click);
      // 
      // sevenBtn
      // 
      this.sevenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sevenBtn.BackColor = System.Drawing.Color.Silver;
      this.sevenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.sevenBtn.Location = new System.Drawing.Point(209, 78);
      this.sevenBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.sevenBtn.Name = "sevenBtn";
      this.sevenBtn.Size = new System.Drawing.Size(65, 69);
      this.sevenBtn.TabIndex = 10;
      this.sevenBtn.Text = "7";
      this.sevenBtn.UseVisualStyleBackColor = false;
      this.sevenBtn.Click += new System.EventHandler(this.sevenBtn_Click);
      // 
      // lnBtn
      // 
      this.lnBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lnBtn.BackColor = System.Drawing.Color.Gray;
      this.lnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.lnBtn.Location = new System.Drawing.Point(140, 78);
      this.lnBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.lnBtn.Name = "lnBtn";
      this.lnBtn.Size = new System.Drawing.Size(65, 69);
      this.lnBtn.TabIndex = 9;
      this.lnBtn.Text = "ln";
      this.lnBtn.UseVisualStyleBackColor = false;
      this.lnBtn.Click += new System.EventHandler(this.lnBtn_Click);
      // 
      // sinBtn
      // 
      this.sinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sinBtn.BackColor = System.Drawing.Color.Gray;
      this.sinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.sinBtn.Location = new System.Drawing.Point(71, 78);
      this.sinBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.sinBtn.Name = "sinBtn";
      this.sinBtn.Size = new System.Drawing.Size(65, 69);
      this.sinBtn.TabIndex = 8;
      this.sinBtn.Text = "sin";
      this.sinBtn.UseVisualStyleBackColor = false;
      this.sinBtn.Click += new System.EventHandler(this.sinBtn_Click);
      // 
      // shiftBtn
      // 
      this.shiftBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.shiftBtn.BackColor = System.Drawing.Color.Gray;
      this.shiftBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.shiftBtn.Location = new System.Drawing.Point(2, 78);
      this.shiftBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.shiftBtn.Name = "shiftBtn";
      this.shiftBtn.Size = new System.Drawing.Size(65, 69);
      this.shiftBtn.TabIndex = 7;
      this.shiftBtn.Text = "Shift";
      this.shiftBtn.UseVisualStyleBackColor = false;
      this.shiftBtn.Click += new System.EventHandler(this.shiftBtn_Click);
      // 
      // clearBtn
      // 
      this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.clearBtn.BackColor = System.Drawing.Color.Maroon;
      this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.clearBtn.Location = new System.Drawing.Point(416, 3);
      this.clearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.clearBtn.Name = "clearBtn";
      this.clearBtn.Size = new System.Drawing.Size(70, 69);
      this.clearBtn.TabIndex = 6;
      this.clearBtn.Text = "AC";
      this.clearBtn.UseVisualStyleBackColor = false;
      this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
      // 
      // backspaceBtn
      // 
      this.backspaceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.backspaceBtn.BackColor = System.Drawing.Color.Maroon;
      this.backspaceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
      this.backspaceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.backspaceBtn.Location = new System.Drawing.Point(347, 3);
      this.backspaceBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.backspaceBtn.Name = "backspaceBtn";
      this.backspaceBtn.Size = new System.Drawing.Size(65, 69);
      this.backspaceBtn.TabIndex = 5;
      this.backspaceBtn.Text = "⌫";
      this.backspaceBtn.UseVisualStyleBackColor = false;
      this.backspaceBtn.Click += new System.EventHandler(this.backspaceBtn_Click);
      // 
      // rightBracketBtn
      // 
      this.rightBracketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rightBracketBtn.BackColor = System.Drawing.Color.Gray;
      this.rightBracketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.rightBracketBtn.Location = new System.Drawing.Point(278, 3);
      this.rightBracketBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.rightBracketBtn.Name = "rightBracketBtn";
      this.rightBracketBtn.Size = new System.Drawing.Size(65, 69);
      this.rightBracketBtn.TabIndex = 4;
      this.rightBracketBtn.Text = ")";
      this.rightBracketBtn.UseVisualStyleBackColor = false;
      this.rightBracketBtn.Click += new System.EventHandler(this.rightBracketBtn_Click);
      // 
      // leftBracketBtn
      // 
      this.leftBracketBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.leftBracketBtn.BackColor = System.Drawing.Color.Gray;
      this.leftBracketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.leftBracketBtn.Location = new System.Drawing.Point(209, 3);
      this.leftBracketBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.leftBracketBtn.Name = "leftBracketBtn";
      this.leftBracketBtn.Size = new System.Drawing.Size(65, 69);
      this.leftBracketBtn.TabIndex = 3;
      this.leftBracketBtn.Text = "(";
      this.leftBracketBtn.UseVisualStyleBackColor = false;
      this.leftBracketBtn.Click += new System.EventHandler(this.leftBracketBtn_Click);
      // 
      // factorialBtn
      // 
      this.factorialBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.factorialBtn.BackColor = System.Drawing.Color.Gray;
      this.factorialBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.factorialBtn.Location = new System.Drawing.Point(140, 3);
      this.factorialBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.factorialBtn.Name = "factorialBtn";
      this.factorialBtn.Size = new System.Drawing.Size(65, 69);
      this.factorialBtn.TabIndex = 2;
      this.factorialBtn.Text = "n!";
      this.factorialBtn.UseVisualStyleBackColor = false;
      this.factorialBtn.Click += new System.EventHandler(this.factorialBtn_Click);
      // 
      // radDegBtn
      // 
      this.radDegBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.radDegBtn.BackColor = System.Drawing.Color.Gray;
      this.radDegBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.radDegBtn.Location = new System.Drawing.Point(2, 3);
      this.radDegBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.radDegBtn.Name = "radDegBtn";
      this.radDegBtn.Size = new System.Drawing.Size(65, 69);
      this.radDegBtn.TabIndex = 36;
      this.radDegBtn.Text = "Rad";
      this.radDegBtn.UseVisualStyleBackColor = false;
      this.radDegBtn.Click += new System.EventHandler(this.radDegBtn_Click);
      // 
      // expBtn
      // 
      this.expBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.expBtn.BackColor = System.Drawing.Color.Gray;
      this.expBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.expBtn.Location = new System.Drawing.Point(71, 3);
      this.expBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.expBtn.Name = "expBtn";
      this.expBtn.Size = new System.Drawing.Size(65, 69);
      this.expBtn.TabIndex = 1;
      this.expBtn.Text = "EXP";
      this.expBtn.UseVisualStyleBackColor = false;
      this.expBtn.Click += new System.EventHandler(this.expBtn_Click);
      // 
      // percentBtn
      // 
      this.percentBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.percentBtn.BackColor = System.Drawing.Color.Gray;
      this.percentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.percentBtn.Location = new System.Drawing.Point(71, 303);
      this.percentBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.percentBtn.Name = "percentBtn";
      this.percentBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.percentBtn.Size = new System.Drawing.Size(65, 70);
      this.percentBtn.TabIndex = 29;
      this.percentBtn.Text = "%";
      this.percentBtn.UseVisualStyleBackColor = false;
      this.percentBtn.Click += new System.EventHandler(this.percentBtn_Click);
      // 
      // additionBtn
      // 
      this.additionBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.additionBtn.BackColor = System.Drawing.Color.DarkOrange;
      this.additionBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
      this.additionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.additionBtn.Location = new System.Drawing.Point(416, 303);
      this.additionBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.additionBtn.Name = "additionBtn";
      this.additionBtn.Size = new System.Drawing.Size(70, 70);
      this.additionBtn.TabIndex = 35;
      this.additionBtn.Text = "+";
      this.additionBtn.UseVisualStyleBackColor = false;
      this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
      // 
      // periodBtn
      // 
      this.periodBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.periodBtn.BackColor = System.Drawing.Color.Silver;
      this.periodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.periodBtn.Location = new System.Drawing.Point(209, 303);
      this.periodBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.periodBtn.Name = "periodBtn";
      this.periodBtn.Size = new System.Drawing.Size(65, 70);
      this.periodBtn.TabIndex = 32;
      this.periodBtn.Text = ".";
      this.periodBtn.UseVisualStyleBackColor = false;
      this.periodBtn.Click += new System.EventHandler(this.periodBtn_Click);
      // 
      // zeroBtn
      // 
      this.zeroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.zeroBtn.BackColor = System.Drawing.Color.Silver;
      this.zeroBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.zeroBtn.Location = new System.Drawing.Point(278, 303);
      this.zeroBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.zeroBtn.Name = "zeroBtn";
      this.zeroBtn.Size = new System.Drawing.Size(65, 70);
      this.zeroBtn.TabIndex = 31;
      this.zeroBtn.Text = "0";
      this.zeroBtn.UseVisualStyleBackColor = false;
      this.zeroBtn.Click += new System.EventHandler(this.zeroBtn_Click);
      // 
      // outputTextBox
      // 
      this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.outputTextBox.BackColor = System.Drawing.SystemColors.Window;
      this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.outputTextBox.DetectUrls = false;
      this.outputTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.outputTextBox.Location = new System.Drawing.Point(5, 5);
      this.outputTextBox.Margin = new System.Windows.Forms.Padding(5);
      this.outputTextBox.Name = "outputTextBox";
      this.outputTextBox.ReadOnly = true;
      this.outputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.outputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.outputTextBox.Size = new System.Drawing.Size(482, 98);
      this.outputTextBox.TabIndex = 1;
      this.outputTextBox.Text = "";
      // 
      // inputTextBox
      // 
      this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.inputTextBox.DetectUrls = false;
      this.inputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.inputTextBox.Location = new System.Drawing.Point(2, 111);
      this.inputTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.inputTextBox.Multiline = false;
      this.inputTextBox.Name = "inputTextBox";
      this.inputTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.inputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.inputTextBox.Size = new System.Drawing.Size(488, 48);
      this.inputTextBox.TabIndex = 2;
      this.inputTextBox.Text = "";
      // 
      // calculatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.White;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(499, 550);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.MinimumSize = new System.Drawing.Size(501, 550);
      this.Name = "calculatorForm";
      this.Padding = new System.Windows.Forms.Padding(2, 64, 0, 0);
      this.Text = "Scientific Calculator";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.DataGridViewTextBoxColumn MainColumn;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.RichTextBox outputTextBox;
    private System.Windows.Forms.RichTextBox inputTextBox;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button equalBtn;
    private System.Windows.Forms.Button periodBtn;
    private System.Windows.Forms.Button zeroBtn;
    private System.Windows.Forms.Button exponentBtn;
    private System.Windows.Forms.Button percentBtn;
    private System.Windows.Forms.Button ansBtn;
    private System.Windows.Forms.Button subtractionBtn;
    private System.Windows.Forms.Button threeBtn;
    private System.Windows.Forms.Button twoBtn;
    private System.Windows.Forms.Button oneBtn;
    private System.Windows.Forms.Button squareRootBtn;
    private System.Windows.Forms.Button tanBtn;
    private System.Windows.Forms.Button eBtn;
    private System.Windows.Forms.Button multiplicationBtn;
    private System.Windows.Forms.Button sixBtn;
    private System.Windows.Forms.Button fiveBtn;
    private System.Windows.Forms.Button fourBtn;
    private System.Windows.Forms.Button logBtn;
    private System.Windows.Forms.Button cosBtn;
    private System.Windows.Forms.Button piBtn;
    private System.Windows.Forms.Button divisionBtn;
    private System.Windows.Forms.Button nineBtn;
    private System.Windows.Forms.Button eightBtn;
    private System.Windows.Forms.Button sevenBtn;
    private System.Windows.Forms.Button lnBtn;
    private System.Windows.Forms.Button sinBtn;
    private System.Windows.Forms.Button shiftBtn;
    private System.Windows.Forms.Button clearBtn;
    private System.Windows.Forms.Button backspaceBtn;
    private System.Windows.Forms.Button rightBracketBtn;
    private System.Windows.Forms.Button leftBracketBtn;
    private System.Windows.Forms.Button factorialBtn;
    private System.Windows.Forms.Button expBtn;
    private System.Windows.Forms.Button additionBtn;
    private System.Windows.Forms.Button radDegBtn;
  }
}

