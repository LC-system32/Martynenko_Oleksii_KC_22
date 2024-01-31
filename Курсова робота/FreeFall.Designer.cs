namespace Курсова_робота
{
    partial class FreeFall
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
            this.components = new System.ComponentModel.Container();
            this.SetNewValue = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SetNewValue
            // 
            this.SetNewValue.Location = new System.Drawing.Point(685, 82);
            this.SetNewValue.Name = "SetNewValue";
            this.SetNewValue.Size = new System.Drawing.Size(103, 52);
            this.SetNewValue.TabIndex = 3;
            this.SetNewValue.Text = "Задати нові значення";
            this.SetNewValue.UseVisualStyleBackColor = true;
            this.SetNewValue.Click += new System.EventHandler(this.SetNewValue_Click);

            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(685, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(103, 52);
            this.CloseForm.TabIndex = 2;
            this.CloseForm.Text = "Вийти з програми";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // timer1
            // 
            this.timer.Enabled = true;
            // 
            // FreeFall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetNewValue);
            this.Controls.Add(this.CloseForm);
            this.Name = "Вільне падіння";
            this.Text = "Вільне падіння";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetNewValue;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Timer timer;
    }
}
