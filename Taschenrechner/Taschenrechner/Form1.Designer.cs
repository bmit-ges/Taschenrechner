namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equals = new System.Windows.Forms.Label();
            this.num11 = new System.Windows.Forms.Label();
            this.num10 = new System.Windows.Forms.Label();
            this.op4 = new System.Windows.Forms.Label();
            this.num9 = new System.Windows.Forms.Label();
            this.num8 = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Label();
            this.op3 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.op2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.Label();
            this.del = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.allClear = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RechnerStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wissenschaftlichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umrechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyScroll = new System.Windows.Forms.FlowLayoutPanel();
            this.history = new System.Windows.Forms.Label();
            this.clearHistory = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.historyScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.historyScroll, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.clearHistory, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 609);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equals, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.num11, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.num10, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.op4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.num9, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.num8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.num7, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.op3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.num6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.num5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.num4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.op2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.num3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.num1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.op1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.del, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.previous, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.current, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.allClear, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.80097F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.20145F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.72764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.08702F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(313, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equals
            // 
            this.equals.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.equals, 2);
            this.equals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equals.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equals.ForeColor = System.Drawing.Color.White;
            this.equals.Location = new System.Drawing.Point(159, 495);
            this.equals.Name = "equals";
            this.equals.Size = new System.Drawing.Size(149, 76);
            this.equals.TabIndex = 22;
            this.equals.Text = "=";
            this.equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // num11
            // 
            this.num11.BackColor = System.Drawing.Color.Black;
            this.num11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num11.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num11.ForeColor = System.Drawing.Color.White;
            this.num11.Location = new System.Drawing.Point(82, 495);
            this.num11.Name = "num11";
            this.num11.Size = new System.Drawing.Size(69, 76);
            this.num11.TabIndex = 19;
            this.num11.Text = "0";
            this.num11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num11.Click += new System.EventHandler(this.num11_Click);
            // 
            // num10
            // 
            this.num10.BackColor = System.Drawing.Color.Black;
            this.num10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num10.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num10.ForeColor = System.Drawing.Color.White;
            this.num10.Location = new System.Drawing.Point(5, 495);
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(69, 76);
            this.num10.TabIndex = 18;
            this.num10.Text = ".";
            this.num10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num10.Click += new System.EventHandler(this.num10_Click);
            // 
            // op4
            // 
            this.op4.BackColor = System.Drawing.Color.Black;
            this.op4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.op4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op4.ForeColor = System.Drawing.Color.White;
            this.op4.Location = new System.Drawing.Point(236, 417);
            this.op4.Name = "op4";
            this.op4.Size = new System.Drawing.Size(72, 76);
            this.op4.TabIndex = 17;
            this.op4.Text = "-";
            this.op4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.op4.Click += new System.EventHandler(this.op4_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.Black;
            this.num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num9.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.Color.White;
            this.num9.Location = new System.Drawing.Point(159, 417);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(69, 76);
            this.num9.TabIndex = 16;
            this.num9.Text = "9";
            this.num9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.Black;
            this.num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num8.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.Color.White;
            this.num8.Location = new System.Drawing.Point(82, 417);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(69, 76);
            this.num8.TabIndex = 15;
            this.num8.Text = "8";
            this.num8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.Black;
            this.num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num7.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.Color.White;
            this.num7.Location = new System.Drawing.Point(5, 417);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(69, 76);
            this.num7.TabIndex = 14;
            this.num7.Text = "7";
            this.num7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // op3
            // 
            this.op3.BackColor = System.Drawing.Color.Black;
            this.op3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.op3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op3.ForeColor = System.Drawing.Color.White;
            this.op3.Location = new System.Drawing.Point(236, 339);
            this.op3.Name = "op3";
            this.op3.Size = new System.Drawing.Size(72, 76);
            this.op3.TabIndex = 13;
            this.op3.Text = "+";
            this.op3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.op3.Click += new System.EventHandler(this.op3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.Black;
            this.num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.Color.White;
            this.num6.Location = new System.Drawing.Point(159, 339);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(69, 76);
            this.num6.TabIndex = 12;
            this.num6.Text = "6";
            this.num6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.Black;
            this.num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.Color.White;
            this.num5.Location = new System.Drawing.Point(82, 339);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(69, 76);
            this.num5.TabIndex = 11;
            this.num5.Text = "5";
            this.num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.Black;
            this.num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.White;
            this.num4.Location = new System.Drawing.Point(5, 339);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(69, 76);
            this.num4.TabIndex = 10;
            this.num4.Text = "4";
            this.num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // op2
            // 
            this.op2.BackColor = System.Drawing.Color.Black;
            this.op2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.op2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op2.ForeColor = System.Drawing.Color.White;
            this.op2.Location = new System.Drawing.Point(236, 261);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(72, 76);
            this.op2.TabIndex = 9;
            this.op2.Text = "*";
            this.op2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.op2.Click += new System.EventHandler(this.op2_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Black;
            this.num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.White;
            this.num3.Location = new System.Drawing.Point(159, 261);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(69, 76);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Black;
            this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.White;
            this.num2.Location = new System.Drawing.Point(82, 261);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 76);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Black;
            this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.White;
            this.num1.Location = new System.Drawing.Point(5, 261);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(69, 76);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // op1
            // 
            this.op1.BackColor = System.Drawing.Color.Black;
            this.op1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.op1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op1.ForeColor = System.Drawing.Color.White;
            this.op1.Location = new System.Drawing.Point(236, 183);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(72, 76);
            this.op1.TabIndex = 5;
            this.op1.Text = "/";
            this.op1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.op1.Click += new System.EventHandler(this.op1_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Black;
            this.del.Dock = System.Windows.Forms.DockStyle.Fill;
            this.del.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.ForeColor = System.Drawing.Color.White;
            this.del.Location = new System.Drawing.Point(159, 183);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(69, 76);
            this.del.TabIndex = 4;
            this.del.Text = "DEL";
            this.del.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tableLayoutPanel1.SetColumnSpan(this.previous, 4);
            this.previous.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previous.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous.ForeColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(5, 2);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(303, 71);
            this.previous.TabIndex = 1;
            this.previous.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // current
            // 
            this.current.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.current, 4);
            this.current.Dock = System.Windows.Forms.DockStyle.Fill;
            this.current.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.ForeColor = System.Drawing.Color.White;
            this.current.Location = new System.Drawing.Point(5, 75);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(303, 106);
            this.current.TabIndex = 0;
            this.current.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // allClear
            // 
            this.allClear.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.SetColumnSpan(this.allClear, 2);
            this.allClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allClear.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allClear.ForeColor = System.Drawing.Color.White;
            this.allClear.Location = new System.Drawing.Point(5, 183);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(146, 76);
            this.allClear.TabIndex = 2;
            this.allClear.Text = "AC";
            this.allClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.allClear.Click += new System.EventHandler(this.allClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.RechnerStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // RechnerStripMenuItem
            // 
            this.RechnerStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.wissenschaftlichToolStripMenuItem,
            this.umrechnerToolStripMenuItem});
            this.RechnerStripMenuItem.Name = "RechnerStripMenuItem";
            this.RechnerStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.RechnerStripMenuItem.Text = "Rechner";
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.standartToolStripMenuItem.Text = "Standard";
            // 
            // wissenschaftlichToolStripMenuItem
            // 
            this.wissenschaftlichToolStripMenuItem.Name = "wissenschaftlichToolStripMenuItem";
            this.wissenschaftlichToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.wissenschaftlichToolStripMenuItem.Text = "Wissenschaftlich";
            this.wissenschaftlichToolStripMenuItem.Click += new System.EventHandler(this.wissenschaftlichToolStripMenuItem_Click);
            // 
            // umrechnerToolStripMenuItem
            // 
            this.umrechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decBinToolStripMenuItem,
            this.decHexToolStripMenuItem,
            this.hexBinToolStripMenuItem});
            this.umrechnerToolStripMenuItem.Name = "umrechnerToolStripMenuItem";
            this.umrechnerToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.umrechnerToolStripMenuItem.Text = "Umrechner";
            // 
            // decBinToolStripMenuItem
            // 
            this.decBinToolStripMenuItem.Name = "decBinToolStripMenuItem";
            this.decBinToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.decBinToolStripMenuItem.Text = "Dec - Bin";
            this.decBinToolStripMenuItem.Click += new System.EventHandler(this.decBinToolStripMenuItem_Click);
            // 
            // decHexToolStripMenuItem
            // 
            this.decHexToolStripMenuItem.Name = "decHexToolStripMenuItem";
            this.decHexToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.decHexToolStripMenuItem.Text = "Dec - Hex";
            this.decHexToolStripMenuItem.Click += new System.EventHandler(this.decHexToolStripMenuItem_Click);
            // 
            // hexBinToolStripMenuItem
            // 
            this.hexBinToolStripMenuItem.Name = "hexBinToolStripMenuItem";
            this.hexBinToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hexBinToolStripMenuItem.Text = "Hex - Bin";
            this.hexBinToolStripMenuItem.Click += new System.EventHandler(this.hexBinToolStripMenuItem_Click);
            // 
            // historyScroll
            // 
            this.historyScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyScroll.AutoScroll = true;
            this.historyScroll.BackColor = System.Drawing.Color.Black;
            this.historyScroll.Controls.Add(this.history);
            this.historyScroll.ForeColor = System.Drawing.Color.White;
            this.historyScroll.Location = new System.Drawing.Point(322, 33);
            this.historyScroll.Name = "historyScroll";
            this.historyScroll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.historyScroll.Size = new System.Drawing.Size(207, 573);
            this.historyScroll.TabIndex = 2;
            // 
            // history
            // 
            this.history.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.history.AutoSize = true;
            this.history.BackColor = System.Drawing.Color.Black;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.Location = new System.Drawing.Point(204, 0);
            this.history.Name = "history";
            this.history.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.history.Size = new System.Drawing.Size(0, 20);
            this.history.TabIndex = 0;
            // 
            // clearHistory
            // 
            this.clearHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearHistory.AutoSize = true;
            this.clearHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearHistory.Location = new System.Drawing.Point(322, 0);
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(207, 30);
            this.clearHistory.TabIndex = 3;
            this.clearHistory.Text = "Clear history";
            this.clearHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 609);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Taschenrechner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numKeys);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.historyScroll.ResumeLayout(false);
            this.historyScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RechnerStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wissenschaftlichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem umrechnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexBinToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label equals;
        private System.Windows.Forms.Label num11;
        private System.Windows.Forms.Label num10;
        private System.Windows.Forms.Label op4;
        private System.Windows.Forms.Label num9;
        private System.Windows.Forms.Label num8;
        private System.Windows.Forms.Label num7;
        private System.Windows.Forms.Label op3;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label op2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label op1;
        private System.Windows.Forms.Label del;
        private System.Windows.Forms.Label previous;
        private System.Windows.Forms.Label current;
        private System.Windows.Forms.Label allClear;
        private System.Windows.Forms.FlowLayoutPanel historyScroll;
        private System.Windows.Forms.Label history;
        private System.Windows.Forms.Label clearHistory;
    }
}

