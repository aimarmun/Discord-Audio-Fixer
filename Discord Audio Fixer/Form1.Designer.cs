
namespace Discord_Audio_Fixer
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
            this.buttonFix = new System.Windows.Forms.Button();
            this.buttonDefaults = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.checkBoxFixOnStart = new System.Windows.Forms.CheckBox();
            this.checkBoxDefaultWhenExit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonFix
            // 
            this.buttonFix.Location = new System.Drawing.Point(12, 258);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(172, 56);
            this.buttonFix.TabIndex = 0;
            this.buttonFix.Text = "Fix";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // buttonDefaults
            // 
            this.buttonDefaults.Location = new System.Drawing.Point(199, 258);
            this.buttonDefaults.Name = "buttonDefaults";
            this.buttonDefaults.Size = new System.Drawing.Size(172, 56);
            this.buttonDefaults.TabIndex = 0;
            this.buttonDefaults.Text = "Defaults";
            this.buttonDefaults.UseVisualStyleBackColor = true;
            this.buttonDefaults.Click += new System.EventHandler(this.buttonDefaults_Click);
            // 
            // label
            // 
            this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(13, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(358, 194);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxFixOnStart
            // 
            this.checkBoxFixOnStart.AutoSize = true;
            this.checkBoxFixOnStart.Location = new System.Drawing.Point(13, 233);
            this.checkBoxFixOnStart.Name = "checkBoxFixOnStart";
            this.checkBoxFixOnStart.Size = new System.Drawing.Size(159, 19);
            this.checkBoxFixOnStart.TabIndex = 2;
            this.checkBoxFixOnStart.Text = "Fix on start and minimize";
            this.checkBoxFixOnStart.UseVisualStyleBackColor = true;
            this.checkBoxFixOnStart.CheckedChanged += new System.EventHandler(this.checkBoxFix_CheckedChanged);
            // 
            // checkBoxDefaultWhenExit
            // 
            this.checkBoxDefaultWhenExit.AutoSize = true;
            this.checkBoxDefaultWhenExit.Location = new System.Drawing.Point(199, 233);
            this.checkBoxDefaultWhenExit.Name = "checkBoxDefaultWhenExit";
            this.checkBoxDefaultWhenExit.Size = new System.Drawing.Size(164, 19);
            this.checkBoxDefaultWhenExit.TabIndex = 3;
            this.checkBoxDefaultWhenExit.Text = "Restore defaults when exit";
            this.checkBoxDefaultWhenExit.UseVisualStyleBackColor = true;
            this.checkBoxDefaultWhenExit.CheckedChanged += new System.EventHandler(this.checkBoxDefaultWhenExit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 333);
            this.Controls.Add(this.checkBoxDefaultWhenExit);
            this.Controls.Add(this.checkBoxFixOnStart);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonDefaults);
            this.Controls.Add(this.buttonFix);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 372);
            this.MinimumSize = new System.Drawing.Size(411, 372);
            this.Name = "Form1";
            this.Text = "Discord Audio Fixer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Button buttonDefaults;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBoxFixOnStart;
        private System.Windows.Forms.CheckBox checkBoxDefaultWhenExit;
    }
}

