namespace WindowsFormsApp_7
{
    partial class Rockets
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
            this.rocket_cmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boom_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // rocket_cmbx
            // 
            this.rocket_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rocket_cmbx.FormattingEnabled = true;
            this.rocket_cmbx.Items.AddRange(new object[] {
            "\'Поларис\' А1",
            "\'Посейдон\'",
            "\'Синева\'",
            "\'Р-29\'"});
            this.rocket_cmbx.Location = new System.Drawing.Point(132, 103);
            this.rocket_cmbx.Name = "rocket_cmbx";
            this.rocket_cmbx.Size = new System.Drawing.Size(121, 21);
            this.rocket_cmbx.TabIndex = 0;
            this.rocket_cmbx.SelectedIndexChanged += new System.EventHandler(this.rocket_cmbx_SelectedIndexChanged);
            this.rocket_cmbx.SelectedValueChanged += new System.EventHandler(this.rocket_cmbx_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(86, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите тип ракет, \r\nкоторыми будете стрелять:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boom_btn
            // 
            this.boom_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boom_btn.Location = new System.Drawing.Point(150, 429);
            this.boom_btn.Name = "boom_btn";
            this.boom_btn.Size = new System.Drawing.Size(103, 41);
            this.boom_btn.TabIndex = 2;
            this.boom_btn.Text = "Ударить!";
            this.boom_btn.UseVisualStyleBackColor = true;
            this.boom_btn.Click += new System.EventHandler(this.boom_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Rockets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(412, 513);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.boom_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rocket_cmbx);
            this.Name = "Rockets";
            this.Text = "Ракеты";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox rocket_cmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boom_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}