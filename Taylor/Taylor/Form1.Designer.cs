namespace Taylor
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
            this.lEntryRad = new System.Windows.Forms.Label();
            this.lEntrySteps = new System.Windows.Forms.Label();
            this.bCalculate = new System.Windows.Forms.Button();
            this.tbEntrySteps = new System.Windows.Forms.TextBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbExpectedResult = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.lExpectedResult = new System.Windows.Forms.Label();
            this.tbEntryRad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lEntryRad
            // 
            this.lEntryRad.AutoSize = true;
            this.lEntryRad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lEntryRad.Location = new System.Drawing.Point(50, 18);
            this.lEntryRad.Name = "lEntryRad";
            this.lEntryRad.Size = new System.Drawing.Size(321, 30);
            this.lEntryRad.TabIndex = 7;
            this.lEntryRad.Text = "Radianos para calcular o cosseno";
            this.lEntryRad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lEntrySteps
            // 
            this.lEntrySteps.AutoSize = true;
            this.lEntrySteps.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lEntrySteps.Location = new System.Drawing.Point(90, 97);
            this.lEntrySteps.Name = "lEntrySteps";
            this.lEntrySteps.Size = new System.Drawing.Size(241, 30);
            this.lEntrySteps.TabIndex = 6;
            this.lEntrySteps.Text = "Passos na seríe de Taylor";
            // 
            // bCalculate
            // 
            this.bCalculate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.bCalculate.Location = new System.Drawing.Point(156, 279);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(109, 45);
            this.bCalculate.TabIndex = 3;
            this.bCalculate.Text = "Calcular";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // tbEntryRad
            // 
            this.tbEntryRad.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbEntryRad.Location = new System.Drawing.Point(132, 51);
            this.tbEntryRad.Name = "tbEntryRad";
            this.tbEntryRad.Size = new System.Drawing.Size(156, 35);
            this.tbEntryRad.TabIndex = 1;
            // 
            // tbEntrySteps
            // 
            this.tbEntrySteps.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbEntrySteps.Location = new System.Drawing.Point(160, 130);
            this.tbEntrySteps.Name = "tbEntrySteps";
            this.tbEntrySteps.Size = new System.Drawing.Size(100, 35);
            this.tbEntrySteps.TabIndex = 2;
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbResult.Location = new System.Drawing.Point(26, 224);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(100, 35);
            this.tbResult.TabIndex = 4;
            this.tbResult.TabStop = false;
            // 
            // tbExpectedResult
            // 
            this.tbExpectedResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.tbExpectedResult.Location = new System.Drawing.Point(235, 224);
            this.tbExpectedResult.Name = "tbExpectedResult";
            this.tbExpectedResult.ReadOnly = true;
            this.tbExpectedResult.Size = new System.Drawing.Size(100, 35);
            this.tbExpectedResult.TabIndex = 5;
            this.tbExpectedResult.TabStop = false;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lResult.Location = new System.Drawing.Point(24, 180);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(104, 30);
            this.lResult.TabIndex = 1;
            this.lResult.Text = "Resultado";
            // 
            // lExpectedResult
            // 
            this.lExpectedResult.AutoSize = true;
            this.lExpectedResult.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lExpectedResult.Location = new System.Drawing.Point(188, 180);
            this.lExpectedResult.Name = "lExpectedResult";
            this.lExpectedResult.Size = new System.Drawing.Size(195, 30);
            this.lExpectedResult.TabIndex = 0;
            this.lExpectedResult.Text = "Resultado Esperado";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 339);
            this.Controls.Add(this.tbEntryRad);
            this.Controls.Add(this.lExpectedResult);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.tbExpectedResult);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbEntrySteps);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.lEntrySteps);
            this.Controls.Add(this.lEntryRad);
            this.Name = "Form1";
            this.Text = "Calculador de Cosseno por Taylor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lEntryRad;
        private System.Windows.Forms.Label lEntrySteps;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.TextBox tbEntrySteps;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbExpectedResult;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label lExpectedResult;
        private System.Windows.Forms.TextBox tbEntryRad;
    }
}

