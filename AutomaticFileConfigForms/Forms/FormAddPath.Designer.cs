namespace AutomaticFileConfigForms.Forms
{
    partial class FormAddPath
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_ChangeSourceFolder = new System.Windows.Forms.Button();
            this.TXT_DestinationFolder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BTN_ChangeSourceFolder);
            this.groupBox1.Controls.Add(this.TXT_DestinationFolder);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 60);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination Folder :";
            // 
            // BTN_ChangeSourceFolder
            // 
            this.BTN_ChangeSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_ChangeSourceFolder.Location = new System.Drawing.Point(679, 21);
            this.BTN_ChangeSourceFolder.Name = "BTN_ChangeSourceFolder";
            this.BTN_ChangeSourceFolder.Size = new System.Drawing.Size(87, 23);
            this.BTN_ChangeSourceFolder.TabIndex = 2;
            this.BTN_ChangeSourceFolder.Text = "Change ...";
            this.BTN_ChangeSourceFolder.UseVisualStyleBackColor = false;
            // 
            // TXT_DestinationFolder
            // 
            this.TXT_DestinationFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DestinationFolder.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXT_DestinationFolder.Location = new System.Drawing.Point(6, 22);
            this.TXT_DestinationFolder.Name = "TXT_DestinationFolder";
            this.TXT_DestinationFolder.ReadOnly = true;
            this.TXT_DestinationFolder.Size = new System.Drawing.Size(374, 23);
            this.TXT_DestinationFolder.TabIndex = 1;
            this.TXT_DestinationFolder.TabStop = false;
            this.TXT_DestinationFolder.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(958, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Change ...";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(393, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Change ...";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormAddPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 228);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAddPath";
            this.Text = "FormAddPath";
            this.Load += new System.EventHandler(this.FormAddPath_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button BTN_ChangeSourceFolder;
        public TextBox TXT_DestinationFolder;
        private Button button1;
        private Button button2;
    }
}