namespace _CS262__GuessNumber2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.createAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showAnswerButton = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.AutoSearchButton1 = new System.Windows.Forms.Button();
            this._1stResult = new System.Windows.Forms.Label();
            this.tryNumber1label = new System.Windows.Forms.Label();
            this.AutoSearchButton2 = new System.Windows.Forms.Button();
            this.tryNumber2Label = new System.Windows.Forms.Label();
            this._2ndResult = new System.Windows.Forms.Label();
            this.inputAnswer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerTryButton = new System.Windows.Forms.Button();
            this.inputAnswer2 = new System.Windows.Forms.TextBox();
            this.inputAnswer3 = new System.Windows.Forms.TextBox();
            this.inputAnswer4 = new System.Windows.Forms.TextBox();
            this.identifyLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.describeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createAnswer
            // 
            this.createAnswer.Location = new System.Drawing.Point(12, 34);
            this.createAnswer.Name = "createAnswer";
            this.createAnswer.Size = new System.Drawing.Size(138, 43);
            this.createAnswer.TabIndex = 1;
            this.createAnswer.Text = "隨機生成隱藏答案";
            this.createAnswer.UseVisualStyleBackColor = true;
            this.createAnswer.Click += new System.EventHandler(this.createAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(165, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "題目未產生";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // showAnswerButton
            // 
            this.showAnswerButton.Location = new System.Drawing.Point(314, 45);
            this.showAnswerButton.Name = "showAnswerButton";
            this.showAnswerButton.Size = new System.Drawing.Size(75, 23);
            this.showAnswerButton.TabIndex = 3;
            this.showAnswerButton.Text = "顯示答案";
            this.showAnswerButton.UseVisualStyleBackColor = true;
            this.showAnswerButton.Click += new System.EventHandler(this.showAnswerButton_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(395, 50);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(65, 12);
            this.answerLabel.TabIndex = 4;
            this.answerLabel.Text = "答案隱藏中";
            // 
            // AutoSearchButton1
            // 
            this.AutoSearchButton1.Location = new System.Drawing.Point(13, 143);
            this.AutoSearchButton1.Name = "AutoSearchButton1";
            this.AutoSearchButton1.Size = new System.Drawing.Size(75, 23);
            this.AutoSearchButton1.TabIndex = 7;
            this.AutoSearchButton1.Text = "第一次解答";
            this.AutoSearchButton1.UseVisualStyleBackColor = true;
            this.AutoSearchButton1.Click += new System.EventHandler(this.AutoSearchButton_Click);
            // 
            // _1stResult
            // 
            this._1stResult.AutoSize = true;
            this._1stResult.Location = new System.Drawing.Point(129, 148);
            this._1stResult.Name = "_1stResult";
            this._1stResult.Size = new System.Drawing.Size(33, 12);
            this._1stResult.TabIndex = 10;
            this._1stResult.Text = "0A0B";
            // 
            // tryNumber1label
            // 
            this.tryNumber1label.AutoSize = true;
            this.tryNumber1label.Location = new System.Drawing.Point(94, 148);
            this.tryNumber1label.Name = "tryNumber1label";
            this.tryNumber1label.Size = new System.Drawing.Size(29, 12);
            this.tryNumber1label.TabIndex = 11;
            this.tryNumber1label.Text = "0000";
            // 
            // AutoSearchButton2
            // 
            this.AutoSearchButton2.Location = new System.Drawing.Point(12, 172);
            this.AutoSearchButton2.Name = "AutoSearchButton2";
            this.AutoSearchButton2.Size = new System.Drawing.Size(75, 23);
            this.AutoSearchButton2.TabIndex = 12;
            this.AutoSearchButton2.Text = "第二次解答";
            this.AutoSearchButton2.UseVisualStyleBackColor = true;
            this.AutoSearchButton2.Click += new System.EventHandler(this.AutoSearchButton2_Click);
            // 
            // tryNumber2Label
            // 
            this.tryNumber2Label.AutoSize = true;
            this.tryNumber2Label.Location = new System.Drawing.Point(93, 177);
            this.tryNumber2Label.Name = "tryNumber2Label";
            this.tryNumber2Label.Size = new System.Drawing.Size(29, 12);
            this.tryNumber2Label.TabIndex = 13;
            this.tryNumber2Label.Text = "0000";
            // 
            // _2ndResult
            // 
            this._2ndResult.AutoSize = true;
            this._2ndResult.Location = new System.Drawing.Point(128, 177);
            this._2ndResult.Name = "_2ndResult";
            this._2ndResult.Size = new System.Drawing.Size(33, 12);
            this._2ndResult.TabIndex = 14;
            this._2ndResult.Text = "0A0B";
            // 
            // inputAnswer1
            // 
            this.inputAnswer1.Location = new System.Drawing.Point(301, 148);
            this.inputAnswer1.Name = "inputAnswer1";
            this.inputAnswer1.Size = new System.Drawing.Size(24, 22);
            this.inputAnswer1.TabIndex = 15;
            this.inputAnswer1.Text = "1";
            this.inputAnswer1.TextChanged += new System.EventHandler(this.inputAnswer1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "電腦自我解答";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 26;
            this.label5.Text = "玩家輸入挑戰";
            // 
            // playerTryButton
            // 
            this.playerTryButton.Location = new System.Drawing.Point(301, 186);
            this.playerTryButton.Name = "playerTryButton";
            this.playerTryButton.Size = new System.Drawing.Size(75, 23);
            this.playerTryButton.TabIndex = 27;
            this.playerTryButton.Text = "顯示結果";
            this.playerTryButton.UseVisualStyleBackColor = true;
            this.playerTryButton.Click += new System.EventHandler(this.playerTryButton_Click);
            // 
            // inputAnswer2
            // 
            this.inputAnswer2.Location = new System.Drawing.Point(331, 148);
            this.inputAnswer2.Name = "inputAnswer2";
            this.inputAnswer2.Size = new System.Drawing.Size(24, 22);
            this.inputAnswer2.TabIndex = 28;
            this.inputAnswer2.Text = "2";
            // 
            // inputAnswer3
            // 
            this.inputAnswer3.Location = new System.Drawing.Point(361, 148);
            this.inputAnswer3.Name = "inputAnswer3";
            this.inputAnswer3.Size = new System.Drawing.Size(24, 22);
            this.inputAnswer3.TabIndex = 29;
            this.inputAnswer3.Text = "3";
            // 
            // inputAnswer4
            // 
            this.inputAnswer4.Location = new System.Drawing.Point(391, 148);
            this.inputAnswer4.Name = "inputAnswer4";
            this.inputAnswer4.Size = new System.Drawing.Size(24, 22);
            this.inputAnswer4.TabIndex = 30;
            this.inputAnswer4.Text = "4";
            // 
            // identifyLabel
            // 
            this.identifyLabel.AutoSize = true;
            this.identifyLabel.Location = new System.Drawing.Point(400, 191);
            this.identifyLabel.Name = "identifyLabel";
            this.identifyLabel.Size = new System.Drawing.Size(0, 12);
            this.identifyLabel.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 32;
            this.label2.Text = "label2";
            // 
            // describeLabel
            // 
            this.describeLabel.AutoSize = true;
            this.describeLabel.Location = new System.Drawing.Point(241, 228);
            this.describeLabel.Name = "describeLabel";
            this.describeLabel.Size = new System.Drawing.Size(53, 12);
            this.describeLabel.TabIndex = 33;
            this.describeLabel.Text = "玩家流程";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.describeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.identifyLabel);
            this.Controls.Add(this.inputAnswer4);
            this.Controls.Add(this.inputAnswer3);
            this.Controls.Add(this.inputAnswer2);
            this.Controls.Add(this.playerTryButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputAnswer1);
            this.Controls.Add(this._2ndResult);
            this.Controls.Add(this.tryNumber2Label);
            this.Controls.Add(this.AutoSearchButton2);
            this.Controls.Add(this.tryNumber1label);
            this.Controls.Add(this._1stResult);
            this.Controls.Add(this.AutoSearchButton1);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.showAnswerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAnswerButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Button AutoSearchButton1;
        private System.Windows.Forms.Label _1stResult;
        private System.Windows.Forms.Label tryNumber1label;
        private System.Windows.Forms.Button AutoSearchButton2;
        private System.Windows.Forms.Label tryNumber2Label;
        private System.Windows.Forms.Label _2ndResult;
        private System.Windows.Forms.TextBox inputAnswer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button playerTryButton;
        private System.Windows.Forms.TextBox inputAnswer2;
        private System.Windows.Forms.TextBox inputAnswer3;
        private System.Windows.Forms.TextBox inputAnswer4;
        private System.Windows.Forms.Label identifyLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label describeLabel;
    }
}

