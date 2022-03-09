
namespace esercizioDiProva
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoDiPizza = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgiungi = new System.Windows.Forms.Button();
            this.txtQuantita = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstVisualizzazione = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo di Pizza";
            // 
            // cmbTipoDiPizza
            // 
            this.cmbTipoDiPizza.FormattingEnabled = true;
            this.cmbTipoDiPizza.Location = new System.Drawing.Point(165, 87);
            this.cmbTipoDiPizza.Name = "cmbTipoDiPizza";
            this.cmbTipoDiPizza.Size = new System.Drawing.Size(182, 33);
            this.cmbTipoDiPizza.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantità";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAgiungi
            // 
            this.btnAgiungi.Location = new System.Drawing.Point(359, 143);
            this.btnAgiungi.Name = "btnAgiungi";
            this.btnAgiungi.Size = new System.Drawing.Size(112, 34);
            this.btnAgiungi.TabIndex = 3;
            this.btnAgiungi.Text = "Aggiungi";
            this.btnAgiungi.UseVisualStyleBackColor = true;
            this.btnAgiungi.Click += new System.EventHandler(this.btnAgiungi_Click);
            // 
            // txtQuantita
            // 
            this.txtQuantita.Location = new System.Drawing.Point(165, 195);
            this.txtQuantita.Name = "txtQuantita";
            this.txtQuantita.Size = new System.Drawing.Size(150, 31);
            this.txtQuantita.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Riepilogo:";
            // 
            // lstVisualizzazione
            // 
            this.lstVisualizzazione.FormattingEnabled = true;
            this.lstVisualizzazione.ItemHeight = 25;
            this.lstVisualizzazione.Location = new System.Drawing.Point(536, 143);
            this.lstVisualizzazione.Name = "lstVisualizzazione";
            this.lstVisualizzazione.Size = new System.Drawing.Size(180, 129);
            this.lstVisualizzazione.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Totale pizze margherita:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "pizze verdura:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstVisualizzazione);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuantita);
            this.Controls.Add(this.btnAgiungi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoDiPizza);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "AS2122_4E_INF_CordiolIBeatrice_Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoDiPizza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgiungi;
        private System.Windows.Forms.TextBox txtQuantita;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstVisualizzazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

