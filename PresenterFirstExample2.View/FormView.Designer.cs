namespace PresenterFirstExample3.View
{
    partial class FormView
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.smtpTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.formDescription = new System.Windows.Forms.Label();
            this.validationErrors = new System.Windows.Forms.ListBox();
            this.commentsTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendingErrors = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "first name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(80, 75);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(317, 75);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(126, 20);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "last name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(59, 273);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(126, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "email";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(165, 503);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // smtpTextBox
            // 
            this.smtpTextBox.Location = new System.Drawing.Point(317, 270);
            this.smtpTextBox.Name = "smtpTextBox";
            this.smtpTextBox.Size = new System.Drawing.Size(126, 20);
            this.smtpTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "smtp relay server";
            // 
            // formDescription
            // 
            this.formDescription.AutoSize = true;
            this.formDescription.Location = new System.Drawing.Point(12, 16);
            this.formDescription.Name = "formDescription";
            this.formDescription.Size = new System.Drawing.Size(479, 13);
            this.formDescription.TabIndex = 11;
            this.formDescription.Text = "This is a form for demonstration purpose only with simple validation and without " +
    "proper error handling ";
            // 
            // validationErrors
            // 
            this.validationErrors.FormattingEnabled = true;
            this.validationErrors.Location = new System.Drawing.Point(25, 364);
            this.validationErrors.Name = "validationErrors";
            this.validationErrors.Size = new System.Drawing.Size(215, 108);
            this.validationErrors.TabIndex = 13;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(80, 116);
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.Size = new System.Drawing.Size(363, 96);
            this.commentsTextBox.TabIndex = 14;
            this.commentsTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "comments";
            // 
            // sendingErrors
            // 
            this.sendingErrors.Location = new System.Drawing.Point(246, 364);
            this.sendingErrors.Name = "sendingErrors";
            this.sendingErrors.Size = new System.Drawing.Size(231, 108);
            this.sendingErrors.TabIndex = 16;
            this.sendingErrors.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "validation errors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "sending errors";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sendingErrors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.validationErrors);
            this.Controls.Add(this.formDescription);
            this.Controls.Add(this.smtpTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormView";
            this.Text = "MVP Presenter First Example number 3";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox smtpTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label formDescription;
        private System.Windows.Forms.ListBox validationErrors;
        private System.Windows.Forms.RichTextBox commentsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox sendingErrors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

