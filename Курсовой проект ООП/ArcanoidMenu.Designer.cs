
namespace Курсовой_проект_ООП
{
    partial class ArcanoidMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArcanoidMenu));
            this.Play = new System.Windows.Forms.Button();
            this.GameRules = new System.Windows.Forms.Button();
            this.MenuExit = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.Constructor = new System.Windows.Forms.Button();
            this.Rules = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Play.BackgroundImage")));
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.ForeColor = System.Drawing.Color.White;
            this.Play.Location = new System.Drawing.Point(109, 102);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(200, 50);
            this.Play.TabIndex = 0;
            this.Play.Text = "Играть";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // GameRules
            // 
            this.GameRules.BackColor = System.Drawing.Color.Transparent;
            this.GameRules.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameRules.BackgroundImage")));
            this.GameRules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameRules.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameRules.ForeColor = System.Drawing.Color.White;
            this.GameRules.Location = new System.Drawing.Point(109, 158);
            this.GameRules.Name = "GameRules";
            this.GameRules.Size = new System.Drawing.Size(200, 50);
            this.GameRules.TabIndex = 3;
            this.GameRules.Text = "Правила";
            this.GameRules.UseVisualStyleBackColor = false;
            this.GameRules.Click += new System.EventHandler(this.GameRules_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.BackColor = System.Drawing.Color.Transparent;
            this.MenuExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuExit.BackgroundImage")));
            this.MenuExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MenuExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuExit.ForeColor = System.Drawing.Color.White;
            this.MenuExit.Location = new System.Drawing.Point(109, 271);
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(200, 50);
            this.MenuExit.TabIndex = 4;
            this.MenuExit.Text = "Выход";
            this.MenuExit.UseVisualStyleBackColor = false;
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.Transparent;
            this.Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Ok.BackgroundImage")));
            this.Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(109, 367);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(200, 50);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = false;
            this.Ok.Visible = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Constructor
            // 
            this.Constructor.BackColor = System.Drawing.Color.Transparent;
            this.Constructor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Constructor.BackgroundImage")));
            this.Constructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Constructor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Constructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Constructor.ForeColor = System.Drawing.Color.White;
            this.Constructor.Location = new System.Drawing.Point(109, 215);
            this.Constructor.Name = "Constructor";
            this.Constructor.Size = new System.Drawing.Size(200, 50);
            this.Constructor.TabIndex = 8;
            this.Constructor.Text = "Конструктор";
            this.Constructor.UseVisualStyleBackColor = false;
            this.Constructor.Click += new System.EventHandler(this.Constructor_Click);
            // 
            // Rules
            // 
            this.Rules.Image = ((System.Drawing.Image)(resources.GetObject("Rules.Image")));
            this.Rules.Location = new System.Drawing.Point(19, 92);
            this.Rules.Name = "Rules";
            this.Rules.Size = new System.Drawing.Size(369, 256);
            this.Rules.TabIndex = 9;
            this.Rules.TabStop = false;
            this.Rules.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(109, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 10;
            this.button1.Text = "Информация";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 129);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // ArcanoidMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(400, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rules);
            this.Controls.Add(this.Constructor);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.MenuExit);
            this.Controls.Add(this.GameRules);
            this.Controls.Add(this.Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(416, 527);
            this.Name = "ArcanoidMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Rules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button GameRules;
        private System.Windows.Forms.Button MenuExit;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Constructor;
        private System.Windows.Forms.PictureBox Rules;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}