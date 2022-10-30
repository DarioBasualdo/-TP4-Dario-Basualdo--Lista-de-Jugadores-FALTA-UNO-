namespace FrondEnd
{
    partial class Menu
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
            this.bt_A = new System.Windows.Forms.Button();
            this.bt_B = new System.Windows.Forms.Button();
            this.bt_VerEquipo = new System.Windows.Forms.Button();
            this.bt_Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_A
            // 
            this.bt_A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_A.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_A.Location = new System.Drawing.Point(50, 28);
            this.bt_A.Name = "bt_A";
            this.bt_A.Size = new System.Drawing.Size(214, 74);
            this.bt_A.TabIndex = 0;
            this.bt_A.Text = "EQUIPO \"A\"";
            this.bt_A.UseVisualStyleBackColor = false;
            this.bt_A.Click += new System.EventHandler(this.bt_A_Click);
            // 
            // bt_B
            // 
            this.bt_B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_B.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_B.Location = new System.Drawing.Point(50, 136);
            this.bt_B.Name = "bt_B";
            this.bt_B.Size = new System.Drawing.Size(214, 74);
            this.bt_B.TabIndex = 1;
            this.bt_B.Text = "EQUIPO \"B\"";
            this.bt_B.UseVisualStyleBackColor = false;
            this.bt_B.Click += new System.EventHandler(this.bt_B_Click);
            // 
            // bt_VerEquipo
            // 
            this.bt_VerEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_VerEquipo.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_VerEquipo.Location = new System.Drawing.Point(50, 234);
            this.bt_VerEquipo.Name = "bt_VerEquipo";
            this.bt_VerEquipo.Size = new System.Drawing.Size(214, 74);
            this.bt_VerEquipo.TabIndex = 2;
            this.bt_VerEquipo.Text = "VER LISTAS";
            this.bt_VerEquipo.UseVisualStyleBackColor = false;
            this.bt_VerEquipo.Click += new System.EventHandler(this.bt_VerEquipo_Click);
            // 
            // bt_Volver
            // 
            this.bt_Volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_Volver.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Volver.Location = new System.Drawing.Point(189, 405);
            this.bt_Volver.Name = "bt_Volver";
            this.bt_Volver.Size = new System.Drawing.Size(112, 44);
            this.bt_Volver.TabIndex = 3;
            this.bt_Volver.Text = "VOLVER";
            this.bt_Volver.UseVisualStyleBackColor = false;
            this.bt_Volver.Click += new System.EventHandler(this.bt_Volver_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.bt_Volver);
            this.Controls.Add(this.bt_VerEquipo);
            this.Controls.Add(this.bt_B);
            this.Controls.Add(this.bt_A);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_A;
        private System.Windows.Forms.Button bt_B;
        private System.Windows.Forms.Button bt_VerEquipo;
        private System.Windows.Forms.Button bt_Volver;
    }
}