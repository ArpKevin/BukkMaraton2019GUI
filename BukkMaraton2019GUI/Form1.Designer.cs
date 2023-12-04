namespace BukkMaraton2019GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_tav = new Label();
            lbl_ido = new Label();
            lbl_atlagsebessegkmh = new Label();
            lbl_atlagsebessegms = new Label();
            lbl_kmh_mezo = new Label();
            lbl_ms_mezo = new Label();
            txtbox_ido = new TextBox();
            btn_szamol = new Button();
            combobox_tav = new ComboBox();
            SuspendLayout();
            // 
            // lbl_tav
            // 
            lbl_tav.AutoSize = true;
            lbl_tav.Location = new Point(57, 73);
            lbl_tav.Name = "lbl_tav";
            lbl_tav.Size = new Size(27, 15);
            lbl_tav.TabIndex = 0;
            lbl_tav.Text = "Táv:";
            // 
            // lbl_ido
            // 
            lbl_ido.AutoSize = true;
            lbl_ido.Location = new Point(57, 118);
            lbl_ido.Name = "lbl_ido";
            lbl_ido.Size = new Size(102, 15);
            lbl_ido.TabIndex = 1;
            lbl_ido.Text = "Idő [óra:perc:mp]:";
            // 
            // lbl_atlagsebessegkmh
            // 
            lbl_atlagsebessegkmh.AutoSize = true;
            lbl_atlagsebessegkmh.Location = new Point(57, 166);
            lbl_atlagsebessegkmh.Name = "lbl_atlagsebessegkmh";
            lbl_atlagsebessegkmh.Size = new Size(129, 15);
            lbl_atlagsebessegkmh.TabIndex = 2;
            lbl_atlagsebessegkmh.Text = "Átlagsebesség [km/h)]:";
            // 
            // lbl_atlagsebessegms
            // 
            lbl_atlagsebessegms.AutoSize = true;
            lbl_atlagsebessegms.Location = new Point(57, 207);
            lbl_atlagsebessegms.Name = "lbl_atlagsebessegms";
            lbl_atlagsebessegms.Size = new Size(121, 15);
            lbl_atlagsebessegms.TabIndex = 2;
            lbl_atlagsebessegms.Text = "Átlagsebesség [m/s)]:";
            // 
            // lbl_kmh_mezo
            // 
            lbl_kmh_mezo.AutoSize = true;
            lbl_kmh_mezo.Location = new Point(222, 165);
            lbl_kmh_mezo.Name = "lbl_kmh_mezo";
            lbl_kmh_mezo.Size = new Size(0, 15);
            lbl_kmh_mezo.TabIndex = 3;
            // 
            // lbl_ms_mezo
            // 
            lbl_ms_mezo.AutoSize = true;
            lbl_ms_mezo.Location = new Point(222, 207);
            lbl_ms_mezo.Name = "lbl_ms_mezo";
            lbl_ms_mezo.Size = new Size(0, 15);
            lbl_ms_mezo.TabIndex = 3;
            // 
            // txtbox_ido
            // 
            txtbox_ido.Location = new Point(195, 115);
            txtbox_ido.Name = "txtbox_ido";
            txtbox_ido.Size = new Size(100, 23);
            txtbox_ido.TabIndex = 4;
            txtbox_ido.Text = "1:00:00";
            // 
            // btn_szamol
            // 
            btn_szamol.Location = new Point(313, 73);
            btn_szamol.Name = "btn_szamol";
            btn_szamol.Size = new Size(101, 65);
            btn_szamol.TabIndex = 5;
            btn_szamol.Text = "Számol";
            btn_szamol.UseVisualStyleBackColor = true;
            btn_szamol.Click += btn_szamol_Click;
            // 
            // combobox_tav
            // 
            combobox_tav.FormattingEnabled = true;
            combobox_tav.Location = new Point(114, 73);
            combobox_tav.Name = "combobox_tav";
            combobox_tav.Size = new Size(181, 23);
            combobox_tav.TabIndex = 6;
            combobox_tav.Text = "Közép - 57km";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(combobox_tav);
            Controls.Add(btn_szamol);
            Controls.Add(txtbox_ido);
            Controls.Add(lbl_ms_mezo);
            Controls.Add(lbl_kmh_mezo);
            Controls.Add(lbl_atlagsebessegms);
            Controls.Add(lbl_atlagsebessegkmh);
            Controls.Add(lbl_ido);
            Controls.Add(lbl_tav);
            Name = "Form1";
            Text = "Bükk Maraton 2019";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tav;
        private Label lbl_ido;
        private Label lbl_atlagsebessegkmh;
        private Label lbl_atlagsebessegms;
        private Label lbl_kmh_mezo;
        private Label lbl_ms_mezo;
        private TextBox txtbox_ido;
        private Button btn_szamol;
        private ComboBox combobox_tav;
    }
}