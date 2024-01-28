namespace Projekt_3_Semestr_Programowanie
{
    partial class Okno_Logowania
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
            Imie = new TextBox();
            Nazwisko = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Imie
            // 
            Imie.Location = new Point(234, 163);
            Imie.Name = "Imie";
            Imie.Size = new Size(100, 23);
            Imie.TabIndex = 0;
            // 
            // Nazwisko
            // 
            Nazwisko.Location = new Point(396, 163);
            Nazwisko.Name = "Nazwisko";
            Nazwisko.Size = new Size(100, 23);
            Nazwisko.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 136);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Nazwisko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(265, 136);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Imię";
            // 
            // button1
            // 
            button1.Location = new Point(330, 242);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Zaloguj się";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Okno_Logowania
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baner_4_co_u_nas_slychac_biznes;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nazwisko);
            Controls.Add(Imie);
            Name = "Okno_Logowania";
            Text = "Okno_Logowania";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Imie;
        private TextBox Nazwisko;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}