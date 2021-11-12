
namespace week08ToyFactory
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonCar = new System.Windows.Forms.Button();
            this.buttonBall = new System.Windows.Forms.Button();
            this.buttonPresent = new System.Windows.Forms.Button();
            this.labelNext = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonColorBox = new System.Windows.Forms.Button();
            this.buttonColorRibbon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(0, 154);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(801, 298);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonCar
            // 
            this.buttonCar.Location = new System.Drawing.Point(23, 12);
            this.buttonCar.Name = "buttonCar";
            this.buttonCar.Size = new System.Drawing.Size(73, 66);
            this.buttonCar.TabIndex = 1;
            this.buttonCar.Text = "CAR";
            this.buttonCar.UseVisualStyleBackColor = true;
            this.buttonCar.Click += new System.EventHandler(this.buttonCar_Click);
            // 
            // buttonBall
            // 
            this.buttonBall.Location = new System.Drawing.Point(137, 12);
            this.buttonBall.Name = "buttonBall";
            this.buttonBall.Size = new System.Drawing.Size(73, 66);
            this.buttonBall.TabIndex = 2;
            this.buttonBall.Text = "BALL";
            this.buttonBall.UseVisualStyleBackColor = true;
            this.buttonBall.Click += new System.EventHandler(this.buttonBall_Click);
            // 
            // buttonPresent
            // 
            this.buttonPresent.Location = new System.Drawing.Point(257, 12);
            this.buttonPresent.Name = "buttonPresent";
            this.buttonPresent.Size = new System.Drawing.Size(85, 66);
            this.buttonPresent.TabIndex = 3;
            this.buttonPresent.Text = "PRESENT";
            this.buttonPresent.UseVisualStyleBackColor = true;
            this.buttonPresent.Click += new System.EventHandler(this.buttonPresent_Click);
            // 
            // labelNext
            // 
            this.labelNext.AutoSize = true;
            this.labelNext.Location = new System.Drawing.Point(391, 13);
            this.labelNext.Name = "labelNext";
            this.labelNext.Size = new System.Drawing.Size(89, 17);
            this.labelNext.TabIndex = 4;
            this.labelNext.Text = "Coming next:";
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Blue;
            this.buttonColor.Location = new System.Drawing.Point(137, 85);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 5;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColorBox
            // 
            this.buttonColorBox.BackColor = System.Drawing.Color.Red;
            this.buttonColorBox.Location = new System.Drawing.Point(257, 85);
            this.buttonColorBox.Name = "buttonColorBox";
            this.buttonColorBox.Size = new System.Drawing.Size(75, 23);
            this.buttonColorBox.TabIndex = 6;
            this.buttonColorBox.UseVisualStyleBackColor = false;
            this.buttonColorBox.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonColorRibbon
            // 
            this.buttonColorRibbon.BackColor = System.Drawing.Color.Yellow;
            this.buttonColorRibbon.Location = new System.Drawing.Point(257, 125);
            this.buttonColorRibbon.Name = "buttonColorRibbon";
            this.buttonColorRibbon.Size = new System.Drawing.Size(75, 23);
            this.buttonColorRibbon.TabIndex = 7;
            this.buttonColorRibbon.UseVisualStyleBackColor = false;
            this.buttonColorRibbon.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonColorRibbon);
            this.Controls.Add(this.buttonColorBox);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.labelNext);
            this.Controls.Add(this.buttonPresent);
            this.Controls.Add(this.buttonBall);
            this.Controls.Add(this.buttonCar);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button buttonCar;
        private System.Windows.Forms.Button buttonBall;
        private System.Windows.Forms.Button buttonPresent;
        private System.Windows.Forms.Label labelNext;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonColorBox;
        private System.Windows.Forms.Button buttonColorRibbon;
    }
}

