namespace Taschenrechner
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.binText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.decText = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wissenschaftlichToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.reset = new System.Windows.Forms.Label();
            this.binDecRad = new System.Windows.Forms.RadioButton();
            this.decBinRad = new System.Windows.Forms.RadioButton();
            this.convert = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.binText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.decText, 0, 1);
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
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // binText
            // 
            this.binText.BackColor = System.Drawing.Color.Black;
            this.binText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.binText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binText.ForeColor = System.Drawing.Color.White;
            this.binText.Location = new System.Drawing.Point(3, 305);
            this.binText.Name = "binText";
            this.binText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.binText.Size = new System.Drawing.Size(472, 199);
            this.binText.TabIndex = 5;
            this.binText.TabStop = false;
            this.binText.Text = "";
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
            this.label3.Text = "Binary";
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
            this.label1.Text = "Decimal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decText
            // 
            this.decText.BackColor = System.Drawing.Color.Black;
            this.decText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decText.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decText.ForeColor = System.Drawing.Color.White;
            this.decText.Location = new System.Drawing.Point(3, 53);
            this.decText.Name = "decText";
            this.decText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.decText.Size = new System.Drawing.Size(472, 196);
            this.decText.TabIndex = 3;
            this.decText.TabStop = false;
            this.decText.Text = "";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 570);
            this.tableLayoutPanel2.TabIndex = 1;
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
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
            // standartToolStripMenuItem
            // 
            this.standartToolStripMenuItem.Name = "standartToolStripMenuItem";
            this.standartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.standartToolStripMenuItem.Text = "Standard";
            this.standartToolStripMenuItem.Click += new System.EventHandler(this.standartToolStripMenuItem_Click);
            // 
            // wissenschaftlichToolStripMenuItem
            // 
            this.wissenschaftlichToolStripMenuItem.Name = "wissenschaftlichToolStripMenuItem";
            this.wissenschaftlichToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wissenschaftlichToolStripMenuItem.Text = "Wissenschaftlich";
            this.wissenschaftlichToolStripMenuItem.Click += new System.EventHandler(this.wissenschaftlichToolStripMenuItem_Click);
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
            // hexBinToolStripMenuItem
            // 
            this.hexBinToolStripMenuItem.Name = "hexBinToolStripMenuItem";
            this.hexBinToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.hexBinToolStripMenuItem.Text = "Dec - Bin";
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.heToolStripMenuItem.Text = "Dec - Hex";
            this.heToolStripMenuItem.Click += new System.EventHandler(this.heToolStripMenuItem_Click);
            // 
            // binHexToolStripMenuItem
            // 
            this.binHexToolStripMenuItem.Name = "binHexToolStripMenuItem";
            this.binHexToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.binHexToolStripMenuItem.Text = "Bin - Hex";
            this.binHexToolStripMenuItem.Click += new System.EventHandler(this.binHexToolStripMenuItem_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.reset, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.binDecRad, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.decBinRad, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.convert, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 544);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(478, 23);
            this.tableLayoutPanel3.TabIndex = 3;
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
            // binDecRad
            // 
            this.binDecRad.AutoSize = true;
            this.binDecRad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.binDecRad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binDecRad.ForeColor = System.Drawing.Color.White;
            this.binDecRad.Location = new System.Drawing.Point(122, 3);
            this.binDecRad.Name = "binDecRad";
            this.binDecRad.Size = new System.Drawing.Size(113, 17);
            this.binDecRad.TabIndex = 1;
            this.binDecRad.TabStop = true;
            this.binDecRad.Text = "Bin - Dec";
            this.binDecRad.UseVisualStyleBackColor = true;
            this.binDecRad.CheckedChanged += new System.EventHandler(this.binDecRad_CheckedChanged);
            // 
            // decBinRad
            // 
            this.decBinRad.AutoSize = true;
            this.decBinRad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.decBinRad.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decBinRad.ForeColor = System.Drawing.Color.White;
            this.decBinRad.Location = new System.Drawing.Point(3, 3);
            this.decBinRad.Name = "decBinRad";
            this.decBinRad.Size = new System.Drawing.Size(113, 17);
            this.decBinRad.TabIndex = 0;
            this.decBinRad.TabStop = true;
            this.decBinRad.Text = "Dec - Bin";
            this.decBinRad.UseVisualStyleBackColor = true;
            this.decBinRad.CheckedChanged += new System.EventHandler(this.decBinRad_CheckedChanged);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 570);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Dec - Bin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox decText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wissenschaftlichToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexBinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binHexToolStripMenuItem;
        private System.Windows.Forms.RichTextBox binText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.RadioButton binDecRad;
        private System.Windows.Forms.RadioButton decBinRad;
        private System.Windows.Forms.Label convert;
        private System.Windows.Forms.Label reset;
    }
}