namespace Tehcizat
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tehcizatDataSet = new Tehcizat.tehcizatDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newCompany = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEtrafli = new System.Windows.Forms.TextBox();
            this.sourceTableAdapter = new Tehcizat.tehcizatDataSetTableAdapters.sourceTableAdapter();
            this.typeTableAdapter = new Tehcizat.tehcizatDataSetTableAdapters.typeTableAdapter();
            this.companyTableAdapter = new Tehcizat.tehcizatDataSetTableAdapters.companyTableAdapter();
            this.unitTableAdapter = new Tehcizat.tehcizatDataSetTableAdapters.unitTableAdapter();
            this.xariciRadioButton = new System.Windows.Forms.RadioButton();
            this.daxiliRadioButton = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehcizatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mənbə";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sourceBindingSource, "id", true));
            this.comboBox1.DataSource = this.sourceBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(86, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "id";
            // 
            // sourceBindingSource
            // 
            this.sourceBindingSource.DataMember = "source";
            this.sourceBindingSource.DataSource = this.tehcizatDataSet;
            // 
            // tehcizatDataSet
            // 
            this.tehcizatDataSet.DataSetName = "tehcizatDataSet";
            this.tehcizatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.typeBindingSource, "id", true));
            this.comboBox2.DataSource = this.typeBindingSource;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 85);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "id";
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "type";
            this.typeBindingSource.DataSource = this.tehcizatDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şirkət";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.companyBindingSource, "id", true));
            this.comboBox3.DataSource = this.companyBindingSource;
            this.comboBox3.DisplayMember = "name";
            this.comboBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.ValueMember = "id";
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.tehcizatDataSet;
            // 
            // newCompany
            // 
            this.newCompany.Location = new System.Drawing.Point(219, 96);
            this.newCompany.Name = "newCompany";
            this.newCompany.Size = new System.Drawing.Size(57, 50);
            this.newCompany.TabIndex = 6;
            this.newCompany.Text = "Yeni şirkət əlavə et";
            this.newCompany.UseVisualStyleBackColor = true;
            this.newCompany.Click += new System.EventHandler(this.newCompany_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(12, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Miqdarı";
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.unitBindingSource, "id", true));
            this.comboBox4.DataSource = this.unitBindingSource;
            this.comboBox4.DisplayMember = "name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(160, 221);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(47, 21);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.ValueMember = "id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "unit";
            this.unitBindingSource.DataSource = this.tehcizatDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Brown;
            this.label8.Location = new System.Drawing.Point(12, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Məhsul";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(86, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(86, 167);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Yarat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(86, 222);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(68, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Brown;
            this.label9.Location = new System.Drawing.Point(41, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sifarişinizi Daxil Edin!";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Ətraflı";
            // 
            // textBoxEtrafli
            // 
            this.textBoxEtrafli.Location = new System.Drawing.Point(86, 248);
            this.textBoxEtrafli.Multiline = true;
            this.textBoxEtrafli.Name = "textBoxEtrafli";
            this.textBoxEtrafli.Size = new System.Drawing.Size(136, 41);
            this.textBoxEtrafli.TabIndex = 22;
            // 
            // sourceTableAdapter
            // 
            this.sourceTableAdapter.ClearBeforeFill = true;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // xariciRadioButton
            // 
            this.xariciRadioButton.AutoSize = true;
            this.xariciRadioButton.Location = new System.Drawing.Point(45, 295);
            this.xariciRadioButton.Name = "xariciRadioButton";
            this.xariciRadioButton.Size = new System.Drawing.Size(51, 17);
            this.xariciRadioButton.TabIndex = 23;
            this.xariciRadioButton.TabStop = true;
            this.xariciRadioButton.Text = "Xarici";
            this.xariciRadioButton.UseVisualStyleBackColor = true;
            // 
            // daxiliRadioButton
            // 
            this.daxiliRadioButton.AutoSize = true;
            this.daxiliRadioButton.Location = new System.Drawing.Point(120, 295);
            this.daxiliRadioButton.Name = "daxiliRadioButton";
            this.daxiliRadioButton.Size = new System.Drawing.Size(50, 17);
            this.daxiliRadioButton.TabIndex = 24;
            this.daxiliRadioButton.TabStop = true;
            this.daxiliRadioButton.Text = "Daxili";
            this.daxiliRadioButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 50);
            this.button2.TabIndex = 25;
            this.button2.Text = "Şirkətlərin siyahısını təzələ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Form2_Load);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.daxiliRadioButton);
            this.Controls.Add(this.xariciRadioButton);
            this.Controls.Add(this.textBoxEtrafli);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newCompany);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Brown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Sifarişinizi daxil edin";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tehcizatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button newCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEtrafli;
        private tehcizatDataSet tehcizatDataSet;
        private System.Windows.Forms.BindingSource sourceBindingSource;
        private tehcizatDataSetTableAdapters.sourceTableAdapter sourceTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private tehcizatDataSetTableAdapters.typeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private tehcizatDataSetTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private tehcizatDataSetTableAdapters.unitTableAdapter unitTableAdapter;
        private System.Windows.Forms.RadioButton xariciRadioButton;
        private System.Windows.Forms.RadioButton daxiliRadioButton;
        private System.Windows.Forms.Button button2;
    }
}