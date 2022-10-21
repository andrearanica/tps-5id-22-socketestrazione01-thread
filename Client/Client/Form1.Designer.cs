
namespace Client
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
            this.txt_number = new System.Windows.Forms.NumericUpDown();
            this.btn_send = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserisci un numero";
            // 
            // txt_number
            // 
            this.txt_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number.Location = new System.Drawing.Point(201, 41);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(33, 29);
            this.txt_number.TabIndex = 1;
            // 
            // btn_send
            // 
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.Location = new System.Drawing.Point(169, 76);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 41);
            this.btn_send.TabIndex = 2;
            this.btn_send.Text = "Invia";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click_1);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(146, 120);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(76, 25);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 186);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_number)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txt_number;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lbl_result;
    }
}

