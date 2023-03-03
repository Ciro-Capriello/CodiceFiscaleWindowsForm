namespace CodiceFiscaleWindowsForm
{
    partial class Form1
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
            this.tbx_Name = new System.Windows.Forms.TextBox();
            this.tbx_Surname = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.picker_BirthDate = new System.Windows.Forms.DateTimePicker();
            this.CBox_Municipality = new System.Windows.Forms.ComboBox();
            this.Btn_Male = new System.Windows.Forms.RadioButton();
            this.btn_Female = new System.Windows.Forms.RadioButton();
            this.btn_GenerateCF = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.TextBox();
            this.lbl_CF = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbx_Name
            // 
            this.tbx_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Name.Location = new System.Drawing.Point(78, 90);
            this.tbx_Name.Name = "tbx_Name";
            this.tbx_Name.Size = new System.Drawing.Size(341, 34);
            this.tbx_Name.TabIndex = 0;
            // 
            // tbx_Surname
            // 
            this.tbx_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Surname.Location = new System.Drawing.Point(78, 183);
            this.tbx_Surname.Name = "tbx_Surname";
            this.tbx_Surname.Size = new System.Drawing.Size(175, 34);
            this.tbx_Surname.TabIndex = 12;
            this.tbx_Surname.TextChanged += new System.EventHandler(this.tbx_Surname_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(73, 43);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(79, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Nome";
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Surname.Location = new System.Drawing.Point(73, 140);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(119, 29);
            this.lbl_Surname.TabIndex = 3;
            this.lbl_Surname.Text = "Cognome";
            // 
            // picker_BirthDate
            // 
            this.picker_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picker_BirthDate.Location = new System.Drawing.Point(78, 284);
            this.picker_BirthDate.Name = "picker_BirthDate";
            this.picker_BirthDate.Size = new System.Drawing.Size(227, 39);
            this.picker_BirthDate.TabIndex = 4;
            // 
            // CBox_Municipality
            // 
            this.CBox_Municipality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox_Municipality.FormattingEnabled = true;
            this.CBox_Municipality.Location = new System.Drawing.Point(78, 499);
            this.CBox_Municipality.Name = "CBox_Municipality";
            this.CBox_Municipality.Size = new System.Drawing.Size(291, 37);
            this.CBox_Municipality.TabIndex = 5;
            // 
            // Btn_Male
            // 
            this.Btn_Male.AutoSize = true;
            this.Btn_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Male.Location = new System.Drawing.Point(78, 385);
            this.Btn_Male.Name = "Btn_Male";
            this.Btn_Male.Size = new System.Drawing.Size(128, 33);
            this.Btn_Male.TabIndex = 6;
            this.Btn_Male.TabStop = true;
            this.Btn_Male.Text = "Maschio";
            this.Btn_Male.UseVisualStyleBackColor = true;
            // 
            // btn_Female
            // 
            this.btn_Female.AutoSize = true;
            this.btn_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Female.Location = new System.Drawing.Point(78, 435);
            this.btn_Female.Name = "btn_Female";
            this.btn_Female.Size = new System.Drawing.Size(139, 33);
            this.btn_Female.TabIndex = 7;
            this.btn_Female.TabStop = true;
            this.btn_Female.Text = "Femmina";
            this.btn_Female.UseVisualStyleBackColor = true;
            // 
            // btn_GenerateCF
            // 
            this.btn_GenerateCF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateCF.Location = new System.Drawing.Point(466, 587);
            this.btn_GenerateCF.Name = "btn_GenerateCF";
            this.btn_GenerateCF.Size = new System.Drawing.Size(384, 86);
            this.btn_GenerateCF.TabIndex = 8;
            this.btn_GenerateCF.Text = "Genera Codice Fiscale";
            this.btn_GenerateCF.UseVisualStyleBackColor = true;
            this.btn_GenerateCF.Click += new System.EventHandler(this.btn_GenerateCF_Click);
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.S.Location = new System.Drawing.Point(717, 353);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(458, 34);
            this.S.TabIndex = 9;
            // 
            // lbl_CF
            // 
            this.lbl_CF.AutoSize = true;
            this.lbl_CF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CF.Location = new System.Drawing.Point(712, 307);
            this.lbl_CF.Name = "lbl_CF";
            this.lbl_CF.Size = new System.Drawing.Size(174, 29);
            this.lbl_CF.TabIndex = 10;
            this.lbl_CF.Text = "Codice Fiscale";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.AutoSize = true;
            this.lbl_BirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BirthDate.Location = new System.Drawing.Point(73, 252);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(174, 29);
            this.lbl_BirthDate.TabIndex = 11;
            this.lbl_BirthDate.Text = "Data di Nascita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 846);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.lbl_CF);
            this.Controls.Add(this.S);
            this.Controls.Add(this.btn_GenerateCF);
            this.Controls.Add(this.btn_Female);
            this.Controls.Add(this.Btn_Male);
            this.Controls.Add(this.CBox_Municipality);
            this.Controls.Add(this.picker_BirthDate);
            this.Controls.Add(this.lbl_Surname);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tbx_Surname);
            this.Controls.Add(this.tbx_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Name;
        private System.Windows.Forms.TextBox tbx_Surname;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.DateTimePicker picker_BirthDate;
        private System.Windows.Forms.ComboBox CBox_Municipality;
        private System.Windows.Forms.RadioButton Btn_Male;
        private System.Windows.Forms.RadioButton btn_Female;
        private System.Windows.Forms.Button btn_GenerateCF;
        private System.Windows.Forms.TextBox S;
        private System.Windows.Forms.Label lbl_CF;
        private System.Windows.Forms.Label lbl_BirthDate;
    }
}

