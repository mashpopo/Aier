namespace Aier
{
    partial class ConfigParameter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cb1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_Optmize = new System.Windows.Forms.Button();
            this.btn_Test = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.textBox_scope1 = new System.Windows.Forms.TextBox();
            this.textBox_Interval = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cb = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.config = new System.Windows.Forms.Label();
            this.testlibrary = new System.Windows.Forms.Label();
            this.testscope = new System.Windows.Forms.Label();
            this.interval = new System.Windows.Forms.Label();
            this.textBox_scope2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb1});
            this.dataGridView1.Location = new System.Drawing.Point(68, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(653, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb1
            // 
            this.cb1.HeaderText = "";
            this.cb1.Name = "cb1";
            // 
            // btn_Optmize
            // 
            this.btn_Optmize.Location = new System.Drawing.Point(102, 400);
            this.btn_Optmize.Name = "btn_Optmize";
            this.btn_Optmize.Size = new System.Drawing.Size(125, 38);
            this.btn_Optmize.TabIndex = 1;
            this.btn_Optmize.Text = "Optmize";
            this.btn_Optmize.UseVisualStyleBackColor = true;
            this.btn_Optmize.Click += new System.EventHandler(this.btn_Optmize_Click);
            // 
            // btn_Test
            // 
            this.btn_Test.Location = new System.Drawing.Point(334, 400);
            this.btn_Test.Name = "btn_Test";
            this.btn_Test.Size = new System.Drawing.Size(122, 38);
            this.btn_Test.TabIndex = 2;
            this.btn_Test.Text = "Run Test";
            this.btn_Test.UseVisualStyleBackColor = true;
            this.btn_Test.Click += new System.EventHandler(this.btn_Test_Click);
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(585, 403);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(114, 35);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "change";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // textBox_scope1
            // 
            this.textBox_scope1.Location = new System.Drawing.Point(166, 213);
            this.textBox_scope1.Name = "textBox_scope1";
            this.textBox_scope1.Size = new System.Drawing.Size(31, 20);
            this.textBox_scope1.TabIndex = 4;
            this.textBox_scope1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_Interval
            // 
            this.textBox_Interval.Location = new System.Drawing.Point(500, 213);
            this.textBox_Interval.Name = "textBox_Interval";
            this.textBox_Interval.Size = new System.Drawing.Size(139, 20);
            this.textBox_Interval.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cb});
            this.dataGridView2.Location = new System.Drawing.Point(68, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 111);
            this.dataGridView2.TabIndex = 6;
            // 
            // cb
            // 
            this.cb.HeaderText = "";
            this.cb.Name = "cb";
            // 
            // config
            // 
            this.config.AutoSize = true;
            this.config.Location = new System.Drawing.Point(73, 23);
            this.config.Name = "config";
            this.config.Size = new System.Drawing.Size(69, 13);
            this.config.TabIndex = 7;
            this.config.Text = "Configuration";
            this.config.Click += new System.EventHandler(this.config_Click);
            // 
            // testlibrary
            // 
            this.testlibrary.AutoSize = true;
            this.testlibrary.Location = new System.Drawing.Point(80, 260);
            this.testlibrary.Name = "testlibrary";
            this.testlibrary.Size = new System.Drawing.Size(62, 13);
            this.testlibrary.TabIndex = 8;
            this.testlibrary.Text = "Test Library";
            // 
            // testscope
            // 
            this.testscope.AutoSize = true;
            this.testscope.Location = new System.Drawing.Point(95, 218);
            this.testscope.Name = "testscope";
            this.testscope.Size = new System.Drawing.Size(65, 13);
            this.testscope.TabIndex = 9;
            this.testscope.Text = "Test_Scope";
            // 
            // interval
            // 
            this.interval.AutoSize = true;
            this.interval.Location = new System.Drawing.Point(416, 216);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(78, 13);
            this.interval.TabIndex = 10;
            this.interval.Text = "Interval Setting";
            // 
            // textBox_scope2
            // 
            this.textBox_scope2.Location = new System.Drawing.Point(212, 213);
            this.textBox_scope2.Name = "textBox_scope2";
            this.textBox_scope2.Size = new System.Drawing.Size(31, 20);
            this.textBox_scope2.TabIndex = 11;
            this.textBox_scope2.TextChanged += new System.EventHandler(this.textBox_scope2_TextChanged);
            // 
            // ConfigParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_scope2);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.testscope);
            this.Controls.Add(this.testlibrary);
            this.Controls.Add(this.config);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox_Interval);
            this.Controls.Add(this.textBox_scope1);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_Test);
            this.Controls.Add(this.btn_Optmize);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConfigParameter";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.ConfigParameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Optmize;
        private System.Windows.Forms.Button btn_Test;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.TextBox textBox_scope1;
        private System.Windows.Forms.TextBox textBox_Interval;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label config;
        private System.Windows.Forms.Label testlibrary;
        private System.Windows.Forms.Label testscope;
        private System.Windows.Forms.Label interval;
        private System.Windows.Forms.TextBox textBox_scope2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cb1;
    }
}

