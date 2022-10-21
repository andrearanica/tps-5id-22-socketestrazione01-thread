
namespace Server
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listServer = new System.Windows.Forms.ListBox();
            this.txt_d = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_d)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // listServer
            // 
            this.listServer.FormattingEnabled = true;
            this.listServer.Location = new System.Drawing.Point(12, 107);
            this.listServer.Name = "listServer";
            this.listServer.Size = new System.Drawing.Size(386, 147);
            this.listServer.TabIndex = 1;
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(220, 51);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(28, 20);
            this.txt_d.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Difficoltà";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(173, 73);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "Inizia";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 266);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.listServer);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Server";
            ((System.ComponentModel.ISupportInitialize)(this.txt_d)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listServer;
        private System.Windows.Forms.NumericUpDown txt_d;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_start;
    }
}

