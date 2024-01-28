namespace Projekt_3_Semestr_Programowanie
{
    partial class Lista_zamowien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_zamowien));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Zamowienia_listbox = new ListBox();
            Produkty_listbox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Cena_wartosc = new Label();
            Ilość_wartosc = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(131, 415);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 0;
            button1.Text = "Dodaj do zamowienia";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(668, 415);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 1;
            button2.Text = "Dodaj zamowienie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(684, 12);
            button3.Name = "button3";
            button3.Size = new Size(104, 23);
            button3.TabIndex = 2;
            button3.Text = "Wyloguj się ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Zamowienia_listbox
            // 
            Zamowienia_listbox.FormattingEnabled = true;
            Zamowienia_listbox.ItemHeight = 15;
            Zamowienia_listbox.Location = new Point(14, 12);
            Zamowienia_listbox.Name = "Zamowienia_listbox";
            Zamowienia_listbox.Size = new Size(120, 379);
            Zamowienia_listbox.TabIndex = 3;
            Zamowienia_listbox.SelectedIndexChanged += Zamowienia_listbox_SelectedIndexChanged;
            // 
            // Produkty_listbox
            // 
            Produkty_listbox.FormattingEnabled = true;
            Produkty_listbox.ItemHeight = 15;
            Produkty_listbox.Location = new Point(140, 72);
            Produkty_listbox.Name = "Produkty_listbox";
            Produkty_listbox.Size = new Size(120, 319);
            Produkty_listbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(140, 23);
            label1.Name = "label1";
            label1.Size = new Size(74, 29);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label2.Location = new Point(352, 72);
            label2.Name = "label2";
            label2.Size = new Size(56, 29);
            label2.TabIndex = 6;
            label2.Text = "Ilość";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.Location = new Point(352, 211);
            label3.Name = "label3";
            label3.Size = new Size(61, 29);
            label3.TabIndex = 7;
            label3.Text = "Cena";
            // 
            // Cena_wartosc
            // 
            Cena_wartosc.AutoSize = true;
            Cena_wartosc.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point, 238);
            Cena_wartosc.Location = new Point(419, 211);
            Cena_wartosc.Name = "Cena_wartosc";
            Cena_wartosc.Size = new Size(0, 29);
            Cena_wartosc.TabIndex = 8;
            // 
            // Ilość_wartosc
            // 
            Ilość_wartosc.AutoSize = true;
            Ilość_wartosc.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point, 238);
            Ilość_wartosc.Location = new Point(419, 72);
            Ilość_wartosc.Name = "Ilość_wartosc";
            Ilość_wartosc.Size = new Size(0, 29);
            Ilość_wartosc.TabIndex = 9;
            // 
            // Lista_zamowien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(Ilość_wartosc);
            Controls.Add(Cena_wartosc);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Produkty_listbox);
            Controls.Add(Zamowienia_listbox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Lista_zamowien";
            Text = "Lista_zamowien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox Zamowienia_listbox;
        private ListBox Produkty_listbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Cena_wartosc;
        private Label Ilość_wartosc;
    }
}