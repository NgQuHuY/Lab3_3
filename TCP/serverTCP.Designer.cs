namespace TCP
{
    partial class serverTCP
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
            this.btnListen = new System.Windows.Forms.Button();
            this.listViewCommand = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(381, 385);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(153, 71);
            this.btnListen.TabIndex = 0;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // listViewCommand
            // 
            this.listViewCommand.HideSelection = false;
            this.listViewCommand.Location = new System.Drawing.Point(13, 14);
            this.listViewCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listViewCommand.Name = "listViewCommand";
            this.listViewCommand.Size = new System.Drawing.Size(840, 361);
            this.listViewCommand.TabIndex = 1;
            this.listViewCommand.UseCompatibleStateImageBehavior = false;
            // 
            // serverTCP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 464);
            this.Controls.Add(this.listViewCommand);
            this.Controls.Add(this.btnListen);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "serverTCP";
            this.Text = "serverTCP";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.ListView listViewCommand;
    }
}