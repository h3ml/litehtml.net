namespace Browser.Windows
{
    partial class BrowserForm
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
            this._address_bar = new System.Windows.Forms.TextBox();
            this._go_button = new System.Windows.Forms.Button();
            this._html = new Browser.Windows.HtmlControl();
            this.SuspendLayout();
            // 
            // _address_bar
            // 
            this._address_bar.Location = new System.Drawing.Point(12, 12);
            this._address_bar.Name = "_address_bar";
            this._address_bar.Size = new System.Drawing.Size(505, 20);
            this._address_bar.TabIndex = 0;
            this._address_bar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.on_address_key_press);
            // 
            // _go_button
            // 
            this._go_button.Location = new System.Drawing.Point(523, 12);
            this._go_button.Name = "_go_button";
            this._go_button.Size = new System.Drawing.Size(54, 20);
            this._go_button.TabIndex = 1;
            this._go_button.Text = "GO";
            this._go_button.UseVisualStyleBackColor = true;
            this._go_button.Click += new System.EventHandler(this.on_go_clicked);
            // 
            // _html
            // 
            this._html.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._html.Location = new System.Drawing.Point(12, 38);
            this._html.Name = "_html";
            this._html.Size = new System.Drawing.Size(565, 280);
            this._html.TabIndex = 2;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 330);
            this.Controls.Add(this._html);
            this.Controls.Add(this._go_button);
            this.Controls.Add(this._address_bar);
            this.Name = "BrowserForm";
            this.Text = "Browser";
            this.Resize += new System.EventHandler(this.BrowserForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _address_bar;
        private System.Windows.Forms.Button _go_button;
        private Browser.Windows.HtmlControl _html;
    }
}

