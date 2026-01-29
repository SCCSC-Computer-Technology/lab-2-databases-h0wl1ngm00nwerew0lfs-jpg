namespace SGreene_Lab2_CPT206
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
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.totalBtn = new System.Windows.Forms.Button();
            this.highestBtn = new System.Windows.Forms.Button();
            this.popDescendingbtn = new System.Windows.Forms.Button();
            this.popAscendingBtn = new System.Windows.Forms.Button();
            this.averageBtn = new System.Windows.Forms.Button();
            this.lowestBtn = new System.Windows.Forms.Button();
            this.nameBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.Lab2toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelLowest = new System.Windows.Forms.Label();
            this.labelHighest = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.txtBoxpop = new System.Windows.Forms.TextBox();
            this.txtBoxstate = new System.Windows.Forms.TextBox();
            this.txtBoxcity = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelPop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(250, 23);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Row";
            this.Lab2toolTip.SetToolTip(this.addBtn, "This shouod add a row filled with the daa you enetered");
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(250, 61);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 18;
            this.deleteBtn.Text = "Delete Row";
            this.Lab2toolTip.SetToolTip(this.deleteBtn, "Thios should deleted the row you selected");
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // totalBtn
            // 
            this.totalBtn.Location = new System.Drawing.Point(35, 376);
            this.totalBtn.Name = "totalBtn";
            this.totalBtn.Size = new System.Drawing.Size(105, 23);
            this.totalBtn.TabIndex = 13;
            this.totalBtn.Text = "Total Pop";
            this.Lab2toolTip.SetToolTip(this.totalBtn, "This when clicked should display the total popualtion");
            this.totalBtn.UseVisualStyleBackColor = true;
            this.totalBtn.Click += new System.EventHandler(this.totalBtn_Click);
            // 
            // highestBtn
            // 
            this.highestBtn.Location = new System.Drawing.Point(35, 205);
            this.highestBtn.Name = "highestBtn";
            this.highestBtn.Size = new System.Drawing.Size(105, 23);
            this.highestBtn.TabIndex = 7;
            this.highestBtn.Text = "Highest Pop";
            this.Lab2toolTip.SetToolTip(this.highestBtn, "This should display the highest Pop");
            this.highestBtn.UseVisualStyleBackColor = true;
            this.highestBtn.Click += new System.EventHandler(this.highestBtn_Click);
            // 
            // popDescendingbtn
            // 
            this.popDescendingbtn.Location = new System.Drawing.Point(356, 312);
            this.popDescendingbtn.Name = "popDescendingbtn";
            this.popDescendingbtn.Size = new System.Drawing.Size(115, 23);
            this.popDescendingbtn.TabIndex = 17;
            this.popDescendingbtn.Text = "Pop Decending";
            this.Lab2toolTip.SetToolTip(this.popDescendingbtn, "This when clicked should sort the table by popualtion in descending order");
            this.popDescendingbtn.UseVisualStyleBackColor = true;
            this.popDescendingbtn.Click += new System.EventHandler(this.popDescendingbtn_Click);
            // 
            // popAscendingBtn
            // 
            this.popAscendingBtn.Location = new System.Drawing.Point(356, 256);
            this.popAscendingBtn.Name = "popAscendingBtn";
            this.popAscendingBtn.Size = new System.Drawing.Size(117, 23);
            this.popAscendingBtn.TabIndex = 16;
            this.popAscendingBtn.Text = "Pop Ascending";
            this.Lab2toolTip.SetToolTip(this.popAscendingBtn, "This should sort the table by population in aseceding order");
            this.popAscendingBtn.UseVisualStyleBackColor = true;
            this.popAscendingBtn.Click += new System.EventHandler(this.popAscendingBtn_Click);
            // 
            // averageBtn
            // 
            this.averageBtn.Location = new System.Drawing.Point(35, 319);
            this.averageBtn.Name = "averageBtn";
            this.averageBtn.Size = new System.Drawing.Size(105, 23);
            this.averageBtn.TabIndex = 11;
            this.averageBtn.Text = "Average Pop";
            this.Lab2toolTip.SetToolTip(this.averageBtn, "This when clicked should display the average popualtion");
            this.averageBtn.UseVisualStyleBackColor = true;
            this.averageBtn.Click += new System.EventHandler(this.averageBtn_Click);
            // 
            // lowestBtn
            // 
            this.lowestBtn.Location = new System.Drawing.Point(35, 263);
            this.lowestBtn.Name = "lowestBtn";
            this.lowestBtn.Size = new System.Drawing.Size(105, 23);
            this.lowestBtn.TabIndex = 9;
            this.lowestBtn.Text = "Lowest Pop";
            this.Lab2toolTip.SetToolTip(this.lowestBtn, "This when clicked should displa the lowest popualtion");
            this.lowestBtn.UseVisualStyleBackColor = true;
            this.lowestBtn.Click += new System.EventHandler(this.lowestBtn_Click);
            // 
            // nameBtn
            // 
            this.nameBtn.Location = new System.Drawing.Point(356, 202);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(115, 23);
            this.nameBtn.TabIndex = 15;
            this.nameBtn.Text = "City Name";
            this.Lab2toolTip.SetToolTip(this.nameBtn, "This when clicked should sort the cities by name alphabatically");
            this.nameBtn.UseVisualStyleBackColor = true;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(356, 361);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(105, 52);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "E&xit";
            this.Lab2toolTip.SetToolTip(this.exitBtn, "This when clicked should exit the program");
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // labelLowest
            // 
            this.labelLowest.AutoSize = true;
            this.labelLowest.Location = new System.Drawing.Point(158, 263);
            this.labelLowest.Name = "labelLowest";
            this.labelLowest.Size = new System.Drawing.Size(119, 16);
            this.labelLowest.TabIndex = 10;
            this.labelLowest.Text = "Lowest Popualtion:";
            // 
            // labelHighest
            // 
            this.labelHighest.AutoSize = true;
            this.labelHighest.Location = new System.Drawing.Point(158, 205);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(120, 16);
            this.labelHighest.TabIndex = 8;
            this.labelHighest.Text = "Highest Popualtion";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(157, 319);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(129, 16);
            this.labelAverage.TabIndex = 12;
            this.labelAverage.Text = "Average Popualtion:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(169, 376);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(108, 16);
            this.labelTotal.TabIndex = 14;
            this.labelTotal.Text = "Total Population:";
            // 
            // txtBoxpop
            // 
            this.txtBoxpop.Location = new System.Drawing.Point(106, 110);
            this.txtBoxpop.Name = "txtBoxpop";
            this.txtBoxpop.Size = new System.Drawing.Size(100, 22);
            this.txtBoxpop.TabIndex = 5;
            // 
            // txtBoxstate
            // 
            this.txtBoxstate.Location = new System.Drawing.Point(106, 60);
            this.txtBoxstate.Name = "txtBoxstate";
            this.txtBoxstate.Size = new System.Drawing.Size(100, 22);
            this.txtBoxstate.TabIndex = 3;
            // 
            // txtBoxcity
            // 
            this.txtBoxcity.Location = new System.Drawing.Point(106, 20);
            this.txtBoxcity.Name = "txtBoxcity";
            this.txtBoxcity.Size = new System.Drawing.Size(100, 22);
            this.txtBoxcity.TabIndex = 1;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(32, 23);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(32, 16);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "City:";
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(32, 61);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(41, 16);
            this.labelState.TabIndex = 2;
            this.labelState.Text = "Satte:";
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(29, 113);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(71, 16);
            this.labelPop.TabIndex = 4;
            this.labelPop.Text = "Popualtion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.labelPop);
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.txtBoxcity);
            this.Controls.Add(this.txtBoxstate);
            this.Controls.Add(this.txtBoxpop);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelHighest);
            this.Controls.Add(this.labelLowest);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nameBtn);
            this.Controls.Add(this.lowestBtn);
            this.Controls.Add(this.averageBtn);
            this.Controls.Add(this.popAscendingBtn);
            this.Controls.Add(this.popDescendingbtn);
            this.Controls.Add(this.highestBtn);
            this.Controls.Add(this.totalBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button totalBtn;
        private System.Windows.Forms.Button highestBtn;
        private System.Windows.Forms.Button popDescendingbtn;
        private System.Windows.Forms.Button popAscendingBtn;
        private System.Windows.Forms.Button averageBtn;
        private System.Windows.Forms.Button lowestBtn;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ToolTip Lab2toolTip;
        private System.Windows.Forms.Label labelLowest;
        private System.Windows.Forms.Label labelHighest;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox txtBoxpop;
        private System.Windows.Forms.TextBox txtBoxstate;
        private System.Windows.Forms.TextBox txtBoxcity;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelPop;
    }
}

