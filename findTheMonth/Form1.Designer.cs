namespace findTheMonth
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
            ayLbl = new Label();
            textGir = new TextBox();
            lblTikla = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // ayLbl
            // 
            ayLbl.AutoSize = true;
            ayLbl.Location = new Point(107, 90);
            ayLbl.Name = "ayLbl";
            ayLbl.Size = new Size(108, 21);
            ayLbl.TabIndex = 0;
            ayLbl.Text = "Ay Numarası";
            ayLbl.Click += a_Click;
            // 
            // textGir
            // 
            textGir.Location = new Point(107, 131);
            textGir.Name = "textGir";
            textGir.Size = new Size(100, 29);
            textGir.TabIndex = 1;
            // 
            // lblTikla
            // 
            lblTikla.AutoSize = true;
            lblTikla.Location = new Point(107, 182);
            lblTikla.Name = "lblTikla";
            lblTikla.Size = new Size(104, 21);
            lblTikla.TabIndex = 2;
            lblTikla.Text = "Ay Adını Bul";
            lblTikla.Click += lblTikla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 233);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 233);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 368);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(lblTikla);
            Controls.Add(textGir);
            Controls.Add(ayLbl);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Find The Month";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ayLbl;
        private TextBox textGir;
        private Label lblTikla;
        private Label label3;
        private Label label1;
    }
}