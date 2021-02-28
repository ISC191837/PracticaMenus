
namespace PracticaMenus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.longitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.controlLabel4 = new System.Windows.Forms.Label();
            this.controlLabel3 = new System.Windows.Forms.Label();
            this.controlLabel2 = new System.Windows.Forms.Label();
            this.controlLabel1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            this.input3 = new System.Windows.Forms.NumericUpDown();
            this.input4 = new System.Windows.Forms.NumericUpDown();
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.longitudToolStripMenuItem,
            this.divisasToolStripMenuItem,
            this.masaToolStripMenuItem,
            this.temperaturaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // longitudToolStripMenuItem
            // 
            this.longitudToolStripMenuItem.Name = "longitudToolStripMenuItem";
            this.longitudToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.longitudToolStripMenuItem.Text = "Longitud";
            this.longitudToolStripMenuItem.Click += new System.EventHandler(this.longitudToolStripMenuItem_Click);
            // 
            // divisasToolStripMenuItem
            // 
            this.divisasToolStripMenuItem.Name = "divisasToolStripMenuItem";
            this.divisasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.divisasToolStripMenuItem.Text = "Divisas";
            this.divisasToolStripMenuItem.Click += new System.EventHandler(this.divisasToolStripMenuItem_Click);
            // 
            // masaToolStripMenuItem
            // 
            this.masaToolStripMenuItem.Name = "masaToolStripMenuItem";
            this.masaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.masaToolStripMenuItem.Text = "Masa";
            this.masaToolStripMenuItem.Click += new System.EventHandler(this.masaToolStripMenuItem_Click);
            // 
            // temperaturaToolStripMenuItem
            // 
            this.temperaturaToolStripMenuItem.Name = "temperaturaToolStripMenuItem";
            this.temperaturaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.temperaturaToolStripMenuItem.Text = "Temperatura";
            this.temperaturaToolStripMenuItem.Click += new System.EventHandler(this.temperaturaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.controlLabel4);
            this.panel1.Controls.Add(this.controlLabel3);
            this.panel1.Controls.Add(this.controlLabel2);
            this.panel1.Controls.Add(this.controlLabel1);
            this.panel1.Controls.Add(this.buttonClear);
            this.panel1.Controls.Add(this.buttonCalc);
            this.panel1.Controls.Add(this.input2);
            this.panel1.Controls.Add(this.input3);
            this.panel1.Controls.Add(this.input4);
            this.panel1.Controls.Add(this.input1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 123);
            this.panel1.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(3, 110);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(29, 13);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Error";
            // 
            // controlLabel4
            // 
            this.controlLabel4.AutoSize = true;
            this.controlLabel4.Location = new System.Drawing.Point(380, 22);
            this.controlLabel4.Name = "controlLabel4";
            this.controlLabel4.Size = new System.Drawing.Size(40, 13);
            this.controlLabel4.TabIndex = 10;
            this.controlLabel4.Text = "Yardas";
            // 
            // controlLabel3
            // 
            this.controlLabel3.AutoSize = true;
            this.controlLabel3.Location = new System.Drawing.Point(254, 22);
            this.controlLabel3.Name = "controlLabel3";
            this.controlLabel3.Size = new System.Drawing.Size(55, 13);
            this.controlLabel3.TabIndex = 9;
            this.controlLabel3.Text = "Kilometros";
            // 
            // controlLabel2
            // 
            this.controlLabel2.AutoSize = true;
            this.controlLabel2.Location = new System.Drawing.Point(127, 22);
            this.controlLabel2.Name = "controlLabel2";
            this.controlLabel2.Size = new System.Drawing.Size(64, 13);
            this.controlLabel2.TabIndex = 8;
            this.controlLabel2.Text = "Centímetros";
            // 
            // controlLabel1
            // 
            this.controlLabel1.AutoSize = true;
            this.controlLabel1.Location = new System.Drawing.Point(3, 22);
            this.controlLabel1.Name = "controlLabel1";
            this.controlLabel1.Size = new System.Drawing.Size(39, 13);
            this.controlLabel1.TabIndex = 7;
            this.controlLabel1.Text = "Metros";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(84, 74);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Limpiar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(3, 74);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(75, 23);
            this.buttonCalc.TabIndex = 5;
            this.buttonCalc.Text = "Calcular";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // input2
            // 
            this.input2.DecimalPlaces = 2;
            this.input2.Enabled = false;
            this.input2.Location = new System.Drawing.Point(129, 38);
            this.input2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(120, 20);
            this.input2.TabIndex = 4;
            // 
            // input3
            // 
            this.input3.DecimalPlaces = 2;
            this.input3.Enabled = false;
            this.input3.Location = new System.Drawing.Point(255, 38);
            this.input3.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(120, 20);
            this.input3.TabIndex = 3;
            // 
            // input4
            // 
            this.input4.DecimalPlaces = 2;
            this.input4.Enabled = false;
            this.input4.Location = new System.Drawing.Point(381, 38);
            this.input4.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(120, 20);
            this.input4.TabIndex = 2;
            // 
            // input1
            // 
            this.input1.DecimalPlaces = 2;
            this.input1.Location = new System.Drawing.Point(3, 38);
            this.input1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(120, 20);
            this.input1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convertidor de longitud";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Convertdor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem longitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperaturaToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.NumericUpDown input2;
        private System.Windows.Forms.NumericUpDown input3;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label controlLabel1;
        private System.Windows.Forms.Label controlLabel4;
        private System.Windows.Forms.Label controlLabel3;
        private System.Windows.Forms.Label controlLabel2;
        private System.Windows.Forms.NumericUpDown input4;
        private System.Windows.Forms.Label errorLabel;
    }
}

