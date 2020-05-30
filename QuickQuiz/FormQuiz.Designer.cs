namespace QuickQuiz
{
    partial class FormQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuiz));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label_question = new System.Windows.Forms.Label();
            this.radio_answer0 = new System.Windows.Forms.RadioButton();
            this.radio_answer1 = new System.Windows.Forms.RadioButton();
            this.radio_answer2 = new System.Windows.Forms.RadioButton();
            this.button_next = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label_message, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_question, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radio_answer0, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_next, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.57747F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.08451F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 422);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label_question
            // 
            this.label_question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_question.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_question.Location = new System.Drawing.Point(3, 0);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(638, 59);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "label1";
            this.label_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radio_answer0
            // 
            this.radio_answer0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer0.Location = new System.Drawing.Point(3, 62);
            this.radio_answer0.Name = "radio_answer0";
            this.radio_answer0.Size = new System.Drawing.Size(638, 53);
            this.radio_answer0.TabIndex = 1;
            this.radio_answer0.TabStop = true;
            this.radio_answer0.Text = "radioButton1";
            this.radio_answer0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer0.UseVisualStyleBackColor = true;
            // 
            // radio_answer1
            // 
            this.radio_answer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer1.Location = new System.Drawing.Point(3, 121);
            this.radio_answer1.Name = "radio_answer1";
            this.radio_answer1.Size = new System.Drawing.Size(638, 53);
            this.radio_answer1.TabIndex = 2;
            this.radio_answer1.TabStop = true;
            this.radio_answer1.Text = "radioButton1";
            this.radio_answer1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer1.UseVisualStyleBackColor = true;
            // 
            // radio_answer2
            // 
            this.radio_answer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_answer2.Location = new System.Drawing.Point(3, 180);
            this.radio_answer2.Name = "radio_answer2";
            this.radio_answer2.Size = new System.Drawing.Size(638, 53);
            this.radio_answer2.TabIndex = 3;
            this.radio_answer2.TabStop = true;
            this.radio_answer2.Text = "radioButton1";
            this.radio_answer2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_answer2.UseVisualStyleBackColor = true;
            // 
            // button_next
            // 
            this.button_next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_next.Location = new System.Drawing.Point(20, 256);
            this.button_next.Margin = new System.Windows.Forms.Padding(20);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(604, 84);
            this.button_next.TabIndex = 4;
            this.button_next.Text = "Следующий вопрос >>";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // label_message
            // 
            this.label_message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_message.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_message.Location = new System.Drawing.Point(3, 360);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(638, 62);
            this.label_message.TabIndex = 5;
            this.label_message.Text = "label1";
            this.label_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 422);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Простая программа для тестов";
            this.Shown += new System.EventHandler(this.FormQuiz_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.RadioButton radio_answer0;
        private System.Windows.Forms.RadioButton radio_answer2;
        private System.Windows.Forms.RadioButton radio_answer1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_message;
    }
}

