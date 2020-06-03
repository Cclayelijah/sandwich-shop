namespace FinalProject
{
    partial class SandwichShop
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.breadComboBox = new System.Windows.Forms.ComboBox();
            this.meatComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cheeseComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tomatoCheckBox = new System.Windows.Forms.CheckBox();
            this.lettuceCheckBox = new System.Windows.Forms.CheckBox();
            this.jalapenoCheckBox = new System.Windows.Forms.CheckBox();
            this.peppersCheckBox = new System.Windows.Forms.CheckBox();
            this.cucumberCheckBox = new System.Windows.Forms.CheckBox();
            this.onionCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.barbequeCheckBox = new System.Windows.Forms.CheckBox();
            this.mayoCheckBox = new System.Windows.Forms.CheckBox();
            this.ranchCheckBox = new System.Windows.Forms.CheckBox();
            this.srirachaCheckBox = new System.Windows.Forms.CheckBox();
            this.mustardCheckBox = new System.Windows.Forms.CheckBox();
            this.honeyMustardCheckBox = new System.Windows.Forms.CheckBox();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.cancelOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.creditCardNumTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.securityCodeTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.monthNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.orderAgainButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumbericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order a Sandwich:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bread";
            // 
            // breadComboBox
            // 
            this.breadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.breadComboBox.FormattingEnabled = true;
            this.breadComboBox.Items.AddRange(new object[] {
            "9-Grain Wheat",
            "Multi-Grain Flatbread",
            "Italian",
            "Italian Herbs & Cheese",
            "White Flatbread",
            "Roasted Garlic"});
            this.breadComboBox.Location = new System.Drawing.Point(119, 60);
            this.breadComboBox.Name = "breadComboBox";
            this.breadComboBox.Size = new System.Drawing.Size(167, 21);
            this.breadComboBox.TabIndex = 2;
            // 
            // meatComboBox
            // 
            this.meatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.meatComboBox.FormattingEnabled = true;
            this.meatComboBox.Items.AddRange(new object[] {
            "Ham",
            "Chicken",
            "Beef",
            "Turkey",
            "Pulled Pork",
            "Tuna"});
            this.meatComboBox.Location = new System.Drawing.Point(119, 99);
            this.meatComboBox.Name = "meatComboBox";
            this.meatComboBox.Size = new System.Drawing.Size(167, 21);
            this.meatComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Meat";
            // 
            // cheeseComboBox
            // 
            this.cheeseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cheeseComboBox.FormattingEnabled = true;
            this.cheeseComboBox.Items.AddRange(new object[] {
            "American",
            "Monterey",
            "Mozzarella",
            "Cheddar",
            "Pepperjack",
            "Swiss"});
            this.cheeseComboBox.Location = new System.Drawing.Point(119, 140);
            this.cheeseComboBox.Name = "cheeseComboBox";
            this.cheeseComboBox.Size = new System.Drawing.Size(167, 21);
            this.cheeseComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cheese";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(129, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Toppings:";
            this.label5.Visible = false;
            // 
            // tomatoCheckBox
            // 
            this.tomatoCheckBox.AutoSize = true;
            this.tomatoCheckBox.Location = new System.Drawing.Point(134, 94);
            this.tomatoCheckBox.Name = "tomatoCheckBox";
            this.tomatoCheckBox.Size = new System.Drawing.Size(73, 17);
            this.tomatoCheckBox.TabIndex = 17;
            this.tomatoCheckBox.Text = "Tomatoes";
            this.tomatoCheckBox.UseVisualStyleBackColor = true;
            this.tomatoCheckBox.Visible = false;
            // 
            // lettuceCheckBox
            // 
            this.lettuceCheckBox.AutoSize = true;
            this.lettuceCheckBox.Location = new System.Drawing.Point(27, 94);
            this.lettuceCheckBox.Name = "lettuceCheckBox";
            this.lettuceCheckBox.Size = new System.Drawing.Size(62, 17);
            this.lettuceCheckBox.TabIndex = 18;
            this.lettuceCheckBox.Text = "Lettuce";
            this.lettuceCheckBox.UseVisualStyleBackColor = true;
            this.lettuceCheckBox.Visible = false;
            // 
            // jalapenoCheckBox
            // 
            this.jalapenoCheckBox.AutoSize = true;
            this.jalapenoCheckBox.Location = new System.Drawing.Point(242, 94);
            this.jalapenoCheckBox.Name = "jalapenoCheckBox";
            this.jalapenoCheckBox.Size = new System.Drawing.Size(74, 17);
            this.jalapenoCheckBox.TabIndex = 19;
            this.jalapenoCheckBox.Text = "Jalapeños";
            this.jalapenoCheckBox.UseVisualStyleBackColor = true;
            this.jalapenoCheckBox.Visible = false;
            // 
            // peppersCheckBox
            // 
            this.peppersCheckBox.AutoSize = true;
            this.peppersCheckBox.Location = new System.Drawing.Point(27, 117);
            this.peppersCheckBox.Name = "peppersCheckBox";
            this.peppersCheckBox.Size = new System.Drawing.Size(97, 17);
            this.peppersCheckBox.TabIndex = 20;
            this.peppersCheckBox.Text = "Green Peppers";
            this.peppersCheckBox.UseVisualStyleBackColor = true;
            this.peppersCheckBox.Visible = false;
            // 
            // cucumberCheckBox
            // 
            this.cucumberCheckBox.AutoSize = true;
            this.cucumberCheckBox.Location = new System.Drawing.Point(134, 117);
            this.cucumberCheckBox.Name = "cucumberCheckBox";
            this.cucumberCheckBox.Size = new System.Drawing.Size(79, 17);
            this.cucumberCheckBox.TabIndex = 21;
            this.cucumberCheckBox.Text = "Cucumbers";
            this.cucumberCheckBox.UseVisualStyleBackColor = true;
            this.cucumberCheckBox.Visible = false;
            // 
            // onionCheckBox
            // 
            this.onionCheckBox.AutoSize = true;
            this.onionCheckBox.Location = new System.Drawing.Point(242, 117);
            this.onionCheckBox.Name = "onionCheckBox";
            this.onionCheckBox.Size = new System.Drawing.Size(59, 17);
            this.onionCheckBox.TabIndex = 22;
            this.onionCheckBox.Text = "Onions";
            this.onionCheckBox.UseVisualStyleBackColor = true;
            this.onionCheckBox.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(131, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Sauces:";
            this.label6.Visible = false;
            // 
            // barbequeCheckBox
            // 
            this.barbequeCheckBox.AutoSize = true;
            this.barbequeCheckBox.Location = new System.Drawing.Point(27, 182);
            this.barbequeCheckBox.Name = "barbequeCheckBox";
            this.barbequeCheckBox.Size = new System.Drawing.Size(72, 17);
            this.barbequeCheckBox.TabIndex = 24;
            this.barbequeCheckBox.Text = "Barbeque";
            this.barbequeCheckBox.UseVisualStyleBackColor = true;
            this.barbequeCheckBox.Visible = false;
            // 
            // mayoCheckBox
            // 
            this.mayoCheckBox.AutoSize = true;
            this.mayoCheckBox.Location = new System.Drawing.Point(134, 182);
            this.mayoCheckBox.Name = "mayoCheckBox";
            this.mayoCheckBox.Size = new System.Drawing.Size(83, 17);
            this.mayoCheckBox.TabIndex = 25;
            this.mayoCheckBox.Text = "Mayonnaise";
            this.mayoCheckBox.UseVisualStyleBackColor = true;
            this.mayoCheckBox.Visible = false;
            // 
            // ranchCheckBox
            // 
            this.ranchCheckBox.AutoSize = true;
            this.ranchCheckBox.Location = new System.Drawing.Point(242, 182);
            this.ranchCheckBox.Name = "ranchCheckBox";
            this.ranchCheckBox.Size = new System.Drawing.Size(58, 17);
            this.ranchCheckBox.TabIndex = 26;
            this.ranchCheckBox.Text = "Ranch";
            this.ranchCheckBox.UseVisualStyleBackColor = true;
            this.ranchCheckBox.Visible = false;
            // 
            // srirachaCheckBox
            // 
            this.srirachaCheckBox.AutoSize = true;
            this.srirachaCheckBox.Location = new System.Drawing.Point(27, 205);
            this.srirachaCheckBox.Name = "srirachaCheckBox";
            this.srirachaCheckBox.Size = new System.Drawing.Size(65, 17);
            this.srirachaCheckBox.TabIndex = 27;
            this.srirachaCheckBox.Text = "Sriracha";
            this.srirachaCheckBox.UseVisualStyleBackColor = true;
            this.srirachaCheckBox.Visible = false;
            // 
            // mustardCheckBox
            // 
            this.mustardCheckBox.AutoSize = true;
            this.mustardCheckBox.Location = new System.Drawing.Point(134, 205);
            this.mustardCheckBox.Name = "mustardCheckBox";
            this.mustardCheckBox.Size = new System.Drawing.Size(64, 17);
            this.mustardCheckBox.TabIndex = 28;
            this.mustardCheckBox.Text = "Mustard";
            this.mustardCheckBox.UseVisualStyleBackColor = true;
            this.mustardCheckBox.Visible = false;
            // 
            // honeyMustardCheckBox
            // 
            this.honeyMustardCheckBox.AutoSize = true;
            this.honeyMustardCheckBox.Location = new System.Drawing.Point(242, 205);
            this.honeyMustardCheckBox.Name = "honeyMustardCheckBox";
            this.honeyMustardCheckBox.Size = new System.Drawing.Size(98, 17);
            this.honeyMustardCheckBox.TabIndex = 29;
            this.honeyMustardCheckBox.Text = "Honey Mustard";
            this.honeyMustardCheckBox.UseVisualStyleBackColor = true;
            this.honeyMustardCheckBox.Visible = false;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.BackColor = System.Drawing.Color.GreenYellow;
            this.placeOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOrderButton.Location = new System.Drawing.Point(134, 324);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(88, 66);
            this.placeOrderButton.TabIndex = 30;
            this.placeOrderButton.Text = "Place Order";
            this.placeOrderButton.UseVisualStyleBackColor = false;
            this.placeOrderButton.Visible = false;
            this.placeOrderButton.Click += new System.EventHandler(this.placeOrderButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.Location = new System.Drawing.Point(242, 324);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(88, 30);
            this.nextButton.TabIndex = 31;
            this.nextButton.Text = "Next ->";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // cancelOrderButton
            // 
            this.cancelOrderButton.Location = new System.Drawing.Point(241, 360);
            this.cancelOrderButton.Name = "cancelOrderButton";
            this.cancelOrderButton.Size = new System.Drawing.Size(88, 30);
            this.cancelOrderButton.TabIndex = 32;
            this.cancelOrderButton.Text = "Cancel Order";
            this.cancelOrderButton.UseVisualStyleBackColor = true;
            this.cancelOrderButton.Click += new System.EventHandler(this.cancelOrderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(27, 360);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(88, 30);
            this.exitButton.TabIndex = 33;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(27, 324);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(88, 30);
            this.backButton.TabIndex = 34;
            this.backButton.Text = "<- Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Cost";
            this.label7.Visible = false;
            // 
            // costTextBox
            // 
            this.costTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.costTextBox.Location = new System.Drawing.Point(49, 69);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.costTextBox.Size = new System.Drawing.Size(252, 118);
            this.costTextBox.TabIndex = 36;
            this.costTextBox.Visible = false;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inventoryTextBox.Location = new System.Drawing.Point(49, 69);
            this.inventoryTextBox.Multiline = true;
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.ReadOnly = true;
            this.inventoryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inventoryTextBox.Size = new System.Drawing.Size(252, 175);
            this.inventoryTextBox.TabIndex = 38;
            this.inventoryTextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(46, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Inventory";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Enter Payment Information";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Credit Card #";
            this.label10.Visible = false;
            // 
            // creditCardNumTextBox
            // 
            this.creditCardNumTextBox.Location = new System.Drawing.Point(134, 226);
            this.creditCardNumTextBox.Name = "creditCardNumTextBox";
            this.creditCardNumTextBox.Size = new System.Drawing.Size(167, 20);
            this.creditCardNumTextBox.TabIndex = 41;
            this.creditCardNumTextBox.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Expiration Date";
            this.label11.Visible = false;
            // 
            // securityCodeTextBox
            // 
            this.securityCodeTextBox.Location = new System.Drawing.Point(134, 276);
            this.securityCodeTextBox.Name = "securityCodeTextBox";
            this.securityCodeTextBox.Size = new System.Drawing.Size(41, 20);
            this.securityCodeTextBox.TabIndex = 45;
            this.securityCodeTextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Security Code";
            this.label12.Visible = false;
            // 
            // monthNumbericUpDown
            // 
            this.monthNumbericUpDown.Location = new System.Drawing.Point(134, 251);
            this.monthNumbericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumbericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumbericUpDown.Name = "monthNumbericUpDown";
            this.monthNumbericUpDown.Size = new System.Drawing.Size(52, 20);
            this.monthNumbericUpDown.TabIndex = 46;
            this.monthNumbericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumbericUpDown.Visible = false;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(192, 251);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.yearNumericUpDown.TabIndex = 47;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.yearNumericUpDown.Visible = false;
            // 
            // orderAgainButton
            // 
            this.orderAgainButton.Location = new System.Drawing.Point(241, 360);
            this.orderAgainButton.Name = "orderAgainButton";
            this.orderAgainButton.Size = new System.Drawing.Size(88, 30);
            this.orderAgainButton.TabIndex = 48;
            this.orderAgainButton.Text = "Order Again";
            this.orderAgainButton.UseVisualStyleBackColor = true;
            this.orderAgainButton.Visible = false;
            this.orderAgainButton.Click += new System.EventHandler(this.orderAgainButton_Click);
            // 
            // SandwichShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 426);
            this.Controls.Add(this.orderAgainButton);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.monthNumbericUpDown);
            this.Controls.Add(this.securityCodeTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.creditCardNumTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelOrderButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.placeOrderButton);
            this.Controls.Add(this.honeyMustardCheckBox);
            this.Controls.Add(this.mustardCheckBox);
            this.Controls.Add(this.srirachaCheckBox);
            this.Controls.Add(this.ranchCheckBox);
            this.Controls.Add(this.mayoCheckBox);
            this.Controls.Add(this.barbequeCheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.onionCheckBox);
            this.Controls.Add(this.cucumberCheckBox);
            this.Controls.Add(this.peppersCheckBox);
            this.Controls.Add(this.jalapenoCheckBox);
            this.Controls.Add(this.lettuceCheckBox);
            this.Controls.Add(this.tomatoCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cheeseComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.meatComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.breadComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SandwichShop";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Sandwich Shop";
            ((System.ComponentModel.ISupportInitialize)(this.monthNumbericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox breadComboBox;
        private System.Windows.Forms.ComboBox meatComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cheeseComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox tomatoCheckBox;
        private System.Windows.Forms.CheckBox lettuceCheckBox;
        private System.Windows.Forms.CheckBox jalapenoCheckBox;
        private System.Windows.Forms.CheckBox peppersCheckBox;
        private System.Windows.Forms.CheckBox cucumberCheckBox;
        private System.Windows.Forms.CheckBox onionCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox barbequeCheckBox;
        private System.Windows.Forms.CheckBox mayoCheckBox;
        private System.Windows.Forms.CheckBox ranchCheckBox;
        private System.Windows.Forms.CheckBox srirachaCheckBox;
        private System.Windows.Forms.CheckBox mustardCheckBox;
        private System.Windows.Forms.CheckBox honeyMustardCheckBox;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox creditCardNumTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox securityCodeTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown monthNumbericUpDown;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Button orderAgainButton;
    }
}

