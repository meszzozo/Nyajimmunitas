namespace Nyajimmunitás
{
    partial class Form1
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
            this.BTNstart = new System.Windows.Forms.Button();
            this.NUDatoltottsag = new System.Windows.Forms.NumericUpDown();
            this.lblatoltottsag = new System.Windows.Forms.Label();
            this.lblfertozes = new System.Windows.Forms.Label();
            this.lblhalalozas = new System.Windows.Forms.Label();
            this.lblfertozottek = new System.Windows.Forms.Label();
            this.NUDfertozottek = new System.Windows.Forms.NumericUpDown();
            this.NUDhalalozas = new System.Windows.Forms.NumericUpDown();
            this.NUDfertozes = new System.Windows.Forms.NumericUpDown();
            this.lblemberszam = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblfert = new System.Windows.Forms.Label();
            this.lblhal = new System.Windows.Forms.Label();
            this.lblkigyogyultakszama = new System.Windows.Forms.Label();
            this.lblkigyogy = new System.Windows.Forms.Label();
            this.lblfertozotekszama = new System.Windows.Forms.Label();
            this.lblhalottakszama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDatoltottsag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfertozottek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDhalalozas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfertozes)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNstart
            // 
            this.BTNstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNstart.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BTNstart.Location = new System.Drawing.Point(1005, 198);
            this.BTNstart.Name = "BTNstart";
            this.BTNstart.Size = new System.Drawing.Size(235, 70);
            this.BTNstart.TabIndex = 0;
            this.BTNstart.Text = "START";
            this.BTNstart.UseVisualStyleBackColor = false;
            this.BTNstart.Click += new System.EventHandler(this.BTNstart_Click);
            // 
            // NUDatoltottsag
            // 
            this.NUDatoltottsag.Location = new System.Drawing.Point(1190, 52);
            this.NUDatoltottsag.Name = "NUDatoltottsag";
            this.NUDatoltottsag.Size = new System.Drawing.Size(50, 20);
            this.NUDatoltottsag.TabIndex = 1;
            this.NUDatoltottsag.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblatoltottsag
            // 
            this.lblatoltottsag.AutoSize = true;
            this.lblatoltottsag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblatoltottsag.ForeColor = System.Drawing.SystemColors.Control;
            this.lblatoltottsag.Location = new System.Drawing.Point(1000, 50);
            this.lblatoltottsag.Name = "lblatoltottsag";
            this.lblatoltottsag.Size = new System.Drawing.Size(125, 25);
            this.lblatoltottsag.TabIndex = 2;
            this.lblatoltottsag.Text = "Átoltottság";
            // 
            // lblfertozes
            // 
            this.lblfertozes.AutoSize = true;
            this.lblfertozes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfertozes.Location = new System.Drawing.Point(1000, 140);
            this.lblfertozes.Name = "lblfertozes";
            this.lblfertozes.Size = new System.Drawing.Size(104, 25);
            this.lblfertozes.TabIndex = 3;
            this.lblfertozes.Text = "Fertőzés";
            // 
            // lblhalalozas
            // 
            this.lblhalalozas.AutoSize = true;
            this.lblhalalozas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhalalozas.Location = new System.Drawing.Point(1000, 110);
            this.lblhalalozas.Name = "lblhalalozas";
            this.lblhalalozas.Size = new System.Drawing.Size(116, 25);
            this.lblhalalozas.TabIndex = 4;
            this.lblhalalozas.Text = "Halálozás";
            // 
            // lblfertozottek
            // 
            this.lblfertozottek.AutoSize = true;
            this.lblfertozottek.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfertozottek.Location = new System.Drawing.Point(1000, 80);
            this.lblfertozottek.Name = "lblfertozottek";
            this.lblfertozottek.Size = new System.Drawing.Size(131, 25);
            this.lblfertozottek.TabIndex = 5;
            this.lblfertozottek.Text = "Fertőzöttek";
            // 
            // NUDfertozottek
            // 
            this.NUDfertozottek.Location = new System.Drawing.Point(1190, 82);
            this.NUDfertozottek.Name = "NUDfertozottek";
            this.NUDfertozottek.Size = new System.Drawing.Size(50, 20);
            this.NUDfertozottek.TabIndex = 6;
            this.NUDfertozottek.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // NUDhalalozas
            // 
            this.NUDhalalozas.Location = new System.Drawing.Point(1190, 112);
            this.NUDhalalozas.Name = "NUDhalalozas";
            this.NUDhalalozas.Size = new System.Drawing.Size(50, 20);
            this.NUDhalalozas.TabIndex = 7;
            this.NUDhalalozas.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // NUDfertozes
            // 
            this.NUDfertozes.Location = new System.Drawing.Point(1190, 142);
            this.NUDfertozes.Name = "NUDfertozes";
            this.NUDfertozes.Size = new System.Drawing.Size(50, 20);
            this.NUDfertozes.TabIndex = 8;
            this.NUDfertozes.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblemberszam
            // 
            this.lblemberszam.AutoSize = true;
            this.lblemberszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblemberszam.Location = new System.Drawing.Point(1000, 20);
            this.lblemberszam.Name = "lblemberszam";
            this.lblemberszam.Size = new System.Drawing.Size(245, 25);
            this.lblemberszam.TabIndex = 9;
            this.lblemberszam.Text = "Emberek száma: 1000";
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblfert
            // 
            this.lblfert.AutoSize = true;
            this.lblfert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfert.Location = new System.Drawing.Point(1000, 314);
            this.lblfert.Name = "lblfert";
            this.lblfert.Size = new System.Drawing.Size(138, 25);
            this.lblfert.TabIndex = 10;
            this.lblfert.Text = "Fertőzöttek:";
            // 
            // lblhal
            // 
            this.lblhal.AutoSize = true;
            this.lblhal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhal.Location = new System.Drawing.Point(1000, 425);
            this.lblhal.Name = "lblhal";
            this.lblhal.Size = new System.Drawing.Size(106, 25);
            this.lblhal.TabIndex = 11;
            this.lblhal.Text = "Halottak:";
            // 
            // lblkigyogyultakszama
            // 
            this.lblkigyogyultakszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblkigyogyultakszama.Location = new System.Drawing.Point(1185, 367);
            this.lblkigyogyultakszama.Name = "lblkigyogyultakszama";
            this.lblkigyogyultakszama.Size = new System.Drawing.Size(50, 25);
            this.lblkigyogyultakszama.TabIndex = 12;
            // 
            // lblkigyogy
            // 
            this.lblkigyogy.AutoSize = true;
            this.lblkigyogy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblkigyogy.Location = new System.Drawing.Point(1000, 367);
            this.lblkigyogy.Name = "lblkigyogy";
            this.lblkigyogy.Size = new System.Drawing.Size(154, 25);
            this.lblkigyogy.TabIndex = 13;
            this.lblkigyogy.Text = "Kigyógyultak:";
            // 
            // lblfertozotekszama
            // 
            this.lblfertozotekszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblfertozotekszama.Location = new System.Drawing.Point(1185, 314);
            this.lblfertozotekszama.Name = "lblfertozotekszama";
            this.lblfertozotekszama.Size = new System.Drawing.Size(50, 25);
            this.lblfertozotekszama.TabIndex = 14;
            // 
            // lblhalottakszama
            // 
            this.lblhalottakszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblhalottakszama.Location = new System.Drawing.Point(1185, 425);
            this.lblhalottakszama.Name = "lblhalottakszama";
            this.lblhalottakszama.Size = new System.Drawing.Size(50, 25);
            this.lblhalottakszama.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1267, 861);
            this.Controls.Add(this.lblhalottakszama);
            this.Controls.Add(this.lblfertozotekszama);
            this.Controls.Add(this.lblkigyogy);
            this.Controls.Add(this.lblkigyogyultakszama);
            this.Controls.Add(this.lblhal);
            this.Controls.Add(this.lblfert);
            this.Controls.Add(this.lblemberszam);
            this.Controls.Add(this.NUDfertozes);
            this.Controls.Add(this.NUDhalalozas);
            this.Controls.Add(this.NUDfertozottek);
            this.Controls.Add(this.lblfertozottek);
            this.Controls.Add(this.lblhalalozas);
            this.Controls.Add(this.lblfertozes);
            this.Controls.Add(this.lblatoltottsag);
            this.Controls.Add(this.NUDatoltottsag);
            this.Controls.Add(this.BTNstart);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Nyájimmunitás";
            ((System.ComponentModel.ISupportInitialize)(this.NUDatoltottsag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfertozottek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDhalalozas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDfertozes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNstart;
        private System.Windows.Forms.NumericUpDown NUDatoltottsag;
        private System.Windows.Forms.Label lblatoltottsag;
        private System.Windows.Forms.Label lblfertozes;
        private System.Windows.Forms.Label lblhalalozas;
        private System.Windows.Forms.Label lblfertozottek;
        private System.Windows.Forms.NumericUpDown NUDfertozottek;
        private System.Windows.Forms.NumericUpDown NUDhalalozas;
        private System.Windows.Forms.NumericUpDown NUDfertozes;
        private System.Windows.Forms.Label lblemberszam;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblfert;
        private System.Windows.Forms.Label lblhal;
        private System.Windows.Forms.Label lblkigyogyultakszama;
        private System.Windows.Forms.Label lblkigyogy;
        private System.Windows.Forms.Label lblfertozotekszama;
        private System.Windows.Forms.Label lblhalottakszama;
    }
}

