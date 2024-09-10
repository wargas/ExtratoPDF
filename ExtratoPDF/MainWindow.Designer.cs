namespace ExtratoPDF
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonSelectFiles = new Button();
            listViewFiles = new ListView();
            statusStrip = new StatusStrip();
            statusApp = new ToolStripStatusLabel();
            panel1 = new Panel();
            listViewItems = new ListView();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label1 = new Label();
            comboBoxBank = new ComboBox();
            buttonProceess = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            buttonCSV = new Button();
            buttonExcel = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            statusStrip.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(listViewFiles, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.Size = new Size(744, 189);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonSelectFiles);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(2, 2);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(740, 28);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonSelectFiles
            // 
            buttonSelectFiles.Location = new Point(588, 2);
            buttonSelectFiles.Margin = new Padding(2);
            buttonSelectFiles.Name = "buttonSelectFiles";
            buttonSelectFiles.Size = new Size(150, 24);
            buttonSelectFiles.TabIndex = 0;
            buttonSelectFiles.Text = "Selecionar arquivos";
            buttonSelectFiles.UseVisualStyleBackColor = true;
            buttonSelectFiles.Click += buttonSelectFiles_Click;
            // 
            // listViewFiles
            // 
            listViewFiles.Dock = DockStyle.Top;
            listViewFiles.FullRowSelect = true;
            listViewFiles.GridLines = true;
            listViewFiles.Location = new Point(2, 34);
            listViewFiles.Margin = new Padding(2);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(740, 151);
            listViewFiles.TabIndex = 1;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { statusApp });
            statusStrip.Location = new Point(5, 418);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 11, 0);
            statusStrip.RightToLeft = RightToLeft.Yes;
            statusStrip.Size = new Size(744, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // statusApp
            // 
            statusApp.Name = "statusApp";
            statusApp.Size = new Size(0, 17);
            // 
            // panel1
            // 
            panel1.Controls.Add(listViewItems);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(5, 194);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(744, 224);
            panel1.TabIndex = 3;
            // 
            // listViewItems
            // 
            listViewItems.Dock = DockStyle.Fill;
            listViewItems.FullRowSelect = true;
            listViewItems.GridLines = true;
            listViewItems.Location = new Point(0, 31);
            listViewItems.Margin = new Padding(2);
            listViewItems.Name = "listViewItems";
            listViewItems.Size = new Size(744, 162);
            listViewItems.TabIndex = 2;
            listViewItems.UseCompatibleStateImageBehavior = false;
            listViewItems.ItemSelectionChanged += listViewItems_ItemSelectionChanged;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label1);
            flowLayoutPanel3.Controls.Add(comboBoxBank);
            flowLayoutPanel3.Controls.Add(buttonProceess);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Margin = new Padding(2);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.RightToLeft = RightToLeft.No;
            flowLayoutPanel3.Size = new Size(744, 31);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(43, 29);
            label1.TabIndex = 2;
            label1.Text = "Banco";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxBank
            // 
            comboBoxBank.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBank.FormattingEnabled = true;
            comboBoxBank.Location = new Point(45, 2);
            comboBoxBank.Margin = new Padding(2);
            comboBoxBank.Name = "comboBoxBank";
            comboBoxBank.Size = new Size(135, 25);
            comboBoxBank.TabIndex = 1;
            // 
            // buttonProceess
            // 
            buttonProceess.Location = new Point(184, 2);
            buttonProceess.Margin = new Padding(2);
            buttonProceess.Name = "buttonProceess";
            buttonProceess.Size = new Size(86, 24);
            buttonProceess.TabIndex = 0;
            buttonProceess.Text = "Processar";
            buttonProceess.UseVisualStyleBackColor = true;
            buttonProceess.Click += buttonProceess_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(buttonCSV);
            flowLayoutPanel2.Controls.Add(buttonExcel);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.Location = new Point(0, 193);
            flowLayoutPanel2.Margin = new Padding(2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(744, 31);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // buttonCSV
            // 
            buttonCSV.Enabled = false;
            buttonCSV.Location = new Point(2, 2);
            buttonCSV.Margin = new Padding(2);
            buttonCSV.Name = "buttonCSV";
            buttonCSV.Size = new Size(104, 24);
            buttonCSV.TabIndex = 0;
            buttonCSV.Text = "SALVAR CSV";
            buttonCSV.UseVisualStyleBackColor = true;
            buttonCSV.Click += buttonCSV_Click;
            // 
            // buttonExcel
            // 
            buttonExcel.Enabled = false;
            buttonExcel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExcel.Location = new Point(110, 2);
            buttonExcel.Margin = new Padding(2);
            buttonExcel.Name = "buttonExcel";
            buttonExcel.Size = new Size(115, 24);
            buttonExcel.TabIndex = 1;
            buttonExcel.Text = "SALVAR EXCEL";
            buttonExcel.UseVisualStyleBackColor = true;
            buttonExcel.Click += buttonEXCEL_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            openFileDialog.Filter = "All Files | *.pdf";
            openFileDialog.Multiselect = true;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(754, 445);
            Controls.Add(panel1);
            Controls.Add(statusStrip);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainWindow";
            Padding = new Padding(5);
            Text = "Extrato PDF";
            Load += MainWindow_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            panel1.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonSelectFiles;
        private ListView listViewFiles;
        private StatusStrip statusStrip;
        private Panel panel1;
        private ListView listViewItems;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button buttonProceess;
        private ComboBox comboBoxBank;
        private Button buttonCSV;
        private Button buttonExcel;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Label label1;
        private ToolStripStatusLabel statusApp;
    }
}
