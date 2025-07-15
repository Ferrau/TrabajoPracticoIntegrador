namespace Ejercicio_9
{
    partial class Administracion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtAñosLuz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.txtNombrePlaneta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbEstrellaFromPlaneta = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkEsHabitable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFiltrarPlaneta = new System.Windows.Forms.Button();
            this.rdKilometros = new System.Windows.Forms.RadioButton();
            this.rdAñosLuz = new System.Windows.Forms.RadioButton();
            this.btnConvertirDistancia = new System.Windows.Forms.Button();
            this.btnConvertirTemperatura = new System.Windows.Forms.Button();
            this.rdFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdCelcius = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnFiltrarEstrella = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrarPlaneta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkEsHabitable);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbEstrellaFromPlaneta);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNombrePlaneta);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Planeta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltrarEstrella);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbTipo);
            this.groupBox2.Controls.Add(this.cmbColor);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(541, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 195);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Estrella";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConvertirDistancia);
            this.groupBox3.Controls.Add(this.rdAñosLuz);
            this.groupBox3.Controls.Add(this.rdKilometros);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtAñosLuz);
            this.groupBox3.Controls.Add(this.txtKilometros);
            this.groupBox3.Location = new System.Drawing.Point(13, 605);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Convertir Distancia";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdFahrenheit);
            this.groupBox4.Controls.Add(this.rdCelcius);
            this.groupBox4.Controls.Add(this.btnConvertirTemperatura);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtCelcius);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtFahrenheit);
            this.groupBox4.Location = new System.Drawing.Point(535, 605);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 205);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Convertir Temperatura";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(123, 38);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(379, 29);
            this.txtKilometros.TabIndex = 0;
            // 
            // txtAñosLuz
            // 
            this.txtAñosLuz.Location = new System.Drawing.Point(123, 73);
            this.txtAñosLuz.Name = "txtAñosLuz";
            this.txtAñosLuz.Size = new System.Drawing.Size(379, 29);
            this.txtAñosLuz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kilometros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Años Luz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrenheit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Celcius:";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(123, 75);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(379, 29);
            this.txtFahrenheit.TabIndex = 5;
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(123, 40);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(379, 29);
            this.txtCelcius.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvResultado);
            this.groupBox5.Location = new System.Drawing.Point(13, 213);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1244, 386);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resultado Busqueda";
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(6, 25);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(1232, 353);
            this.dgvResultado.TabIndex = 0;
            // 
            // txtNombrePlaneta
            // 
            this.txtNombrePlaneta.Location = new System.Drawing.Point(109, 55);
            this.txtNombrePlaneta.Name = "txtNombrePlaneta";
            this.txtNombrePlaneta.Size = new System.Drawing.Size(393, 29);
            this.txtNombrePlaneta.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre:";
            // 
            // cmbEstrellaFromPlaneta
            // 
            this.cmbEstrellaFromPlaneta.FormattingEnabled = true;
            this.cmbEstrellaFromPlaneta.Location = new System.Drawing.Point(109, 91);
            this.cmbEstrellaFromPlaneta.Name = "cmbEstrellaFromPlaneta";
            this.cmbEstrellaFromPlaneta.Size = new System.Drawing.Size(393, 32);
            this.cmbEstrellaFromPlaneta.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estrella:";
            // 
            // checkEsHabitable
            // 
            this.checkEsHabitable.AutoSize = true;
            this.checkEsHabitable.Location = new System.Drawing.Point(109, 129);
            this.checkEsHabitable.Name = "checkEsHabitable";
            this.checkEsHabitable.Size = new System.Drawing.Size(130, 28);
            this.checkEsHabitable.TabIndex = 7;
            this.checkEsHabitable.Text = "EsHabitable";
            this.checkEsHabitable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Filtros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 9;
            this.label8.Text = "Filtros";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(109, 84);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(393, 32);
            this.cmbTipo.TabIndex = 9;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(109, 46);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(393, 32);
            this.cmbColor.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Tipo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Color:";
            // 
            // btnFiltrarPlaneta
            // 
            this.btnFiltrarPlaneta.Location = new System.Drawing.Point(301, 130);
            this.btnFiltrarPlaneta.Name = "btnFiltrarPlaneta";
            this.btnFiltrarPlaneta.Size = new System.Drawing.Size(158, 48);
            this.btnFiltrarPlaneta.TabIndex = 9;
            this.btnFiltrarPlaneta.Text = "Filtrar";
            this.btnFiltrarPlaneta.UseVisualStyleBackColor = true;
            this.btnFiltrarPlaneta.Click += new System.EventHandler(this.btnFiltrarPlaneta_Click);
            // 
            // rdKilometros
            // 
            this.rdKilometros.AutoSize = true;
            this.rdKilometros.Checked = true;
            this.rdKilometros.Location = new System.Drawing.Point(163, 108);
            this.rdKilometros.Name = "rdKilometros";
            this.rdKilometros.Size = new System.Drawing.Size(116, 28);
            this.rdKilometros.TabIndex = 4;
            this.rdKilometros.TabStop = true;
            this.rdKilometros.Text = "Kilometros";
            this.rdKilometros.UseVisualStyleBackColor = true;
            this.rdKilometros.CheckedChanged += new System.EventHandler(this.rdKilometros_CheckedChanged);
            // 
            // rdAñosLuz
            // 
            this.rdAñosLuz.AutoSize = true;
            this.rdAñosLuz.Location = new System.Drawing.Point(335, 108);
            this.rdAñosLuz.Name = "rdAñosLuz";
            this.rdAñosLuz.Size = new System.Drawing.Size(107, 28);
            this.rdAñosLuz.TabIndex = 5;
            this.rdAñosLuz.Text = "Años Luz";
            this.rdAñosLuz.UseVisualStyleBackColor = true;
            this.rdAñosLuz.CheckedChanged += new System.EventHandler(this.rdAñosLuz_CheckedChanged);
            // 
            // btnConvertirDistancia
            // 
            this.btnConvertirDistancia.Location = new System.Drawing.Point(219, 151);
            this.btnConvertirDistancia.Name = "btnConvertirDistancia";
            this.btnConvertirDistancia.Size = new System.Drawing.Size(158, 48);
            this.btnConvertirDistancia.TabIndex = 10;
            this.btnConvertirDistancia.Text = "Convertir";
            this.btnConvertirDistancia.UseVisualStyleBackColor = true;
            this.btnConvertirDistancia.Click += new System.EventHandler(this.btnConvertirDistancia_Click);
            // 
            // btnConvertirTemperatura
            // 
            this.btnConvertirTemperatura.Location = new System.Drawing.Point(219, 151);
            this.btnConvertirTemperatura.Name = "btnConvertirTemperatura";
            this.btnConvertirTemperatura.Size = new System.Drawing.Size(158, 48);
            this.btnConvertirTemperatura.TabIndex = 11;
            this.btnConvertirTemperatura.Text = "Convertir";
            this.btnConvertirTemperatura.UseVisualStyleBackColor = true;
            this.btnConvertirTemperatura.Click += new System.EventHandler(this.btnConvertirTemperatura_Click);
            // 
            // rdFahrenheit
            // 
            this.rdFahrenheit.AutoSize = true;
            this.rdFahrenheit.Location = new System.Drawing.Point(335, 110);
            this.rdFahrenheit.Name = "rdFahrenheit";
            this.rdFahrenheit.Size = new System.Drawing.Size(119, 28);
            this.rdFahrenheit.TabIndex = 12;
            this.rdFahrenheit.Text = "Fahrenheit";
            this.rdFahrenheit.UseVisualStyleBackColor = true;
            this.rdFahrenheit.CheckedChanged += new System.EventHandler(this.rdFahrenheit_CheckedChanged);
            // 
            // rdCelcius
            // 
            this.rdCelcius.AutoSize = true;
            this.rdCelcius.Checked = true;
            this.rdCelcius.Location = new System.Drawing.Point(163, 110);
            this.rdCelcius.Name = "rdCelcius";
            this.rdCelcius.Size = new System.Drawing.Size(90, 28);
            this.rdCelcius.TabIndex = 11;
            this.rdCelcius.TabStop = true;
            this.rdCelcius.Text = "Celcius";
            this.rdCelcius.UseVisualStyleBackColor = true;
            this.rdCelcius.CheckedChanged += new System.EventHandler(this.rdCelcius_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 29);
            this.textBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Temperatura:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(135, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(367, 32);
            this.comboBox1.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Constelación:";
            // 
            // btnFiltrarEstrella
            // 
            this.btnFiltrarEstrella.Location = new System.Drawing.Point(535, 91);
            this.btnFiltrarEstrella.Name = "btnFiltrarEstrella";
            this.btnFiltrarEstrella.Size = new System.Drawing.Size(158, 48);
            this.btnFiltrarEstrella.TabIndex = 10;
            this.btnFiltrarEstrella.Text = "Filtrar";
            this.btnFiltrarEstrella.UseVisualStyleBackColor = true;
            this.btnFiltrarEstrella.Click += new System.EventHandler(this.btnFiltrarEstrella_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 816);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAñosLuz;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEstrellaFromPlaneta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombrePlaneta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkEsHabitable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFiltrarPlaneta;
        private System.Windows.Forms.Button btnConvertirDistancia;
        private System.Windows.Forms.RadioButton rdAñosLuz;
        private System.Windows.Forms.RadioButton rdKilometros;
        private System.Windows.Forms.Button btnConvertirTemperatura;
        private System.Windows.Forms.RadioButton rdFahrenheit;
        private System.Windows.Forms.RadioButton rdCelcius;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFiltrarEstrella;
    }
}