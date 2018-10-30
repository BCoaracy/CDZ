namespace CDZ
{
    partial class EditaEstrelas
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
            this.btnGerarRel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.relatorios = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConstelacao = new System.Windows.Forms.ComboBox();
            this.grpEdiEstrelas = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAglo = new System.Windows.Forms.TextBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.txtMag = new System.Windows.Forms.TextBox();
            this.txtCons = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstrelaEdit = new System.Windows.Forms.ComboBox();
            this.lblConst = new System.Windows.Forms.Label();
            this.cmbConstEdit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbRelatorio = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.relatorios.SuspendLayout();
            this.grpEdiEstrelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarRel
            // 
            this.btnGerarRel.Location = new System.Drawing.Point(184, 62);
            this.btnGerarRel.Name = "btnGerarRel";
            this.btnGerarRel.Size = new System.Drawing.Size(122, 23);
            this.btnGerarRel.TabIndex = 0;
            this.btnGerarRel.Text = "Gerar Relatório";
            this.btnGerarRel.UseVisualStyleBackColor = true;
            this.btnGerarRel.Click += new System.EventHandler(this.btnGerarRel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(842, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // relatorios
            // 
            this.relatorios.Controls.Add(this.label1);
            this.relatorios.Controls.Add(this.cmbConstelacao);
            this.relatorios.Controls.Add(this.btnGerarRel);
            this.relatorios.Location = new System.Drawing.Point(35, 12);
            this.relatorios.Name = "relatorios";
            this.relatorios.Size = new System.Drawing.Size(325, 114);
            this.relatorios.TabIndex = 3;
            this.relatorios.TabStop = false;
            this.relatorios.Text = "Relatório por constelação";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha a constelação";
            // 
            // cmbConstelacao
            // 
            this.cmbConstelacao.FormattingEnabled = true;
            this.cmbConstelacao.Location = new System.Drawing.Point(6, 62);
            this.cmbConstelacao.Name = "cmbConstelacao";
            this.cmbConstelacao.Size = new System.Drawing.Size(147, 24);
            this.cmbConstelacao.TabIndex = 1;
            // 
            // grpEdiEstrelas
            // 
            this.grpEdiEstrelas.Controls.Add(this.label7);
            this.grpEdiEstrelas.Controls.Add(this.label6);
            this.grpEdiEstrelas.Controls.Add(this.label5);
            this.grpEdiEstrelas.Controls.Add(this.label4);
            this.grpEdiEstrelas.Controls.Add(this.txtAglo);
            this.grpEdiEstrelas.Controls.Add(this.txtDist);
            this.grpEdiEstrelas.Controls.Add(this.txtMag);
            this.grpEdiEstrelas.Controls.Add(this.txtCons);
            this.grpEdiEstrelas.Controls.Add(this.txtNome);
            this.grpEdiEstrelas.Controls.Add(this.label3);
            this.grpEdiEstrelas.Controls.Add(this.cmbEstrelaEdit);
            this.grpEdiEstrelas.Controls.Add(this.lblConst);
            this.grpEdiEstrelas.Controls.Add(this.cmbConstEdit);
            this.grpEdiEstrelas.Controls.Add(this.label2);
            this.grpEdiEstrelas.Location = new System.Drawing.Point(550, 12);
            this.grpEdiEstrelas.Name = "grpEdiEstrelas";
            this.grpEdiEstrelas.Size = new System.Drawing.Size(367, 355);
            this.grpEdiEstrelas.TabIndex = 4;
            this.grpEdiEstrelas.TabStop = false;
            this.grpEdiEstrelas.Text = "Edição de Estrela";
            this.grpEdiEstrelas.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Aglomerado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Distancia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Magnitude:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Constelação:";
            // 
            // txtAglo
            // 
            this.txtAglo.Location = new System.Drawing.Point(196, 261);
            this.txtAglo.Name = "txtAglo";
            this.txtAglo.Size = new System.Drawing.Size(147, 22);
            this.txtAglo.TabIndex = 14;
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(196, 224);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(147, 22);
            this.txtDist.TabIndex = 13;
            // 
            // txtMag
            // 
            this.txtMag.Location = new System.Drawing.Point(196, 187);
            this.txtMag.Name = "txtMag";
            this.txtMag.Size = new System.Drawing.Size(147, 22);
            this.txtMag.TabIndex = 12;
            // 
            // txtCons
            // 
            this.txtCons.Location = new System.Drawing.Point(196, 151);
            this.txtCons.Name = "txtCons";
            this.txtCons.Size = new System.Drawing.Size(147, 22);
            this.txtCons.TabIndex = 11;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(196, 114);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 22);
            this.txtNome.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Escolha a estrela";
            // 
            // cmbEstrelaEdit
            // 
            this.cmbEstrelaEdit.FormattingEnabled = true;
            this.cmbEstrelaEdit.Location = new System.Drawing.Point(196, 79);
            this.cmbEstrelaEdit.Name = "cmbEstrelaEdit";
            this.cmbEstrelaEdit.Size = new System.Drawing.Size(147, 24);
            this.cmbEstrelaEdit.TabIndex = 8;
            this.cmbEstrelaEdit.SelectionChangeCommitted += new System.EventHandler(this.cmbConstEdit_SelectionChangeCommitted);
            // 
            // lblConst
            // 
            this.lblConst.AutoSize = true;
            this.lblConst.Location = new System.Drawing.Point(25, 41);
            this.lblConst.Name = "lblConst";
            this.lblConst.Size = new System.Drawing.Size(150, 17);
            this.lblConst.TabIndex = 7;
            this.lblConst.Text = "Escolha a constelação";
            // 
            // cmbConstEdit
            // 
            this.cmbConstEdit.FormattingEnabled = true;
            this.cmbConstEdit.Location = new System.Drawing.Point(196, 38);
            this.cmbConstEdit.Name = "cmbConstEdit";
            this.cmbConstEdit.Size = new System.Drawing.Size(147, 24);
            this.cmbConstEdit.TabIndex = 6;
            this.cmbConstEdit.SelectedIndexChanged += new System.EventHandler(this.cmbConstEdit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // rtbRelatorio
            // 
            this.rtbRelatorio.Location = new System.Drawing.Point(35, 139);
            this.rtbRelatorio.Name = "rtbRelatorio";
            this.rtbRelatorio.Size = new System.Drawing.Size(452, 360);
            this.rtbRelatorio.TabIndex = 5;
            this.rtbRelatorio.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(717, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditaEstrelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 528);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rtbRelatorio);
            this.Controls.Add(this.grpEdiEstrelas);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.relatorios);
            this.Name = "EditaEstrelas";
            this.Text = "EditaEstrelas";
            this.relatorios.ResumeLayout(false);
            this.relatorios.PerformLayout();
            this.grpEdiEstrelas.ResumeLayout(false);
            this.grpEdiEstrelas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox relatorios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConstelacao;
        private System.Windows.Forms.GroupBox grpEdiEstrelas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstrelaEdit;
        private System.Windows.Forms.Label lblConst;
        private System.Windows.Forms.ComboBox cmbConstEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAglo;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.TextBox txtMag;
        private System.Windows.Forms.TextBox txtCons;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbRelatorio;
        private System.Windows.Forms.Button btnSave;
    }
}