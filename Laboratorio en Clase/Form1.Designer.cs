namespace Laboratorio_en_Clase
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.textBoxcompania = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxgeneracion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttongrabar = new System.Windows.Forms.Button();
            this.buttonactualizar = new System.Windows.Forms.Button();
            this.buttonmodel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttontodos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan Josué Luna Cardona 0905-23-1346";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(197, 27);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(184, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(197, 72);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(184, 22);
            this.textBoxnombre.TabIndex = 2;
            // 
            // textBoxcompania
            // 
            this.textBoxcompania.Location = new System.Drawing.Point(197, 117);
            this.textBoxcompania.Name = "textBoxcompania";
            this.textBoxcompania.Size = new System.Drawing.Size(184, 22);
            this.textBoxcompania.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(197, 168);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(286, 22);
            this.dateTimePicker.TabIndex = 5;
            // 
            // textBoxgeneracion
            // 
            this.textBoxgeneracion.Location = new System.Drawing.Point(197, 214);
            this.textBoxgeneracion.Name = "textBoxgeneracion";
            this.textBoxgeneracion.Size = new System.Drawing.Size(184, 22);
            this.textBoxgeneracion.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Compañia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Año de Lanzamiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 27);
            this.label6.TabIndex = 11;
            this.label6.Text = "Generación";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttontodos);
            this.groupBox1.Controls.Add(this.buttonmodel);
            this.groupBox1.Controls.Add(this.buttonactualizar);
            this.groupBox1.Controls.Add(this.buttongrabar);
            this.groupBox1.Location = new System.Drawing.Point(892, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 252);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttongrabar
            // 
            this.buttongrabar.Location = new System.Drawing.Point(39, 30);
            this.buttongrabar.Name = "buttongrabar";
            this.buttongrabar.Size = new System.Drawing.Size(125, 56);
            this.buttongrabar.TabIndex = 0;
            this.buttongrabar.Text = "Grabar";
            this.buttongrabar.UseVisualStyleBackColor = true;
            this.buttongrabar.Click += new System.EventHandler(this.buttongrabar_Click);
            // 
            // buttonactualizar
            // 
            this.buttonactualizar.Location = new System.Drawing.Point(208, 32);
            this.buttonactualizar.Name = "buttonactualizar";
            this.buttonactualizar.Size = new System.Drawing.Size(114, 54);
            this.buttonactualizar.TabIndex = 1;
            this.buttonactualizar.Text = "Actualizar";
            this.buttonactualizar.UseVisualStyleBackColor = true;
            // 
            // buttonmodel
            // 
            this.buttonmodel.Location = new System.Drawing.Point(109, 120);
            this.buttonmodel.Name = "buttonmodel";
            this.buttonmodel.Size = new System.Drawing.Size(212, 51);
            this.buttonmodel.TabIndex = 2;
            this.buttonmodel.Text = "Model";
            this.buttonmodel.UseVisualStyleBackColor = true;
            this.buttonmodel.Click += new System.EventHandler(this.buttonmodel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Old English Text MT", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(771, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "Gabriel Enrique Villanueva Hernandez 0905-23-21427";
            // 
            // buttontodos
            // 
            this.buttontodos.Location = new System.Drawing.Point(109, 177);
            this.buttontodos.Name = "buttontodos";
            this.buttontodos.Size = new System.Drawing.Size(212, 51);
            this.buttontodos.TabIndex = 3;
            this.buttontodos.Text = "Todos";
            this.buttontodos.UseVisualStyleBackColor = true;
            this.buttontodos.Click += new System.EventHandler(this.buttontodos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(861, 233);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxgeneracion);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxcompania);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.TextBox textBoxcompania;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxgeneracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonactualizar;
        private System.Windows.Forms.Button buttongrabar;
        private System.Windows.Forms.Button buttonmodel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttontodos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

