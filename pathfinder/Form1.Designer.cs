namespace pathfinder
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.info_moves = new System.Windows.Forms.Label();
            this.info_time = new System.Windows.Forms.Label();
            this.label313 = new System.Windows.Forms.Label();
            this.label314 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // info_moves
            // 
            this.info_moves.AutoSize = true;
            this.info_moves.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_moves.Location = new System.Drawing.Point(1147, 12);
            this.info_moves.Name = "info_moves";
            this.info_moves.Size = new System.Drawing.Size(0, 28);
            this.info_moves.TabIndex = 312;
            // 
            // info_time
            // 
            this.info_time.AutoSize = true;
            this.info_time.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info_time.Location = new System.Drawing.Point(1147, 39);
            this.info_time.Name = "info_time";
            this.info_time.Size = new System.Drawing.Size(0, 28);
            this.info_time.TabIndex = 313;
            // 
            // label313
            // 
            this.label313.AutoSize = true;
            this.label313.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label313.Location = new System.Drawing.Point(839, 9);
            this.label313.Name = "label313";
            this.label313.Size = new System.Drawing.Size(302, 28);
            this.label313.TabIndex = 314;
            this.label313.Text = "Počet navštívených dlaždic:";
            this.label313.Click += new System.EventHandler(this.label313_Click);
            // 
            // label314
            // 
            this.label314.AutoSize = true;
            this.label314.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label314.Location = new System.Drawing.Point(839, 39);
            this.label314.Name = "label314";
            this.label314.Size = new System.Drawing.Size(54, 28);
            this.label314.TabIndex = 315;
            this.label314.Text = "Čas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(844, 784);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 26);
            this.button1.TabIndex = 316;
            this.button1.Text = "Vymaž!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 803);
            this.panel1.TabIndex = 317;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 753);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(341, 25);
            this.button2.TabIndex = 318;
            this.button2.Text = "Hledej!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(840, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 23);
            this.label2.TabIndex = 320;
            this.label2.Text = "Levé tlačítko -> START";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(840, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 23);
            this.label3.TabIndex = 321;
            this.label3.Text = "Pravé tlačítko -> KONEC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(840, 699);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 23);
            this.label4.TabIndex = 322;
            this.label4.Text = "Prostřední tlačítko -> PŘEKÁŽKY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 817);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label314);
            this.Controls.Add(this.label313);
            this.Controls.Add(this.info_time);
            this.Controls.Add(this.info_moves);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label info_moves;
        private System.Windows.Forms.Label info_time;
        private System.Windows.Forms.Label label313;
        private System.Windows.Forms.Label label314;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

