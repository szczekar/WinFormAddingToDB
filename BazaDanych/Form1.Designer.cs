namespace BazaDanych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBaza = new System.Windows.Forms.Button();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.buttonDopiszDoBazy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeleteTable = new System.Windows.Forms.Button();
            this.inputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBaza
            // 
            this.buttonBaza.Location = new System.Drawing.Point(287, 223);
            this.buttonBaza.Name = "buttonBaza";
            this.buttonBaza.Size = new System.Drawing.Size(184, 46);
            this.buttonBaza.TabIndex = 0;
            this.buttonBaza.Text = "Zapisz do bazy 1 usera";
            this.buttonBaza.UseVisualStyleBackColor = true;
            this.buttonBaza.Click += new System.EventHandler(this.buttonBaza_Click);
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Location = new System.Drawing.Point(287, 87);
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(184, 20);
            this.textBoxNewUser.TabIndex = 1;
            // 
            // buttonDopiszDoBazy
            // 
            this.buttonDopiszDoBazy.Location = new System.Drawing.Point(287, 168);
            this.buttonDopiszDoBazy.Name = "buttonDopiszDoBazy";
            this.buttonDopiszDoBazy.Size = new System.Drawing.Size(184, 23);
            this.buttonDopiszDoBazy.TabIndex = 2;
            this.buttonDopiszDoBazy.Text = "Dopisz do bazy ";
            this.buttonDopiszDoBazy.UseVisualStyleBackColor = true;
            this.buttonDopiszDoBazy.Click += new System.EventHandler(this.buttonDopiszDoBazy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wpisz nowego użytkownika do bazy";
            // 
            // buttonDeleteTable
            // 
            this.buttonDeleteTable.Location = new System.Drawing.Point(287, 301);
            this.buttonDeleteTable.Name = "buttonDeleteTable";
            this.buttonDeleteTable.Size = new System.Drawing.Size(184, 43);
            this.buttonDeleteTable.TabIndex = 4;
            this.buttonDeleteTable.Text = "USUŃ DANE Z TABELI";
            this.buttonDeleteTable.UseVisualStyleBackColor = true;
            this.buttonDeleteTable.Click += new System.EventHandler(this.buttonDeleteTable_Click);
            // 
            // inputPassword
            // 
            this.inputPassword.Location = new System.Drawing.Point(287, 131);
            this.inputPassword.Name = "inputPassword";
            this.inputPassword.Size = new System.Drawing.Size(184, 20);
            this.inputPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wpisz hasło";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputPassword);
            this.Controls.Add(this.buttonDeleteTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDopiszDoBazy);
            this.Controls.Add(this.textBoxNewUser);
            this.Controls.Add(this.buttonBaza);
            this.Name = "Form1";
            this.Text = "Zapis do bazy SQL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBaza;
        private System.Windows.Forms.TextBox textBoxNewUser;
        private System.Windows.Forms.Button buttonDopiszDoBazy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeleteTable;
        private System.Windows.Forms.TextBox inputPassword;
        private System.Windows.Forms.Label label2;
    }
}

