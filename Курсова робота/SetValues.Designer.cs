using Курсова_робота.Properties;

namespace Курсова_робота
{
    partial class SetValues
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetValues));
            this.DefaultValues = new System.Windows.Forms.Button();
            this.LabelWind = new System.Windows.Forms.Label();
            this.LabelMass = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.SetWind = new System.Windows.Forms.TextBox();
            this.SetMass = new System.Windows.Forms.TextBox();
            this.SetSpeed = new System.Windows.Forms.TextBox();
            this.SetPosition = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.HelpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultValues
            // 
            this.DefaultValues.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DefaultValues.Location = new System.Drawing.Point(25, 194);
            this.DefaultValues.Name = "DefaultValues";
            this.DefaultValues.Size = new System.Drawing.Size(106, 50);
            this.DefaultValues.TabIndex = 22;
            this.DefaultValues.Text = "Дефолтні значення";
            this.DefaultValues.UseVisualStyleBackColor = true;
            this.DefaultValues.Click += new System.EventHandler(this.DefaultValues_Click);

            // 
            // LabelWind
            // 
            this.LabelWind.AutoSize = true;
            this.LabelWind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelWind.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelWind.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelWind.Location = new System.Drawing.Point(28, 160);
            this.LabelWind.Name = "LabelWind";
            this.LabelWind.Size = new System.Drawing.Size(90, 18);
            this.LabelWind.TabIndex = 21;
            this.LabelWind.Text = "Опір повітря";
            // 
            // LabelMass
            // 
            this.LabelMass.AutoSize = true;
            this.LabelMass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelMass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelMass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelMass.Location = new System.Drawing.Point(28, 108);
            this.LabelMass.Name = "LabelMass";
            this.LabelMass.Size = new System.Drawing.Size(79, 18);
            this.LabelMass.TabIndex = 20;
            this.LabelMass.Text = "Масса тіла";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSpeed.Location = new System.Drawing.Point(28, 56);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(104, 18);
            this.LabelSpeed.TabIndex = 19;
            this.LabelSpeed.Text = "Швидкість тіла";
            // 
            // LabelPosition
            // 
            this.LabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LabelPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelPosition.Location = new System.Drawing.Point(28, 12);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(90, 18);
            this.LabelPosition.TabIndex = 18;
            this.LabelPosition.Text = "Позиція тіла";
            this.LabelPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SetWind
            // 
            this.SetWind.Location = new System.Drawing.Point(146, 154);
            this.SetWind.Name = "SetWind";
            this.SetWind.Size = new System.Drawing.Size(112, 22);
            this.SetWind.TabIndex = 17;
            // 
            // SetMass
            // 
            this.SetMass.Location = new System.Drawing.Point(146, 105);
            this.SetMass.Name = "SetMass";
            this.SetMass.Size = new System.Drawing.Size(112, 22);
            this.SetMass.TabIndex = 16;
            // 
            // SetSpeed
            // 
            this.SetSpeed.Location = new System.Drawing.Point(146, 56);
            this.SetSpeed.Name = "SetSpeed";
            this.SetSpeed.Size = new System.Drawing.Size(112, 22);
            this.SetSpeed.TabIndex = 15;
            // 
            // SetPosition
            // 
            this.SetPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SetPosition.Location = new System.Drawing.Point(146, 8);
            this.SetPosition.Name = "SetPosition";
            this.SetPosition.Size = new System.Drawing.Size(112, 22);
            this.SetPosition.TabIndex = 14;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // HelpButton
            // 
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HelpButton.Location = new System.Drawing.Point(146, 196);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(48, 48);
            this.HelpButton.TabIndex = 23;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);

            // 
            // SetValues
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.DefaultValues);
            this.Controls.Add(this.LabelWind);
            this.Controls.Add(this.LabelMass);
            this.Controls.Add(this.LabelSpeed);
            this.Controls.Add(this.LabelPosition);
            this.Controls.Add(this.SetWind);
            this.Controls.Add(this.SetMass);
            this.Controls.Add(this.SetSpeed);
            this.Controls.Add(this.SetPosition);
            this.Controls.Add(this.HelpButton);
            this.Name = "Встановленя значень";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Встановленя значень";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DefaultValues;
        private System.Windows.Forms.Label LabelWind;
        private System.Windows.Forms.Label LabelMass;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Label LabelPosition;
        private System.Windows.Forms.TextBox SetWind;
        private System.Windows.Forms.TextBox SetMass;
        private System.Windows.Forms.TextBox SetSpeed;
        private System.Windows.Forms.TextBox SetPosition;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button HelpButton;
    }
}

