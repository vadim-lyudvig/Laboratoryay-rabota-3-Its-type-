
namespace СС
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.cmbNumAfter1 = new System.Windows.Forms.ComboBox();
            this.cmbNumAfter2 = new System.Windows.Forms.ComboBox();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResultAfter = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(97, 40);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(146, 23);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(96, 116);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(147, 23);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
            // 
            // cmbNumAfter1
            // 
            this.cmbNumAfter1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumAfter1.FormattingEnabled = true;
            this.cmbNumAfter1.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbNumAfter1.Location = new System.Drawing.Point(291, 40);
            this.cmbNumAfter1.Name = "cmbNumAfter1";
            this.cmbNumAfter1.Size = new System.Drawing.Size(54, 23);
            this.cmbNumAfter1.TabIndex = 2;
            this.cmbNumAfter1.SelectedIndexChanged += new System.EventHandler(this.cmbNumAfter1_SelectedIndexChanged);
            // 
            // cmbNumAfter2
            // 
            this.cmbNumAfter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumAfter2.FormattingEnabled = true;
            this.cmbNumAfter2.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbNumAfter2.Location = new System.Drawing.Point(289, 113);
            this.cmbNumAfter2.Name = "cmbNumAfter2";
            this.cmbNumAfter2.Size = new System.Drawing.Size(56, 23);
            this.cmbNumAfter2.TabIndex = 3;
            this.cmbNumAfter2.SelectedIndexChanged += new System.EventHandler(this.cmbNumAfter2_SelectedIndexChanged);
            // 
            // cmbAction
            // 
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            ">",
            "<",
            "="});
            this.cmbAction.Location = new System.Drawing.Point(146, 84);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(34, 23);
            this.cmbAction.TabIndex = 4;
            this.cmbAction.SelectedIndexChanged += new System.EventHandler(this.cmbAction_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "СС";
            // 
            // cmbResultAfter
            // 
            this.cmbResultAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultAfter.FormattingEnabled = true;
            this.cmbResultAfter.Items.AddRange(new object[] {
            "2",
            "8",
            "10",
            "16"});
            this.cmbResultAfter.Location = new System.Drawing.Point(120, 199);
            this.cmbResultAfter.Name = "cmbResultAfter";
            this.cmbResultAfter.Size = new System.Drawing.Size(82, 23);
            this.cmbResultAfter.TabIndex = 14;
            this.cmbResultAfter.SelectedIndexChanged += new System.EventHandler(this.cmbResultAfter_SelectedIndexChanged);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(96, 239);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(147, 23);
            this.txtResult.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "СС";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Число 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Число 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Показать результат в СС: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Результат:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Оператор:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(269, 199);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 49);
            this.ClearButton.TabIndex = 26;
            this.ClearButton.Text = "Отчистить все";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 273);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.cmbResultAfter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAction);
            this.Controls.Add(this.cmbNumAfter2);
            this.Controls.Add(this.cmbNumAfter1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox cmbNumAfter1;
        private System.Windows.Forms.ComboBox cmbNumAfter2;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbResultAfter;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearButton;
    }
}

