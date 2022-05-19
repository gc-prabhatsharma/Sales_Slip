namespace Sales_Slip
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1FlexGridBandedView1 = new C1.Win.FlexGrid.C1FlexGridBandedView();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.excelExportButton = new System.Windows.Forms.Button();
            this.pdfExportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.None;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = false;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c1FlexGrid1.Location = new System.Drawing.Point(3, 3);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1012, 510);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.UseCompatibleTextRendering = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.c1FlexGrid1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1018, 584);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 519);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 62);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.excelExportButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pdfExportButton, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1012, 62);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // excelExportButton
            // 
            this.excelExportButton.AutoSize = true;
            this.excelExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.excelExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.excelExportButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.excelExportButton.ForeColor = System.Drawing.Color.Snow;
            this.excelExportButton.Location = new System.Drawing.Point(509, 3);
            this.excelExportButton.Name = "excelExportButton";
            this.excelExportButton.Size = new System.Drawing.Size(500, 56);
            this.excelExportButton.TabIndex = 0;
            this.excelExportButton.Text = "Export to Excel";
            this.excelExportButton.UseVisualStyleBackColor = false;
            this.excelExportButton.Click += new System.EventHandler(this.excelExportButton_Click);
            // 
            // pdfExportButton
            // 
            this.pdfExportButton.AutoSize = true;
            this.pdfExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pdfExportButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfExportButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pdfExportButton.ForeColor = System.Drawing.Color.Snow;
            this.pdfExportButton.Location = new System.Drawing.Point(3, 3);
            this.pdfExportButton.Name = "pdfExportButton";
            this.pdfExportButton.Size = new System.Drawing.Size(500, 56);
            this.pdfExportButton.TabIndex = 1;
            this.pdfExportButton.Text = "Export to PDF";
            this.pdfExportButton.UseVisualStyleBackColor = false;
            this.pdfExportButton.Click += new System.EventHandler(this.pdfExportButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 584);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sales Slip";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGridBandedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private C1.Win.FlexGrid.C1FlexGridBandedView c1FlexGridBandedView1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button pdfExportButton;
        private Button excelExportButton;
        private TableLayoutPanel tableLayoutPanel2;
    }
}