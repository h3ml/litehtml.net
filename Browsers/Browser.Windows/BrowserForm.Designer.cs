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
            this._console = new Browser.Windows.ConsoleControl();
            this._toolbar = new Browser.Windows.ToolbarControl();
            this._view = new Browser.Windows.HtmlControl();
            this._splitter = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // _console
            // 
            this._console.BackColor = System.Drawing.SystemColors.Info;
            this._console.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._console.Location = new System.Drawing.Point(0, 365);
            this._console.Name = "_console";
            this._console.Size = new System.Drawing.Size(770, 123);
            this._console.TabIndex = 2;
            // 
            // _toolbar
            // 
            this._toolbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this._toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this._toolbar.Location = new System.Drawing.Point(0, 0);
            this._toolbar.Name = "_toolbar";
            this._toolbar.Size = new System.Drawing.Size(770, 23);
            this._toolbar.TabIndex = 1;
            // 
            // _view
            // 
            this._view.BackColor = System.Drawing.SystemColors.Control;
            this._view.Dock = System.Windows.Forms.DockStyle.Fill;
            this._view.Location = new System.Drawing.Point(0, 0);
            this._view.Name = "_view";
            this._view.Size = new System.Drawing.Size(770, 488);
            this._view.TabIndex = 0;
            // 
            // _splitter
            // 
            this._splitter.Cursor = System.Windows.Forms.Cursors.HSplit;
            this._splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._splitter.Location = new System.Drawing.Point(0, 355);
            this._splitter.Name = "_splitter";
            this._splitter.Size = new System.Drawing.Size(770, 10);
            this._splitter.TabIndex = 3;
            this._splitter.TabStop = false;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 488);
            this.Controls.Add(this._splitter);
            this.Controls.Add(this._console);
            this.Controls.Add(this._toolbar);
            this.Controls.Add(this._view);
            this.KeyPreview = true;
            this.Name = "BrowserForm";
            this.Text = "Browser";
            this.ResumeLayout(false);

        }

        #endregion

        private HtmlControl _view;
        private ToolbarControl _toolbar;
        private ConsoleControl _console;
        private System.Windows.Forms.Splitter _splitter;
    }
}

