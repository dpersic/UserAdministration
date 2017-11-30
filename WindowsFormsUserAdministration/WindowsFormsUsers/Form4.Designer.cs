namespace WindowsFormsUsers
{
    partial class Form4
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddUsername = new System.Windows.Forms.Label();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.inptAddName = new System.Windows.Forms.TextBox();
            this.inptAddSurname = new System.Windows.Forms.TextBox();
            this.inptAddUsername = new System.Windows.Forms.TextBox();
            this.inptAddPassword = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(133, 56);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj Korisnika";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(70, 116);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(24, 13);
            this.lblAddName.TabIndex = 1;
            this.lblAddName.Text = "Ime";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(50, 155);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(44, 13);
            this.lblAddSurname.TabIndex = 2;
            this.lblAddSurname.Text = "Prezime";
            // 
            // lblAddUsername
            // 
            this.lblAddUsername.AutoSize = true;
            this.lblAddUsername.Location = new System.Drawing.Point(19, 189);
            this.lblAddUsername.Name = "lblAddUsername";
            this.lblAddUsername.Size = new System.Drawing.Size(75, 13);
            this.lblAddUsername.TabIndex = 3;
            this.lblAddUsername.Text = "Korisničko ime";
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Location = new System.Drawing.Point(50, 230);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(44, 13);
            this.lblAddPassword.TabIndex = 4;
            this.lblAddPassword.Text = "Lozinka";
            // 
            // inptAddName
            // 
            this.inptAddName.Location = new System.Drawing.Point(100, 116);
            this.inptAddName.Name = "inptAddName";
            this.inptAddName.Size = new System.Drawing.Size(100, 20);
            this.inptAddName.TabIndex = 5;
            // 
            // inptAddSurname
            // 
            this.inptAddSurname.Location = new System.Drawing.Point(100, 152);
            this.inptAddSurname.Name = "inptAddSurname";
            this.inptAddSurname.Size = new System.Drawing.Size(100, 20);
            this.inptAddSurname.TabIndex = 6;
            // 
            // inptAddUsername
            // 
            this.inptAddUsername.Location = new System.Drawing.Point(100, 186);
            this.inptAddUsername.Name = "inptAddUsername";
            this.inptAddUsername.Size = new System.Drawing.Size(100, 20);
            this.inptAddUsername.TabIndex = 7;
            // 
            // inptAddPassword
            // 
            this.inptAddPassword.Location = new System.Drawing.Point(100, 227);
            this.inptAddPassword.Name = "inptAddPassword";
            this.inptAddPassword.Size = new System.Drawing.Size(100, 20);
            this.inptAddPassword.TabIndex = 8;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(156, 282);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(120, 30);
            this.btnADD.TabIndex = 9;
            this.btnADD.Text = "DODAJ";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 352);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.inptAddPassword);
            this.Controls.Add(this.inptAddUsername);
            this.Controls.Add(this.inptAddSurname);
            this.Controls.Add(this.inptAddName);
            this.Controls.Add(this.lblAddPassword);
            this.Controls.Add(this.lblAddUsername);
            this.Controls.Add(this.lblAddSurname);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddUsername;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.TextBox inptAddName;
        private System.Windows.Forms.TextBox inptAddSurname;
        private System.Windows.Forms.TextBox inptAddUsername;
        private System.Windows.Forms.TextBox inptAddPassword;
        private System.Windows.Forms.Button btnADD;
    }
}