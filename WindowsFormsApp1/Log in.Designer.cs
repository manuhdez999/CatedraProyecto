namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtusuario = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtcodigo = new MetroFramework.Controls.MetroTextBox();
            this.btningresar = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.conchas_la_5DataSet1 = new WindowsFormsApp1.Conchas_la_5DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchas_la_5DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(186, 360);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 20);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Usuario:";
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.CustomButton.Image = null;
            this.txtusuario.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtusuario.CustomButton.Name = "";
            this.txtusuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusuario.CustomButton.TabIndex = 1;
            this.txtusuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusuario.CustomButton.UseSelectable = true;
            this.txtusuario.CustomButton.Visible = false;
            this.txtusuario.Lines = new string[0];
            this.txtusuario.Location = new System.Drawing.Point(297, 360);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.ShortcutsEnabled = true;
            this.txtusuario.Size = new System.Drawing.Size(212, 23);
            this.txtusuario.TabIndex = 2;
            this.txtusuario.UseSelectable = true;
            this.txtusuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(163, 415);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Contraseña:";
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // txtcodigo
            // 
            // 
            // 
            // 
            this.txtcodigo.CustomButton.Image = null;
            this.txtcodigo.CustomButton.Location = new System.Drawing.Point(190, 1);
            this.txtcodigo.CustomButton.Name = "";
            this.txtcodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcodigo.CustomButton.TabIndex = 1;
            this.txtcodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcodigo.CustomButton.UseSelectable = true;
            this.txtcodigo.CustomButton.Visible = false;
            this.txtcodigo.Lines = new string[0];
            this.txtcodigo.Location = new System.Drawing.Point(297, 415);
            this.txtcodigo.MaxLength = 32767;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.SelectionLength = 0;
            this.txtcodigo.SelectionStart = 0;
            this.txtcodigo.ShortcutsEnabled = true;
            this.txtcodigo.Size = new System.Drawing.Size(212, 23);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.UseSelectable = true;
            this.txtcodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(355, 468);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(113, 24);
            this.btningresar.TabIndex = 5;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseSelectable = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Black;
            this.metroLabel3.Location = new System.Drawing.Point(338, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(171, 56);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Iniciar Sesión";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.Color.Black;
            this.metroButton2.Location = new System.Drawing.Point(692, 70);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(102, 30);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Regresar";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // conchas_la_5DataSet1
            // 
            this.conchas_la_5DataSet1.DataSetName = "Conchas_la_5DataSet";
            this.conchas_la_5DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 622);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Conchas la 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchas_la_5DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtusuario;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtcodigo;
        private MetroFramework.Controls.MetroButton btningresar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private Conchas_la_5DataSet conchas_la_5DataSet1;
    }
}

