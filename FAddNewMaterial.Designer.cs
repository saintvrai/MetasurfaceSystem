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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaterialColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMagneticConductivity = new System.Windows.Forms.TextBox();
            this.txtElectricConductivity = new System.Windows.Forms.TextBox();
            this.txtMaterialType = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaterialHeatCapacity = new System.Windows.Forms.TextBox();
            this.txtMaterialThermalConductivity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMaterialThermalExpansionCoefficient = new System.Windows.Forms.TextBox();
            this.txtMaterialPoissonRatio = new System.Windows.Forms.TextBox();
            this.txtMaterialYoungModulus = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtMaterialRho = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHelp);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основные настройки";
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(375, 491);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 23);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(189, 491);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(18, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 444);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(429, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtMaterialColor);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.trackBar1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(7, 168);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 134);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(285, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 11;
            // 
            // txtMaterialColor
            // 
            this.txtMaterialColor.Location = new System.Drawing.Point(21, 28);
            this.txtMaterialColor.Name = "txtMaterialColor";
            this.txtMaterialColor.Size = new System.Drawing.Size(97, 23);
            this.txtMaterialColor.TabIndex = 10;
            this.txtMaterialColor.UseVisualStyleBackColor = true;
            this.txtMaterialColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "100%";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(241, 41);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(126, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Прозрачность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "0%";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMagneticConductivity);
            this.groupBox2.Controls.Add(this.txtElectricConductivity);
            this.groupBox2.Controls.Add(this.txtMaterialType);
            this.groupBox2.Controls.Add(this.txtMaterialName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Основные настройки";
            // 
            // txtMagneticConductivity
            // 
            this.txtMagneticConductivity.Location = new System.Drawing.Point(221, 114);
            this.txtMagneticConductivity.Name = "txtMagneticConductivity";
            this.txtMagneticConductivity.Size = new System.Drawing.Size(100, 20);
            this.txtMagneticConductivity.TabIndex = 11;
            // 
            // txtElectricConductivity
            // 
            this.txtElectricConductivity.Location = new System.Drawing.Point(17, 114);
            this.txtElectricConductivity.Name = "txtElectricConductivity";
            this.txtElectricConductivity.Size = new System.Drawing.Size(100, 20);
            this.txtElectricConductivity.TabIndex = 10;
            // 
            // txtMaterialType
            // 
            this.txtMaterialType.Location = new System.Drawing.Point(221, 49);
            this.txtMaterialType.Name = "txtMaterialType";
            this.txtMaterialType.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialType.TabIndex = 9;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.Location = new System.Drawing.Point(17, 49);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название материала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Электрическая проницаемость:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Магнитная проницаемость:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(429, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Тепловые";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Используйте эти настройки для теплового анализа";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaterialHeatCapacity);
            this.groupBox4.Controls.Add(this.txtMaterialThermalConductivity);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 84);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Тепловые настройки";
            // 
            // txtMaterialHeatCapacity
            // 
            this.txtMaterialHeatCapacity.Location = new System.Drawing.Point(221, 49);
            this.txtMaterialHeatCapacity.Name = "txtMaterialHeatCapacity";
            this.txtMaterialHeatCapacity.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialHeatCapacity.TabIndex = 9;
            // 
            // txtMaterialThermalConductivity
            // 
            this.txtMaterialThermalConductivity.Location = new System.Drawing.Point(17, 49);
            this.txtMaterialThermalConductivity.Name = "txtMaterialThermalConductivity";
            this.txtMaterialThermalConductivity.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialThermalConductivity.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Теплопроводность:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(221, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Теплоёмкость:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(429, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Механические";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMaterialThermalExpansionCoefficient);
            this.groupBox5.Controls.Add(this.txtMaterialPoissonRatio);
            this.groupBox5.Controls.Add(this.txtMaterialYoungModulus);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Location = new System.Drawing.Point(6, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 222);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Механические настройки";
            // 
            // txtMaterialThermalExpansionCoefficient
            // 
            this.txtMaterialThermalExpansionCoefficient.Location = new System.Drawing.Point(17, 90);
            this.txtMaterialThermalExpansionCoefficient.Name = "txtMaterialThermalExpansionCoefficient";
            this.txtMaterialThermalExpansionCoefficient.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialThermalExpansionCoefficient.TabIndex = 10;
            // 
            // txtMaterialPoissonRatio
            // 
            this.txtMaterialPoissonRatio.Location = new System.Drawing.Point(17, 139);
            this.txtMaterialPoissonRatio.Name = "txtMaterialPoissonRatio";
            this.txtMaterialPoissonRatio.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialPoissonRatio.TabIndex = 9;
            // 
            // txtMaterialYoungModulus
            // 
            this.txtMaterialYoungModulus.Location = new System.Drawing.Point(17, 41);
            this.txtMaterialYoungModulus.Name = "txtMaterialYoungModulus";
            this.txtMaterialYoungModulus.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialYoungModulus.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Модуль Юнга:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Коэффициент Пуассона:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(17, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Коэффициент теплового расширения:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(429, 418);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Плотность";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtMaterialRho);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(6, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(417, 82);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Настройки плотности";
            // 
            // txtMaterialRho
            // 
            this.txtMaterialRho.Location = new System.Drawing.Point(20, 36);
            this.txtMaterialRho.Name = "txtMaterialRho";
            this.txtMaterialRho.Size = new System.Drawing.Size(100, 20);
            this.txtMaterialRho.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Весовая плотность материала:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.Color = System.Drawing.Color.Yellow;
            this.colorDialog1.FullOpen = true;
            // 
            // FAddNewMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 551);
            this.Controls.Add(this.groupBox1);
            this.Name = "FAddNewMaterial";
            this.Text = "Добавление нового материала";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txtMagneticConductivity;
        private System.Windows.Forms.TextBox txtElectricConductivity;
        private System.Windows.Forms.TextBox txtMaterialType;
        private System.Windows.Forms.TextBox txtMaterialName;
        private System.Windows.Forms.Button txtMaterialColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaterialHeatCapacity;
        private System.Windows.Forms.TextBox txtMaterialThermalConductivity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMaterialThermalExpansionCoefficient;
        private System.Windows.Forms.TextBox txtMaterialPoissonRatio;
        private System.Windows.Forms.TextBox txtMaterialYoungModulus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtMaterialRho;
        private System.Windows.Forms.Label label9;
    }
}