namespace WindowsFormsApp1
{
    partial class Registrar_usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar_usuario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtnombre = new MetroFramework.Controls.MetroTextBox();
            this.txtcodigo = new MetroFramework.Controls.MetroTextBox();
            this.cmbtipodeusuario = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtedad = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtapellido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtusuario = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(296, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(179, 245);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Nombre:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(161, 429);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Contraseña:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(133, 465);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(110, 20);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Tipo de Usuario:";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(333, 520);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(99, 44);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Registrar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtnombre
            // 
            // 
            // 
            // 
            this.txtnombre.CustomButton.Image = null;
            this.txtnombre.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtnombre.CustomButton.Name = "";
            this.txtnombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtnombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnombre.CustomButton.TabIndex = 1;
            this.txtnombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnombre.CustomButton.UseSelectable = true;
            this.txtnombre.CustomButton.Visible = false;
            this.txtnombre.Lines = new string[0];
            this.txtnombre.Location = new System.Drawing.Point(296, 245);
            this.txtnombre.MaxLength = 32767;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.PasswordChar = '\0';
            this.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnombre.SelectedText = "";
            this.txtnombre.SelectionLength = 0;
            this.txtnombre.SelectionStart = 0;
            this.txtnombre.ShortcutsEnabled = true;
            this.txtnombre.Size = new System.Drawing.Size(191, 23);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.UseSelectable = true;
            this.txtnombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtcodigo
            // 
            // 
            // 
            // 
            this.txtcodigo.CustomButton.Image = null;
            this.txtcodigo.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtcodigo.CustomButton.Name = "";
            this.txtcodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcodigo.CustomButton.TabIndex = 1;
            this.txtcodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcodigo.CustomButton.UseSelectable = true;
            this.txtcodigo.CustomButton.Visible = false;
            this.txtcodigo.Lines = new string[0];
            this.txtcodigo.Location = new System.Drawing.Point(296, 426);
            this.txtcodigo.MaxLength = 32767;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.SelectionLength = 0;
            this.txtcodigo.SelectionStart = 0;
            this.txtcodigo.ShortcutsEnabled = true;
            this.txtcodigo.Size = new System.Drawing.Size(191, 23);
            this.txtcodigo.TabIndex = 6;
            this.txtcodigo.UseSelectable = true;
            this.txtcodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbtipodeusuario
            // 
            this.cmbtipodeusuario.FormattingEnabled = true;
            this.cmbtipodeusuario.ItemHeight = 24;
            this.cmbtipodeusuario.Items.AddRange(new object[] {
            "Administrador",
            "Mesero/a"});
            this.cmbtipodeusuario.Location = new System.Drawing.Point(296, 465);
            this.cmbtipodeusuario.Name = "cmbtipodeusuario";
            this.cmbtipodeusuario.Size = new System.Drawing.Size(191, 30);
            this.cmbtipodeusuario.TabIndex = 7;
            this.cmbtipodeusuario.UseSelectable = true;
            this.cmbtipodeusuario.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(564, 42);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(91, 30);
            this.metroButton2.TabIndex = 8;
            this.metroButton2.Text = "Regresar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(200, 342);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 20);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Edad:";
            // 
            // txtedad
            // 
            // 
            // 
            // 
            this.txtedad.CustomButton.Image = null;
            this.txtedad.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtedad.CustomButton.Name = "";
            this.txtedad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtedad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtedad.CustomButton.TabIndex = 1;
            this.txtedad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtedad.CustomButton.UseSelectable = true;
            this.txtedad.CustomButton.Visible = false;
            this.txtedad.Lines = new string[0];
            this.txtedad.Location = new System.Drawing.Point(296, 342);
            this.txtedad.MaxLength = 32767;
            this.txtedad.Name = "txtedad";
            this.txtedad.PasswordChar = '\0';
            this.txtedad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtedad.SelectedText = "";
            this.txtedad.SelectionLength = 0;
            this.txtedad.SelectionStart = 0;
            this.txtedad.ShortcutsEnabled = true;
            this.txtedad.Size = new System.Drawing.Size(191, 23);
            this.txtedad.TabIndex = 10;
            this.txtedad.UseSelectable = true;
            this.txtedad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtedad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(181, 295);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 20);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "Apellido:";
            // 
            // txtapellido
            // 
            // 
            // 
            // 
            this.txtapellido.CustomButton.Image = null;
            this.txtapellido.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtapellido.CustomButton.Name = "";
            this.txtapellido.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtapellido.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtapellido.CustomButton.TabIndex = 1;
            this.txtapellido.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtapellido.CustomButton.UseSelectable = true;
            this.txtapellido.CustomButton.Visible = false;
            this.txtapellido.Lines = new string[0];
            this.txtapellido.Location = new System.Drawing.Point(296, 295);
            this.txtapellido.MaxLength = 32767;
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.PasswordChar = '\0';
            this.txtapellido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtapellido.SelectedText = "";
            this.txtapellido.SelectionLength = 0;
            this.txtapellido.SelectionStart = 0;
            this.txtapellido.ShortcutsEnabled = true;
            this.txtapellido.Size = new System.Drawing.Size(191, 23);
            this.txtapellido.TabIndex = 12;
            this.txtapellido.UseSelectable = true;
            this.txtapellido.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtapellido.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(189, 392);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(54, 20);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "usuario";
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.CustomButton.Image = null;
            this.txtusuario.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.txtusuario.CustomButton.Name = "";
            this.txtusuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusuario.CustomButton.TabIndex = 1;
            this.txtusuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusuario.CustomButton.UseSelectable = true;
            this.txtusuario.CustomButton.Visible = false;
            this.txtusuario.Lines = new string[0];
            this.txtusuario.Location = new System.Drawing.Point(296, 389);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.ShortcutsEnabled = true;
            this.txtusuario.Size = new System.Drawing.Size(191, 23);
            this.txtusuario.TabIndex = 14;
            this.txtusuario.UseSelectable = true;
            this.txtusuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Registrar_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 588);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.cmbtipodeusuario);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registrar_usuario";
            this.Text = "Registrar Usuario";
            this.Load += new System.EventHandler(this.Registrar_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtnombre;
        private MetroFramework.Controls.MetroTextBox txtcodigo;
        private MetroFramework.Controls.MetroComboBox cmbtipodeusuario;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtedad;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtapellido;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtusuario;
    }
}