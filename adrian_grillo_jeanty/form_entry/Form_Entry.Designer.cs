namespace adrian_grillo_jeanty
{
    partial class Form_Entry
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
            this.comboBox_ticker = new System.Windows.Forms.ComboBox();
            this.comboBox_period = new System.Windows.Forms.ComboBox();
            this.label_ticker = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.button_go = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_ticker
            // 
            this.comboBox_ticker.FormattingEnabled = true;
            this.comboBox_ticker.Items.AddRange(new object[] {
            "IBM",
            "AAJ",
            "AAP",
            "MSFT",
            "AAPL",
            "META",
            "GOOG",
            "NVDA"});
            this.comboBox_ticker.Location = new System.Drawing.Point(71, 229);
            this.comboBox_ticker.Name = "comboBox_ticker";
            this.comboBox_ticker.Size = new System.Drawing.Size(218, 28);
            this.comboBox_ticker.TabIndex = 0;
            this.comboBox_ticker.Text = "IBM";
            this.comboBox_ticker.SelectedIndexChanged += new System.EventHandler(this.ticker_comboBox_SelectedIndexChanged);
            // 
            // comboBox_period
            // 
            this.comboBox_period.FormattingEnabled = true;
            this.comboBox_period.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly"});
            this.comboBox_period.Location = new System.Drawing.Point(71, 300);
            this.comboBox_period.Name = "comboBox_period";
            this.comboBox_period.Size = new System.Drawing.Size(218, 28);
            this.comboBox_period.TabIndex = 4;
            this.comboBox_period.Text = "Week";
            this.comboBox_period.SelectedIndexChanged += new System.EventHandler(this.period_comboBox_SelectedIndexChanged);
            // 
            // label_ticker
            // 
            this.label_ticker.AutoSize = true;
            this.label_ticker.Location = new System.Drawing.Point(67, 206);
            this.label_ticker.Name = "label_ticker";
            this.label_ticker.Size = new System.Drawing.Size(51, 20);
            this.label_ticker.TabIndex = 5;
            this.label_ticker.Text = "Ticker";
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Location = new System.Drawing.Point(67, 277);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(54, 20);
            this.label_period.TabIndex = 6;
            this.label_period.Text = "Period";
            // 
            // button_go
            // 
            this.button_go.Location = new System.Drawing.Point(71, 334);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(110, 42);
            this.button_go.TabIndex = 7;
            this.button_go.Text = "Submit";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_submit);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Stock Files | *.csv | Daily Stocks | *-Day.csv | Weekly Stocks | *-Week.csv |" +
    " Monthly Stocks | *-Month.csv";
            this.openFileDialog.InitialDirectory = "C:\\Users\\grill\\OneDrive\\Desktop\\root\\repos\\adrian_grillo_jeanty";
            this.openFileDialog.Multiselect = true;
            // 
            // openDialog
            // 
            this.openDialog.Location = new System.Drawing.Point(71, 81);
            this.openDialog.Name = "openDialog";
            this.openDialog.Size = new System.Drawing.Size(102, 80);
            this.openDialog.TabIndex = 8;
            this.openDialog.Text = "Open File";
            this.openDialog.UseVisualStyleBackColor = true;
            this.openDialog.Click += new System.EventHandler(this.button_load_stock);
            // 
            // Form_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 617);
            this.Controls.Add(this.openDialog);
            this.Controls.Add(this.button_go);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_ticker);
            this.Controls.Add(this.comboBox_period);
            this.Controls.Add(this.comboBox_ticker);
            this.Name = "Form_Entry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.button_load_stock);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_ticker;
        private System.Windows.Forms.ComboBox comboBox_period;
        private System.Windows.Forms.Label label_ticker;
        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button openDialog;
    }
}

