namespace RestClient
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.endpointURITextBox = new System.Windows.Forms.TextBox();
            this.responseTextBox = new System.Windows.Forms.TextBox();
            this.commandGoButton = new System.Windows.Forms.Button();
            this.requestURILabel = new System.Windows.Forms.Label();
            this.responseBodyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // endpontURITextBox
            // 
            this.endpointURITextBox.Location = new System.Drawing.Point(118, 6);
            this.endpointURITextBox.Name = "endpointURITextBox";
            this.endpointURITextBox.Size = new System.Drawing.Size(348, 22);
            this.endpointURITextBox.TabIndex = 0;
            // 
            // responseTextBox
            // 
            this.responseTextBox.Location = new System.Drawing.Point(118, 35);
            this.responseTextBox.Multiline = true;
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseTextBox.Size = new System.Drawing.Size(482, 223);
            this.responseTextBox.TabIndex = 1;
            // 
            // commandGoButton
            // 
            this.commandGoButton.Location = new System.Drawing.Point(472, 5);
            this.commandGoButton.Name = "commandGoButton";
            this.commandGoButton.Size = new System.Drawing.Size(128, 23);
            this.commandGoButton.TabIndex = 2;
            this.commandGoButton.Text = "GO";
            this.commandGoButton.UseVisualStyleBackColor = true;
            this.commandGoButton.Click += new System.EventHandler(this.CommandGoOnClick);
            // 
            // requestURILabel
            // 
            this.requestURILabel.Location = new System.Drawing.Point(12, 9);
            this.requestURILabel.Name = "requestURILabel";
            this.requestURILabel.Size = new System.Drawing.Size(100, 23);
            this.requestURILabel.TabIndex = 3;
            this.requestURILabel.Text = "Request URI:";
            // 
            // responseBodyLabel
            // 
            this.responseBodyLabel.Location = new System.Drawing.Point(12, 32);
            this.responseBodyLabel.Name = "responseBodyLabel";
            this.responseBodyLabel.Size = new System.Drawing.Size(100, 23);
            this.responseBodyLabel.TabIndex = 4;
            this.responseBodyLabel.Text = "Response:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 270);
            this.Controls.Add(this.responseBodyLabel);
            this.Controls.Add(this.requestURILabel);
            this.Controls.Add(this.commandGoButton);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.endpointURITextBox);
            this.Name = "MainForm";
            this.Text = "C# REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        
        private System.Windows.Forms.Label requestURILabel;
        private System.Windows.Forms.Label responseBodyLabel;
        private System.Windows.Forms.Button commandGoButton;
        private System.Windows.Forms.TextBox responseTextBox;
        private System.Windows.Forms.TextBox endpointURITextBox;


        #endregion
    }
}