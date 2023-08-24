
namespace App_KasirZero
{
    partial class FormMasterKasir
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_KdKasir_FKasir = new System.Windows.Forms.TextBox();
            this.textBox_nmKasir_FKasir = new System.Windows.Forms.TextBox();
            this.textBox_PwdKasir_FKasir = new System.Windows.Forms.TextBox();
            this.comboBox_LvlKasir_FormKasir = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_tutup_formKasir = new System.Windows.Forms.Button();
            this.btn_hapus_formKasir = new System.Windows.Forms.Button();
            this.btn_edit_formKasir = new System.Windows.Forms.Button();
            this.btn_input_formKasir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kode Kasir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Kasir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password Kasir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Level Kasir";
            // 
            // textBox_KdKasir_FKasir
            // 
            this.textBox_KdKasir_FKasir.Location = new System.Drawing.Point(158, 44);
            this.textBox_KdKasir_FKasir.Name = "textBox_KdKasir_FKasir";
            this.textBox_KdKasir_FKasir.Size = new System.Drawing.Size(206, 22);
            this.textBox_KdKasir_FKasir.TabIndex = 4;
            this.textBox_KdKasir_FKasir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KdKasir_FKasir_KeyPress);
            // 
            // textBox_nmKasir_FKasir
            // 
            this.textBox_nmKasir_FKasir.Location = new System.Drawing.Point(158, 76);
            this.textBox_nmKasir_FKasir.Name = "textBox_nmKasir_FKasir";
            this.textBox_nmKasir_FKasir.Size = new System.Drawing.Size(292, 22);
            this.textBox_nmKasir_FKasir.TabIndex = 5;
            // 
            // textBox_PwdKasir_FKasir
            // 
            this.textBox_PwdKasir_FKasir.Location = new System.Drawing.Point(158, 108);
            this.textBox_PwdKasir_FKasir.Name = "textBox_PwdKasir_FKasir";
            this.textBox_PwdKasir_FKasir.Size = new System.Drawing.Size(206, 22);
            this.textBox_PwdKasir_FKasir.TabIndex = 6;
            // 
            // comboBox_LvlKasir_FormKasir
            // 
            this.comboBox_LvlKasir_FormKasir.FormattingEnabled = true;
            this.comboBox_LvlKasir_FormKasir.Location = new System.Drawing.Point(158, 139);
            this.comboBox_LvlKasir_FormKasir.Name = "comboBox_LvlKasir_FormKasir";
            this.comboBox_LvlKasir_FormKasir.Size = new System.Drawing.Size(137, 24);
            this.comboBox_LvlKasir_FormKasir.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tutup_formKasir);
            this.groupBox1.Controls.Add(this.btn_hapus_formKasir);
            this.groupBox1.Controls.Add(this.btn_edit_formKasir);
            this.groupBox1.Controls.Add(this.btn_input_formKasir);
            this.groupBox1.Location = new System.Drawing.Point(50, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proses";
            // 
            // btn_tutup_formKasir
            // 
            this.btn_tutup_formKasir.Location = new System.Drawing.Point(351, 21);
            this.btn_tutup_formKasir.Name = "btn_tutup_formKasir";
            this.btn_tutup_formKasir.Size = new System.Drawing.Size(109, 50);
            this.btn_tutup_formKasir.TabIndex = 12;
            this.btn_tutup_formKasir.Text = "TUTUP";
            this.btn_tutup_formKasir.UseVisualStyleBackColor = true;
            this.btn_tutup_formKasir.Click += new System.EventHandler(this.btn_tutup_formKasir_Click);
            // 
            // btn_hapus_formKasir
            // 
            this.btn_hapus_formKasir.Location = new System.Drawing.Point(236, 21);
            this.btn_hapus_formKasir.Name = "btn_hapus_formKasir";
            this.btn_hapus_formKasir.Size = new System.Drawing.Size(109, 50);
            this.btn_hapus_formKasir.TabIndex = 11;
            this.btn_hapus_formKasir.Text = "HAPUS";
            this.btn_hapus_formKasir.UseVisualStyleBackColor = true;
            this.btn_hapus_formKasir.Click += new System.EventHandler(this.btn_hapus_formKasir_Click);
            // 
            // btn_edit_formKasir
            // 
            this.btn_edit_formKasir.Location = new System.Drawing.Point(121, 21);
            this.btn_edit_formKasir.Name = "btn_edit_formKasir";
            this.btn_edit_formKasir.Size = new System.Drawing.Size(109, 50);
            this.btn_edit_formKasir.TabIndex = 10;
            this.btn_edit_formKasir.Text = "EDIT";
            this.btn_edit_formKasir.UseVisualStyleBackColor = true;
            this.btn_edit_formKasir.Click += new System.EventHandler(this.btn_edit_formKasir_Click);
            // 
            // btn_input_formKasir
            // 
            this.btn_input_formKasir.Location = new System.Drawing.Point(6, 21);
            this.btn_input_formKasir.Name = "btn_input_formKasir";
            this.btn_input_formKasir.Size = new System.Drawing.Size(109, 50);
            this.btn_input_formKasir.TabIndex = 9;
            this.btn_input_formKasir.Text = "INPUT";
            this.btn_input_formKasir.UseVisualStyleBackColor = true;
            this.btn_input_formKasir.Click += new System.EventHandler(this.btn_input_formKasir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 242);
            this.dataGridView1.TabIndex = 9;
            // 
            // FormMasterKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 524);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_LvlKasir_FormKasir);
            this.Controls.Add(this.textBox_PwdKasir_FKasir);
            this.Controls.Add(this.textBox_nmKasir_FKasir);
            this.Controls.Add(this.textBox_KdKasir_FKasir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterKasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKasir";
            this.Load += new System.EventHandler(this.FormMasterKasir_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_KdKasir_FKasir;
        private System.Windows.Forms.TextBox textBox_nmKasir_FKasir;
        private System.Windows.Forms.TextBox textBox_PwdKasir_FKasir;
        private System.Windows.Forms.ComboBox comboBox_LvlKasir_FormKasir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tutup_formKasir;
        private System.Windows.Forms.Button btn_hapus_formKasir;
        private System.Windows.Forms.Button btn_edit_formKasir;
        private System.Windows.Forms.Button btn_input_formKasir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}