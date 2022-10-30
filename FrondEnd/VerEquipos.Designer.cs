namespace FrondEnd
{
    partial class VerEquipos
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
            this.btVolver = new System.Windows.Forms.Button();
            this.lbtituloB = new System.Windows.Forms.Label();
            this.lbtituloA = new System.Windows.Forms.Label();
            this.dtgvVeraA = new System.Windows.Forms.DataGridView();
            this.dtgvVerB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVeraA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerB)).BeginInit();
            this.SuspendLayout();
            // 
            // btVolver
            // 
            this.btVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.btVolver.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(768, 512);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(123, 35);
            this.btVolver.TabIndex = 0;
            this.btVolver.Text = "VOLVER";
            this.btVolver.UseVisualStyleBackColor = false;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // lbtituloB
            // 
            this.lbtituloB.AutoSize = true;
            this.lbtituloB.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtituloB.Location = new System.Drawing.Point(444, 25);
            this.lbtituloB.Name = "lbtituloB";
            this.lbtituloB.Size = new System.Drawing.Size(91, 28);
            this.lbtituloB.TabIndex = 3;
            this.lbtituloB.Text = "EquipoB";
            // 
            // lbtituloA
            // 
            this.lbtituloA.AutoSize = true;
            this.lbtituloA.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtituloA.Location = new System.Drawing.Point(17, 25);
            this.lbtituloA.Name = "lbtituloA";
            this.lbtituloA.Size = new System.Drawing.Size(93, 28);
            this.lbtituloA.TabIndex = 4;
            this.lbtituloA.Text = "EquipoA";
            // 
            // dtgvVeraA
            // 
            this.dtgvVeraA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVeraA.Location = new System.Drawing.Point(22, 73);
            this.dtgvVeraA.Name = "dtgvVeraA";
            this.dtgvVeraA.ReadOnly = true;
            this.dtgvVeraA.Size = new System.Drawing.Size(351, 433);
            this.dtgvVeraA.TabIndex = 5;
            // 
            // dtgvVerB
            // 
            this.dtgvVerB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVerB.Location = new System.Drawing.Point(449, 73);
            this.dtgvVerB.Name = "dtgvVerB";
            this.dtgvVerB.ReadOnly = true;
            this.dtgvVerB.Size = new System.Drawing.Size(351, 433);
            this.dtgvVerB.TabIndex = 6;
            // 
            // VerEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.dtgvVerB);
            this.Controls.Add(this.dtgvVeraA);
            this.Controls.Add(this.lbtituloA);
            this.Controls.Add(this.lbtituloB);
            this.Controls.Add(this.btVolver);
            this.Name = "VerEquipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarEquipos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVeraA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Label lbtituloB;
        private System.Windows.Forms.Label lbtituloA;
        private System.Windows.Forms.DataGridView dtgvVeraA;
        private System.Windows.Forms.DataGridView dtgvVerB;
    }
}