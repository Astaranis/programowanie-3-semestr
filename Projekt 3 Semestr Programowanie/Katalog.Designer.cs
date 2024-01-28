namespace Projekt_3_Semestr_Programowanie
{
    partial class Katalog
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            Nazwa_text = new TextBox();
            Cena_text = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            usun = new Button();
            nowa_cena = new TextBox();
            label3 = new Label();
            Zmien = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(651, 415);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 0;
            button1.Text = "Dodaj do zamowienia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(177, 23);
            button2.TabIndex = 1;
            button2.Text = "Lista Zamowien";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(168, 364);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Nazwa_text
            // 
            Nazwa_text.Location = new Point(596, 96);
            Nazwa_text.Name = "Nazwa_text";
            Nazwa_text.Size = new Size(100, 23);
            Nazwa_text.TabIndex = 3;
            // 
            // Cena_text
            // 
            Cena_text.Location = new Point(596, 140);
            Cena_text.Name = "Cena_text";
            Cena_text.Size = new Size(100, 23);
            Cena_text.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(602, 122);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "Cena produktu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 78);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 6;
            label2.Text = "Nazwa produktu";
            // 
            // button3
            // 
            button3.Location = new Point(596, 178);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 7;
            button3.Text = "Dodaj produkt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // usun
            // 
            usun.Location = new Point(195, 178);
            usun.Name = "usun";
            usun.Size = new Size(92, 23);
            usun.TabIndex = 8;
            usun.Text = "Usuń produkt";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // nowa_cena
            // 
            nowa_cena.Location = new Point(398, 140);
            nowa_cena.Name = "nowa_cena";
            nowa_cena.Size = new Size(100, 23);
            nowa_cena.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 122);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 10;
            label3.Text = "Nowa Cena";
            // 
            // Zmien
            // 
            Zmien.Location = new Point(398, 178);
            Zmien.Name = "Zmien";
            Zmien.Size = new Size(100, 23);
            Zmien.TabIndex = 11;
            Zmien.Text = "Aktualizuj Cene";
            Zmien.UseVisualStyleBackColor = true;
            Zmien.Click += Zmien_Click;
            // 
            // Katalog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Zmien);
            Controls.Add(label3);
            Controls.Add(nowa_cena);
            Controls.Add(usun);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cena_text);
            Controls.Add(Nazwa_text);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Katalog";
            Text = "Katalog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private TextBox Nazwa_text;
        private TextBox Cena_text;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button usun;
        private TextBox nowa_cena;
        private Label label3;
        private Button Zmien;
    }
}