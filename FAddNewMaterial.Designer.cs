namespace MySystem
{
    partial class FAddNewMaterial
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnHelp = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            tabPage1 = new System.Windows.Forms.TabPage();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtMaterialName = new System.Windows.Forms.TextBox();
            txtMaterialType = new System.Windows.Forms.TextBox();
            txtElectricConductivity = new System.Windows.Forms.TextBox();
            txtMagneticConductivity = new System.Windows.Forms.TextBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            trackBar1 = new System.Windows.Forms.TrackBar();
            label7 = new System.Windows.Forms.Label();
            txtMaterialColor = new System.Windows.Forms.Button();
            label11 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            groupBox1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnHelp);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new System.Drawing.Point(14, 14);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox1.Size = new System.Drawing.Size(552, 608);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Основные настройки";
            // 
            // btnHelp
            // 
            btnHelp.Location = new System.Drawing.Point(438, 567);
            btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(88, 27);
            btnHelp.TabIndex = 5;
            btnHelp.Text = "Помощь";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(329, 567);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(220, 567);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.Color = System.Drawing.Color.Yellow;
            colorDialog1.FullOpen = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(502, 484);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Основные";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtMagneticConductivity);
            groupBox2.Controls.Add(txtElectricConductivity);
            groupBox2.Controls.Add(txtMaterialType);
            groupBox2.Controls.Add(txtMaterialName);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new System.Drawing.Point(7, 7);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox2.Size = new System.Drawing.Size(486, 180);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Основные настройки";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(258, 98);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(160, 15);
            label4.TabIndex = 5;
            label4.Text = "Магнитная проницаемость:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(20, 98);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(182, 15);
            label3.TabIndex = 4;
            label3.Text = "Электрическая проницаемость:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(258, 23);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Тип:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 23);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 15);
            label1.TabIndex = 2;
            label1.Text = "Название материала:";
            // 
            // txtMaterialName
            // 
            txtMaterialName.Location = new System.Drawing.Point(20, 57);
            txtMaterialName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMaterialName.Name = "txtMaterialName";
            txtMaterialName.Size = new System.Drawing.Size(116, 23);
            txtMaterialName.TabIndex = 8;
            // 
            // txtMaterialType
            // 
            txtMaterialType.Location = new System.Drawing.Point(258, 57);
            txtMaterialType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMaterialType.Name = "txtMaterialType";
            txtMaterialType.Size = new System.Drawing.Size(116, 23);
            txtMaterialType.TabIndex = 9;
            // 
            // txtElectricConductivity
            // 
            txtElectricConductivity.Location = new System.Drawing.Point(20, 132);
            txtElectricConductivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtElectricConductivity.Name = "txtElectricConductivity";
            txtElectricConductivity.Size = new System.Drawing.Size(116, 23);
            txtElectricConductivity.TabIndex = 10;
            // 
            // txtMagneticConductivity
            // 
            txtMagneticConductivity.Location = new System.Drawing.Point(258, 132);
            txtMagneticConductivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMagneticConductivity.Name = "txtMagneticConductivity";
            txtMagneticConductivity.Size = new System.Drawing.Size(116, 23);
            txtMagneticConductivity.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(txtMaterialColor);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(trackBar1);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new System.Drawing.Point(8, 194);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBox3.Size = new System.Drawing.Size(485, 155);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Цвет";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(250, 47);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(23, 15);
            label6.TabIndex = 7;
            label6.Text = "0%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(278, 18);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(89, 15);
            label5.TabIndex = 6;
            label5.Text = "Прозрачность:";
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(281, 47);
            trackBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            trackBar1.Maximum = 100;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(147, 45);
            trackBar1.TabIndex = 8;
            trackBar1.TickFrequency = 10;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(435, 47);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 15);
            label7.TabIndex = 9;
            label7.Text = "100%";
            // 
            // txtMaterialColor
            // 
            txtMaterialColor.Location = new System.Drawing.Point(24, 32);
            txtMaterialColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMaterialColor.Name = "txtMaterialColor";
            txtMaterialColor.Size = new System.Drawing.Size(113, 27);
            txtMaterialColor.TabIndex = 10;
            txtMaterialColor.UseVisualStyleBackColor = true;
            txtMaterialColor.Click += button1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(332, 107);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(0, 15);
            label11.TabIndex = 11;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new System.Drawing.Point(21, 30);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(510, 512);
            tabControl1.TabIndex = 2;
            // 
            // FAddNewMaterial
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(576, 636);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FAddNewMaterial";
            Text = "Добавление нового материала";
            groupBox1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button txtMaterialColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMagneticConductivity;
        private System.Windows.Forms.TextBox txtElectricConductivity;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}