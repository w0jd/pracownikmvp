namespace pracownik.View
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.button_zapisz = new System.Windows.Forms.Button();
            this.button_wczytaj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton_niewiem = new System.Windows.Forms.RadioButton();
            this.radioButton_nie = new System.Windows.Forms.RadioButton();
            this.radioButton_tak = new System.Windows.Forms.RadioButton();
            this.comboBox_Stanowisko = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_urodz = new System.Windows.Forms.DateTimePicker();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.imie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider_pole = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_puste = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDown_saropki = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wyslij = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_puste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_saropki)).BeginInit();
            this.SuspendLayout();
            // 
            // button_zapisz
            // 
            this.button_zapisz.Location = new System.Drawing.Point(91, 329);
            this.button_zapisz.Name = "button_zapisz";
            this.button_zapisz.Size = new System.Drawing.Size(75, 23);
            this.button_zapisz.TabIndex = 0;
            this.button_zapisz.Text = "zapisz";
            this.button_zapisz.UseVisualStyleBackColor = true;
            this.button_zapisz.Click += new System.EventHandler(this.button_Zapisz_Click);
            // 
            // button_wczytaj
            // 
            this.button_wczytaj.Location = new System.Drawing.Point(239, 329);
            this.button_wczytaj.Name = "button_wczytaj";
            this.button_wczytaj.Size = new System.Drawing.Size(75, 23);
            this.button_wczytaj.TabIndex = 1;
            this.button_wczytaj.Text = "wczytaj";
            this.button_wczytaj.UseVisualStyleBackColor = true;
            this.button_wczytaj.Click += new System.EventHandler(this.button_wczytaj_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // radioButton_niewiem
            // 
            this.radioButton_niewiem.AutoSize = true;
            this.radioButton_niewiem.Checked = true;
            this.radioButton_niewiem.Location = new System.Drawing.Point(119, 228);
            this.radioButton_niewiem.Name = "radioButton_niewiem";
            this.radioButton_niewiem.Size = new System.Drawing.Size(116, 17);
            this.radioButton_niewiem.TabIndex = 3;
            this.radioButton_niewiem.TabStop = true;
            this.radioButton_niewiem.Text = "umowa na zlecenie";
            this.radioButton_niewiem.UseVisualStyleBackColor = true;
            // 
            // radioButton_nie
            // 
            this.radioButton_nie.AutoSize = true;
            this.radioButton_nie.Location = new System.Drawing.Point(119, 205);
            this.radioButton_nie.Name = "radioButton_nie";
            this.radioButton_nie.Size = new System.Drawing.Size(147, 17);
            this.radioButton_nie.TabIndex = 4;
            this.radioButton_nie.TabStop = true;
            this.radioButton_nie.Text = "umowa na czas określony";
            this.radioButton_nie.UseVisualStyleBackColor = true;
            // 
            // radioButton_tak
            // 
            this.radioButton_tak.AutoSize = true;
            this.radioButton_tak.Location = new System.Drawing.Point(119, 180);
            this.radioButton_tak.Name = "radioButton_tak";
            this.radioButton_tak.Size = new System.Drawing.Size(164, 17);
            this.radioButton_tak.TabIndex = 5;
            this.radioButton_tak.TabStop = true;
            this.radioButton_tak.Text = "umowa na czas nie określony";
            this.radioButton_tak.UseVisualStyleBackColor = true;
            this.radioButton_tak.Click += new System.EventHandler(this.radioButton_tak_Click);
            // 
            // comboBox_Stanowisko
            // 
            this.comboBox_Stanowisko.FormattingEnabled = true;
            this.comboBox_Stanowisko.Items.AddRange(new object[] {
            "Tester",
            "Projektant",
            "Inżynier",
            "Młodszy Programiszta",
            "Starszy Programista"});
            this.comboBox_Stanowisko.Location = new System.Drawing.Point(91, 135);
            this.comboBox_Stanowisko.Name = "comboBox_Stanowisko";
            this.comboBox_Stanowisko.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Stanowisko.TabIndex = 6;
            this.comboBox_Stanowisko.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker_urodz
            // 
            this.dateTimePicker_urodz.Location = new System.Drawing.Point(91, 86);
            this.dateTimePicker_urodz.MaxDate = new System.DateTime(2023, 3, 17, 0, 0, 0, 0);
            this.dateTimePicker_urodz.Name = "dateTimePicker_urodz";
            this.dateTimePicker_urodz.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_urodz.TabIndex = 7;
            this.dateTimePicker_urodz.Value = new System.DateTime(2023, 3, 17, 0, 0, 0, 0);
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(91, 61);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBox_nazwisko.TabIndex = 8;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(91, 35);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(100, 20);
            this.textBox_imie.TabIndex = 9;
            // 
            // listBox_lista
            // 
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.Location = new System.Drawing.Point(523, 35);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.Size = new System.Drawing.Size(251, 368);
            this.listBox_lista.TabIndex = 10;
            this.listBox_lista.SelectedIndexChanged += new System.EventHandler(this.listBox_lista_SelectedIndexChanged);
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(26, 35);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(25, 13);
            this.imie.TabIndex = 11;
            this.imie.Text = "imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "data ainezdoru";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "stananowsko";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "czy jeseteś idiotą";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // errorProvider_pole
            // 
            this.errorProvider_pole.ContainerControl = this;
            this.errorProvider_pole.RightToLeftChanged += new System.EventHandler(this.button_wyslij_Click);
            // 
            // errorProvider_puste
            // 
            this.errorProvider_puste.ContainerControl = this;
            // 
            // numericUpDown_saropki
            // 
            this.numericUpDown_saropki.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_saropki.Location = new System.Drawing.Point(122, 112);
            this.numericUpDown_saropki.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_saropki.Name = "numericUpDown_saropki";
            this.numericUpDown_saropki.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_saropki.TabIndex = 17;
            this.numericUpDown_saropki.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ile kchesz pieniency";
            // 
            // button_wyslij
            // 
            this.button_wyslij.Location = new System.Drawing.Point(167, 262);
            this.button_wyslij.Name = "button_wyslij";
            this.button_wyslij.Size = new System.Drawing.Size(75, 23);
            this.button_wyslij.TabIndex = 19;
            this.button_wyslij.Text = "wyslij";
            this.button_wyslij.UseVisualStyleBackColor = true;
            this.button_wyslij.Click += new System.EventHandler(this.button_wyslij_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_wyslij);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_saropki);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.listBox_lista);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.dateTimePicker_urodz);
            this.Controls.Add(this.comboBox_Stanowisko);
            this.Controls.Add(this.radioButton_tak);
            this.Controls.Add(this.radioButton_nie);
            this.Controls.Add(this.radioButton_niewiem);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_wczytaj);
            this.Controls.Add(this.button_zapisz);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_puste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_saropki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_zapisz;
		private System.Windows.Forms.Button button_wczytaj;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RadioButton radioButton_niewiem;
		private System.Windows.Forms.RadioButton radioButton_nie;
		private System.Windows.Forms.RadioButton radioButton_tak;
		private System.Windows.Forms.ComboBox comboBox_Stanowisko;
		private System.Windows.Forms.DateTimePicker dateTimePicker_urodz;
		private System.Windows.Forms.TextBox textBox_nazwisko;
		private System.Windows.Forms.TextBox textBox_imie;
		private System.Windows.Forms.ListBox listBox_lista;
		private System.Windows.Forms.Label imie;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ErrorProvider errorProvider_pole;
		private System.Windows.Forms.ErrorProvider errorProvider_puste;
		private System.Windows.Forms.Button button_wyslij;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown_saropki;
	}
}

