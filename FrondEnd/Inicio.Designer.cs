namespace FrondEnd
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bt_inicio = new System.Windows.Forms.Button();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.img_balon = new System.Windows.Forms.PictureBox();
            this.timer_balon = new System.Windows.Forms.Timer(this.components);
            this.txt_contador = new System.Windows.Forms.Label();
            this.bt_otrointento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_balon)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_inicio
            // 
            this.bt_inicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_inicio.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inicio.Location = new System.Drawing.Point(283, 204);
            this.bt_inicio.Name = "bt_inicio";
            this.bt_inicio.Size = new System.Drawing.Size(202, 103);
            this.bt_inicio.TabIndex = 0;
            this.bt_inicio.Text = "INGRESAR";
            this.bt_inicio.UseVisualStyleBackColor = false;
            this.bt_inicio.Click += new System.EventHandler(this.bt_inicio_Click);
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titulo.Location = new System.Drawing.Point(278, 28);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(166, 28);
            this.lb_titulo.TabIndex = 3;
            this.lb_titulo.Text = "BIENVENIDO A :";
            // 
            // img_balon
            // 
            this.img_balon.Image = ((System.Drawing.Image)(resources.GetObject("img_balon.Image")));
            this.img_balon.Location = new System.Drawing.Point(12, 12);
            this.img_balon.Name = "img_balon";
            this.img_balon.Size = new System.Drawing.Size(221, 125);
            this.img_balon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_balon.TabIndex = 4;
            this.img_balon.TabStop = false;
            this.img_balon.Click += new System.EventHandler(this.img_balon_Click);
            // 
            // timer_balon
            // 
            this.timer_balon.Enabled = true;
            this.timer_balon.Interval = 300;
            this.timer_balon.Tick += new System.EventHandler(this.timer_balon_Tick);
            // 
            // txt_contador
            // 
            this.txt_contador.AutoSize = true;
            this.txt_contador.Font = new System.Drawing.Font("Jokerman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contador.Location = new System.Drawing.Point(280, 370);
            this.txt_contador.Name = "txt_contador";
            this.txt_contador.Size = new System.Drawing.Size(0, 39);
            this.txt_contador.TabIndex = 5;
            // 
            // bt_otrointento
            // 
            this.bt_otrointento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(255)))), ((int)(((byte)(215)))));
            this.bt_otrointento.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_otrointento.Location = new System.Drawing.Point(283, 476);
            this.bt_otrointento.Name = "bt_otrointento";
            this.bt_otrointento.Size = new System.Drawing.Size(202, 59);
            this.bt_otrointento.TabIndex = 6;
            this.bt_otrointento.Text = "Otravez";
            this.bt_otrointento.UseVisualStyleBackColor = false;
            this.bt_otrointento.Visible = false;
            this.bt_otrointento.Click += new System.EventHandler(this.bt_otrointento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿FALTA UNO?";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(563, 567);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_otrointento);
            this.Controls.Add(this.txt_contador);
            this.Controls.Add(this.img_balon);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.bt_inicio);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicio_FormClosing);
            this.Click += new System.EventHandler(this.Inicio_Click);
            ((System.ComponentModel.ISupportInitialize)(this.img_balon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_inicio;
        private System.Windows.Forms.Label lb_titulo;
        private System.Windows.Forms.PictureBox img_balon;
        public System.Windows.Forms.Timer timer_balon;
        private System.Windows.Forms.Label txt_contador;
        private System.Windows.Forms.Button bt_otrointento;
        private System.Windows.Forms.Label label1;
    }
}

