namespace Servicios_CS_SQLS
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btBaja = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.cBTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBApMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBApPat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBNombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBTelef = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelC1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelC2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 154);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btModificar.Enabled = false;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModificar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btModificar.Location = new System.Drawing.Point(788, 358);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(137, 35);
            this.btModificar.TabIndex = 18;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            // 
            // btBaja
            // 
            this.btBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btBaja.Enabled = false;
            this.btBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBaja.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btBaja.Location = new System.Drawing.Point(417, 358);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(137, 35);
            this.btBaja.TabIndex = 17;
            this.btBaja.Text = "Baja";
            this.btBaja.UseVisualStyleBackColor = false;
            // 
            // btAlta
            // 
            this.btAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btAlta.Location = new System.Drawing.Point(28, 358);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(137, 35);
            this.btAlta.TabIndex = 16;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // cBTipo
            // 
            this.cBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipo.FormattingEnabled = true;
            this.cBTipo.Items.AddRange(new object[] {
            "UASLP",
            "Facultad",
            "Externo"});
            this.cBTipo.Location = new System.Drawing.Point(580, 24);
            this.cBTipo.Name = "cBTipo";
            this.cBTipo.Size = new System.Drawing.Size(241, 23);
            this.cBTipo.TabIndex = 11;
            this.cBTipo.SelectedIndexChanged += new System.EventHandler(this.cBTipo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tipo de cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Telefono: ";
            // 
            // tBEmail
            // 
            this.tBEmail.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.Location = new System.Drawing.Point(90, 141);
            this.tBEmail.MaxLength = 100;
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(288, 23);
            this.tBEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email: ";
            // 
            // tBApMat
            // 
            this.tBApMat.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBApMat.Location = new System.Drawing.Point(176, 99);
            this.tBApMat.MaxLength = 100;
            this.tBApMat.Name = "tBApMat";
            this.tBApMat.Size = new System.Drawing.Size(202, 23);
            this.tBApMat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido Materno: ";
            // 
            // tBApPat
            // 
            this.tBApPat.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBApPat.Location = new System.Drawing.Point(176, 61);
            this.tBApPat.MaxLength = 100;
            this.tBApPat.Name = "tBApPat";
            this.tBApPat.Size = new System.Drawing.Size(202, 23);
            this.tBApPat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // tBNombres
            // 
            this.tBNombres.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombres.Location = new System.Drawing.Point(117, 24);
            this.tBNombres.MaxLength = 100;
            this.tBNombres.Name = "tBNombres";
            this.tBNombres.Size = new System.Drawing.Size(261, 23);
            this.tBNombres.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre(s):";
            // 
            // tBTelef
            // 
            this.tBTelef.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBTelef.Location = new System.Drawing.Point(117, 181);
            this.tBTelef.MaxLength = 50;
            this.tBTelef.Name = "tBTelef";
            this.tBTelef.Size = new System.Drawing.Size(261, 23);
            this.tBTelef.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 419);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(897, 222);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.ColumnHeaderCellChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnHeaderCellChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(580, 61);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // labelC1
            // 
            this.labelC1.AutoSize = true;
            this.labelC1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC1.Location = new System.Drawing.Point(449, 61);
            this.labelC1.Name = "labelC1";
            this.labelC1.Size = new System.Drawing.Size(67, 17);
            this.labelC1.TabIndex = 47;
            this.labelC1.Text = "Carrera: ";
            this.labelC1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(580, 103);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 23);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // labelC2
            // 
            this.labelC2.AutoSize = true;
            this.labelC2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelC2.Location = new System.Drawing.Point(449, 103);
            this.labelC2.Name = "labelC2";
            this.labelC2.Size = new System.Drawing.Size(113, 17);
            this.labelC2.TabIndex = 49;
            this.labelC2.Text = "Departamento:";
            this.labelC2.Visible = false;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 653);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelC2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelC1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tBTelef);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.cBTipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBApMat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBApPat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNombres);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.ComboBox cBTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBApMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBApPat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBTelef;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelC1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelC2;
    }
}