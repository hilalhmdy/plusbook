
namespace Plusbook
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
            this.browse_button = new System.Windows.Forms.Button();
            this.selected_filename_label = new System.Windows.Forms.Label();
            this.bfs_radio = new System.Windows.Forms.RadioButton();
            this.dfs_radio = new System.Windows.Forms.RadioButton();
            this.start_profile_dropdown = new System.Windows.Forms.ComboBox();
            this.end_profile_dropdown = new System.Windows.Forms.ComboBox();
            this.result_label = new System.Windows.Forms.Label();
            this.result_textbox = new System.Windows.Forms.RichTextBox();
            this.browse_label = new System.Windows.Forms.Label();
            this.algorithm_label = new System.Windows.Forms.Label();
            this.start_profile_label = new System.Windows.Forms.Label();
            this.end_profile_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(155, 20);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 0;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // selected_filename_label
            // 
            this.selected_filename_label.AutoSize = true;
            this.selected_filename_label.Location = new System.Drawing.Point(248, 25);
            this.selected_filename_label.Name = "selected_filename_label";
            this.selected_filename_label.Size = new System.Drawing.Size(0, 13);
            this.selected_filename_label.TabIndex = 1;
            // 
            // bfs_radio
            // 
            this.bfs_radio.AutoSize = true;
            this.bfs_radio.Location = new System.Drawing.Point(156, 65);
            this.bfs_radio.Name = "bfs_radio";
            this.bfs_radio.Size = new System.Drawing.Size(45, 17);
            this.bfs_radio.TabIndex = 2;
            this.bfs_radio.TabStop = true;
            this.bfs_radio.Text = "BFS";
            this.bfs_radio.UseVisualStyleBackColor = true;
            // 
            // dfs_radio
            // 
            this.dfs_radio.AutoSize = true;
            this.dfs_radio.Location = new System.Drawing.Point(251, 65);
            this.dfs_radio.Name = "dfs_radio";
            this.dfs_radio.Size = new System.Drawing.Size(46, 17);
            this.dfs_radio.TabIndex = 3;
            this.dfs_radio.TabStop = true;
            this.dfs_radio.Text = "DFS";
            this.dfs_radio.UseVisualStyleBackColor = true;
            // 
            // start_profile_dropdown
            // 
            this.start_profile_dropdown.FormattingEnabled = true;
            this.start_profile_dropdown.Location = new System.Drawing.Point(155, 104);
            this.start_profile_dropdown.Name = "start_profile_dropdown";
            this.start_profile_dropdown.Size = new System.Drawing.Size(190, 21);
            this.start_profile_dropdown.TabIndex = 4;
            // 
            // end_profile_dropdown
            // 
            this.end_profile_dropdown.FormattingEnabled = true;
            this.end_profile_dropdown.Location = new System.Drawing.Point(155, 144);
            this.end_profile_dropdown.Name = "end_profile_dropdown";
            this.end_profile_dropdown.Size = new System.Drawing.Size(190, 21);
            this.end_profile_dropdown.TabIndex = 5;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(14, 203);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(30, 13);
            this.result_label.TabIndex = 6;
            this.result_label.Text = "Hasil";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(17, 222);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(328, 216);
            this.result_textbox.TabIndex = 7;
            this.result_textbox.Text = "";
            // 
            // browse_label
            // 
            this.browse_label.AutoSize = true;
            this.browse_label.Location = new System.Drawing.Point(14, 25);
            this.browse_label.Name = "browse_label";
            this.browse_label.Size = new System.Drawing.Size(42, 13);
            this.browse_label.TabIndex = 8;
            this.browse_label.Text = "Pilih file";
            // 
            // algorithm_label
            // 
            this.algorithm_label.AutoSize = true;
            this.algorithm_label.Location = new System.Drawing.Point(14, 67);
            this.algorithm_label.Name = "algorithm_label";
            this.algorithm_label.Size = new System.Drawing.Size(56, 13);
            this.algorithm_label.TabIndex = 9;
            this.algorithm_label.Text = "Algoritme :";
            // 
            // start_profile_label
            // 
            this.start_profile_label.AutoSize = true;
            this.start_profile_label.Location = new System.Drawing.Point(14, 107);
            this.start_profile_label.Name = "start_profile_label";
            this.start_profile_label.Size = new System.Drawing.Size(27, 13);
            this.start_profile_label.TabIndex = 10;
            this.start_profile_label.Text = "start";
            // 
            // end_profile_label
            // 
            this.end_profile_label.AutoSize = true;
            this.end_profile_label.Location = new System.Drawing.Point(14, 147);
            this.end_profile_label.Name = "end_profile_label";
            this.end_profile_label.Size = new System.Drawing.Size(25, 13);
            this.end_profile_label.TabIndex = 11;
            this.end_profile_label.Text = "end";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 454);
            this.Controls.Add(this.end_profile_label);
            this.Controls.Add(this.start_profile_label);
            this.Controls.Add(this.algorithm_label);
            this.Controls.Add(this.browse_label);
            this.Controls.Add(this.result_textbox);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.end_profile_dropdown);
            this.Controls.Add(this.start_profile_dropdown);
            this.Controls.Add(this.dfs_radio);
            this.Controls.Add(this.bfs_radio);
            this.Controls.Add(this.selected_filename_label);
            this.Controls.Add(this.browse_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.Label selected_filename_label;
        private System.Windows.Forms.RadioButton bfs_radio;
        private System.Windows.Forms.RadioButton dfs_radio;
        private System.Windows.Forms.ComboBox start_profile_dropdown;
        private System.Windows.Forms.ComboBox end_profile_dropdown;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.RichTextBox result_textbox;
        private System.Windows.Forms.Label browse_label;
        private System.Windows.Forms.Label algorithm_label;
        private System.Windows.Forms.Label start_profile_label;
        private System.Windows.Forms.Label end_profile_label;
    }
}

