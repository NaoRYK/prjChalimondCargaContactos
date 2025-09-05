namespace prjChalimondRegistroContactos
{
    partial class formCargarContacto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.maskPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblContactName = new System.Windows.Forms.Label();
            this.lblContactPhone = new System.Windows.Forms.Label();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.lblContactList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(99, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cargar Contacto";
            // 
            // maskPhoneNumber
            // 
            this.maskPhoneNumber.Location = new System.Drawing.Point(145, 62);
            this.maskPhoneNumber.Mask = "(351)000-0000";
            this.maskPhoneNumber.Name = "maskPhoneNumber";
            this.maskPhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.maskPhoneNumber.TabIndex = 1;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(21, 62);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.Size = new System.Drawing.Size(118, 20);
            this.txtContactName.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(274, 60);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Grabar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Location = new System.Drawing.Point(27, 49);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(89, 13);
            this.lblContactName.TabIndex = 4;
            this.lblContactName.Text = "Nombre contacto";
            // 
            // lblContactPhone
            // 
            this.lblContactPhone.AutoSize = true;
            this.lblContactPhone.Location = new System.Drawing.Point(152, 49);
            this.lblContactPhone.Name = "lblContactPhone";
            this.lblContactPhone.Size = new System.Drawing.Size(95, 13);
            this.lblContactPhone.TabIndex = 5;
            this.lblContactPhone.Text = "Telefono Contacto";
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(21, 113);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(328, 121);
            this.lstContacts.TabIndex = 6;
            // 
            // lblContactList
            // 
            this.lblContactList.AutoSize = true;
            this.lblContactList.Location = new System.Drawing.Point(18, 97);
            this.lblContactList.Name = "lblContactList";
            this.lblContactList.Size = new System.Drawing.Size(94, 13);
            this.lblContactList.TabIndex = 7;
            this.lblContactList.Text = "Lista de contactos";
            // 
            // formCargarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 276);
            this.Controls.Add(this.lblContactList);
            this.Controls.Add(this.lstContacts);
            this.Controls.Add(this.lblContactPhone);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtContactName);
            this.Controls.Add(this.maskPhoneNumber);
            this.Controls.Add(this.lblTitle);
            this.Name = "formCargarContacto";
            this.Text = "Cargar contactos";
            this.Load += new System.EventHandler(this.formCargarContacto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MaskedTextBox maskPhoneNumber;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.Label lblContactPhone;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Label lblContactList;
    }
}

