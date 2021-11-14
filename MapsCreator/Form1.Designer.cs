namespace MapsCreator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFilter = new System.Windows.Forms.ListBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbNonFilter = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNonFilter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPoint1 = new System.Windows.Forms.TextBox();
            this.tbPoint2 = new System.Windows.Forms.TextBox();
            this.cb_novoltage = new System.Windows.Forms.CheckBox();
            this.cb_04 = new System.Windows.Forms.CheckBox();
            this.cb_6 = new System.Windows.Forms.CheckBox();
            this.cb_10 = new System.Windows.Forms.CheckBox();
            this.cb_35 = new System.Windows.Forms.CheckBox();
            this.cb_110 = new System.Windows.Forms.CheckBox();
            this.cb_220 = new System.Windows.Forms.CheckBox();
            this.cb_500 = new System.Windows.Forms.CheckBox();
            this.cb_substation = new System.Windows.Forms.CheckBox();
            this.cb_filterByVoltage = new System.Windows.Forms.CheckBox();
            this.cb_filterByName = new System.Windows.Forms.CheckBox();
            this.cb_filterByCoordinates = new System.Windows.Forms.CheckBox();
            this.cb_filterByType = new System.Windows.Forms.CheckBox();
            this.gb_filterByName = new System.Windows.Forms.GroupBox();
            this.gb_filterByVoltage = new System.Windows.Forms.GroupBox();
            this.gb_filterByCoordinates = new System.Windows.Forms.GroupBox();
            this.gb_filterByType = new System.Windows.Forms.GroupBox();
            this.cb_typeLineString = new System.Windows.Forms.CheckBox();
            this.cb_typePoint = new System.Windows.Forms.CheckBox();
            this.cb_typePolygon = new System.Windows.Forms.CheckBox();
            this.lbl_selectedNodes = new System.Windows.Forms.Label();
            this.gb_filterByName.SuspendLayout();
            this.gb_filterByVoltage.SuspendLayout();
            this.gb_filterByCoordinates.SuspendLayout();
            this.gb_filterByType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilter
            // 
            this.lbFilter.FormattingEnabled = true;
            this.lbFilter.ItemHeight = 16;
            this.lbFilter.Location = new System.Drawing.Point(6, 20);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(254, 372);
            this.lbFilter.TabIndex = 0;
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(6, 415);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(254, 22);
            this.tbFilter.TabIndex = 1;
            this.tbFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFilter_KeyDown);
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(547, 340);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(404, 40);
            this.btnBegin.TabIndex = 2;
            this.btnBegin.Text = "Начать";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(9, 524);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 17);
            this.lblPath.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(547, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // lbl_progress
            // 
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(548, 405);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(73, 17);
            this.lbl_progress.TabIndex = 5;
            this.lbl_progress.Text = "Прогресс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Извлечь узлы, которые содержат";
            // 
            // lbNonFilter
            // 
            this.lbNonFilter.FormattingEnabled = true;
            this.lbNonFilter.ItemHeight = 16;
            this.lbNonFilter.Location = new System.Drawing.Point(266, 20);
            this.lbNonFilter.Name = "lbNonFilter";
            this.lbNonFilter.Size = new System.Drawing.Size(254, 372);
            this.lbNonFilter.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Не извлекать узлы, которые содержат";
            // 
            // tbNonFilter
            // 
            this.tbNonFilter.Location = new System.Drawing.Point(266, 415);
            this.tbNonFilter.Name = "tbNonFilter";
            this.tbNonFilter.Size = new System.Drawing.Size(254, 22);
            this.tbNonFilter.TabIndex = 1;
            this.tbNonFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNonFilter_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Точка 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Точка 2:";
            // 
            // tbPoint1
            // 
            this.tbPoint1.Location = new System.Drawing.Point(85, 26);
            this.tbPoint1.Name = "tbPoint1";
            this.tbPoint1.Size = new System.Drawing.Size(261, 22);
            this.tbPoint1.TabIndex = 1;
            this.tbPoint1.Text = "42.927366 132.271664";
            this.tbPoint1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNonFilter_KeyDown);
            // 
            // tbPoint2
            // 
            this.tbPoint2.Location = new System.Drawing.Point(85, 54);
            this.tbPoint2.Name = "tbPoint2";
            this.tbPoint2.Size = new System.Drawing.Size(261, 22);
            this.tbPoint2.TabIndex = 1;
            this.tbPoint2.Text = "42.836978 132.383931";
            this.tbPoint2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNonFilter_KeyDown);
            // 
            // cb_novoltage
            // 
            this.cb_novoltage.AutoSize = true;
            this.cb_novoltage.Location = new System.Drawing.Point(6, 21);
            this.cb_novoltage.Name = "cb_novoltage";
            this.cb_novoltage.Size = new System.Drawing.Size(100, 21);
            this.cb_novoltage.TabIndex = 7;
            this.cb_novoltage.Text = "no_voltage";
            this.cb_novoltage.UseVisualStyleBackColor = true;
            // 
            // cb_04
            // 
            this.cb_04.AutoSize = true;
            this.cb_04.Location = new System.Drawing.Point(6, 48);
            this.cb_04.Name = "cb_04";
            this.cb_04.Size = new System.Drawing.Size(68, 21);
            this.cb_04.TabIndex = 7;
            this.cb_04.Text = "0_4kv";
            this.cb_04.UseVisualStyleBackColor = true;
            // 
            // cb_6
            // 
            this.cb_6.AutoSize = true;
            this.cb_6.Location = new System.Drawing.Point(6, 75);
            this.cb_6.Name = "cb_6";
            this.cb_6.Size = new System.Drawing.Size(52, 21);
            this.cb_6.TabIndex = 7;
            this.cb_6.Text = "6kv";
            this.cb_6.UseVisualStyleBackColor = true;
            // 
            // cb_10
            // 
            this.cb_10.AutoSize = true;
            this.cb_10.Location = new System.Drawing.Point(142, 21);
            this.cb_10.Name = "cb_10";
            this.cb_10.Size = new System.Drawing.Size(60, 21);
            this.cb_10.TabIndex = 7;
            this.cb_10.Text = "10kv";
            this.cb_10.UseVisualStyleBackColor = true;
            // 
            // cb_35
            // 
            this.cb_35.AutoSize = true;
            this.cb_35.Location = new System.Drawing.Point(142, 48);
            this.cb_35.Name = "cb_35";
            this.cb_35.Size = new System.Drawing.Size(60, 21);
            this.cb_35.TabIndex = 7;
            this.cb_35.Text = "35kv";
            this.cb_35.UseVisualStyleBackColor = true;
            // 
            // cb_110
            // 
            this.cb_110.AutoSize = true;
            this.cb_110.Location = new System.Drawing.Point(142, 75);
            this.cb_110.Name = "cb_110";
            this.cb_110.Size = new System.Drawing.Size(68, 21);
            this.cb_110.TabIndex = 7;
            this.cb_110.Text = "110kv";
            this.cb_110.UseVisualStyleBackColor = true;
            // 
            // cb_220
            // 
            this.cb_220.AutoSize = true;
            this.cb_220.Location = new System.Drawing.Point(278, 21);
            this.cb_220.Name = "cb_220";
            this.cb_220.Size = new System.Drawing.Size(68, 21);
            this.cb_220.TabIndex = 7;
            this.cb_220.Text = "220kv";
            this.cb_220.UseVisualStyleBackColor = true;
            // 
            // cb_500
            // 
            this.cb_500.AutoSize = true;
            this.cb_500.Location = new System.Drawing.Point(278, 48);
            this.cb_500.Name = "cb_500";
            this.cb_500.Size = new System.Drawing.Size(68, 21);
            this.cb_500.TabIndex = 7;
            this.cb_500.Text = "500kv";
            this.cb_500.UseVisualStyleBackColor = true;
            // 
            // cb_substation
            // 
            this.cb_substation.AutoSize = true;
            this.cb_substation.Location = new System.Drawing.Point(278, 75);
            this.cb_substation.Name = "cb_substation";
            this.cb_substation.Size = new System.Drawing.Size(103, 21);
            this.cb_substation.TabIndex = 7;
            this.cb_substation.Text = "sub_station";
            this.cb_substation.UseVisualStyleBackColor = true;
            // 
            // cb_filterByVoltage
            // 
            this.cb_filterByVoltage.AutoSize = true;
            this.cb_filterByVoltage.Location = new System.Drawing.Point(9, 12);
            this.cb_filterByVoltage.Name = "cb_filterByVoltage";
            this.cb_filterByVoltage.Size = new System.Drawing.Size(186, 21);
            this.cb_filterByVoltage.TabIndex = 8;
            this.cb_filterByVoltage.Text = "фильтр по напряжению";
            this.cb_filterByVoltage.UseVisualStyleBackColor = true;
            this.cb_filterByVoltage.CheckedChanged += new System.EventHandler(this.cb_filterByVoltage_CheckedChanged);
            // 
            // cb_filterByName
            // 
            this.cb_filterByName.AutoSize = true;
            this.cb_filterByName.Location = new System.Drawing.Point(275, 12);
            this.cb_filterByName.Name = "cb_filterByName";
            this.cb_filterByName.Size = new System.Drawing.Size(167, 21);
            this.cb_filterByName.TabIndex = 8;
            this.cb_filterByName.Text = "фильтр по названию";
            this.cb_filterByName.UseVisualStyleBackColor = true;
            this.cb_filterByName.CheckedChanged += new System.EventHandler(this.cb_filterByName_CheckedChanged);
            // 
            // cb_filterByCoordinates
            // 
            this.cb_filterByCoordinates.AutoSize = true;
            this.cb_filterByCoordinates.Location = new System.Drawing.Point(505, 12);
            this.cb_filterByCoordinates.Name = "cb_filterByCoordinates";
            this.cb_filterByCoordinates.Size = new System.Drawing.Size(190, 21);
            this.cb_filterByCoordinates.TabIndex = 8;
            this.cb_filterByCoordinates.Text = "фильтр по координатам";
            this.cb_filterByCoordinates.UseVisualStyleBackColor = true;
            this.cb_filterByCoordinates.CheckedChanged += new System.EventHandler(this.cb_filterByCoordinates_CheckedChanged);
            // 
            // cb_filterByType
            // 
            this.cb_filterByType.AutoSize = true;
            this.cb_filterByType.Location = new System.Drawing.Point(748, 12);
            this.cb_filterByType.Name = "cb_filterByType";
            this.cb_filterByType.Size = new System.Drawing.Size(133, 21);
            this.cb_filterByType.TabIndex = 8;
            this.cb_filterByType.Text = "фильтр по типу";
            this.cb_filterByType.UseVisualStyleBackColor = true;
            this.cb_filterByType.CheckedChanged += new System.EventHandler(this.cb_filterByType_CheckedChanged);
            // 
            // gb_filterByName
            // 
            this.gb_filterByName.Controls.Add(this.lbFilter);
            this.gb_filterByName.Controls.Add(this.lbNonFilter);
            this.gb_filterByName.Controls.Add(this.label4);
            this.gb_filterByName.Controls.Add(this.label5);
            this.gb_filterByName.Controls.Add(this.tbFilter);
            this.gb_filterByName.Controls.Add(this.tbNonFilter);
            this.gb_filterByName.Location = new System.Drawing.Point(9, 39);
            this.gb_filterByName.Name = "gb_filterByName";
            this.gb_filterByName.Size = new System.Drawing.Size(532, 444);
            this.gb_filterByName.TabIndex = 9;
            this.gb_filterByName.TabStop = false;
            this.gb_filterByName.Text = "Фильтр по наименованию";
            // 
            // gb_filterByVoltage
            // 
            this.gb_filterByVoltage.Controls.Add(this.cb_novoltage);
            this.gb_filterByVoltage.Controls.Add(this.cb_04);
            this.gb_filterByVoltage.Controls.Add(this.cb_6);
            this.gb_filterByVoltage.Controls.Add(this.cb_10);
            this.gb_filterByVoltage.Controls.Add(this.cb_35);
            this.gb_filterByVoltage.Controls.Add(this.cb_110);
            this.gb_filterByVoltage.Controls.Add(this.cb_substation);
            this.gb_filterByVoltage.Controls.Add(this.cb_220);
            this.gb_filterByVoltage.Controls.Add(this.cb_500);
            this.gb_filterByVoltage.Location = new System.Drawing.Point(547, 39);
            this.gb_filterByVoltage.Name = "gb_filterByVoltage";
            this.gb_filterByVoltage.Size = new System.Drawing.Size(401, 114);
            this.gb_filterByVoltage.TabIndex = 10;
            this.gb_filterByVoltage.TabStop = false;
            this.gb_filterByVoltage.Text = "Фильтр по напряжению";
            // 
            // gb_filterByCoordinates
            // 
            this.gb_filterByCoordinates.Controls.Add(this.label6);
            this.gb_filterByCoordinates.Controls.Add(this.tbPoint1);
            this.gb_filterByCoordinates.Controls.Add(this.label7);
            this.gb_filterByCoordinates.Controls.Add(this.tbPoint2);
            this.gb_filterByCoordinates.Location = new System.Drawing.Point(547, 159);
            this.gb_filterByCoordinates.Name = "gb_filterByCoordinates";
            this.gb_filterByCoordinates.Size = new System.Drawing.Size(401, 92);
            this.gb_filterByCoordinates.TabIndex = 11;
            this.gb_filterByCoordinates.TabStop = false;
            this.gb_filterByCoordinates.Text = "Фильтр по координатам";
            // 
            // gb_filterByType
            // 
            this.gb_filterByType.Controls.Add(this.cb_typeLineString);
            this.gb_filterByType.Controls.Add(this.cb_typePoint);
            this.gb_filterByType.Controls.Add(this.cb_typePolygon);
            this.gb_filterByType.Location = new System.Drawing.Point(547, 257);
            this.gb_filterByType.Name = "gb_filterByType";
            this.gb_filterByType.Size = new System.Drawing.Size(401, 77);
            this.gb_filterByType.TabIndex = 12;
            this.gb_filterByType.TabStop = false;
            this.gb_filterByType.Text = "Фильтр по типу";
            // 
            // cb_typeLineString
            // 
            this.cb_typeLineString.AutoSize = true;
            this.cb_typeLineString.Location = new System.Drawing.Point(252, 32);
            this.cb_typeLineString.Name = "cb_typeLineString";
            this.cb_typeLineString.Size = new System.Drawing.Size(94, 21);
            this.cb_typeLineString.TabIndex = 8;
            this.cb_typeLineString.Text = "LineString";
            this.cb_typeLineString.UseVisualStyleBackColor = true;
            // 
            // cb_typePoint
            // 
            this.cb_typePoint.AutoSize = true;
            this.cb_typePoint.Location = new System.Drawing.Point(13, 32);
            this.cb_typePoint.Name = "cb_typePoint";
            this.cb_typePoint.Size = new System.Drawing.Size(62, 21);
            this.cb_typePoint.TabIndex = 8;
            this.cb_typePoint.Text = "Point";
            this.cb_typePoint.UseVisualStyleBackColor = true;
            // 
            // cb_typePolygon
            // 
            this.cb_typePolygon.AutoSize = true;
            this.cb_typePolygon.Location = new System.Drawing.Point(121, 32);
            this.cb_typePolygon.Name = "cb_typePolygon";
            this.cb_typePolygon.Size = new System.Drawing.Size(81, 21);
            this.cb_typePolygon.TabIndex = 8;
            this.cb_typePolygon.Text = "Polygon";
            this.cb_typePolygon.UseVisualStyleBackColor = true;
            // 
            // lbl_selectedNodes
            // 
            this.lbl_selectedNodes.AutoSize = true;
            this.lbl_selectedNodes.Location = new System.Drawing.Point(548, 434);
            this.lbl_selectedNodes.Name = "lbl_selectedNodes";
            this.lbl_selectedNodes.Size = new System.Drawing.Size(120, 17);
            this.lbl_selectedNodes.TabIndex = 5;
            this.lbl_selectedNodes.Text = "Выделено узлов:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 494);
            this.Controls.Add(this.gb_filterByType);
            this.Controls.Add(this.gb_filterByCoordinates);
            this.Controls.Add(this.cb_filterByCoordinates);
            this.Controls.Add(this.gb_filterByVoltage);
            this.Controls.Add(this.gb_filterByName);
            this.Controls.Add(this.cb_filterByType);
            this.Controls.Add(this.cb_filterByName);
            this.Controls.Add(this.cb_filterByVoltage);
            this.Controls.Add(this.lbl_selectedNodes);
            this.Controls.Add(this.lbl_progress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBegin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapsCreator";
            this.gb_filterByName.ResumeLayout(false);
            this.gb_filterByName.PerformLayout();
            this.gb_filterByVoltage.ResumeLayout(false);
            this.gb_filterByVoltage.PerformLayout();
            this.gb_filterByCoordinates.ResumeLayout(false);
            this.gb_filterByCoordinates.PerformLayout();
            this.gb_filterByType.ResumeLayout(false);
            this.gb_filterByType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbFilter;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_progress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbNonFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNonFilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPoint1;
        private System.Windows.Forms.TextBox tbPoint2;
        private System.Windows.Forms.CheckBox cb_novoltage;
        private System.Windows.Forms.CheckBox cb_04;
        private System.Windows.Forms.CheckBox cb_6;
        private System.Windows.Forms.CheckBox cb_10;
        private System.Windows.Forms.CheckBox cb_35;
        private System.Windows.Forms.CheckBox cb_110;
        private System.Windows.Forms.CheckBox cb_220;
        private System.Windows.Forms.CheckBox cb_500;
        private System.Windows.Forms.CheckBox cb_substation;
        private System.Windows.Forms.CheckBox cb_filterByVoltage;
        private System.Windows.Forms.CheckBox cb_filterByName;
        private System.Windows.Forms.CheckBox cb_filterByCoordinates;
        private System.Windows.Forms.CheckBox cb_filterByType;
        private System.Windows.Forms.GroupBox gb_filterByName;
        private System.Windows.Forms.GroupBox gb_filterByVoltage;
        private System.Windows.Forms.GroupBox gb_filterByCoordinates;
        private System.Windows.Forms.GroupBox gb_filterByType;
        private System.Windows.Forms.CheckBox cb_typeLineString;
        private System.Windows.Forms.CheckBox cb_typePolygon;
        private System.Windows.Forms.CheckBox cb_typePoint;
        private System.Windows.Forms.Label lbl_selectedNodes;
    }
}

