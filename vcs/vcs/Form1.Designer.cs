namespace vcs
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
            this.button1 = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.folderWatcher = new System.Windows.Forms.Button();
            this.commitMessageBox = new System.Windows.Forms.TextBox();
            this.commitLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.displayall_button = new System.Windows.Forms.Button();
            this.branch_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.versionBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // about_button
            // 
            this.about_button.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.Location = new System.Drawing.Point(37, 478);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(75, 23);
            this.about_button.TabIndex = 1;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filesName});
            this.dataGridView1.Location = new System.Drawing.Point(186, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // filesName
            // 
            this.filesName.HeaderText = "Files";
            this.filesName.Name = "filesName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drill VCS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // folderWatcher
            // 
            this.folderWatcher.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.folderWatcher.Location = new System.Drawing.Point(27, 207);
            this.folderWatcher.Name = "folderWatcher";
            this.folderWatcher.Size = new System.Drawing.Size(136, 23);
            this.folderWatcher.TabIndex = 4;
            this.folderWatcher.Text = "FOLDER WATCH";
            this.folderWatcher.UseVisualStyleBackColor = true;
            this.folderWatcher.Click += new System.EventHandler(this.folderWatcher_Click);
            // 
            // commitMessageBox
            // 
            this.commitMessageBox.Location = new System.Drawing.Point(496, 424);
            this.commitMessageBox.Multiline = true;
            this.commitMessageBox.Name = "commitMessageBox";
            this.commitMessageBox.Size = new System.Drawing.Size(293, 94);
            this.commitMessageBox.TabIndex = 5;
            this.commitMessageBox.TextChanged += new System.EventHandler(this.commitMessageBox_TextChanged);
            // 
            // commitLabel
            // 
            this.commitLabel.AutoSize = true;
            this.commitLabel.Font = new System.Drawing.Font("Product Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitLabel.Location = new System.Drawing.Point(571, 400);
            this.commitLabel.Name = "commitLabel";
            this.commitLabel.Size = new System.Drawing.Size(128, 19);
            this.commitLabel.TabIndex = 6;
            this.commitLabel.Text = "Commit Message";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(714, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Commit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // displayall_button
            // 
            this.displayall_button.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayall_button.Location = new System.Drawing.Point(27, 256);
            this.displayall_button.Name = "displayall_button";
            this.displayall_button.Size = new System.Drawing.Size(136, 23);
            this.displayall_button.TabIndex = 10;
            this.displayall_button.Text = "DISPLAY ALL";
            this.displayall_button.UseVisualStyleBackColor = true;
            this.displayall_button.Click += new System.EventHandler(this.displayall_button_Click);
            // 
            // branch_button
            // 
            this.branch_button.Font = new System.Drawing.Font("Product Sans", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch_button.Location = new System.Drawing.Point(27, 301);
            this.branch_button.Name = "branch_button";
            this.branch_button.Size = new System.Drawing.Size(136, 25);
            this.branch_button.TabIndex = 11;
            this.branch_button.Text = "BRANCH";
            this.branch_button.UseVisualStyleBackColor = true;
            this.branch_button.Click += new System.EventHandler(this.branch_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(328, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please specify the version !!!";
            // 
            // versionBox
            // 
            this.versionBox.Location = new System.Drawing.Point(399, 422);
            this.versionBox.Name = "versionBox";
            this.versionBox.Size = new System.Drawing.Size(68, 20);
            this.versionBox.TabIndex = 13;
            this.versionBox.TextChanged += new System.EventHandler(this.versionBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.versionBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.branch_button);
            this.Controls.Add(this.displayall_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.commitLabel);
            this.Controls.Add(this.commitMessageBox);
            this.Controls.Add(this.folderWatcher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button folderWatcher;
        private System.Windows.Forms.TextBox commitMessageBox;
        private System.Windows.Forms.Label commitLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesName;
        private System.Windows.Forms.Button displayall_button;
        private System.Windows.Forms.Button branch_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox versionBox;
    }
}

