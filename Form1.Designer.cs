namespace WF.Niquel
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btnJogar = new Button();
            timerSpin = new System.Windows.Forms.Timer(components);
            timer1 = new System.Windows.Forms.Timer(components);
            btn2 = new Button();
            btn3 = new Button();
            label1 = new Label();
            lblcoin = new Label();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 150F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn1.Location = new Point(38, 104);
            btn1.Name = "btn1";
            btn1.Size = new Size(372, 306);
            btn1.TabIndex = 0;
            btn1.Text = "0";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btnJogar
            // 
            btnJogar.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnJogar.Location = new Point(38, 12);
            btnJogar.Name = "btnJogar";
            btnJogar.Size = new Size(372, 69);
            btnJogar.TabIndex = 1;
            btnJogar.Text = "Jogar";
            btnJogar.UseVisualStyleBackColor = true;
            btnJogar.Click += btnJogar_Click;
            // 
            // timerSpin
            // 
            timerSpin.Tick += timerSpin_Tick;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 150F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn2.Location = new Point(445, 104);
            btn2.Name = "btn2";
            btn2.Size = new Size(372, 306);
            btn2.TabIndex = 2;
            btn2.Text = "0";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 150F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn3.Location = new Point(855, 104);
            btn3.Name = "btn3";
            btn3.Size = new Size(372, 306);
            btn3.TabIndex = 3;
            btn3.Text = "0";
            btn3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 450);
            label1.Name = "label1";
            label1.Size = new Size(151, 62);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // lblcoin
            // 
            lblcoin.AutoSize = true;
            lblcoin.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcoin.Location = new Point(802, 19);
            lblcoin.Name = "lblcoin";
            lblcoin.Size = new Size(93, 62);
            lblcoin.TabIndex = 5;
            lblcoin.Text = "xxx";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl3.Location = new Point(657, 19);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(139, 62);
            lbl3.TabIndex = 6;
            lbl3.Text = "COIN";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1300, 621);
            Controls.Add(lbl3);
            Controls.Add(lblcoin);
            Controls.Add(label1);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnJogar);
            Controls.Add(btn1);
            ForeColor = Color.Orange;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btnJogar;
        private System.Windows.Forms.Timer timerSpin;
        private System.Windows.Forms.Timer timer1;
        private Button btn2;
        private Button btn3;
        private Label label1;
        private Label lblcoin;
        private Label lbl3;
    }
}
