
namespace OpenTK3_StandardTemplate_WinForms
{
    partial class MainForm
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
            this.showAxes = new System.Windows.Forms.CheckBox();
            this.changeBackground = new System.Windows.Forms.Button();
            this.lblOx = new System.Windows.Forms.Label();
            this.lblOy = new System.Windows.Forms.Label();
            this.lblOz = new System.Windows.Forms.Label();
            this.resetScene = new System.Windows.Forms.Button();
            this.enableRotation = new System.Windows.Forms.CheckBox();
            this.enableObjectRotation = new System.Windows.Forms.CheckBox();
            this.Transparency = new System.Windows.Forms.Button();
            this.Texture1 = new System.Windows.Forms.RadioButton();
            this.texture2 = new System.Windows.Forms.RadioButton();
            this.light = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showAxes
            // 
            this.showAxes.AutoSize = true;
            this.showAxes.Checked = true;
            this.showAxes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxes.Location = new System.Drawing.Point(2232, 31);
            this.showAxes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.showAxes.Name = "showAxes";
            this.showAxes.Size = new System.Drawing.Size(193, 36);
            this.showAxes.TabIndex = 0;
            this.showAxes.Text = "Show Axes";
            this.showAxes.UseVisualStyleBackColor = true;
            this.showAxes.CheckedChanged += new System.EventHandler(this.showAxes_CheckedChanged);
            // 
            // changeBackground
            // 
            this.changeBackground.Location = new System.Drawing.Point(2232, 258);
            this.changeBackground.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.changeBackground.Name = "changeBackground";
            this.changeBackground.Size = new System.Drawing.Size(533, 76);
            this.changeBackground.TabIndex = 1;
            this.changeBackground.Text = "Change background color";
            this.changeBackground.UseVisualStyleBackColor = true;
            this.changeBackground.Click += new System.EventHandler(this.changeBackground_Click);
            // 
            // lblOx
            // 
            this.lblOx.BackColor = System.Drawing.Color.Red;
            this.lblOx.Location = new System.Drawing.Point(2291, 83);
            this.lblOx.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(107, 48);
            this.lblOx.TabIndex = 2;
            this.lblOx.Text = "Ox";
            this.lblOx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOy
            // 
            this.lblOy.BackColor = System.Drawing.Color.Green;
            this.lblOy.Location = new System.Drawing.Point(2413, 83);
            this.lblOy.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOy.Name = "lblOy";
            this.lblOy.Size = new System.Drawing.Size(107, 48);
            this.lblOy.TabIndex = 3;
            this.lblOy.Text = "Oy";
            this.lblOy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOz
            // 
            this.lblOz.BackColor = System.Drawing.Color.Blue;
            this.lblOz.Location = new System.Drawing.Point(2536, 83);
            this.lblOz.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblOz.Name = "lblOz";
            this.lblOz.Size = new System.Drawing.Size(107, 48);
            this.lblOz.TabIndex = 4;
            this.lblOz.Text = "Oz";
            this.lblOz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resetScene
            // 
            this.resetScene.Location = new System.Drawing.Point(2232, 348);
            this.resetScene.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.resetScene.Name = "resetScene";
            this.resetScene.Size = new System.Drawing.Size(533, 76);
            this.resetScene.TabIndex = 5;
            this.resetScene.Text = "Reset scene";
            this.resetScene.UseVisualStyleBackColor = true;
            this.resetScene.Click += new System.EventHandler(this.resetScene_Click);
            // 
            // enableRotation
            // 
            this.enableRotation.AutoSize = true;
            this.enableRotation.Location = new System.Drawing.Point(2232, 138);
            this.enableRotation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.enableRotation.Name = "enableRotation";
            this.enableRotation.Size = new System.Drawing.Size(337, 36);
            this.enableRotation.TabIndex = 6;
            this.enableRotation.Text = "Enable mouse rotation";
            this.enableRotation.UseVisualStyleBackColor = true;
            // 
            // enableObjectRotation
            // 
            this.enableObjectRotation.AutoSize = true;
            this.enableObjectRotation.Location = new System.Drawing.Point(2232, 198);
            this.enableObjectRotation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.enableObjectRotation.Name = "enableObjectRotation";
            this.enableObjectRotation.Size = new System.Drawing.Size(329, 36);
            this.enableObjectRotation.TabIndex = 7;
            this.enableObjectRotation.Text = "Enable object rotation";
            this.enableObjectRotation.UseVisualStyleBackColor = true;
            // 
            // Transparency
            // 
            this.Transparency.Location = new System.Drawing.Point(2232, 434);
            this.Transparency.Name = "Transparency";
            this.Transparency.Size = new System.Drawing.Size(533, 71);
            this.Transparency.TabIndex = 8;
            this.Transparency.Text = "alpha-blending";
            this.Transparency.UseVisualStyleBackColor = true;
            this.Transparency.Click += new System.EventHandler(this.Transparency_Click);
            // 
            // Texture1
            // 
            this.Texture1.AutoSize = true;
            this.Texture1.Location = new System.Drawing.Point(2232, 600);
            this.Texture1.Name = "Texture1";
            this.Texture1.Size = new System.Drawing.Size(154, 36);
            this.Texture1.TabIndex = 9;
            this.Texture1.TabStop = true;
            this.Texture1.Text = "texture1";
            this.Texture1.UseVisualStyleBackColor = true;
            this.Texture1.CheckedChanged += new System.EventHandler(this.Texture1_CheckedChanged);
            // 
            // texture2
            // 
            this.texture2.AutoSize = true;
            this.texture2.Location = new System.Drawing.Point(2232, 669);
            this.texture2.Name = "texture2";
            this.texture2.Size = new System.Drawing.Size(154, 36);
            this.texture2.TabIndex = 10;
            this.texture2.TabStop = true;
            this.texture2.Text = "texture2";
            this.texture2.UseVisualStyleBackColor = true;
            this.texture2.CheckedChanged += new System.EventHandler(this.texture2_CheckedChanged);
            // 
            // light
            // 
            this.light.Location = new System.Drawing.Point(2232, 519);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(533, 75);
            this.light.TabIndex = 11;
            this.light.Text = "Iluminare";
            this.light.UseVisualStyleBackColor = true;
            this.light.Click += new System.EventHandler(this.light_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2797, 1488);
            this.Controls.Add(this.light);
            this.Controls.Add(this.texture2);
            this.Controls.Add(this.Texture1);
            this.Controls.Add(this.Transparency);
            this.Controls.Add(this.enableObjectRotation);
            this.Controls.Add(this.enableRotation);
            this.Controls.Add(this.resetScene);
            this.Controls.Add(this.lblOz);
            this.Controls.Add(this.lblOy);
            this.Controls.Add(this.lblOx);
            this.Controls.Add(this.changeBackground);
            this.Controls.Add(this.showAxes);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "MainForm";
            this.Text = "OpenTK 3";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox showAxes;
        private System.Windows.Forms.Button changeBackground;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Label lblOy;
        private System.Windows.Forms.Label lblOz;
        private System.Windows.Forms.Button resetScene;
        private System.Windows.Forms.CheckBox enableRotation;
        private System.Windows.Forms.CheckBox enableObjectRotation;
        private System.Windows.Forms.Button Transparency;
        private System.Windows.Forms.RadioButton Texture1;
        private System.Windows.Forms.RadioButton texture2;
        private System.Windows.Forms.Button light;
    }
}

