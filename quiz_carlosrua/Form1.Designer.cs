
namespace quiz_carlosrua
{
    partial class battlefield
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(battlefield));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.direccion = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.Label();
            this.Time1 = new System.Windows.Forms.DateTimePicker();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.consola = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.CheckedListBox();
            this.DLC = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.CheckBox();
            this.Box2 = new System.Windows.Forms.CheckBox();
            this.USUARIOS = new System.Windows.Forms.Label();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.transacciones = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::quiz_carlosrua.Properties.Resources.battlefield;
            this.pictureBox1.Location = new System.Drawing.Point(-72, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.BackColor = System.Drawing.Color.Blue;
            this.direccion.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion.ForeColor = System.Drawing.Color.Black;
            this.direccion.Location = new System.Drawing.Point(227, 203);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(195, 27);
            this.direccion.TabIndex = 1;
            this.direccion.Text = "Direccion De Pago:";
            this.direccion.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(232, 233);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(224, 22);
            this.text1.TabIndex = 2;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.BackColor = System.Drawing.Color.Blue;
            this.fecha.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(227, 270);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(159, 27);
            this.fecha.TabIndex = 3;
            this.fecha.Text = "Fecha De Pago:";
            // 
            // Time1
            // 
            this.Time1.Location = new System.Drawing.Point(232, 301);
            this.Time1.Name = "Time1";
            this.Time1.Size = new System.Drawing.Size(265, 22);
            this.Time1.TabIndex = 4;
            // 
            // combo1
            // 
            this.combo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo1.FormattingEnabled = true;
            this.combo1.Items.AddRange(new object[] {
            "RADIO",
            "PS3",
            "PS4",
            "PS5",
            "XBOX 360",
            "XBOX ONE",
            "PC"});
            this.combo1.Location = new System.Drawing.Point(232, 370);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(154, 36);
            this.combo1.TabIndex = 5;
            this.combo1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // consola
            // 
            this.consola.AutoSize = true;
            this.consola.BackColor = System.Drawing.Color.Blue;
            this.consola.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consola.Location = new System.Drawing.Point(227, 340);
            this.consola.Name = "consola";
            this.consola.Size = new System.Drawing.Size(94, 27);
            this.consola.TabIndex = 6;
            this.consola.Text = "Consola:";
            // 
            // ListBox1
            // 
            this.ListBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Items.AddRange(new object[] {
            "China Rising",
            "Second Assault",
            "Naval Strike",
            "Dragon\'s Teeth",
            "Final Stand"});
            this.ListBox1.Location = new System.Drawing.Point(232, 439);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(187, 89);
            this.ListBox1.TabIndex = 7;
            // 
            // DLC
            // 
            this.DLC.AutoSize = true;
            this.DLC.BackColor = System.Drawing.Color.Blue;
            this.DLC.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DLC.Location = new System.Drawing.Point(227, 409);
            this.DLC.Name = "DLC";
            this.DLC.Size = new System.Drawing.Size(55, 27);
            this.DLC.TabIndex = 8;
            this.DLC.Text = "DLC:";
            this.DLC.Click += new System.EventHandler(this.label4_Click);
            // 
            // Box1
            // 
            this.Box1.AutoSize = true;
            this.Box1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Box1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box1.Location = new System.Drawing.Point(649, 235);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(45, 24);
            this.Box1.TabIndex = 9;
            this.Box1.Text = "SI";
            this.Box1.UseVisualStyleBackColor = false;
            // 
            // Box2
            // 
            this.Box2.AutoSize = true;
            this.Box2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Box2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box2.Location = new System.Drawing.Point(649, 263);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(55, 24);
            this.Box2.TabIndex = 10;
            this.Box2.Text = "NO";
            this.Box2.UseVisualStyleBackColor = false;
            this.Box2.CheckedChanged += new System.EventHandler(this.Box2_CheckedChanged);
            // 
            // USUARIOS
            // 
            this.USUARIOS.AutoSize = true;
            this.USUARIOS.BackColor = System.Drawing.Color.Blue;
            this.USUARIOS.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USUARIOS.Location = new System.Drawing.Point(649, 193);
            this.USUARIOS.Name = "USUARIOS";
            this.USUARIOS.Size = new System.Drawing.Size(185, 27);
            this.USUARIOS.TabIndex = 11;
            this.USUARIOS.Text = "Usuarios Premiun:";
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(649, 354);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(210, 96);
            this.rtxtResults.TabIndex = 12;
            this.rtxtResults.Text = "";
            // 
            // transacciones
            // 
            this.transacciones.AutoSize = true;
            this.transacciones.BackColor = System.Drawing.Color.Blue;
            this.transacciones.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transacciones.ForeColor = System.Drawing.Color.Black;
            this.transacciones.Location = new System.Drawing.Point(649, 324);
            this.transacciones.Name = "transacciones";
            this.transacciones.Size = new System.Drawing.Size(150, 27);
            this.transacciones.TabIndex = 13;
            this.transacciones.Text = "Transacciones:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(649, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 39);
            this.button1.TabIndex = 14;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(753, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 39);
            this.button2.TabIndex = 15;
            this.button2.Text = "Reporte";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // battlefield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quiz_carlosrua.Properties.Resources._6GMLIJTQ6JCGLIA2FZOQWIHJQA;
            this.ClientSize = new System.Drawing.Size(1101, 581);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transacciones);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.USUARIOS);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.DLC);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.consola);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.Time1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "battlefield";
            this.Text = "battlefield epic game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label direccion;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.DateTimePicker Time1;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.Label consola;
        private System.Windows.Forms.CheckedListBox ListBox1;
        private System.Windows.Forms.Label DLC;
        private System.Windows.Forms.CheckBox Box1;
        private System.Windows.Forms.CheckBox Box2;
        private System.Windows.Forms.Label USUARIOS;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.Label transacciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

