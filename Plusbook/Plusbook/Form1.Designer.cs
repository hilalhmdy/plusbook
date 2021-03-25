
namespace Plusbook
{
    partial class plusbook_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(plusbook_form));
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
            this.process_button = new System.Windows.Forms.Button();
            this.graph_viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
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
            this.bfs_radio.Location = new System.Drawing.Point(248, 88);
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
            this.dfs_radio.Location = new System.Drawing.Point(300, 88);
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
            this.start_profile_dropdown.Location = new System.Drawing.Point(248, 148);
            this.start_profile_dropdown.Name = "start_profile_dropdown";
            this.start_profile_dropdown.Size = new System.Drawing.Size(98, 21);
            this.start_profile_dropdown.TabIndex = 4;
            // 
            // end_profile_dropdown
            // 
            this.end_profile_dropdown.FormattingEnabled = true;
            this.end_profile_dropdown.Location = new System.Drawing.Point(248, 190);
            this.end_profile_dropdown.Name = "end_profile_dropdown";
            this.end_profile_dropdown.Size = new System.Drawing.Size(98, 21);
            this.end_profile_dropdown.TabIndex = 5;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(15, 405);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(30, 13);
            this.result_label.TabIndex = 6;
            this.result_label.Text = "Hasil";
            // 
            // result_textbox
            // 
            this.result_textbox.Location = new System.Drawing.Point(18, 424);
            this.result_textbox.Name = "result_textbox";
            this.result_textbox.Size = new System.Drawing.Size(328, 231);
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
            this.algorithm_label.Location = new System.Drawing.Point(239, 70);
            this.algorithm_label.Name = "algorithm_label";
            this.algorithm_label.Size = new System.Drawing.Size(56, 13);
            this.algorithm_label.TabIndex = 9;
            this.algorithm_label.Text = "Algoritme :";
            // 
            // start_profile_label
            // 
            this.start_profile_label.AutoSize = true;
            this.start_profile_label.Location = new System.Drawing.Point(239, 132);
            this.start_profile_label.Name = "start_profile_label";
            this.start_profile_label.Size = new System.Drawing.Size(27, 13);
            this.start_profile_label.TabIndex = 10;
            this.start_profile_label.Text = "start";
            // 
            // end_profile_label
            // 
            this.end_profile_label.AutoSize = true;
            this.end_profile_label.Location = new System.Drawing.Point(239, 174);
            this.end_profile_label.Name = "end_profile_label";
            this.end_profile_label.Size = new System.Drawing.Size(25, 13);
            this.end_profile_label.TabIndex = 11;
            this.end_profile_label.Text = "end";
            // 
            // process_button
            // 
            this.process_button.Location = new System.Drawing.Point(248, 243);
            this.process_button.Name = "process_button";
            this.process_button.Size = new System.Drawing.Size(98, 139);
            this.process_button.TabIndex = 12;
            this.process_button.Text = "Process";
            this.process_button.UseVisualStyleBackColor = true;
            this.process_button.Click += new System.EventHandler(this.process_button_Click);
            // 
            // graph_viewer
            // 
            this.graph_viewer.ArrowheadLength = 10D;
            this.graph_viewer.AsyncLayout = false;
            this.graph_viewer.AutoScroll = true;
            this.graph_viewer.BackwardEnabled = false;
            this.graph_viewer.BuildHitTree = true;
            this.graph_viewer.CurrentLayoutMethod = Microsoft.Msagl.GraphViewerGdi.LayoutMethod.UseSettingsOfTheGraph;
            this.graph_viewer.EdgeInsertButtonVisible = false;
            this.graph_viewer.FileName = "";
            this.graph_viewer.ForwardEnabled = false;
            this.graph_viewer.Graph = null;
            this.graph_viewer.InsertingEdge = false;
            this.graph_viewer.LayoutAlgorithmSettingsButtonVisible = false;
            this.graph_viewer.LayoutEditingEnabled = true;
            this.graph_viewer.Location = new System.Drawing.Point(17, 49);
            this.graph_viewer.LooseOffsetForRouting = 0.25D;
            this.graph_viewer.MouseHitDistance = 0.05D;
            this.graph_viewer.Name = "graph_viewer";
            this.graph_viewer.NavigationVisible = true;
            this.graph_viewer.NeedToCalculateLayout = true;
            this.graph_viewer.OffsetForRelaxingInRouting = 0.6D;
            this.graph_viewer.PaddingForEdgeRouting = 8D;
            this.graph_viewer.PanButtonPressed = false;
            this.graph_viewer.SaveAsImageEnabled = true;
            this.graph_viewer.SaveAsMsaglEnabled = true;
            this.graph_viewer.SaveButtonVisible = true;
            this.graph_viewer.SaveGraphButtonVisible = true;
            this.graph_viewer.SaveInVectorFormatEnabled = true;
            this.graph_viewer.Size = new System.Drawing.Size(213, 348);
            this.graph_viewer.TabIndex = 13;
            this.graph_viewer.TightOffsetForRouting = 0.125D;
            this.graph_viewer.ToolBarIsVisible = true;
            this.graph_viewer.Transform = ((Microsoft.Msagl.Core.Geometry.Curves.PlaneTransformation)(resources.GetObject("graph_viewer.Transform")));
            this.graph_viewer.UndoRedoButtonsVisible = false;
            this.graph_viewer.WindowZoomButtonPressed = false;
            this.graph_viewer.ZoomF = 1D;
            this.graph_viewer.ZoomWindowThreshold = 0.05D;
            // 
            // plusbook_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 667);
            this.Controls.Add(this.graph_viewer);
            this.Controls.Add(this.process_button);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "plusbook_form";
            this.Text = "plusbook [Tubes 2 Stima]";
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
        private System.Windows.Forms.Button process_button;
        private Microsoft.Msagl.GraphViewerGdi.GViewer graph_viewer;
    }
}

