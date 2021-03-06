
namespace Zork.Builder.UserControls
{
    partial class SelectNeighborControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.directionTextBox = new System.Windows.Forms.TextBox();
            this.neighborsComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // directionTextBox
            // 
            this.directionTextBox.Location = new System.Drawing.Point(3, 3);
            this.directionTextBox.Name = "directionTextBox";
            this.directionTextBox.ReadOnly = true;
            this.directionTextBox.Size = new System.Drawing.Size(145, 20);
            this.directionTextBox.TabIndex = 0;
            this.directionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // neighborsComboBox
            // 
            this.neighborsComboBox.FormattingEnabled = true;
            this.neighborsComboBox.Location = new System.Drawing.Point(3, 29);
            this.neighborsComboBox.Name = "neighborsComboBox";
            this.neighborsComboBox.Size = new System.Drawing.Size(145, 21);
            this.neighborsComboBox.TabIndex = 1;
            this.neighborsComboBox.SelectedIndexChanged += new System.EventHandler(this.neighborsComboBox_SelectedIndexChanged);
            // 
            // SelectNeighborControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.neighborsComboBox);
            this.Controls.Add(this.directionTextBox);
            this.Name = "SelectNeighborControl";
            this.Size = new System.Drawing.Size(152, 55);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox directionTextBox;
        private System.Windows.Forms.ComboBox neighborsComboBox;
    }
}
