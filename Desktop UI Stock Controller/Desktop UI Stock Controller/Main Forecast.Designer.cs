namespace Desktop_UI_Stock_Controller
{
    partial class Main_Forecast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Forecast));
            this.label1 = new System.Windows.Forms.Label();
            this.returnHmeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "This is the Main Forecast";
            // 
            // returnHmeBtn
            // 
            this.returnHmeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.returnHmeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.returnHmeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnHmeBtn.BorderRadius = 0;
            this.returnHmeBtn.ButtonText = "Return to Home";
            this.returnHmeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnHmeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.returnHmeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.returnHmeBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("returnHmeBtn.Iconimage")));
            this.returnHmeBtn.Iconimage_right = null;
            this.returnHmeBtn.Iconimage_right_Selected = null;
            this.returnHmeBtn.Iconimage_Selected = null;
            this.returnHmeBtn.IconMarginLeft = 0;
            this.returnHmeBtn.IconMarginRight = 0;
            this.returnHmeBtn.IconRightVisible = true;
            this.returnHmeBtn.IconRightZoom = 0D;
            this.returnHmeBtn.IconVisible = true;
            this.returnHmeBtn.IconZoom = 50D;
            this.returnHmeBtn.IsTab = false;
            this.returnHmeBtn.Location = new System.Drawing.Point(263, 296);
            this.returnHmeBtn.Name = "returnHmeBtn";
            this.returnHmeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.returnHmeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.returnHmeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.returnHmeBtn.selected = false;
            this.returnHmeBtn.Size = new System.Drawing.Size(155, 48);
            this.returnHmeBtn.TabIndex = 1;
            this.returnHmeBtn.Text = "Return to Home";
            this.returnHmeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnHmeBtn.Textcolor = System.Drawing.Color.White;
            this.returnHmeBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnHmeBtn.Click += new System.EventHandler(this.returnHmeBtn_Click);
            // 
            // Main_Forecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnHmeBtn);
            this.Controls.Add(this.label1);
            this.Name = "Main_Forecast";
            this.Text = "Main_Forecast";
            this.Load += new System.EventHandler(this.Main_Forecast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton returnHmeBtn;
    }
}