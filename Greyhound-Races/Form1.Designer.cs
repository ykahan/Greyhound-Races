namespace Greyhound_Races
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TrackPicBox = new System.Windows.Forms.PictureBox();
            this.Dog1PicBox = new System.Windows.Forms.PictureBox();
            this.Dog2PicBox = new System.Windows.Forms.PictureBox();
            this.Dog3PicBox = new System.Windows.Forms.PictureBox();
            this.Dog4PicBox = new System.Windows.Forms.PictureBox();
            this.BusinessNameLbl = new System.Windows.Forms.Label();
            this.MinimumBetLbl = new System.Windows.Forms.Label();
            this.JoeBtn = new System.Windows.Forms.RadioButton();
            this.BobBtn = new System.Windows.Forms.RadioButton();
            this.AlBtn = new System.Windows.Forms.RadioButton();
            this.BetSizeLbl = new System.Windows.Forms.Label();
            this.BetUpDown = new System.Windows.Forms.NumericUpDown();
            this.OnDogLbl = new System.Windows.Forms.Label();
            this.DogUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartBtn = new System.Windows.Forms.Button();
            this.JoeLbl = new System.Windows.Forms.Label();
            this.BobLbl = new System.Windows.Forms.Label();
            this.AlLbl = new System.Windows.Forms.Label();
            this.PlaceBetBtn = new System.Windows.Forms.Button();
            this.RaceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TrackPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackPicBox
            // 
            this.TrackPicBox.Image = ((System.Drawing.Image)(resources.GetObject("TrackPicBox.Image")));
            this.TrackPicBox.Location = new System.Drawing.Point(0, 2);
            this.TrackPicBox.Name = "TrackPicBox";
            this.TrackPicBox.Size = new System.Drawing.Size(783, 201);
            this.TrackPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TrackPicBox.TabIndex = 0;
            this.TrackPicBox.TabStop = false;
            // 
            // Dog1PicBox
            // 
            this.Dog1PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog1PicBox.Image")));
            this.Dog1PicBox.Location = new System.Drawing.Point(0, 12);
            this.Dog1PicBox.Name = "Dog1PicBox";
            this.Dog1PicBox.Size = new System.Drawing.Size(75, 20);
            this.Dog1PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dog1PicBox.TabIndex = 1;
            this.Dog1PicBox.TabStop = false;
            // 
            // Dog2PicBox
            // 
            this.Dog2PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog2PicBox.Image")));
            this.Dog2PicBox.Location = new System.Drawing.Point(0, 56);
            this.Dog2PicBox.Name = "Dog2PicBox";
            this.Dog2PicBox.Size = new System.Drawing.Size(75, 20);
            this.Dog2PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dog2PicBox.TabIndex = 2;
            this.Dog2PicBox.TabStop = false;
            // 
            // Dog3PicBox
            // 
            this.Dog3PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog3PicBox.Image")));
            this.Dog3PicBox.Location = new System.Drawing.Point(0, 118);
            this.Dog3PicBox.Name = "Dog3PicBox";
            this.Dog3PicBox.Size = new System.Drawing.Size(75, 20);
            this.Dog3PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dog3PicBox.TabIndex = 3;
            this.Dog3PicBox.TabStop = false;
            // 
            // Dog4PicBox
            // 
            this.Dog4PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Dog4PicBox.Image")));
            this.Dog4PicBox.Location = new System.Drawing.Point(0, 171);
            this.Dog4PicBox.Name = "Dog4PicBox";
            this.Dog4PicBox.Size = new System.Drawing.Size(75, 20);
            this.Dog4PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dog4PicBox.TabIndex = 4;
            this.Dog4PicBox.TabStop = false;
            // 
            // BusinessNameLbl
            // 
            this.BusinessNameLbl.AutoSize = true;
            this.BusinessNameLbl.Location = new System.Drawing.Point(13, 210);
            this.BusinessNameLbl.Name = "BusinessNameLbl";
            this.BusinessNameLbl.Size = new System.Drawing.Size(158, 13);
            this.BusinessNameLbl.TabIndex = 5;
            this.BusinessNameLbl.Text = "Yehoshua\'s Illegal Betting Parlor";
            // 
            // MinimumBetLbl
            // 
            this.MinimumBetLbl.AutoSize = true;
            this.MinimumBetLbl.Location = new System.Drawing.Point(16, 227);
            this.MinimumBetLbl.Name = "MinimumBetLbl";
            this.MinimumBetLbl.Size = new System.Drawing.Size(92, 13);
            this.MinimumBetLbl.TabIndex = 6;
            this.MinimumBetLbl.Text = "Minimum Bet is $1";
            this.MinimumBetLbl.Click += new System.EventHandler(this.MinimumBetLbl_Click);
            // 
            // JoeBtn
            // 
            this.JoeBtn.AutoSize = true;
            this.JoeBtn.Checked = true;
            this.JoeBtn.Location = new System.Drawing.Point(13, 260);
            this.JoeBtn.Name = "JoeBtn";
            this.JoeBtn.Size = new System.Drawing.Size(42, 17);
            this.JoeBtn.TabIndex = 10;
            this.JoeBtn.TabStop = true;
            this.JoeBtn.Text = "Joe";
            this.JoeBtn.UseVisualStyleBackColor = true;
            this.JoeBtn.CheckedChanged += new System.EventHandler(this.JoeBtn_CheckedChanged);
            // 
            // BobBtn
            // 
            this.BobBtn.AutoSize = true;
            this.BobBtn.Location = new System.Drawing.Point(13, 293);
            this.BobBtn.Name = "BobBtn";
            this.BobBtn.Size = new System.Drawing.Size(44, 17);
            this.BobBtn.TabIndex = 11;
            this.BobBtn.Text = "Bob";
            this.BobBtn.UseVisualStyleBackColor = true;
            // 
            // AlBtn
            // 
            this.AlBtn.AutoSize = true;
            this.AlBtn.Location = new System.Drawing.Point(13, 329);
            this.AlBtn.Name = "AlBtn";
            this.AlBtn.Size = new System.Drawing.Size(34, 17);
            this.AlBtn.TabIndex = 12;
            this.AlBtn.Text = "Al";
            this.AlBtn.UseVisualStyleBackColor = true;
            // 
            // BetSizeLbl
            // 
            this.BetSizeLbl.AutoSize = true;
            this.BetSizeLbl.Location = new System.Drawing.Point(195, 260);
            this.BetSizeLbl.Name = "BetSizeLbl";
            this.BetSizeLbl.Size = new System.Drawing.Size(82, 13);
            this.BetSizeLbl.TabIndex = 14;
            this.BetSizeLbl.Text = "Wants To Bet $";
            this.BetSizeLbl.Click += new System.EventHandler(this.BetSizeLbl_Click);
            // 
            // BetUpDown
            // 
            this.BetUpDown.Location = new System.Drawing.Point(273, 259);
            this.BetUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BetUpDown.Name = "BetUpDown";
            this.BetUpDown.Size = new System.Drawing.Size(35, 20);
            this.BetUpDown.TabIndex = 15;
            this.BetUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BetUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // OnDogLbl
            // 
            this.OnDogLbl.AutoSize = true;
            this.OnDogLbl.Location = new System.Drawing.Point(314, 260);
            this.OnDogLbl.Name = "OnDogLbl";
            this.OnDogLbl.Size = new System.Drawing.Size(84, 13);
            this.OnDogLbl.TabIndex = 16;
            this.OnDogLbl.Text = "On Dog Number";
            // 
            // DogUpDown
            // 
            this.DogUpDown.Location = new System.Drawing.Point(404, 257);
            this.DogUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogUpDown.Name = "DogUpDown";
            this.DogUpDown.Size = new System.Drawing.Size(25, 20);
            this.DogUpDown.TabIndex = 17;
            this.DogUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartBtn
            // 
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBtn.Location = new System.Drawing.Point(498, 210);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(285, 145);
            this.StartBtn.TabIndex = 18;
            this.StartBtn.Text = "Race!";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // JoeLbl
            // 
            this.JoeLbl.AutoSize = true;
            this.JoeLbl.Location = new System.Drawing.Point(195, 282);
            this.JoeLbl.Name = "JoeLbl";
            this.JoeLbl.Size = new System.Drawing.Size(134, 13);
            this.JoeLbl.TabIndex = 19;
            this.JoeLbl.Text = "Joe Has  Not Placed A Bet";
            // 
            // BobLbl
            // 
            this.BobLbl.AutoSize = true;
            this.BobLbl.Location = new System.Drawing.Point(195, 306);
            this.BobLbl.Name = "BobLbl";
            this.BobLbl.Size = new System.Drawing.Size(133, 13);
            this.BobLbl.TabIndex = 20;
            this.BobLbl.Text = "Bob Has Not Placed A Bet";
            // 
            // AlLbl
            // 
            this.AlLbl.AutoSize = true;
            this.AlLbl.Location = new System.Drawing.Point(195, 329);
            this.AlLbl.Name = "AlLbl";
            this.AlLbl.Size = new System.Drawing.Size(123, 13);
            this.AlLbl.TabIndex = 21;
            this.AlLbl.Text = "Al Has Not Placed A Bet";
            // 
            // PlaceBetBtn
            // 
            this.PlaceBetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaceBetBtn.Location = new System.Drawing.Point(343, 282);
            this.PlaceBetBtn.Name = "PlaceBetBtn";
            this.PlaceBetBtn.Size = new System.Drawing.Size(124, 60);
            this.PlaceBetBtn.TabIndex = 22;
            this.PlaceBetBtn.TabStop = false;
            this.PlaceBetBtn.Text = "Place Bet";
            this.PlaceBetBtn.UseVisualStyleBackColor = true;
            this.PlaceBetBtn.Click += new System.EventHandler(this.PlaceBetBtn_Click);
            // 
            // RaceTimer
            // 
            this.RaceTimer.Interval = 1;
            this.RaceTimer.Tick += new System.EventHandler(this.RaceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 358);
            this.Controls.Add(this.PlaceBetBtn);
            this.Controls.Add(this.AlLbl);
            this.Controls.Add(this.BobLbl);
            this.Controls.Add(this.JoeLbl);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DogUpDown);
            this.Controls.Add(this.OnDogLbl);
            this.Controls.Add(this.BetUpDown);
            this.Controls.Add(this.BetSizeLbl);
            this.Controls.Add(this.AlBtn);
            this.Controls.Add(this.BobBtn);
            this.Controls.Add(this.JoeBtn);
            this.Controls.Add(this.MinimumBetLbl);
            this.Controls.Add(this.BusinessNameLbl);
            this.Controls.Add(this.Dog4PicBox);
            this.Controls.Add(this.Dog3PicBox);
            this.Controls.Add(this.Dog2PicBox);
            this.Controls.Add(this.Dog1PicBox);
            this.Controls.Add(this.TrackPicBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.TrackPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TrackPicBox;
        private System.Windows.Forms.PictureBox Dog1PicBox;
        private System.Windows.Forms.PictureBox Dog2PicBox;
        private System.Windows.Forms.PictureBox Dog3PicBox;
        private System.Windows.Forms.PictureBox Dog4PicBox;
        private System.Windows.Forms.Label BusinessNameLbl;
        private System.Windows.Forms.Label MinimumBetLbl;
        private System.Windows.Forms.RadioButton JoeBtn;
        private System.Windows.Forms.RadioButton BobBtn;
        private System.Windows.Forms.RadioButton AlBtn;
        private System.Windows.Forms.Label BetSizeLbl;
        private System.Windows.Forms.NumericUpDown BetUpDown;
        private System.Windows.Forms.Label OnDogLbl;
        private System.Windows.Forms.NumericUpDown DogUpDown;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label JoeLbl;
        private System.Windows.Forms.Label BobLbl;
        private System.Windows.Forms.Label AlLbl;
        private System.Windows.Forms.Button PlaceBetBtn;
        private System.Windows.Forms.Timer RaceTimer;
    }
}

