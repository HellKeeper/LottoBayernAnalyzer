namespace LottoBayernAnalyzer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.imgType = new System.Windows.Forms.PictureBox();
            this.tlpLotto6from49 = new System.Windows.Forms.TableLayoutPanel();
            this.panelFilters = new System.Windows.Forms.Panel();
            this.cbSaturdays = new System.Windows.Forms.CheckBox();
            this.cbWednesdays = new System.Windows.Forms.CheckBox();
            this.btnAllDates = new System.Windows.Forms.Button();
            this.btnLastYear = new System.Windows.Forms.Button();
            this.btnLastWeek = new System.Windows.Forms.Button();
            this.btnLastMonth = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.panelMode = new System.Windows.Forms.Panel();
            this.rbDrawDiff = new System.Windows.Forms.RadioButton();
            this.lottoButton1 = new LottoBayernAnalyzer.LottoButton();
            this.lottoButton2 = new LottoBayernAnalyzer.LottoButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.rbTotalDraws = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.imgType)).BeginInit();
            this.tlpLotto6from49.SuspendLayout();
            this.panelFilters.SuspendLayout();
            this.panelMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgType
            // 
            this.imgType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgType.BackColor = System.Drawing.Color.White;
            this.imgType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgType.Image = global::LottoBayernAnalyzer.Properties.Resources.Lotto6from49;
            this.imgType.Location = new System.Drawing.Point(12, 12);
            this.imgType.Name = "imgType";
            this.imgType.Size = new System.Drawing.Size(597, 50);
            this.imgType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgType.TabIndex = 0;
            this.imgType.TabStop = false;
            this.imgType.Click += new System.EventHandler(this.ImgType_Click);
            // 
            // tlpLotto6from49
            // 
            this.tlpLotto6from49.ColumnCount = 7;
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.Controls.Add(this.lottoButton1, 0, 0);
            this.tlpLotto6from49.Controls.Add(this.lottoButton2, 1, 1);
            this.tlpLotto6from49.Location = new System.Drawing.Point(12, 129);
            this.tlpLotto6from49.Name = "tlpLotto6from49";
            this.tlpLotto6from49.Padding = new System.Windows.Forms.Padding(2);
            this.tlpLotto6from49.RowCount = 7;
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLotto6from49.Size = new System.Drawing.Size(448, 448);
            this.tlpLotto6from49.TabIndex = 2;
            // 
            // panelFilters
            // 
            this.panelFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFilters.Controls.Add(this.cbSaturdays);
            this.panelFilters.Controls.Add(this.cbWednesdays);
            this.panelFilters.Controls.Add(this.btnAllDates);
            this.panelFilters.Controls.Add(this.btnLastYear);
            this.panelFilters.Controls.Add(this.btnLastWeek);
            this.panelFilters.Controls.Add(this.btnLastMonth);
            this.panelFilters.Controls.Add(this.lblStartDate);
            this.panelFilters.Controls.Add(this.dtpStartDate);
            this.panelFilters.Location = new System.Drawing.Point(12, 69);
            this.panelFilters.Name = "panelFilters";
            this.panelFilters.Size = new System.Drawing.Size(597, 54);
            this.panelFilters.TabIndex = 3;
            // 
            // cbSaturdays
            // 
            this.cbSaturdays.AutoSize = true;
            this.cbSaturdays.Checked = true;
            this.cbSaturdays.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSaturdays.Location = new System.Drawing.Point(243, 28);
            this.cbSaturdays.Name = "cbSaturdays";
            this.cbSaturdays.Size = new System.Drawing.Size(73, 17);
            this.cbSaturdays.TabIndex = 3;
            this.cbSaturdays.TabStop = false;
            this.cbSaturdays.Text = "Saturdays";
            this.cbSaturdays.UseVisualStyleBackColor = true;
            this.cbSaturdays.CheckedChanged += new System.EventHandler(this.filters_Changed);
            // 
            // cbWednesdays
            // 
            this.cbWednesdays.AutoSize = true;
            this.cbWednesdays.Checked = true;
            this.cbWednesdays.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWednesdays.Location = new System.Drawing.Point(243, 6);
            this.cbWednesdays.Name = "cbWednesdays";
            this.cbWednesdays.Size = new System.Drawing.Size(88, 17);
            this.cbWednesdays.TabIndex = 3;
            this.cbWednesdays.TabStop = false;
            this.cbWednesdays.Text = "Wednesdays";
            this.cbWednesdays.UseVisualStyleBackColor = true;
            this.cbWednesdays.CheckedChanged += new System.EventHandler(this.filters_Changed);
            // 
            // btnAllDates
            // 
            this.btnAllDates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAllDates.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnAllDates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllDates.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAllDates.Location = new System.Drawing.Point(6, 26);
            this.btnAllDates.Margin = new System.Windows.Forms.Padding(0);
            this.btnAllDates.Name = "btnAllDates";
            this.btnAllDates.Size = new System.Drawing.Size(29, 22);
            this.btnAllDates.TabIndex = 2;
            this.btnAllDates.TabStop = false;
            this.btnAllDates.Text = "All";
            this.btnAllDates.UseVisualStyleBackColor = true;
            this.btnAllDates.Click += new System.EventHandler(this.btnAllDates_Click);
            // 
            // btnLastYear
            // 
            this.btnLastYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastYear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnLastYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastYear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLastYear.Location = new System.Drawing.Point(35, 26);
            this.btnLastYear.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastYear.Name = "btnLastYear";
            this.btnLastYear.Size = new System.Drawing.Size(68, 22);
            this.btnLastYear.TabIndex = 2;
            this.btnLastYear.TabStop = false;
            this.btnLastYear.Text = "Last year";
            this.btnLastYear.UseVisualStyleBackColor = true;
            this.btnLastYear.Click += new System.EventHandler(this.btnLastYear_Click);
            // 
            // btnLastWeek
            // 
            this.btnLastWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastWeek.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnLastWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastWeek.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLastWeek.Location = new System.Drawing.Point(172, 26);
            this.btnLastWeek.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastWeek.Name = "btnLastWeek";
            this.btnLastWeek.Size = new System.Drawing.Size(65, 22);
            this.btnLastWeek.TabIndex = 2;
            this.btnLastWeek.TabStop = false;
            this.btnLastWeek.Text = "Last week";
            this.btnLastWeek.UseVisualStyleBackColor = true;
            this.btnLastWeek.Click += new System.EventHandler(this.btnLastWeek_Click);
            // 
            // btnLastMonth
            // 
            this.btnLastMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastMonth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.btnLastMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastMonth.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLastMonth.Location = new System.Drawing.Point(103, 26);
            this.btnLastMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btnLastMonth.Name = "btnLastMonth";
            this.btnLastMonth.Size = new System.Drawing.Size(69, 22);
            this.btnLastMonth.TabIndex = 2;
            this.btnLastMonth.TabStop = false;
            this.btnLastMonth.Text = "Last month";
            this.btnLastMonth.UseVisualStyleBackColor = true;
            this.btnLastMonth.Click += new System.EventHandler(this.btnLastMonth_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.Location = new System.Drawing.Point(3, 3);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(81, 20);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start date:";
            this.lblStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(90, 3);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(147, 20);
            this.dtpStartDate.TabIndex = 0;
            this.dtpStartDate.TabStop = false;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.filters_Changed);
            // 
            // panelMode
            // 
            this.panelMode.Controls.Add(this.rbTotalDraws);
            this.panelMode.Controls.Add(this.rbDrawDiff);
            this.panelMode.Location = new System.Drawing.Point(466, 129);
            this.panelMode.Name = "panelMode";
            this.panelMode.Padding = new System.Windows.Forms.Padding(4);
            this.panelMode.Size = new System.Drawing.Size(142, 57);
            this.panelMode.TabIndex = 4;
            // 
            // rbDrawDiff
            // 
            this.rbDrawDiff.AutoSize = true;
            this.rbDrawDiff.Checked = true;
            this.rbDrawDiff.Location = new System.Drawing.Point(7, 7);
            this.rbDrawDiff.Name = "rbDrawDiff";
            this.rbDrawDiff.Size = new System.Drawing.Size(121, 17);
            this.rbDrawDiff.TabIndex = 0;
            this.rbDrawDiff.TabStop = true;
            this.rbDrawDiff.Tag = "1";
            this.rbDrawDiff.Text = "Last draw difference";
            this.toolTip.SetToolTip(this.rbDrawDiff, "Number of draws since the number was picked last");
            this.rbDrawDiff.UseVisualStyleBackColor = true;
            this.rbDrawDiff.CheckedChanged += new System.EventHandler(this.filters_Changed);
            // 
            // lottoButton1
            // 
            this.lottoButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lottoButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lottoButton1.Checked = true;
            this.lottoButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lottoButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoButton1.Location = new System.Drawing.Point(2, 2);
            this.lottoButton1.Margin = new System.Windows.Forms.Padding(0);
            this.lottoButton1.Name = "lottoButton1";
            this.lottoButton1.Number = 1;
            this.lottoButton1.Size = new System.Drawing.Size(60, 60);
            this.lottoButton1.StatStyle = LottoBayernAnalyzer.LottoButton.StatisticsStyle.TotalDraws;
            this.lottoButton1.TabIndex = 0;
            this.lottoButton1.TabStop = false;
            this.lottoButton1.UseVisualStyleBackColor = false;
            // 
            // lottoButton2
            // 
            this.lottoButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lottoButton2.Checked = false;
            this.lottoButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lottoButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lottoButton2.Location = new System.Drawing.Point(66, 66);
            this.lottoButton2.Margin = new System.Windows.Forms.Padding(0);
            this.lottoButton2.Name = "lottoButton2";
            this.lottoButton2.Number = 22;
            this.lottoButton2.Size = new System.Drawing.Size(60, 60);
            this.lottoButton2.StatStyle = LottoBayernAnalyzer.LottoButton.StatisticsStyle.DrawDiff;
            this.lottoButton2.TabIndex = 0;
            this.lottoButton2.TabStop = false;
            this.lottoButton2.UseVisualStyleBackColor = false;
            // 
            // rbTotalDraws
            // 
            this.rbTotalDraws.AutoSize = true;
            this.rbTotalDraws.Location = new System.Drawing.Point(7, 30);
            this.rbTotalDraws.Name = "rbTotalDraws";
            this.rbTotalDraws.Size = new System.Drawing.Size(80, 17);
            this.rbTotalDraws.TabIndex = 0;
            this.rbTotalDraws.Tag = "2";
            this.rbTotalDraws.Text = "Total draws";
            this.toolTip.SetToolTip(this.rbTotalDraws, "Total number of draws the number was picked");
            this.rbTotalDraws.UseVisualStyleBackColor = true;
            this.rbTotalDraws.CheckedChanged += new System.EventHandler(this.filters_Changed);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 607);
            this.Controls.Add(this.panelMode);
            this.Controls.Add(this.panelFilters);
            this.Controls.Add(this.tlpLotto6from49);
            this.Controls.Add(this.imgType);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgType)).EndInit();
            this.tlpLotto6from49.ResumeLayout(false);
            this.panelFilters.ResumeLayout(false);
            this.panelFilters.PerformLayout();
            this.panelMode.ResumeLayout(false);
            this.panelMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgType;
        private System.Windows.Forms.TableLayoutPanel tlpLotto6from49;
        private LottoButton lottoButton1;
        private LottoButton lottoButton2;
        private System.Windows.Forms.Panel panelFilters;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnLastMonth;
        private System.Windows.Forms.Button btnLastYear;
        private System.Windows.Forms.Button btnLastWeek;
        private System.Windows.Forms.Button btnAllDates;
        private System.Windows.Forms.CheckBox cbWednesdays;
        private System.Windows.Forms.CheckBox cbSaturdays;
        private System.Windows.Forms.Panel panelMode;
        private System.Windows.Forms.RadioButton rbDrawDiff;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton rbTotalDraws;
    }
}

