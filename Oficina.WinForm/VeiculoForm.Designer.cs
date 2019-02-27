namespace Oficina.WinForm
{
    partial class veiculoForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marcaComboBox = new System.Windows.Forms.ComboBox();
            this.modeloComboBox = new System.Windows.Forms.ComboBox();
            this.corComboBox = new System.Windows.Forms.ComboBox();
            this.cambioComboBox = new System.Windows.Forms.ComboBox();
            this.combustivelComboBox = new System.Windows.Forms.ComboBox();
            this.placaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.anoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.obsGroupBox = new System.Windows.Forms.GroupBox();
            this.obsTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.veiculoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.obsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Combustivel:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cambio:";
            // 
            // marcaComboBox
            // 
            this.marcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaComboBox.FormattingEnabled = true;
            this.marcaComboBox.Location = new System.Drawing.Point(57, 50);
            this.marcaComboBox.Name = "marcaComboBox";
            this.marcaComboBox.Size = new System.Drawing.Size(199, 21);
            this.marcaComboBox.TabIndex = 3;
            this.marcaComboBox.Tag = "*";
            this.marcaComboBox.SelectedIndexChanged += new System.EventHandler(this.marcaComboBox_SelectedIndexChanged);
            // 
            // modeloComboBox
            // 
            this.modeloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeloComboBox.FormattingEnabled = true;
            this.modeloComboBox.Location = new System.Drawing.Point(57, 90);
            this.modeloComboBox.Name = "modeloComboBox";
            this.modeloComboBox.Size = new System.Drawing.Size(199, 21);
            this.modeloComboBox.TabIndex = 5;
            this.modeloComboBox.Tag = "*";
            // 
            // corComboBox
            // 
            this.corComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.corComboBox.FormattingEnabled = true;
            this.corComboBox.Location = new System.Drawing.Point(466, 10);
            this.corComboBox.Name = "corComboBox";
            this.corComboBox.Size = new System.Drawing.Size(196, 21);
            this.corComboBox.TabIndex = 9;
            this.corComboBox.Tag = "*";
            // 
            // cambioComboBox
            // 
            this.cambioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cambioComboBox.FormattingEnabled = true;
            this.cambioComboBox.Location = new System.Drawing.Point(466, 90);
            this.cambioComboBox.Name = "cambioComboBox";
            this.cambioComboBox.Size = new System.Drawing.Size(196, 21);
            this.cambioComboBox.TabIndex = 13;
            this.cambioComboBox.Tag = "*";
            // 
            // combustivelComboBox
            // 
            this.combustivelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustivelComboBox.FormattingEnabled = true;
            this.combustivelComboBox.Location = new System.Drawing.Point(466, 50);
            this.combustivelComboBox.Name = "combustivelComboBox";
            this.combustivelComboBox.Size = new System.Drawing.Size(196, 21);
            this.combustivelComboBox.TabIndex = 11;
            this.combustivelComboBox.Tag = "*";
            // 
            // placaMaskedTextBox
            // 
            this.placaMaskedTextBox.Location = new System.Drawing.Point(57, 10);
            this.placaMaskedTextBox.Mask = ">LLL<-0000";
            this.placaMaskedTextBox.Name = "placaMaskedTextBox";
            this.placaMaskedTextBox.Size = new System.Drawing.Size(199, 20);
            this.placaMaskedTextBox.TabIndex = 1;
            this.placaMaskedTextBox.Tag = "*PLACA";
            this.placaMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // anoMaskedTextBox
            // 
            this.anoMaskedTextBox.Location = new System.Drawing.Point(57, 130);
            this.anoMaskedTextBox.Mask = "0000";
            this.anoMaskedTextBox.Name = "anoMaskedTextBox";
            this.anoMaskedTextBox.Size = new System.Drawing.Size(199, 20);
            this.anoMaskedTextBox.TabIndex = 7;
            this.anoMaskedTextBox.Tag = "*ANO";
            // 
            // obsGroupBox
            // 
            this.obsGroupBox.Controls.Add(this.obsTextBox);
            this.obsGroupBox.Location = new System.Drawing.Point(16, 166);
            this.obsGroupBox.Name = "obsGroupBox";
            this.obsGroupBox.Size = new System.Drawing.Size(646, 100);
            this.obsGroupBox.TabIndex = 14;
            this.obsGroupBox.TabStop = false;
            this.obsGroupBox.Text = "Observação (300)";
            // 
            // obsTextBox
            // 
            this.obsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obsTextBox.Location = new System.Drawing.Point(3, 16);
            this.obsTextBox.MaxLength = 300;
            this.obsTextBox.Multiline = true;
            this.obsTextBox.Name = "obsTextBox";
            this.obsTextBox.Size = new System.Drawing.Size(640, 81);
            this.obsTextBox.TabIndex = 0;
            this.obsTextBox.TextChanged += new System.EventHandler(this.obsTextBox_TextChanged);
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(546, 278);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(75, 23);
            this.gravarButton.TabIndex = 15;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // veiculoErrorProvider
            // 
            this.veiculoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.veiculoErrorProvider.ContainerControl = this;
            // 
            // veiculoForm
            // 
            this.AcceptButton = this.gravarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 313);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.obsGroupBox);
            this.Controls.Add(this.anoMaskedTextBox);
            this.Controls.Add(this.placaMaskedTextBox);
            this.Controls.Add(this.cambioComboBox);
            this.Controls.Add(this.modeloComboBox);
            this.Controls.Add(this.combustivelComboBox);
            this.Controls.Add(this.corComboBox);
            this.Controls.Add(this.marcaComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "veiculoForm";
            this.Text = "Cadastro de Veiculo";
            this.obsGroupBox.ResumeLayout(false);
            this.obsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox marcaComboBox;
        private System.Windows.Forms.ComboBox modeloComboBox;
        private System.Windows.Forms.ComboBox corComboBox;
        private System.Windows.Forms.ComboBox cambioComboBox;
        private System.Windows.Forms.ComboBox combustivelComboBox;
        private System.Windows.Forms.MaskedTextBox placaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox anoMaskedTextBox;
        private System.Windows.Forms.GroupBox obsGroupBox;
        private System.Windows.Forms.TextBox obsTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.ErrorProvider veiculoErrorProvider;
    }
}

