
namespace VariablesPractice
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
            this.displayLabel = new System.Windows.Forms.Label();
            this.wayneButton = new System.Windows.Forms.Button();
            this.areaButton = new System.Windows.Forms.Button();
            this.carpetButton = new System.Windows.Forms.Button();
            this.saleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(231, 13);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(530, 428);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "...";
            this.displayLabel.Click += new System.EventHandler(this.displayLabel_Click);
            // 
            // wayneButton
            // 
            this.wayneButton.Location = new System.Drawing.Point(70, 91);
            this.wayneButton.Name = "wayneButton";
            this.wayneButton.Size = new System.Drawing.Size(75, 23);
            this.wayneButton.TabIndex = 1;
            this.wayneButton.Text = "Hockey";
            this.wayneButton.UseVisualStyleBackColor = true;
            this.wayneButton.Click += new System.EventHandler(this.wayneButton_Click);
            // 
            // areaButton
            // 
            this.areaButton.Location = new System.Drawing.Point(70, 185);
            this.areaButton.Name = "areaButton";
            this.areaButton.Size = new System.Drawing.Size(75, 23);
            this.areaButton.TabIndex = 2;
            this.areaButton.Text = "Area";
            this.areaButton.UseVisualStyleBackColor = true;
            this.areaButton.Click += new System.EventHandler(this.areaButton_Click);
            // 
            // carpetButton
            // 
            this.carpetButton.Location = new System.Drawing.Point(70, 271);
            this.carpetButton.Name = "carpetButton";
            this.carpetButton.Size = new System.Drawing.Size(75, 23);
            this.carpetButton.TabIndex = 3;
            this.carpetButton.Text = "Carpet";
            this.carpetButton.UseVisualStyleBackColor = true;
            this.carpetButton.Click += new System.EventHandler(this.carpetButton_Click);
            // 
            // saleButton
            // 
            this.saleButton.Location = new System.Drawing.Point(70, 360);
            this.saleButton.Name = "saleButton";
            this.saleButton.Size = new System.Drawing.Size(75, 23);
            this.saleButton.TabIndex = 4;
            this.saleButton.Text = "Bill";
            this.saleButton.UseVisualStyleBackColor = true;
            this.saleButton.Click += new System.EventHandler(this.saleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saleButton);
            this.Controls.Add(this.carpetButton);
            this.Controls.Add(this.areaButton);
            this.Controls.Add(this.wayneButton);
            this.Controls.Add(this.displayLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Button wayneButton;
        private System.Windows.Forms.Button areaButton;
        private System.Windows.Forms.Button carpetButton;
        private System.Windows.Forms.Button saleButton;
    }
}

