namespace CreateFile
{
    partial class CreateFileForm
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
            saveButton = new Button();
            enterButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(38, 375);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(91, 23);
            saveButton.TabIndex = 8;
            saveButton.Text = "Guardar como";
            saveButton.UseVisualStyleBackColor = true;
            // 
            // enterButton
            // 
            enterButton.Location = new Point(163, 375);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(106, 23);
            enterButton.TabIndex = 9;
            enterButton.Text = "Ingresar";
            enterButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(297, 375);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(88, 23);
            exitButton.TabIndex = 10;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // CreateFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 455);
            Controls.Add(exitButton);
            Controls.Add(enterButton);
            Controls.Add(saveButton);
            Name = "CreateFileForm";
            Text = "CreateFileForm";
            Controls.SetChildIndex(saveButton, 0);
            Controls.SetChildIndex(enterButton, 0);
            Controls.SetChildIndex(exitButton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button enterButton;
        private Button exitButton;
    }
}