namespace WeekOfNov6th
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
            this.lblTemperatureConverter = new System.Windows.Forms.Label();
            this.lblMoneyConvert = new System.Windows.Forms.Label();
            this.check_ctof = new System.Windows.Forms.RadioButton();
            this.check_ftoc = new System.Windows.Forms.RadioButton();
            this.grpTempConverter = new System.Windows.Forms.GroupBox();
            this.mon_dropdown = new System.Windows.Forms.ComboBox();
            this.btn_temp = new System.Windows.Forms.Button();
            this.rtb_Output = new System.Windows.Forms.RichTextBox();
            this.btn_mon = new System.Windows.Forms.Button();
            this.txt_input2 = new System.Windows.Forms.TextBox();
            this.txt_input1 = new System.Windows.Forms.TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblDistanceConverter = new System.Windows.Forms.Label();
            this.box_metoin = new System.Windows.Forms.CheckBox();
            this.box_mitokm = new System.Windows.Forms.CheckBox();
            this.btn_dis = new System.Windows.Forms.Button();
            this.box_intome = new System.Windows.Forms.CheckBox();
            this.box_kitomi = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.grpTempConverter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemperatureConverter
            // 
            this.lblTemperatureConverter.AutoSize = true;
            this.lblTemperatureConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperatureConverter.Location = new System.Drawing.Point(42, 68);
            this.lblTemperatureConverter.Name = "lblTemperatureConverter";
            this.lblTemperatureConverter.Size = new System.Drawing.Size(236, 26);
            this.lblTemperatureConverter.TabIndex = 0;
            this.lblTemperatureConverter.Text = "Temperature Converter";
            // 
            // lblMoneyConvert
            // 
            this.lblMoneyConvert.AutoSize = true;
            this.lblMoneyConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyConvert.Location = new System.Drawing.Point(42, 142);
            this.lblMoneyConvert.Name = "lblMoneyConvert";
            this.lblMoneyConvert.Size = new System.Drawing.Size(178, 26);
            this.lblMoneyConvert.TabIndex = 1;
            this.lblMoneyConvert.Text = "Money Converter";
            // 
            // check_ctof
            // 
            this.check_ctof.AutoSize = true;
            this.check_ctof.Location = new System.Drawing.Point(18, 31);
            this.check_ctof.Name = "check_ctof";
            this.check_ctof.Size = new System.Drawing.Size(196, 28);
            this.check_ctof.TabIndex = 2;
            this.check_ctof.TabStop = true;
            this.check_ctof.Text = "Celsuis - Fahrenheit";
            this.check_ctof.UseVisualStyleBackColor = true;
            // 
            // check_ftoc
            // 
            this.check_ftoc.AutoSize = true;
            this.check_ftoc.Location = new System.Drawing.Point(234, 31);
            this.check_ftoc.Name = "check_ftoc";
            this.check_ftoc.Size = new System.Drawing.Size(196, 28);
            this.check_ftoc.TabIndex = 3;
            this.check_ftoc.TabStop = true;
            this.check_ftoc.Text = "Fahrenheit - Celsius";
            this.check_ftoc.UseVisualStyleBackColor = true;
            // 
            // grpTempConverter
            // 
            this.grpTempConverter.Controls.Add(this.check_ctof);
            this.grpTempConverter.Controls.Add(this.check_ftoc);
            this.grpTempConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTempConverter.Location = new System.Drawing.Point(321, 38);
            this.grpTempConverter.Name = "grpTempConverter";
            this.grpTempConverter.Size = new System.Drawing.Size(458, 77);
            this.grpTempConverter.TabIndex = 4;
            this.grpTempConverter.TabStop = false;
            this.grpTempConverter.Tag = "";
            this.grpTempConverter.Text = "Convert";
            // 
            // mon_dropdown
            // 
            this.mon_dropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mon_dropdown.FormattingEnabled = true;
            this.mon_dropdown.Items.AddRange(new object[] {
            "Dollar - Yen",
            "Yen - Dollar",
            "Dollar - Euro",
            "Euro - Dollar",
            "Dollar - Pounds",
            "Pounds - Dollar",
            "Dollar - AUD",
            "AUD - Dollar"});
            this.mon_dropdown.Location = new System.Drawing.Point(321, 142);
            this.mon_dropdown.Name = "mon_dropdown";
            this.mon_dropdown.Size = new System.Drawing.Size(121, 32);
            this.mon_dropdown.TabIndex = 5;
            // 
            // btn_temp
            // 
            this.btn_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_temp.Location = new System.Drawing.Point(846, 82);
            this.btn_temp.Name = "btn_temp";
            this.btn_temp.Size = new System.Drawing.Size(75, 33);
            this.btn_temp.TabIndex = 6;
            this.btn_temp.Text = "button1";
            this.btn_temp.UseVisualStyleBackColor = true;
            this.btn_temp.Click += new System.EventHandler(this.btn_temp_Click);
            // 
            // rtb_Output
            // 
            this.rtb_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Output.Location = new System.Drawing.Point(47, 478);
            this.rtb_Output.Name = "rtb_Output";
            this.rtb_Output.Size = new System.Drawing.Size(964, 148);
            this.rtb_Output.TabIndex = 7;
            this.rtb_Output.Text = "";
            // 
            // btn_mon
            // 
            this.btn_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mon.Location = new System.Drawing.Point(846, 136);
            this.btn_mon.Name = "btn_mon";
            this.btn_mon.Size = new System.Drawing.Size(75, 32);
            this.btn_mon.TabIndex = 8;
            this.btn_mon.Text = "button2";
            this.btn_mon.UseVisualStyleBackColor = true;
            this.btn_mon.Click += new System.EventHandler(this.btn_mon_Click);
            // 
            // txt_input2
            // 
            this.txt_input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input2.Location = new System.Drawing.Point(321, 411);
            this.txt_input2.Name = "txt_input2";
            this.txt_input2.Size = new System.Drawing.Size(169, 29);
            this.txt_input2.TabIndex = 9;
            // 
            // txt_input1
            // 
            this.txt_input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input1.Location = new System.Drawing.Point(47, 411);
            this.txt_input1.Name = "txt_input1";
            this.txt_input1.Size = new System.Drawing.Size(173, 29);
            this.txt_input1.TabIndex = 10;
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(43, 372);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(61, 24);
            this.lblInput1.TabIndex = 11;
            this.lblInput1.Text = "Input1";
            // 
            // lblInput2
            // 
            this.lblInput2.AutoSize = true;
            this.lblInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput2.Location = new System.Drawing.Point(317, 372);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(61, 24);
            this.lblInput2.TabIndex = 12;
            this.lblInput2.Text = "Input2";
            // 
            // lblDistanceConverter
            // 
            this.lblDistanceConverter.AutoSize = true;
            this.lblDistanceConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceConverter.Location = new System.Drawing.Point(42, 243);
            this.lblDistanceConverter.Name = "lblDistanceConverter";
            this.lblDistanceConverter.Size = new System.Drawing.Size(196, 25);
            this.lblDistanceConverter.TabIndex = 13;
            this.lblDistanceConverter.Tag = "";
            this.lblDistanceConverter.Text = "Distance Converter";
            // 
            // box_metoin
            // 
            this.box_metoin.AutoSize = true;
            this.box_metoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_metoin.Location = new System.Drawing.Point(569, 240);
            this.box_metoin.Name = "box_metoin";
            this.box_metoin.Size = new System.Drawing.Size(167, 28);
            this.box_metoin.TabIndex = 14;
            this.box_metoin.Text = "Meters to Inches";
            this.box_metoin.UseVisualStyleBackColor = true;
            // 
            // box_mitokm
            // 
            this.box_mitokm.AutoSize = true;
            this.box_mitokm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_mitokm.Location = new System.Drawing.Point(321, 240);
            this.box_mitokm.Name = "box_mitokm";
            this.box_mitokm.Size = new System.Drawing.Size(186, 28);
            this.box_mitokm.TabIndex = 15;
            this.box_mitokm.Tag = "";
            this.box_mitokm.Text = "Miles to Kilometers";
            this.box_mitokm.UseVisualStyleBackColor = true;
            // 
            // btn_dis
            // 
            this.btn_dis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dis.Location = new System.Drawing.Point(846, 243);
            this.btn_dis.Name = "btn_dis";
            this.btn_dis.Size = new System.Drawing.Size(75, 31);
            this.btn_dis.TabIndex = 16;
            this.btn_dis.Text = "button3";
            this.btn_dis.UseVisualStyleBackColor = true;
            this.btn_dis.Click += new System.EventHandler(this.btn_dis_Click);
            // 
            // box_intome
            // 
            this.box_intome.AutoSize = true;
            this.box_intome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_intome.Location = new System.Drawing.Point(569, 290);
            this.box_intome.Name = "box_intome";
            this.box_intome.Size = new System.Drawing.Size(167, 28);
            this.box_intome.TabIndex = 17;
            this.box_intome.Text = "Inches to Meters";
            this.box_intome.UseVisualStyleBackColor = true;
            // 
            // box_kitomi
            // 
            this.box_kitomi.AutoSize = true;
            this.box_kitomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_kitomi.Location = new System.Drawing.Point(321, 290);
            this.box_kitomi.Name = "box_kitomi";
            this.box_kitomi.Size = new System.Drawing.Size(186, 28);
            this.box_kitomi.TabIndex = 18;
            this.box_kitomi.Text = "Kilometers to Miles";
            this.box_kitomi.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(846, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 31);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 648);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.box_kitomi);
            this.Controls.Add(this.box_intome);
            this.Controls.Add(this.btn_dis);
            this.Controls.Add(this.box_mitokm);
            this.Controls.Add(this.box_metoin);
            this.Controls.Add(this.lblDistanceConverter);
            this.Controls.Add(this.lblInput2);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.txt_input1);
            this.Controls.Add(this.txt_input2);
            this.Controls.Add(this.btn_mon);
            this.Controls.Add(this.rtb_Output);
            this.Controls.Add(this.btn_temp);
            this.Controls.Add(this.mon_dropdown);
            this.Controls.Add(this.grpTempConverter);
            this.Controls.Add(this.lblMoneyConvert);
            this.Controls.Add(this.lblTemperatureConverter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpTempConverter.ResumeLayout(false);
            this.grpTempConverter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatureConverter;
        private System.Windows.Forms.Label lblMoneyConvert;
        private System.Windows.Forms.RadioButton check_ctof;
        private System.Windows.Forms.RadioButton check_ftoc;
        private System.Windows.Forms.GroupBox grpTempConverter;
        private System.Windows.Forms.ComboBox mon_dropdown;
        private System.Windows.Forms.Button btn_temp;
        private System.Windows.Forms.RichTextBox rtb_Output;
        private System.Windows.Forms.Button btn_mon;
        private System.Windows.Forms.TextBox txt_input2;
        private System.Windows.Forms.TextBox txt_input1;
        private System.Windows.Forms.Label lblInput1;
        private System.Windows.Forms.Label lblInput2;
        private System.Windows.Forms.Label lblDistanceConverter;
        private System.Windows.Forms.CheckBox box_metoin;
        private System.Windows.Forms.CheckBox box_mitokm;
        private System.Windows.Forms.Button btn_dis;
        private System.Windows.Forms.CheckBox box_intome;
        private System.Windows.Forms.CheckBox box_kitomi;
        private System.Windows.Forms.Button button4;
    }
}

