
namespace App_KasirZero
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_KodeKasir = new System.Windows.Forms.TextBox();
            this.txb_PassKasir = new System.Windows.Forms.TextBox();
            this.btn_loginKasir = new System.Windows.Forms.Button();
            this.btn_CancelLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txb_KodeKasir
            // 
            this.txb_KodeKasir.Location = new System.Drawing.Point(156, 112);
            this.txb_KodeKasir.Name = "txb_KodeKasir";
            this.txb_KodeKasir.Size = new System.Drawing.Size(185, 22);
            this.txb_KodeKasir.TabIndex = 2;
            // 
            // txb_PassKasir
            // 
            this.txb_PassKasir.Location = new System.Drawing.Point(156, 146);
            this.txb_PassKasir.Name = "txb_PassKasir";
            this.txb_PassKasir.Size = new System.Drawing.Size(185, 22);
            this.txb_PassKasir.TabIndex = 3;
            // 
            // btn_loginKasir
            // 
            this.btn_loginKasir.Location = new System.Drawing.Point(156, 174);
            this.btn_loginKasir.Name = "btn_loginKasir";
            this.btn_loginKasir.Size = new System.Drawing.Size(82, 47);
            this.btn_loginKasir.TabIndex = 4;
            this.btn_loginKasir.Text = "Login";
            this.btn_loginKasir.UseVisualStyleBackColor = true;
            this.btn_loginKasir.Click += new System.EventHandler(this.btn_loginKasir_Click);
            // 
            // btn_CancelLogin
            // 
            this.btn_CancelLogin.Location = new System.Drawing.Point(258, 174);
            this.btn_CancelLogin.Name = "btn_CancelLogin";
            this.btn_CancelLogin.Size = new System.Drawing.Size(83, 47);
            this.btn_CancelLogin.TabIndex = 5;
            this.btn_CancelLogin.Text = "Cancel";
            this.btn_CancelLogin.UseVisualStyleBackColor = true;
            this.btn_CancelLogin.Click += new System.EventHandler(this.btn_CancelLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 322);
            this.Controls.Add(this.btn_CancelLogin);
            this.Controls.Add(this.btn_loginKasir);
            this.Controls.Add(this.txb_PassKasir);
            this.Controls.Add(this.txb_KodeKasir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_KodeKasir;
        private System.Windows.Forms.TextBox txb_PassKasir;
        private System.Windows.Forms.Button btn_loginKasir;
        private System.Windows.Forms.Button btn_CancelLogin;
    }
}

