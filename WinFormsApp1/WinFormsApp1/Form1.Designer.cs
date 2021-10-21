
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.XmlTree = new System.Windows.Forms.TreeView();
            this.delete = new System.Windows.Forms.Button();
            this.dif = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.TextBox();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.marklabel = new System.Windows.Forms.Label();
            this.addQuestion = new System.Windows.Forms.Button();
            this.updateQuestion = new System.Windows.Forms.Button();
            this.getData = new System.Windows.Forms.Button();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.isRight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addAnswer = new System.Windows.Forms.Button();
            this.updateAnswer = new System.Windows.Forms.Button();
            this.numAnswer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // XmlTree
            // 
            this.XmlTree.Location = new System.Drawing.Point(23, 12);
            this.XmlTree.Name = "XmlTree";
            this.XmlTree.Size = new System.Drawing.Size(394, 309);
            this.XmlTree.TabIndex = 0;
            this.XmlTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.XmlTree_AfterSelect);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(323, 363);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(94, 29);
            this.delete.TabIndex = 2;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // dif
            // 
            this.dif.Location = new System.Drawing.Point(457, 12);
            this.dif.Name = "dif";
            this.dif.Size = new System.Drawing.Size(125, 27);
            this.dif.TabIndex = 4;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(457, 106);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(125, 27);
            this.type.TabIndex = 5;
            // 
            // mark
            // 
            this.mark.Location = new System.Drawing.Point(457, 154);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(125, 27);
            this.mark.TabIndex = 6;
            // 
            // textQuestion
            // 
            this.textQuestion.Location = new System.Drawing.Point(457, 202);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(125, 27);
            this.textQuestion.TabIndex = 7;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(457, 58);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(125, 27);
            this.time.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сложность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тип вопроса";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(591, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Текст";
            // 
            // marklabel
            // 
            this.marklabel.AutoSize = true;
            this.marklabel.Location = new System.Drawing.Point(592, 157);
            this.marklabel.Name = "marklabel";
            this.marklabel.Size = new System.Drawing.Size(144, 20);
            this.marklabel.TabIndex = 15;
            this.marklabel.Text = "Количество баллов";
            // 
            // addQuestion
            // 
            this.addQuestion.Location = new System.Drawing.Point(457, 245);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(159, 29);
            this.addQuestion.TabIndex = 18;
            this.addQuestion.Text = "Добавить вопрос";
            this.addQuestion.UseVisualStyleBackColor = true;
            this.addQuestion.Click += new System.EventHandler(this.addQuestion_Click);
            // 
            // updateQuestion
            // 
            this.updateQuestion.Location = new System.Drawing.Point(457, 292);
            this.updateQuestion.Name = "updateQuestion";
            this.updateQuestion.Size = new System.Drawing.Size(159, 29);
            this.updateQuestion.TabIndex = 19;
            this.updateQuestion.Text = "Изменить вопрос";
            this.updateQuestion.UseVisualStyleBackColor = true;
            this.updateQuestion.Click += new System.EventHandler(this.updateQuestion_Click);
            // 
            // getData
            // 
            this.getData.Location = new System.Drawing.Point(23, 363);
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(155, 29);
            this.getData.TabIndex = 20;
            this.getData.Text = "Получить данные";
            this.getData.UseVisualStyleBackColor = true;
            this.getData.Click += new System.EventHandler(this.getData_Click);
            // 
            // textAnswer
            // 
            this.textAnswer.Location = new System.Drawing.Point(766, 12);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(125, 27);
            this.textAnswer.TabIndex = 21;
            // 
            // isRight
            // 
            this.isRight.Location = new System.Drawing.Point(766, 58);
            this.isRight.Name = "isRight";
            this.isRight.Size = new System.Drawing.Size(125, 27);
            this.isRight.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(916, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Текст";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(916, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Достоверность";
            // 
            // addAnswer
            // 
            this.addAnswer.Location = new System.Drawing.Point(766, 157);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(159, 29);
            this.addAnswer.TabIndex = 25;
            this.addAnswer.Text = "Добавить ответ";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // updateAnswer
            // 
            this.updateAnswer.Location = new System.Drawing.Point(766, 205);
            this.updateAnswer.Name = "updateAnswer";
            this.updateAnswer.Size = new System.Drawing.Size(159, 29);
            this.updateAnswer.TabIndex = 26;
            this.updateAnswer.Text = "Изменить ответ";
            this.updateAnswer.UseVisualStyleBackColor = true;
            this.updateAnswer.Click += new System.EventHandler(this.updateAnswer_Click);
            // 
            // numAnswer
            // 
            this.numAnswer.Location = new System.Drawing.Point(766, 106);
            this.numAnswer.Name = "numAnswer";
            this.numAnswer.Size = new System.Drawing.Size(125, 27);
            this.numAnswer.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(916, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер вопроса";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 472);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numAnswer);
            this.Controls.Add(this.updateAnswer);
            this.Controls.Add(this.addAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.isRight);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.getData);
            this.Controls.Add(this.updateQuestion);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.marklabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dif);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.XmlTree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView XmlTree;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox dif;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label marklabel;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Button updateQuestion;
        private System.Windows.Forms.Button getData;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.TextBox isRight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Button updateAnswer;
        private System.Windows.Forms.TextBox numAnswer;
        private System.Windows.Forms.Label label7;
    }
}

