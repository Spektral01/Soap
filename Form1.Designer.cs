namespace Parser
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
            this.CheckedListBoxEge = new System.Windows.Forms.CheckedListBox();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ListBoxPars = new System.Windows.Forms.ListBox();
            this.GroupBoxFilterEge4 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFilterCity5 = new System.Windows.Forms.GroupBox();
            this.ComboBoxCity = new System.Windows.Forms.ComboBox();
            this.GroupBoxFilterProg6 = new System.Windows.Forms.GroupBox();
            this.RadioButtonBudget6 = new System.Windows.Forms.RadioButton();
            this.RadioButtonPay7 = new System.Windows.Forms.RadioButton();
            this.RadioButtonOchno3 = new System.Windows.Forms.RadioButton();
            this.RadioButtonZaochno4 = new System.Windows.Forms.RadioButton();
            this.RadioButtonDist5 = new System.Windows.Forms.RadioButton();
            this.GroupBoxFilterProg3 = new System.Windows.Forms.GroupBox();
            this.LabelProgress = new System.Windows.Forms.Label();
            this.RadioButtonVUZ1 = new System.Windows.Forms.RadioButton();
            this.GroupBoxSearch1 = new System.Windows.Forms.GroupBox();
            this.CheckBoxDorm_3 = new System.Windows.Forms.CheckBox();
            this.CheckBoxArmy_2 = new System.Windows.Forms.CheckBox();
            this.GroupBoxFilterVUZ2 = new System.Windows.Forms.GroupBox();
            this.GroupBoxFilterEge4.SuspendLayout();
            this.GroupBoxFilterCity5.SuspendLayout();
            this.GroupBoxFilterProg6.SuspendLayout();
            this.GroupBoxFilterProg3.SuspendLayout();
            this.GroupBoxSearch1.SuspendLayout();
            this.GroupBoxFilterVUZ2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckedListBoxEge
            // 
            this.CheckedListBoxEge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedListBoxEge.FormattingEnabled = true;
            this.CheckedListBoxEge.Items.AddRange(new object[] {
            "Русский язык",
            "Математика",
            "Обществознание",
            "Физика",
            "История",
            "Иностранный язык",
            "Информатика",
            "Биология",
            "Литература",
            "Химия",
            "География"});
            this.CheckedListBoxEge.Location = new System.Drawing.Point(11, 34);
            this.CheckedListBoxEge.Name = "CheckedListBoxEge";
            this.CheckedListBoxEge.Size = new System.Drawing.Size(154, 123);
            this.CheckedListBoxEge.TabIndex = 4;
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearList.Location = new System.Drawing.Point(1161, 595);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(115, 30);
            this.ButtonClearList.TabIndex = 9;
            this.ButtonClearList.Text = "Очистить лист";
            this.ButtonClearList.UseVisualStyleBackColor = true;
            this.ButtonClearList.Visible = false;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(1179, 559);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(76, 30);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Пуск";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Visible = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ListBoxPars
            // 
            this.ListBoxPars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxPars.FormattingEnabled = true;
            this.ListBoxPars.ItemHeight = 16;
            this.ListBoxPars.Location = new System.Drawing.Point(12, 12);
            this.ListBoxPars.Name = "ListBoxPars";
            this.ListBoxPars.Size = new System.Drawing.Size(1100, 644);
            this.ListBoxPars.TabIndex = 0;
            this.ListBoxPars.DoubleClick += new System.EventHandler(this.ListBoxPars_DoubleClick);
            // 
            // GroupBoxFilterEge4
            // 
            this.GroupBoxFilterEge4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterEge4.Controls.Add(this.CheckedListBoxEge);
            this.GroupBoxFilterEge4.Location = new System.Drawing.Point(1139, 116);
            this.GroupBoxFilterEge4.Name = "GroupBoxFilterEge4";
            this.GroupBoxFilterEge4.Size = new System.Drawing.Size(190, 161);
            this.GroupBoxFilterEge4.TabIndex = 22;
            this.GroupBoxFilterEge4.TabStop = false;
            this.GroupBoxFilterEge4.Text = "Предметы ЕГЭ";
            this.GroupBoxFilterEge4.Visible = false;
            // 
            // GroupBoxFilterCity5
            // 
            this.GroupBoxFilterCity5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterCity5.Controls.Add(this.ComboBoxCity);
            this.GroupBoxFilterCity5.Location = new System.Drawing.Point(1139, 51);
            this.GroupBoxFilterCity5.Name = "GroupBoxFilterCity5";
            this.GroupBoxFilterCity5.Size = new System.Drawing.Size(190, 59);
            this.GroupBoxFilterCity5.TabIndex = 23;
            this.GroupBoxFilterCity5.TabStop = false;
            this.GroupBoxFilterCity5.Text = "Город";
            this.GroupBoxFilterCity5.Visible = false;
            // 
            // ComboBoxCity
            // 
            this.ComboBoxCity.FormattingEnabled = true;
            this.ComboBoxCity.Items.AddRange(new object[] {
            "Все города",
            "Москва",
            "Санкт-Петербург",
            "Екатеринбург",
            "Казань",
            "Новосибирск",
            "Томск",
            "Самара",
            "Ростов",
            "Воронеж",
            "Краснодар",
            "Красноярск"});
            this.ComboBoxCity.Location = new System.Drawing.Point(22, 24);
            this.ComboBoxCity.Name = "ComboBoxCity";
            this.ComboBoxCity.Size = new System.Drawing.Size(143, 24);
            this.ComboBoxCity.TabIndex = 0;
            this.ComboBoxCity.Text = "-";
            // 
            // GroupBoxFilterProg6
            // 
            this.GroupBoxFilterProg6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterProg6.Controls.Add(this.RadioButtonPay7);
            this.GroupBoxFilterProg6.Controls.Add(this.RadioButtonBudget6);
            this.GroupBoxFilterProg6.Location = new System.Drawing.Point(0, 104);
            this.GroupBoxFilterProg6.Name = "GroupBoxFilterProg6";
            this.GroupBoxFilterProg6.Size = new System.Drawing.Size(190, 66);
            this.GroupBoxFilterProg6.TabIndex = 22;
            this.GroupBoxFilterProg6.TabStop = false;
            this.GroupBoxFilterProg6.Text = "Оплата";
            // 
            // RadioButtonBudget6
            // 
            this.RadioButtonBudget6.AutoSize = true;
            this.RadioButtonBudget6.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonBudget6.Name = "RadioButtonBudget6";
            this.RadioButtonBudget6.Size = new System.Drawing.Size(80, 21);
            this.RadioButtonBudget6.TabIndex = 26;
            this.RadioButtonBudget6.TabStop = true;
            this.RadioButtonBudget6.Text = "Бюджет";
            this.RadioButtonBudget6.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPay7
            // 
            this.RadioButtonPay7.AutoSize = true;
            this.RadioButtonPay7.Location = new System.Drawing.Point(11, 42);
            this.RadioButtonPay7.Name = "RadioButtonPay7";
            this.RadioButtonPay7.Size = new System.Drawing.Size(78, 21);
            this.RadioButtonPay7.TabIndex = 27;
            this.RadioButtonPay7.TabStop = true;
            this.RadioButtonPay7.Text = "Платно";
            this.RadioButtonPay7.UseVisualStyleBackColor = true;
            // 
            // RadioButtonOchno3
            // 
            this.RadioButtonOchno3.AutoSize = true;
            this.RadioButtonOchno3.Location = new System.Drawing.Point(11, 19);
            this.RadioButtonOchno3.Name = "RadioButtonOchno3";
            this.RadioButtonOchno3.Size = new System.Drawing.Size(64, 21);
            this.RadioButtonOchno3.TabIndex = 23;
            this.RadioButtonOchno3.TabStop = true;
            this.RadioButtonOchno3.Text = "Очно";
            this.RadioButtonOchno3.UseVisualStyleBackColor = true;
            // 
            // RadioButtonZaochno4
            // 
            this.RadioButtonZaochno4.AutoSize = true;
            this.RadioButtonZaochno4.Location = new System.Drawing.Point(11, 42);
            this.RadioButtonZaochno4.Name = "RadioButtonZaochno4";
            this.RadioButtonZaochno4.Size = new System.Drawing.Size(78, 21);
            this.RadioButtonZaochno4.TabIndex = 24;
            this.RadioButtonZaochno4.TabStop = true;
            this.RadioButtonZaochno4.Text = "Заочно";
            this.RadioButtonZaochno4.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDist5
            // 
            this.RadioButtonDist5.AutoSize = true;
            this.RadioButtonDist5.Location = new System.Drawing.Point(11, 65);
            this.RadioButtonDist5.Name = "RadioButtonDist5";
            this.RadioButtonDist5.Size = new System.Drawing.Size(126, 21);
            this.RadioButtonDist5.TabIndex = 25;
            this.RadioButtonDist5.TabStop = true;
            this.RadioButtonDist5.Text = "Дистанционно";
            this.RadioButtonDist5.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFilterProg3
            // 
            this.GroupBoxFilterProg3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonDist5);
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonZaochno4);
            this.GroupBoxFilterProg3.Controls.Add(this.RadioButtonOchno3);
            this.GroupBoxFilterProg3.Controls.Add(this.GroupBoxFilterProg6);
            this.GroupBoxFilterProg3.Location = new System.Drawing.Point(1127, 283);
            this.GroupBoxFilterProg3.Name = "GroupBoxFilterProg3";
            this.GroupBoxFilterProg3.Size = new System.Drawing.Size(190, 168);
            this.GroupBoxFilterProg3.TabIndex = 21;
            this.GroupBoxFilterProg3.TabStop = false;
            this.GroupBoxFilterProg3.Text = "Форма обучения";
            this.GroupBoxFilterProg3.Visible = false;
            // 
            // LabelProgress
            // 
            this.LabelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelProgress.AutoSize = true;
            this.LabelProgress.Location = new System.Drawing.Point(1158, 639);
            this.LabelProgress.Name = "LabelProgress";
            this.LabelProgress.Size = new System.Drawing.Size(0, 17);
            this.LabelProgress.TabIndex = 24;
            this.LabelProgress.Click += new System.EventHandler(this.LabelProgress_Click);
            // 
            // RadioButtonVUZ1
            // 
            this.RadioButtonVUZ1.AutoSize = true;
            this.RadioButtonVUZ1.Location = new System.Drawing.Point(6, 9);
            this.RadioButtonVUZ1.Name = "RadioButtonVUZ1";
            this.RadioButtonVUZ1.Size = new System.Drawing.Size(111, 21);
            this.RadioButtonVUZ1.TabIndex = 13;
            this.RadioButtonVUZ1.TabStop = true;
            this.RadioButtonVUZ1.Text = "Выбор ВУЗа";
            this.RadioButtonVUZ1.UseVisualStyleBackColor = true;
            this.RadioButtonVUZ1.CheckedChanged += new System.EventHandler(this.RadioButtonVUZ1_CheckedChanged);
            // 
            // GroupBoxSearch1
            // 
            this.GroupBoxSearch1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxSearch1.Controls.Add(this.RadioButtonVUZ1);
            this.GroupBoxSearch1.Location = new System.Drawing.Point(1139, 12);
            this.GroupBoxSearch1.Name = "GroupBoxSearch1";
            this.GroupBoxSearch1.Size = new System.Drawing.Size(190, 33);
            this.GroupBoxSearch1.TabIndex = 15;
            this.GroupBoxSearch1.TabStop = false;
            // 
            // CheckBoxDorm_3
            // 
            this.CheckBoxDorm_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxDorm_3.AutoSize = true;
            this.CheckBoxDorm_3.Location = new System.Drawing.Point(6, 48);
            this.CheckBoxDorm_3.Name = "CheckBoxDorm_3";
            this.CheckBoxDorm_3.Size = new System.Drawing.Size(108, 21);
            this.CheckBoxDorm_3.TabIndex = 8;
            this.CheckBoxDorm_3.Text = "Общежитие";
            this.CheckBoxDorm_3.UseVisualStyleBackColor = true;
            // 
            // CheckBoxArmy_2
            // 
            this.CheckBoxArmy_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxArmy_2.AutoSize = true;
            this.CheckBoxArmy_2.Location = new System.Drawing.Point(-6, 21);
            this.CheckBoxArmy_2.Name = "CheckBoxArmy_2";
            this.CheckBoxArmy_2.Size = new System.Drawing.Size(149, 21);
            this.CheckBoxArmy_2.TabIndex = 7;
            this.CheckBoxArmy_2.Text = "Военная кафедра";
            this.CheckBoxArmy_2.UseVisualStyleBackColor = true;
            // 
            // GroupBoxFilterVUZ2
            // 
            this.GroupBoxFilterVUZ2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBoxFilterVUZ2.CausesValidation = false;
            this.GroupBoxFilterVUZ2.Controls.Add(this.CheckBoxArmy_2);
            this.GroupBoxFilterVUZ2.Controls.Add(this.CheckBoxDorm_3);
            this.GroupBoxFilterVUZ2.Location = new System.Drawing.Point(1121, 455);
            this.GroupBoxFilterVUZ2.Name = "GroupBoxFilterVUZ2";
            this.GroupBoxFilterVUZ2.Size = new System.Drawing.Size(228, 87);
            this.GroupBoxFilterVUZ2.TabIndex = 20;
            this.GroupBoxFilterVUZ2.TabStop = false;
            this.GroupBoxFilterVUZ2.Visible = false;
            this.GroupBoxFilterVUZ2.Enter += new System.EventHandler(this.GroupBoxFilterVUZ2_Enter);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1350, 685);
            this.Controls.Add(this.GroupBoxFilterVUZ2);
            this.Controls.Add(this.GroupBoxFilterProg3);
            this.Controls.Add(this.LabelProgress);
            this.Controls.Add(this.GroupBoxFilterCity5);
            this.Controls.Add(this.GroupBoxFilterEge4);
            this.Controls.Add(this.GroupBoxSearch1);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonClearList);
            this.Controls.Add(this.ListBoxPars);
            this.Name = "Form1";
            this.Text = "Помощник в выборе вуза и специальности";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxFilterEge4.ResumeLayout(false);
            this.GroupBoxFilterCity5.ResumeLayout(false);
            this.GroupBoxFilterProg6.ResumeLayout(false);
            this.GroupBoxFilterProg6.PerformLayout();
            this.GroupBoxFilterProg3.ResumeLayout(false);
            this.GroupBoxFilterProg3.PerformLayout();
            this.GroupBoxSearch1.ResumeLayout(false);
            this.GroupBoxSearch1.PerformLayout();
            this.GroupBoxFilterVUZ2.ResumeLayout(false);
            this.GroupBoxFilterVUZ2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox CheckedListBoxEge;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ListBox ListBoxPars;
        private System.Windows.Forms.GroupBox GroupBoxFilterEge4;
        private System.Windows.Forms.GroupBox GroupBoxFilterCity5;
        private System.Windows.Forms.ComboBox ComboBoxCity;
        private System.Windows.Forms.GroupBox GroupBoxFilterProg6;
        private System.Windows.Forms.RadioButton RadioButtonPay7;
        private System.Windows.Forms.RadioButton RadioButtonBudget6;
        private System.Windows.Forms.RadioButton RadioButtonOchno3;
        private System.Windows.Forms.RadioButton RadioButtonZaochno4;
        private System.Windows.Forms.RadioButton RadioButtonDist5;
        private System.Windows.Forms.GroupBox GroupBoxFilterProg3;
        private System.Windows.Forms.Label LabelProgress;
        private System.Windows.Forms.RadioButton RadioButtonVUZ1;
        private System.Windows.Forms.GroupBox GroupBoxSearch1;
        private System.Windows.Forms.CheckBox CheckBoxDorm_3;
        private System.Windows.Forms.CheckBox CheckBoxArmy_2;
        private System.Windows.Forms.GroupBox GroupBoxFilterVUZ2;
    }
}
