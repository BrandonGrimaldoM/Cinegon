
namespace Cinegon
{
    partial class Form2
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
            this.TablaDeDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPelicula = new System.Windows.Forms.TextBox();
            this.cbxGenero = new System.Windows.Forms.ComboBox();
            this.cbxHorario = new System.Windows.Forms.ComboBox();
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxPanel = new System.Windows.Forms.ComboBox();
            this.btnPantalla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TablaDeDatos
            // 
            this.TablaDeDatos.AllowUserToAddRows = false;
            this.TablaDeDatos.AllowUserToDeleteRows = false;
            this.TablaDeDatos.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.TablaDeDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeDatos.Location = new System.Drawing.Point(38, 139);
            this.TablaDeDatos.Name = "TablaDeDatos";
            this.TablaDeDatos.ReadOnly = true;
            this.TablaDeDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaDeDatos.Size = new System.Drawing.Size(597, 237);
            this.TablaDeDatos.TabIndex = 0;
            this.TablaDeDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDeDatos_CellClick);
            this.TablaDeDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaDeDatos_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Película";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(285, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Idioma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(167, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Duración";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(487, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Imagen";
            // 
            // txtPelicula
            // 
            this.txtPelicula.Location = new System.Drawing.Point(85, 32);
            this.txtPelicula.Name = "txtPelicula";
            this.txtPelicula.Size = new System.Drawing.Size(550, 20);
            this.txtPelicula.TabIndex = 7;
            // 
            // cbxGenero
            // 
            this.cbxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGenero.FormattingEnabled = true;
            this.cbxGenero.Location = new System.Drawing.Point(85, 63);
            this.cbxGenero.Name = "cbxGenero";
            this.cbxGenero.Size = new System.Drawing.Size(550, 21);
            this.cbxGenero.TabIndex = 8;
            // 
            // cbxHorario
            // 
            this.cbxHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHorario.FormattingEnabled = true;
            this.cbxHorario.Location = new System.Drawing.Point(85, 97);
            this.cbxHorario.Name = "cbxHorario";
            this.cbxHorario.Size = new System.Drawing.Size(76, 21);
            this.cbxHorario.TabIndex = 9;
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Location = new System.Drawing.Point(327, 96);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(154, 21);
            this.cbxIdioma.TabIndex = 11;
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(231, 97);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(48, 20);
            this.txtDuracion.TabIndex = 12;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(535, 96);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.ReadOnly = true;
            this.txtImagen.Size = new System.Drawing.Size(100, 20);
            this.txtImagen.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(641, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(641, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 23);
            this.btnEditar.TabIndex = 15;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(641, 197);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.BackColor = System.Drawing.Color.White;
            this.btnSubirImagen.Location = new System.Drawing.Point(641, 93);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(87, 23);
            this.btnSubirImagen.TabIndex = 17;
            this.btnSubirImagen.Text = "Subir imagen";
            this.btnSubirImagen.UseVisualStyleBackColor = false;
            this.btnSubirImagen.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(641, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Panel";
            // 
            // cbxPanel
            // 
            this.cbxPanel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPanel.FormattingEnabled = true;
            this.cbxPanel.Items.AddRange(new object[] {
            "Sin Panel"});
            this.cbxPanel.Location = new System.Drawing.Point(641, 257);
            this.cbxPanel.Name = "cbxPanel";
            this.cbxPanel.Size = new System.Drawing.Size(87, 21);
            this.cbxPanel.TabIndex = 20;
            this.cbxPanel.SelectedIndexChanged += new System.EventHandler(this.cbxPanel_SelectedIndexChanged);
            // 
            // btnPantalla
            // 
            this.btnPantalla.Location = new System.Drawing.Point(38, 382);
            this.btnPantalla.Name = "btnPantalla";
            this.btnPantalla.Size = new System.Drawing.Size(690, 23);
            this.btnPantalla.TabIndex = 21;
            this.btnPantalla.Text = "Desplegar Pantalla";
            this.btnPantalla.UseVisualStyleBackColor = true;
            this.btnPantalla.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cinegon.Properties.Resources.cinelogo;
            this.pictureBox1.Location = new System.Drawing.Point(641, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(322, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "CineGon";
            // 
            // ShowImage
            // 
            this.ShowImage.BackColor = System.Drawing.Color.Transparent;
            this.ShowImage.Location = new System.Drawing.Point(749, 12);
            this.ShowImage.Name = "ShowImage";
            this.ShowImage.Size = new System.Drawing.Size(268, 393);
            this.ShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowImage.TabIndex = 24;
            this.ShowImage.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cinegon.Properties.Resources.cinelogo;
            this.pictureBox2.Location = new System.Drawing.Point(641, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinegon.Properties.Resources.fondocine;
            this.ClientSize = new System.Drawing.Size(1061, 432);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowImage);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPantalla);
            this.Controls.Add(this.cbxPanel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubirImagen);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.cbxHorario);
            this.Controls.Add(this.cbxGenero);
            this.Controls.Add(this.txtPelicula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaDeDatos);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1077, 471);
            this.MinimumSize = new System.Drawing.Size(1077, 471);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaDeDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPelicula;
        private System.Windows.Forms.ComboBox cbxGenero;
        private System.Windows.Forms.ComboBox cbxHorario;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxPanel;
        private System.Windows.Forms.Button btnPantalla;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox ShowImage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}