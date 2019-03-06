namespace Servicios_CS_SQLS
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.tBNombres = new System.Windows.Forms.TextBox();
            this.tBApPat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBApMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBTipo = new System.Windows.Forms.ComboBox();
            this.cBGenero = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dTPFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btAlta = new System.Windows.Forms.Button();
            this.btBaja = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre(s):";
            // 
            // tBNombres
            // 
            this.tBNombres.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombres.Location = new System.Drawing.Point(114, 22);
            this.tBNombres.MaxLength = 100;
            this.tBNombres.Name = "tBNombres";
            this.tBNombres.Size = new System.Drawing.Size(261, 23);
            this.tBNombres.TabIndex = 1;
            // 
            // tBApPat
            // 
            this.tBApPat.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBApPat.Location = new System.Drawing.Point(173, 59);
            this.tBApPat.MaxLength = 100;
            this.tBApPat.Name = "tBApPat";
            this.tBApPat.Size = new System.Drawing.Size(202, 23);
            this.tBApPat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido Paterno: ";
            // 
            // tBApMat
            // 
            this.tBApMat.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBApMat.Location = new System.Drawing.Point(173, 97);
            this.tBApMat.MaxLength = 100;
            this.tBApMat.Name = "tBApMat";
            this.tBApMat.Size = new System.Drawing.Size(202, 23);
            this.tBApMat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido Materno: ";
            // 
            // tBEmail
            // 
            this.tBEmail.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBEmail.Location = new System.Drawing.Point(87, 139);
            this.tBEmail.MaxLength = 100;
            this.tBEmail.Name = "tBEmail";
            this.tBEmail.Size = new System.Drawing.Size(288, 23);
            this.tBEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo: ";
            // 
            // cBTipo
            // 
            this.cBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTipo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTipo.FormattingEnabled = true;
            this.cBTipo.Items.AddRange(new object[] {
            "Becario",
            "Encargado"});
            this.cBTipo.Location = new System.Drawing.Point(87, 179);
            this.cBTipo.Name = "cBTipo";
            this.cBTipo.Size = new System.Drawing.Size(288, 23);
            this.cBTipo.TabIndex = 9;
            // 
            // cBGenero
            // 
            this.cBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGenero.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGenero.FormattingEnabled = true;
            this.cBGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cBGenero.Location = new System.Drawing.Point(98, 219);
            this.cBGenero.Name = "cBGenero";
            this.cBGenero.Size = new System.Drawing.Size(277, 23);
            this.cBGenero.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Género: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha de\r\nNacimiento: ";
            // 
            // dTPFechaNac
            // 
            this.dTPFechaNac.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFechaNac.Location = new System.Drawing.Point(144, 271);
            this.dTPFechaNac.Name = "dTPFechaNac";
            this.dTPFechaNac.Size = new System.Drawing.Size(231, 23);
            this.dTPFechaNac.TabIndex = 13;
            // 
            // btAlta
            // 
            this.btAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlta.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btAlta.Location = new System.Drawing.Point(25, 323);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(137, 35);
            this.btAlta.TabIndex = 14;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = false;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btBaja
            // 
            this.btBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btBaja.Enabled = false;
            this.btBaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBaja.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btBaja.Location = new System.Drawing.Point(394, 323);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(137, 35);
            this.btBaja.TabIndex = 15;
            this.btBaja.Text = "Baja";
            this.btBaja.UseVisualStyleBackColor = false;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(137)))));
            this.btModificar.Enabled = false;
            this.btModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btModificar.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(250)))));
            this.btModificar.Location = new System.Drawing.Point(743, 323);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(137, 35);
            this.btModificar.TabIndex = 16;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 405);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(855, 222);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.ColumnHeaderCellChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnHeaderCellChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 154);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(909, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.dTPFechaNac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBGenero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBApMat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBApPat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBNombres);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEmpleados";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBNombres;
        private System.Windows.Forms.TextBox tBApPat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBApMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBTipo;
        private System.Windows.Forms.ComboBox cBGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dTPFechaNac;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}