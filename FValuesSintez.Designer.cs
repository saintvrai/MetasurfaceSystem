namespace MySystem
{
    partial class FValuesSintez
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtPopulationNumber = new System.Windows.Forms.TextBox();
            txtMutationChance = new System.Windows.Forms.TextBox();
            txtCrossingChance = new System.Windows.Forms.TextBox();
            btnHelp = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(52, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(371, 26);
            label1.TabIndex = 1;
            label1.Text = "Ввод данных о настройках синтеза";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 15);
            label2.TabIndex = 2;
            label2.Text = "Количество поколений:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(129, 15);
            label3.TabIndex = 3;
            label3.Text = "Вероятность мутации:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(32, 151);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(157, 15);
            label4.TabIndex = 4;
            label4.Text = "Вероятность скрещивания:";
            // 
            // txtPopulationNumber
            // 
            txtPopulationNumber.Location = new System.Drawing.Point(195, 64);
            txtPopulationNumber.Name = "txtPopulationNumber";
            txtPopulationNumber.Size = new System.Drawing.Size(100, 23);
            txtPopulationNumber.TabIndex = 6;
            // 
            // txtMutationChance
            // 
            txtMutationChance.Location = new System.Drawing.Point(195, 107);
            txtMutationChance.Name = "txtMutationChance";
            txtMutationChance.Size = new System.Drawing.Size(100, 23);
            txtMutationChance.TabIndex = 7;
            // 
            // txtCrossingChance
            // 
            txtCrossingChance.Location = new System.Drawing.Point(195, 148);
            txtCrossingChance.Name = "txtCrossingChance";
            txtCrossingChance.Size = new System.Drawing.Size(100, 23);
            txtCrossingChance.TabIndex = 8;
            // 
            // btnHelp
            // 
            btnHelp.Location = new System.Drawing.Point(304, 199);
            btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(88, 27);
            btnHelp.TabIndex = 14;
            btnHelp.Text = "Помощь";
            btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(195, 199);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSave.Location = new System.Drawing.Point(86, 199);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(88, 27);
            btnSave.TabIndex = 12;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // FValuesSintez
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(489, 239);
            Controls.Add(btnHelp);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCrossingChance);
            Controls.Add(txtMutationChance);
            Controls.Add(txtPopulationNumber);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FValuesSintez";
            Text = "FValuesSintez";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPopulationNumber;
        private System.Windows.Forms.TextBox txtMutationChance;
        private System.Windows.Forms.TextBox txtCrossingChance;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}