namespace WindowsFormsApp_7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nerd_detector = new System.Windows.Forms.PictureBox();
            this.military_link = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gradus_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.surfacing_pb = new System.Windows.Forms.PictureBox();
            this.about_pb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerd_detector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacing_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // nerd_detector
            // 
            this.nerd_detector.BackColor = System.Drawing.Color.Transparent;
            this.nerd_detector.Image = ((System.Drawing.Image)(resources.GetObject("nerd_detector.Image")));
            this.nerd_detector.Location = new System.Drawing.Point(695, 12);
            this.nerd_detector.Name = "nerd_detector";
            this.nerd_detector.Size = new System.Drawing.Size(210, 210);
            this.nerd_detector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nerd_detector.TabIndex = 1;
            this.nerd_detector.TabStop = false;
            this.nerd_detector.Click += new System.EventHandler(this.nerd_detector_Click);
            // 
            // military_link
            // 
            this.military_link.AutoSize = true;
            this.military_link.BackColor = System.Drawing.Color.Transparent;
            this.military_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.military_link.ForeColor = System.Drawing.Color.Aqua;
            this.military_link.Location = new System.Drawing.Point(602, 855);
            this.military_link.Name = "military_link";
            this.military_link.Size = new System.Drawing.Size(101, 24);
            this.military_link.TabIndex = 2;
            this.military_link.Text = "К ракетам";
            this.military_link.Click += new System.EventHandler(this.military_link_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(418, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 210);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(985, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(89, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // gradus_lbl
            // 
            this.gradus_lbl.AutoSize = true;
            this.gradus_lbl.BackColor = System.Drawing.Color.Transparent;
            this.gradus_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradus_lbl.ForeColor = System.Drawing.Color.Aqua;
            this.gradus_lbl.Location = new System.Drawing.Point(1080, 287);
            this.gradus_lbl.Name = "gradus_lbl";
            this.gradus_lbl.Size = new System.Drawing.Size(36, 25);
            this.gradus_lbl.TabIndex = 5;
            this.gradus_lbl.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // surfacing_pb
            // 
            this.surfacing_pb.BackColor = System.Drawing.Color.Transparent;
            this.surfacing_pb.Image = ((System.Drawing.Image)(resources.GetObject("surfacing_pb.Image")));
            this.surfacing_pb.Location = new System.Drawing.Point(86, 663);
            this.surfacing_pb.Name = "surfacing_pb";
            this.surfacing_pb.Size = new System.Drawing.Size(96, 96);
            this.surfacing_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.surfacing_pb.TabIndex = 7;
            this.surfacing_pb.TabStop = false;
            this.surfacing_pb.Click += new System.EventHandler(this.surfacing_pb_Click);
            // 
            // about_pb
            // 
            this.about_pb.BackColor = System.Drawing.Color.Transparent;
            this.about_pb.Image = ((System.Drawing.Image)(resources.GetObject("about_pb.Image")));
            this.about_pb.Location = new System.Drawing.Point(1226, 789);
            this.about_pb.Name = "about_pb";
            this.about_pb.Size = new System.Drawing.Size(100, 100);
            this.about_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.about_pb.TabIndex = 8;
            this.about_pb.TabStop = false;
            this.about_pb.Click += new System.EventHandler(this.about_pb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 901);
            this.Controls.Add(this.about_pb);
            this.Controls.Add(this.surfacing_pb);
            this.Controls.Add(this.gradus_lbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.military_link);
            this.Controls.Add(this.nerd_detector);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Подводная лодка";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nerd_detector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surfacing_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.about_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox nerd_detector;
        private System.Windows.Forms.Label military_link;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label gradus_lbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox surfacing_pb;
        private System.Windows.Forms.PictureBox about_pb;
    }
}

