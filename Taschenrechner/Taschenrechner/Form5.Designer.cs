namespace Taschenrechner
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.binHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wissenschaftlichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.reset = new System.Windows.Forms.Label();
            this.hexDecRad = new System.Windows.Forms.RadioButton();
            this.decHexRad = new System.Windows.Forms.RadioButton();
            this.convert = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hexText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.binText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // binHexToolStripMenuItem
            // 
            this.binHexToolStripMenuItem.Name = "binHexToolStripMenuItem";
            this.binHexToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.binHexToolStripMenuItem.Text = "Bin - Hex";
            // 
            // hexBinToolStripMenuItem
            // 
            this.hexBinToolStripMenuItem.Name = "hexBinToolStripMenuItem";
            this.hexBinToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hexBinToolStripMenuItem.Text = "Dec - Bin";
            this.hexBinToolStripMenuItem.Click += new System.EventHandler(this.hexBinToolStripMenuItem_Click);
            // 
            // programmerToolStripMenuItem
            // 
            this.programmerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexBinToolStripMenuItem,
            this.heToolStripMenuItem,
            this.binHexToolStripMenuItem});
            this.programmerToolStripMenuItem.Name = "programmerToolStripMenuItem";
            this.programmerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmerToolStripMenuItem.Text = "Umrechner";
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.heToolStripMenuItem.Text = "Dec - Hex";
            this.heToolStripMenuItem.Click += new System.EventHandler(this.heToolStripMenuItem_Click);
            // 
            // wissenschaftlichToolStripMenuItem
            // 
            this.wissenschaftlichToolStripMenuItem.Name = "wissenschaftlichToolStripMenuItem";
            this.wissenschaftlichToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wissenschaftlichToolStripMenuItem.Text = "Wissenschaftlich";
            this.wissenschaftlichToolStripMenuItem.Click += new System.EventHandler(this.wissenschaftlichToolStripMenuItem_Click);
            // 
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standartToolStripMenuItem.Text = "Standard";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // rechnerToolStripMenuItem
            // 
            this.rechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standartToolStripMenuItem,
            this.wissenschaftlichToolStripMenuItem,
            this.programmerToolStripMenuItem});
            this.rechnerToolStripMenuItem.Name = "rechnerToolStripMenuItem";
            this.rechnerToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.rechnerToolStripMenuItem.Text = "Rechner";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.menuStrip1, 2);
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.rechnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 570);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.reset, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.hexDecRad, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.decHexRad, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.convert, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 544);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 23);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // reset
            // 
            this.reset.AutoSize = true;
            this.reset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reset.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.White;
            this.reset.Location = new System.Drawing.Point(360, 0);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(115, 23);
            this.reset.TabIndex = 3;
            this.reset.Text = "Reset";
            this.reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // hexDecRad
            // 
            this.hexDecRad.AutoSize = true;
            this.hexDecRad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexDecRad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexDecRad.ForeColor = System.Drawing.Color.White;
            this.hexDecRad.Location = new System.Drawing.Point(122, 3);
            this.hexDecRad.Name = "hexDecRad";
            this.hexDecRad.Size = new System.Drawing.Size(113, 17);
            this.hexDecRad.TabIndex = 1;
            this.hexDecRad.TabStop = true;
            this.hexDecRad.Text = "Hex - Bin";
            this.hexDecRad.UseVisualStyleBackColor = true;
            this.hexDecRad.CheckedChanged += new System.EventHandler(this.hexDecRad_CheckedChanged);
            // 
            // decHexRad
            // 
            this.decHexRad.AutoSize = true;
            this.decHexRad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decHexRad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decHexRad.ForeColor = System.Drawing.Color.White;
            this.decHexRad.Location = new System.Drawing.Point(3, 3);
            this.decHexRad.Name = "decHexRad";
            this.decHexRad.Size = new System.Drawing.Size(113, 17);
            this.decHexRad.TabIndex = 0;
            this.decHexRad.TabStop = true;
            this.decHexRad.Text = "Bin - Hex";
            this.decHexRad.UseVisualStyleBackColor = true;
            this.decHexRad.CheckedChanged += new System.EventHandler(this.decHexRad_CheckedChanged);
            // 
            // convert
            // 
            this.convert.AutoSize = true;
            this.convert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.convert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.convert.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.ForeColor = System.Drawing.Color.White;
            this.convert.Location = new System.Drawing.Point(241, 0);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(113, 23);
            this.convert.TabIndex = 2;
            this.convert.Text = "Convert";
            this.convert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.hexText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.binText, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 507);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // hexText
            // 
            this.hexText.BackColor = System.Drawing.Color.Black;
            this.hexText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexText.ForeColor = System.Drawing.Color.White;
            this.hexText.Location = new System.Drawing.Point(3, 305);
            this.hexText.Name = "hexText";
            this.hexText.Size = new System.Drawing.Size(472, 199);
            this.hexText.TabIndex = 5;
            this.hexText.TabStop = false;
            this.hexText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hexadecimal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // binText
            // 
            this.binText.BackColor = System.Drawing.Color.Black;
            this.binText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.binText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binText.ForeColor = System.Drawing.Color.White;
            this.binText.Location = new System.Drawing.Point(3, 53);
            this.binText.Name = "binText";
            this.binText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.binText.Size = new System.Drawing.Size(472, 196);
            this.binText.TabIndex = 3;
            this.binText.TabStop = false;
            this.binText.Text = "";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 570);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form5";
            this.ShowIcon = false;
            this.Text = "Bin - Hex";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem binHexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wissenschaftlichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox hexText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox binText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label reset;
        private System.Windows.Forms.RadioButton hexDecRad;
        private System.Windows.Forms.RadioButton decHexRad;
        private System.Windows.Forms.Label convert;
    }
}