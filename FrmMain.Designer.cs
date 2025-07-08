namespace PostmanCollectionGenerator
{
    partial class frmMain
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
            btnSelectFile = new Button();
            txtFilePath = new TextBox();
            txtControllerName = new TextBox();
            btnGenerator = new Button();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(12, 12);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(75, 23);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 41);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(505, 23);
            txtFilePath.TabIndex = 1;
            // 
            // txtControllerName
            // 
            txtControllerName.Location = new Point(12, 70);
            txtControllerName.Name = "txtControllerName";
            txtControllerName.Size = new Size(505, 23);
            txtControllerName.TabIndex = 2;
            // 
            // btnGenerator
            // 
            btnGenerator.Location = new Point(93, 12);
            btnGenerator.Name = "btnGenerator";
            btnGenerator.Size = new Size(75, 23);
            btnGenerator.TabIndex = 3;
            btnGenerator.Text = "Generator";
            btnGenerator.UseVisualStyleBackColor = true;
            btnGenerator.Click += btnGenerator_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1120, 580);
            Controls.Add(btnGenerator);
            Controls.Add(txtControllerName);
            Controls.Add(txtFilePath);
            Controls.Add(btnSelectFile);
            Name = "frmMain";
            Text = "Postman Collection Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private TextBox txtFilePath;
        private TextBox txtControllerName;
        private Button btnGenerator;
    }
}
