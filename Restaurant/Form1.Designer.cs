﻿
namespace Restaurant
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPerson4 = new System.Windows.Forms.RadioButton();
            this.rbPerson3 = new System.Windows.Forms.RadioButton();
            this.rbPerson2 = new System.Windows.Forms.RadioButton();
            this.rbPerson1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowMealInfo = new System.Windows.Forms.Button();
            this.rbMeal5 = new System.Windows.Forms.RadioButton();
            this.rbMeal4 = new System.Windows.Forms.RadioButton();
            this.rbMeal3 = new System.Windows.Forms.RadioButton();
            this.rbMeal2 = new System.Windows.Forms.RadioButton();
            this.rbMeal1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lbOrderPrice4 = new System.Windows.Forms.Label();
            this.lbOrderPrice3 = new System.Windows.Forms.Label();
            this.lbOrderPrice2 = new System.Windows.Forms.Label();
            this.lbOrderPrice1 = new System.Windows.Forms.Label();
            this.lbClientOrder2 = new System.Windows.Forms.Label();
            this.lbClientOrder3 = new System.Windows.Forms.Label();
            this.lbClientOrder4 = new System.Windows.Forms.Label();
            this.lbClientOrder1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rbPerson4);
            this.groupBox1.Controls.Add(this.rbPerson3);
            this.groupBox1.Controls.Add(this.rbPerson2);
            this.groupBox1.Controls.Add(this.rbPerson1);
            this.groupBox1.Location = new System.Drawing.Point(64, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Information";
            // 
            // rbPerson4
            // 
            this.rbPerson4.AutoSize = true;
            this.rbPerson4.Location = new System.Drawing.Point(18, 194);
            this.rbPerson4.Name = "rbPerson4";
            this.rbPerson4.Size = new System.Drawing.Size(67, 24);
            this.rbPerson4.TabIndex = 3;
            this.rbPerson4.TabStop = true;
            this.rbPerson4.Text = "Sam";
            this.rbPerson4.UseVisualStyleBackColor = true;
            this.rbPerson4.CheckedChanged += new System.EventHandler(this.rbPerson4_CheckedChanged);
            // 
            // rbPerson3
            // 
            this.rbPerson3.AutoSize = true;
            this.rbPerson3.Location = new System.Drawing.Point(18, 145);
            this.rbPerson3.Name = "rbPerson3";
            this.rbPerson3.Size = new System.Drawing.Size(65, 24);
            this.rbPerson3.TabIndex = 2;
            this.rbPerson3.TabStop = true;
            this.rbPerson3.Text = "Lars";
            this.rbPerson3.UseVisualStyleBackColor = true;
            this.rbPerson3.CheckedChanged += new System.EventHandler(this.rbPerson3_CheckedChanged);
            // 
            // rbPerson2
            // 
            this.rbPerson2.AutoSize = true;
            this.rbPerson2.Location = new System.Drawing.Point(18, 97);
            this.rbPerson2.Name = "rbPerson2";
            this.rbPerson2.Size = new System.Drawing.Size(77, 24);
            this.rbPerson2.TabIndex = 1;
            this.rbPerson2.TabStop = true;
            this.rbPerson2.Text = "Myron";
            this.rbPerson2.UseVisualStyleBackColor = true;
            this.rbPerson2.CheckedChanged += new System.EventHandler(this.rbPerson2_CheckedChanged);
            // 
            // rbPerson1
            // 
            this.rbPerson1.AutoSize = true;
            this.rbPerson1.Location = new System.Drawing.Point(18, 51);
            this.rbPerson1.Name = "rbPerson1";
            this.rbPerson1.Size = new System.Drawing.Size(58, 24);
            this.rbPerson1.TabIndex = 0;
            this.rbPerson1.TabStop = true;
            this.rbPerson1.Text = "Jim";
            this.rbPerson1.UseVisualStyleBackColor = true;
            this.rbPerson1.CheckedChanged += new System.EventHandler(this.rbPerson1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.btnShowMealInfo);
            this.groupBox2.Controls.Add(this.rbMeal5);
            this.groupBox2.Controls.Add(this.rbMeal4);
            this.groupBox2.Controls.Add(this.rbMeal3);
            this.groupBox2.Controls.Add(this.rbMeal2);
            this.groupBox2.Controls.Add(this.rbMeal1);
            this.groupBox2.Location = new System.Drawing.Point(269, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 332);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal Information";
            // 
            // btnShowMealInfo
            // 
            this.btnShowMealInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowMealInfo.Location = new System.Drawing.Point(18, 38);
            this.btnShowMealInfo.Name = "btnShowMealInfo";
            this.btnShowMealInfo.Size = new System.Drawing.Size(174, 29);
            this.btnShowMealInfo.TabIndex = 9;
            this.btnShowMealInfo.Text = "Show Meal Info";
            this.btnShowMealInfo.UseVisualStyleBackColor = false;
            this.btnShowMealInfo.Click += new System.EventHandler(this.btnShowMealInfo_Click);
            // 
            // rbMeal5
            // 
            this.rbMeal5.AutoSize = true;
            this.rbMeal5.Location = new System.Drawing.Point(18, 282);
            this.rbMeal5.Name = "rbMeal5";
            this.rbMeal5.Size = new System.Drawing.Size(74, 24);
            this.rbMeal5.TabIndex = 8;
            this.rbMeal5.TabStop = true;
            this.rbMeal5.Text = "..........";
            this.rbMeal5.UseVisualStyleBackColor = true;
            this.rbMeal5.CheckedChanged += new System.EventHandler(this.rbMeal5_CheckedChanged);
            // 
            // rbMeal4
            // 
            this.rbMeal4.AutoSize = true;
            this.rbMeal4.Location = new System.Drawing.Point(18, 234);
            this.rbMeal4.Name = "rbMeal4";
            this.rbMeal4.Size = new System.Drawing.Size(74, 24);
            this.rbMeal4.TabIndex = 7;
            this.rbMeal4.TabStop = true;
            this.rbMeal4.Text = "..........";
            this.rbMeal4.UseVisualStyleBackColor = true;
            this.rbMeal4.CheckedChanged += new System.EventHandler(this.rbMeal4_CheckedChanged);
            // 
            // rbMeal3
            // 
            this.rbMeal3.AutoSize = true;
            this.rbMeal3.Location = new System.Drawing.Point(18, 185);
            this.rbMeal3.Name = "rbMeal3";
            this.rbMeal3.Size = new System.Drawing.Size(74, 24);
            this.rbMeal3.TabIndex = 6;
            this.rbMeal3.TabStop = true;
            this.rbMeal3.Text = "..........";
            this.rbMeal3.UseVisualStyleBackColor = true;
            this.rbMeal3.CheckedChanged += new System.EventHandler(this.rbMeal3_CheckedChanged);
            // 
            // rbMeal2
            // 
            this.rbMeal2.AutoSize = true;
            this.rbMeal2.Location = new System.Drawing.Point(18, 137);
            this.rbMeal2.Name = "rbMeal2";
            this.rbMeal2.Size = new System.Drawing.Size(74, 24);
            this.rbMeal2.TabIndex = 5;
            this.rbMeal2.TabStop = true;
            this.rbMeal2.Text = "..........";
            this.rbMeal2.UseVisualStyleBackColor = true;
            this.rbMeal2.CheckedChanged += new System.EventHandler(this.rbMeal2_CheckedChanged);
            // 
            // rbMeal1
            // 
            this.rbMeal1.AutoSize = true;
            this.rbMeal1.Location = new System.Drawing.Point(18, 91);
            this.rbMeal1.Name = "rbMeal1";
            this.rbMeal1.Size = new System.Drawing.Size(74, 24);
            this.rbMeal1.TabIndex = 4;
            this.rbMeal1.TabStop = true;
            this.rbMeal1.Text = "..........";
            this.rbMeal1.UseVisualStyleBackColor = true;
            this.rbMeal1.CheckedChanged += new System.EventHandler(this.rbMeal1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(110, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Place your oder by choosing your name and the meal you want ";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(64, 587);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(680, 52);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place your order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lbTotalPrice);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.lbOrderPrice4);
            this.groupBox3.Controls.Add(this.lbOrderPrice3);
            this.groupBox3.Controls.Add(this.lbOrderPrice2);
            this.groupBox3.Controls.Add(this.lbOrderPrice1);
            this.groupBox3.Controls.Add(this.lbClientOrder2);
            this.groupBox3.Controls.Add(this.lbClientOrder3);
            this.groupBox3.Controls.Add(this.lbClientOrder4);
            this.groupBox3.Controls.Add(this.lbClientOrder1);
            this.groupBox3.Location = new System.Drawing.Point(64, 677);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(680, 275);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orderlist ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(527, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "_____________+";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.Location = new System.Drawing.Point(543, 223);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(93, 25);
            this.lbTotalPrice.TabIndex = 9;
            this.lbTotalPrice.Text = "Euro ...,...";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(17, 223);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(105, 25);
            this.label.TabIndex = 8;
            this.label.Text = "Total Price";
            // 
            // lbOrderPrice4
            // 
            this.lbOrderPrice4.AutoSize = true;
            this.lbOrderPrice4.Location = new System.Drawing.Point(544, 167);
            this.lbOrderPrice4.Name = "lbOrderPrice4";
            this.lbOrderPrice4.Size = new System.Drawing.Size(75, 20);
            this.lbOrderPrice4.TabIndex = 7;
            this.lbOrderPrice4.Text = "Euro ...,...";
            // 
            // lbOrderPrice3
            // 
            this.lbOrderPrice3.AutoSize = true;
            this.lbOrderPrice3.Location = new System.Drawing.Point(544, 124);
            this.lbOrderPrice3.Name = "lbOrderPrice3";
            this.lbOrderPrice3.Size = new System.Drawing.Size(75, 20);
            this.lbOrderPrice3.TabIndex = 6;
            this.lbOrderPrice3.Text = "Euro ...,...";
            // 
            // lbOrderPrice2
            // 
            this.lbOrderPrice2.AutoSize = true;
            this.lbOrderPrice2.Location = new System.Drawing.Point(544, 82);
            this.lbOrderPrice2.Name = "lbOrderPrice2";
            this.lbOrderPrice2.Size = new System.Drawing.Size(75, 20);
            this.lbOrderPrice2.TabIndex = 5;
            this.lbOrderPrice2.Text = "Euro ...,...";
            // 
            // lbOrderPrice1
            // 
            this.lbOrderPrice1.AutoSize = true;
            this.lbOrderPrice1.Location = new System.Drawing.Point(544, 43);
            this.lbOrderPrice1.Name = "lbOrderPrice1";
            this.lbOrderPrice1.Size = new System.Drawing.Size(75, 20);
            this.lbOrderPrice1.TabIndex = 4;
            this.lbOrderPrice1.Text = "Euro ...,...";
            // 
            // lbClientOrder2
            // 
            this.lbClientOrder2.AutoSize = true;
            this.lbClientOrder2.Location = new System.Drawing.Point(18, 82);
            this.lbClientOrder2.Name = "lbClientOrder2";
            this.lbClientOrder2.Size = new System.Drawing.Size(90, 20);
            this.lbClientOrder2.TabIndex = 3;
            this.lbClientOrder2.Text = "Client order";
            // 
            // lbClientOrder3
            // 
            this.lbClientOrder3.AutoSize = true;
            this.lbClientOrder3.Location = new System.Drawing.Point(18, 124);
            this.lbClientOrder3.Name = "lbClientOrder3";
            this.lbClientOrder3.Size = new System.Drawing.Size(90, 20);
            this.lbClientOrder3.TabIndex = 2;
            this.lbClientOrder3.Text = "Client order";
            // 
            // lbClientOrder4
            // 
            this.lbClientOrder4.AutoSize = true;
            this.lbClientOrder4.Location = new System.Drawing.Point(18, 167);
            this.lbClientOrder4.Name = "lbClientOrder4";
            this.lbClientOrder4.Size = new System.Drawing.Size(90, 20);
            this.lbClientOrder4.TabIndex = 1;
            this.lbClientOrder4.Text = "Client order";
            // 
            // lbClientOrder1
            // 
            this.lbClientOrder1.AutoSize = true;
            this.lbClientOrder1.Location = new System.Drawing.Point(18, 43);
            this.lbClientOrder1.Name = "lbClientOrder1";
            this.lbClientOrder1.Size = new System.Drawing.Size(90, 20);
            this.lbClientOrder1.TabIndex = 0;
            this.lbClientOrder1.Text = "Client order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Every person may only order one meal at a time.\r\nWhen you finished the first meal" +
    " then you may order your next meal. \r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(64, 980);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(680, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make order final ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnAddName
            // 
            this.btnAddName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddName.Location = new System.Drawing.Point(428, 122);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(190, 48);
            this.btnAddName.TabIndex = 7;
            this.btnAddName.Text = "Add your name";
            this.btnAddName.UseVisualStyleBackColor = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(128, 135);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(271, 26);
            this.tbName.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 1088);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnAddName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPerson4;
        private System.Windows.Forms.RadioButton rbPerson3;
        private System.Windows.Forms.RadioButton rbPerson2;
        private System.Windows.Forms.RadioButton rbPerson1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMeal1;
        private System.Windows.Forms.RadioButton rbMeal5;
        private System.Windows.Forms.RadioButton rbMeal4;
        private System.Windows.Forms.RadioButton rbMeal3;
        private System.Windows.Forms.RadioButton rbMeal2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lbOrderPrice4;
        private System.Windows.Forms.Label lbOrderPrice3;
        private System.Windows.Forms.Label lbOrderPrice2;
        private System.Windows.Forms.Label lbOrderPrice1;
        private System.Windows.Forms.Label lbClientOrder2;
        private System.Windows.Forms.Label lbClientOrder3;
        private System.Windows.Forms.Label lbClientOrder4;
        private System.Windows.Forms.Label lbClientOrder1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnShowMealInfo;
    }
}

