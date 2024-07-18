namespace osu_search_filter_generator
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.KEY_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.OPERATION_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.ADD_BUTTON = new System.Windows.Forms.Button();
            this.MODE_OSU = new System.Windows.Forms.CheckBox();
            this.MODE_TAIKO = new System.Windows.Forms.CheckBox();
            this.MODE_CATCH = new System.Windows.Forms.CheckBox();
            this.MODE_MANIA = new System.Windows.Forms.CheckBox();
            this.VALUE_TEXTBOX = new System.Windows.Forms.TextBox();
            this.STATUS_NOTSUBMITTED = new System.Windows.Forms.CheckBox();
            this.STATUS_PENDING = new System.Windows.Forms.CheckBox();
            this.STATUS_APPROVED = new System.Windows.Forms.CheckBox();
            this.STATUS_RANKED = new System.Windows.Forms.CheckBox();
            this.STATUS_LOVED = new System.Windows.Forms.CheckBox();
            this.STATUS_EXCLUDEAPPROVED = new System.Windows.Forms.CheckBox();
            this.PREVIEW_LABEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MANIA_1K = new System.Windows.Forms.CheckBox();
            this.MANIA_10K = new System.Windows.Forms.CheckBox();
            this.MANIA_9K = new System.Windows.Forms.CheckBox();
            this.MANIA_8K = new System.Windows.Forms.CheckBox();
            this.MANIA_7K = new System.Windows.Forms.CheckBox();
            this.MANIA_6K = new System.Windows.Forms.CheckBox();
            this.MANIA_5K = new System.Windows.Forms.CheckBox();
            this.MANIA_4K = new System.Windows.Forms.CheckBox();
            this.MANIA_3K = new System.Windows.Forms.CheckBox();
            this.MANIA_2K = new System.Windows.Forms.CheckBox();
            this.COPY_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19F);
            this.label1.Location = new System.Drawing.Point(633, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preview";
            // 
            // KEY_COMBOBOX
            // 
            this.KEY_COMBOBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KEY_COMBOBOX.Font = new System.Drawing.Font("Quicksand Light", 16F);
            this.KEY_COMBOBOX.FormattingEnabled = true;
            this.KEY_COMBOBOX.Items.AddRange(new object[] {
            "Status",
            "AR",
            "CS",
            "OD",
            "HP",
            "Length",
            "Stars",
            "Keys",
            "BPM",
            "Drain",
            "Played",
            "UnPlayed",
            "Speed",
            "Artist",
            "Creator"});
            this.KEY_COMBOBOX.Location = new System.Drawing.Point(33, 294);
            this.KEY_COMBOBOX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.KEY_COMBOBOX.Name = "KEY_COMBOBOX";
            this.KEY_COMBOBOX.Size = new System.Drawing.Size(180, 39);
            this.KEY_COMBOBOX.TabIndex = 2;
            this.KEY_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.KEY_COMBOBOX_SelectedIndexChanged);
            // 
            // OPERATION_COMBOBOX
            // 
            this.OPERATION_COMBOBOX.AutoCompleteCustomSource.AddRange(new string[] {
            "==",
            "!=",
            "<",
            ">",
            "<=",
            ">="});
            this.OPERATION_COMBOBOX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OPERATION_COMBOBOX.Font = new System.Drawing.Font("Quicksand Light", 16F);
            this.OPERATION_COMBOBOX.FormattingEnabled = true;
            this.OPERATION_COMBOBOX.Items.AddRange(new object[] {
            "=",
            "≠",
            "<",
            ">",
            "<=",
            ">="});
            this.OPERATION_COMBOBOX.Location = new System.Drawing.Point(246, 294);
            this.OPERATION_COMBOBOX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OPERATION_COMBOBOX.Name = "OPERATION_COMBOBOX";
            this.OPERATION_COMBOBOX.Size = new System.Drawing.Size(55, 39);
            this.OPERATION_COMBOBOX.TabIndex = 3;
            // 
            // ADD_BUTTON
            // 
            this.ADD_BUTTON.Location = new System.Drawing.Point(33, 345);
            this.ADD_BUTTON.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ADD_BUTTON.Name = "ADD_BUTTON";
            this.ADD_BUTTON.Size = new System.Drawing.Size(112, 46);
            this.ADD_BUTTON.TabIndex = 6;
            this.ADD_BUTTON.Text = "Add";
            this.ADD_BUTTON.UseVisualStyleBackColor = true;
            this.ADD_BUTTON.Click += new System.EventHandler(this.ADD_BUTTON_Click);
            // 
            // MODE_OSU
            // 
            this.MODE_OSU.AutoSize = true;
            this.MODE_OSU.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODE_OSU.Location = new System.Drawing.Point(149, 36);
            this.MODE_OSU.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MODE_OSU.Name = "MODE_OSU";
            this.MODE_OSU.Size = new System.Drawing.Size(71, 35);
            this.MODE_OSU.TabIndex = 12;
            this.MODE_OSU.Text = "osu!";
            this.MODE_OSU.UseVisualStyleBackColor = true;
            // 
            // MODE_TAIKO
            // 
            this.MODE_TAIKO.AutoSize = true;
            this.MODE_TAIKO.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODE_TAIKO.Location = new System.Drawing.Point(149, 83);
            this.MODE_TAIKO.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MODE_TAIKO.Name = "MODE_TAIKO";
            this.MODE_TAIKO.Size = new System.Drawing.Size(119, 35);
            this.MODE_TAIKO.TabIndex = 13;
            this.MODE_TAIKO.Text = "osu!taiko";
            this.MODE_TAIKO.UseVisualStyleBackColor = true;
            // 
            // MODE_CATCH
            // 
            this.MODE_CATCH.AutoSize = true;
            this.MODE_CATCH.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODE_CATCH.Location = new System.Drawing.Point(149, 130);
            this.MODE_CATCH.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MODE_CATCH.Name = "MODE_CATCH";
            this.MODE_CATCH.Size = new System.Drawing.Size(125, 35);
            this.MODE_CATCH.TabIndex = 14;
            this.MODE_CATCH.Text = "osu!catch";
            this.MODE_CATCH.UseVisualStyleBackColor = true;
            // 
            // MODE_MANIA
            // 
            this.MODE_MANIA.AutoSize = true;
            this.MODE_MANIA.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MODE_MANIA.Location = new System.Drawing.Point(149, 177);
            this.MODE_MANIA.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MODE_MANIA.Name = "MODE_MANIA";
            this.MODE_MANIA.Size = new System.Drawing.Size(132, 35);
            this.MODE_MANIA.TabIndex = 15;
            this.MODE_MANIA.Text = "osu!mania";
            this.MODE_MANIA.UseVisualStyleBackColor = true;
            // 
            // VALUE_TEXTBOX
            // 
            this.VALUE_TEXTBOX.Font = new System.Drawing.Font("Quicksand Light", 16F);
            this.VALUE_TEXTBOX.Location = new System.Drawing.Point(341, 299);
            this.VALUE_TEXTBOX.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VALUE_TEXTBOX.Name = "VALUE_TEXTBOX";
            this.VALUE_TEXTBOX.Size = new System.Drawing.Size(206, 34);
            this.VALUE_TEXTBOX.TabIndex = 16;
            // 
            // STATUS_NOTSUBMITTED
            // 
            this.STATUS_NOTSUBMITTED.AutoSize = true;
            this.STATUS_NOTSUBMITTED.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_NOTSUBMITTED.Location = new System.Drawing.Point(246, 482);
            this.STATUS_NOTSUBMITTED.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_NOTSUBMITTED.Name = "STATUS_NOTSUBMITTED";
            this.STATUS_NOTSUBMITTED.Size = new System.Drawing.Size(173, 35);
            this.STATUS_NOTSUBMITTED.TabIndex = 20;
            this.STATUS_NOTSUBMITTED.Text = "Not Submitted";
            this.STATUS_NOTSUBMITTED.UseVisualStyleBackColor = true;
            this.STATUS_NOTSUBMITTED.Visible = false;
            // 
            // STATUS_PENDING
            // 
            this.STATUS_PENDING.AutoSize = true;
            this.STATUS_PENDING.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_PENDING.Location = new System.Drawing.Point(246, 435);
            this.STATUS_PENDING.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_PENDING.Name = "STATUS_PENDING";
            this.STATUS_PENDING.Size = new System.Drawing.Size(111, 35);
            this.STATUS_PENDING.TabIndex = 19;
            this.STATUS_PENDING.Text = "Pending";
            this.STATUS_PENDING.UseVisualStyleBackColor = true;
            this.STATUS_PENDING.Visible = false;
            // 
            // STATUS_APPROVED
            // 
            this.STATUS_APPROVED.AutoSize = true;
            this.STATUS_APPROVED.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_APPROVED.Location = new System.Drawing.Point(246, 388);
            this.STATUS_APPROVED.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_APPROVED.Name = "STATUS_APPROVED";
            this.STATUS_APPROVED.Size = new System.Drawing.Size(130, 35);
            this.STATUS_APPROVED.TabIndex = 18;
            this.STATUS_APPROVED.Text = "Approved";
            this.STATUS_APPROVED.UseVisualStyleBackColor = true;
            this.STATUS_APPROVED.Visible = false;
            this.STATUS_APPROVED.CheckedChanged += new System.EventHandler(this.STATUS_APPROVED_CheckedChanged);
            // 
            // STATUS_RANKED
            // 
            this.STATUS_RANKED.AutoSize = true;
            this.STATUS_RANKED.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_RANKED.Location = new System.Drawing.Point(246, 294);
            this.STATUS_RANKED.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_RANKED.Name = "STATUS_RANKED";
            this.STATUS_RANKED.Size = new System.Drawing.Size(108, 35);
            this.STATUS_RANKED.TabIndex = 17;
            this.STATUS_RANKED.Text = "Ranked";
            this.STATUS_RANKED.UseVisualStyleBackColor = true;
            this.STATUS_RANKED.Visible = false;
            this.STATUS_RANKED.CheckedChanged += new System.EventHandler(this.STATUS_RANKED_CheckedChanged);
            // 
            // STATUS_LOVED
            // 
            this.STATUS_LOVED.AutoSize = true;
            this.STATUS_LOVED.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_LOVED.Location = new System.Drawing.Point(246, 341);
            this.STATUS_LOVED.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_LOVED.Name = "STATUS_LOVED";
            this.STATUS_LOVED.Size = new System.Drawing.Size(93, 35);
            this.STATUS_LOVED.TabIndex = 22;
            this.STATUS_LOVED.Text = "Loved";
            this.STATUS_LOVED.UseVisualStyleBackColor = true;
            this.STATUS_LOVED.Visible = false;
            // 
            // STATUS_EXCLUDEAPPROVED
            // 
            this.STATUS_EXCLUDEAPPROVED.AutoSize = true;
            this.STATUS_EXCLUDEAPPROVED.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STATUS_EXCLUDEAPPROVED.Location = new System.Drawing.Point(378, 294);
            this.STATUS_EXCLUDEAPPROVED.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.STATUS_EXCLUDEAPPROVED.Name = "STATUS_EXCLUDEAPPROVED";
            this.STATUS_EXCLUDEAPPROVED.Size = new System.Drawing.Size(211, 35);
            this.STATUS_EXCLUDEAPPROVED.TabIndex = 23;
            this.STATUS_EXCLUDEAPPROVED.Text = "Exclude Approved";
            this.STATUS_EXCLUDEAPPROVED.UseVisualStyleBackColor = true;
            this.STATUS_EXCLUDEAPPROVED.Visible = false;
            this.STATUS_EXCLUDEAPPROVED.CheckedChanged += new System.EventHandler(this.STATUS_EXCLUDEAPPROVED_CheckedChanged);
            // 
            // PREVIEW_LABEL
            // 
            this.PREVIEW_LABEL.AutoSize = true;
            this.PREVIEW_LABEL.Font = new System.Drawing.Font("Quicksand Light", 16F);
            this.PREVIEW_LABEL.Location = new System.Drawing.Point(632, 80);
            this.PREVIEW_LABEL.Name = "PREVIEW_LABEL";
            this.PREVIEW_LABEL.Size = new System.Drawing.Size(95, 33);
            this.PREVIEW_LABEL.TabIndex = 24;
            this.PREVIEW_LABEL.Text = "Preview!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand Light", 19F);
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mode";
            // 
            // MANIA_1K
            // 
            this.MANIA_1K.AutoSize = true;
            this.MANIA_1K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_1K.Location = new System.Drawing.Point(246, 294);
            this.MANIA_1K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_1K.Name = "MANIA_1K";
            this.MANIA_1K.Size = new System.Drawing.Size(55, 35);
            this.MANIA_1K.TabIndex = 26;
            this.MANIA_1K.Text = "1K";
            this.MANIA_1K.UseVisualStyleBackColor = true;
            this.MANIA_1K.Visible = false;
            // 
            // MANIA_10K
            // 
            this.MANIA_10K.AutoSize = true;
            this.MANIA_10K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_10K.Location = new System.Drawing.Point(378, 482);
            this.MANIA_10K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_10K.Name = "MANIA_10K";
            this.MANIA_10K.Size = new System.Drawing.Size(67, 35);
            this.MANIA_10K.TabIndex = 29;
            this.MANIA_10K.Text = "10K";
            this.MANIA_10K.UseVisualStyleBackColor = true;
            this.MANIA_10K.Visible = false;
            // 
            // MANIA_9K
            // 
            this.MANIA_9K.AutoSize = true;
            this.MANIA_9K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_9K.Location = new System.Drawing.Point(378, 435);
            this.MANIA_9K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_9K.Name = "MANIA_9K";
            this.MANIA_9K.Size = new System.Drawing.Size(59, 35);
            this.MANIA_9K.TabIndex = 30;
            this.MANIA_9K.Text = "9K";
            this.MANIA_9K.UseVisualStyleBackColor = true;
            this.MANIA_9K.Visible = false;
            // 
            // MANIA_8K
            // 
            this.MANIA_8K.AutoSize = true;
            this.MANIA_8K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_8K.Location = new System.Drawing.Point(378, 388);
            this.MANIA_8K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_8K.Name = "MANIA_8K";
            this.MANIA_8K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_8K.TabIndex = 31;
            this.MANIA_8K.Text = "8K";
            this.MANIA_8K.UseVisualStyleBackColor = true;
            this.MANIA_8K.Visible = false;
            // 
            // MANIA_7K
            // 
            this.MANIA_7K.AutoSize = true;
            this.MANIA_7K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_7K.Location = new System.Drawing.Point(378, 341);
            this.MANIA_7K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_7K.Name = "MANIA_7K";
            this.MANIA_7K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_7K.TabIndex = 32;
            this.MANIA_7K.Text = "7K";
            this.MANIA_7K.UseVisualStyleBackColor = true;
            this.MANIA_7K.Visible = false;
            // 
            // MANIA_6K
            // 
            this.MANIA_6K.AutoSize = true;
            this.MANIA_6K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_6K.Location = new System.Drawing.Point(378, 296);
            this.MANIA_6K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_6K.Name = "MANIA_6K";
            this.MANIA_6K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_6K.TabIndex = 33;
            this.MANIA_6K.Text = "6K";
            this.MANIA_6K.UseVisualStyleBackColor = true;
            this.MANIA_6K.Visible = false;
            // 
            // MANIA_5K
            // 
            this.MANIA_5K.AutoSize = true;
            this.MANIA_5K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_5K.Location = new System.Drawing.Point(246, 482);
            this.MANIA_5K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_5K.Name = "MANIA_5K";
            this.MANIA_5K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_5K.TabIndex = 34;
            this.MANIA_5K.Text = "5K";
            this.MANIA_5K.UseVisualStyleBackColor = true;
            this.MANIA_5K.Visible = false;
            // 
            // MANIA_4K
            // 
            this.MANIA_4K.AutoSize = true;
            this.MANIA_4K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_4K.Location = new System.Drawing.Point(246, 435);
            this.MANIA_4K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_4K.Name = "MANIA_4K";
            this.MANIA_4K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_4K.TabIndex = 35;
            this.MANIA_4K.Text = "4K";
            this.MANIA_4K.UseVisualStyleBackColor = true;
            this.MANIA_4K.Visible = false;
            // 
            // MANIA_3K
            // 
            this.MANIA_3K.AutoSize = true;
            this.MANIA_3K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_3K.Location = new System.Drawing.Point(246, 388);
            this.MANIA_3K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_3K.Name = "MANIA_3K";
            this.MANIA_3K.Size = new System.Drawing.Size(58, 35);
            this.MANIA_3K.TabIndex = 36;
            this.MANIA_3K.Text = "3K";
            this.MANIA_3K.UseVisualStyleBackColor = true;
            this.MANIA_3K.Visible = false;
            // 
            // MANIA_2K
            // 
            this.MANIA_2K.AutoSize = true;
            this.MANIA_2K.Font = new System.Drawing.Font("Quicksand Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANIA_2K.Location = new System.Drawing.Point(246, 341);
            this.MANIA_2K.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MANIA_2K.Name = "MANIA_2K";
            this.MANIA_2K.Size = new System.Drawing.Size(59, 35);
            this.MANIA_2K.TabIndex = 37;
            this.MANIA_2K.Text = "2K";
            this.MANIA_2K.UseVisualStyleBackColor = true;
            this.MANIA_2K.Visible = false;
            // 
            // COPY_BUTTON
            // 
            this.COPY_BUTTON.Location = new System.Drawing.Point(33, 419);
            this.COPY_BUTTON.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.COPY_BUTTON.Name = "COPY_BUTTON";
            this.COPY_BUTTON.Size = new System.Drawing.Size(112, 46);
            this.COPY_BUTTON.TabIndex = 38;
            this.COPY_BUTTON.Text = "Copy";
            this.COPY_BUTTON.UseVisualStyleBackColor = true;
            this.COPY_BUTTON.Click += new System.EventHandler(this.COPY_BUTTON_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1080, 754);
            this.Controls.Add(this.COPY_BUTTON);
            this.Controls.Add(this.MANIA_2K);
            this.Controls.Add(this.MANIA_3K);
            this.Controls.Add(this.MANIA_4K);
            this.Controls.Add(this.MANIA_5K);
            this.Controls.Add(this.MANIA_6K);
            this.Controls.Add(this.MANIA_7K);
            this.Controls.Add(this.MANIA_8K);
            this.Controls.Add(this.MANIA_9K);
            this.Controls.Add(this.MANIA_10K);
            this.Controls.Add(this.MANIA_1K);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PREVIEW_LABEL);
            this.Controls.Add(this.STATUS_EXCLUDEAPPROVED);
            this.Controls.Add(this.STATUS_LOVED);
            this.Controls.Add(this.STATUS_NOTSUBMITTED);
            this.Controls.Add(this.STATUS_PENDING);
            this.Controls.Add(this.STATUS_APPROVED);
            this.Controls.Add(this.STATUS_RANKED);
            this.Controls.Add(this.VALUE_TEXTBOX);
            this.Controls.Add(this.MODE_MANIA);
            this.Controls.Add(this.MODE_CATCH);
            this.Controls.Add(this.MODE_TAIKO);
            this.Controls.Add(this.MODE_OSU);
            this.Controls.Add(this.ADD_BUTTON);
            this.Controls.Add(this.OPERATION_COMBOBOX);
            this.Controls.Add(this.KEY_COMBOBOX);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Quicksand Light", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Main";
            this.Text = "osu! Map Search Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox KEY_COMBOBOX;
        private System.Windows.Forms.ComboBox OPERATION_COMBOBOX;
        private System.Windows.Forms.Button ADD_BUTTON;
        private System.Windows.Forms.CheckBox MODE_OSU;
        private System.Windows.Forms.CheckBox MODE_TAIKO;
        private System.Windows.Forms.CheckBox MODE_CATCH;
        private System.Windows.Forms.CheckBox MODE_MANIA;
        private System.Windows.Forms.TextBox VALUE_TEXTBOX;
        private System.Windows.Forms.CheckBox STATUS_NOTSUBMITTED;
        private System.Windows.Forms.CheckBox STATUS_PENDING;
        private System.Windows.Forms.CheckBox STATUS_APPROVED;
        private System.Windows.Forms.CheckBox STATUS_RANKED;
        private System.Windows.Forms.CheckBox STATUS_LOVED;
        private System.Windows.Forms.CheckBox STATUS_EXCLUDEAPPROVED;
        private System.Windows.Forms.Label PREVIEW_LABEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox MANIA_1K;
        private System.Windows.Forms.CheckBox MANIA_10K;
        private System.Windows.Forms.CheckBox MANIA_9K;
        private System.Windows.Forms.CheckBox MANIA_8K;
        private System.Windows.Forms.CheckBox MANIA_7K;
        private System.Windows.Forms.CheckBox MANIA_6K;
        private System.Windows.Forms.CheckBox MANIA_5K;
        private System.Windows.Forms.CheckBox MANIA_4K;
        private System.Windows.Forms.CheckBox MANIA_3K;
        private System.Windows.Forms.CheckBox MANIA_2K;
        private System.Windows.Forms.Button COPY_BUTTON;
    }
}

