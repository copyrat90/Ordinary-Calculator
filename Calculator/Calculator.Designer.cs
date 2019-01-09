namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DotButton = new System.Windows.Forms.Button();
            this.MulButton = new System.Windows.Forms.Button();
            this.SubButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EqlButton = new System.Windows.Forms.Button();
            this.DivButton = new System.Windows.Forms.Button();
            this.DelButton = new System.Windows.Forms.Button();
            this.ClrButton = new System.Windows.Forms.Button();
            this.NegButton = new System.Windows.Forms.Button();
            this.SqrtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(12, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(86, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(160, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(12, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(86, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(68, 62);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(160, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(68, 62);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(12, 162);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 62);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button8.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(86, 162);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(68, 62);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button9.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Location = new System.Drawing.Point(160, 162);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(68, 62);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button0.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button0.Location = new System.Drawing.Point(86, 366);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 62);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.NumButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ResultLabel.Font = new System.Drawing.Font("맑은 고딕", 28F, System.Drawing.FontStyle.Bold);
            this.ResultLabel.Location = new System.Drawing.Point(13, 13);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(289, 72);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "0";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DotButton
            // 
            this.DotButton.BackColor = System.Drawing.Color.Silver;
            this.DotButton.CausesValidation = false;
            this.DotButton.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.DotButton.Location = new System.Drawing.Point(160, 366);
            this.DotButton.Name = "DotButton";
            this.DotButton.Size = new System.Drawing.Size(68, 62);
            this.DotButton.TabIndex = 11;
            this.DotButton.Text = ".";
            this.DotButton.UseVisualStyleBackColor = false;
            this.DotButton.Click += new System.EventHandler(this.DotButton_Click);
            // 
            // MulButton
            // 
            this.MulButton.BackColor = System.Drawing.Color.Silver;
            this.MulButton.CausesValidation = false;
            this.MulButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.MulButton.Location = new System.Drawing.Point(234, 162);
            this.MulButton.Name = "MulButton";
            this.MulButton.Size = new System.Drawing.Size(68, 62);
            this.MulButton.TabIndex = 12;
            this.MulButton.Text = "×";
            this.MulButton.UseVisualStyleBackColor = false;
            this.MulButton.Click += new System.EventHandler(this.Op4Button_Click);
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.Color.Silver;
            this.SubButton.CausesValidation = false;
            this.SubButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.SubButton.Location = new System.Drawing.Point(234, 230);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(68, 62);
            this.SubButton.TabIndex = 13;
            this.SubButton.Text = "-";
            this.SubButton.UseVisualStyleBackColor = false;
            this.SubButton.Click += new System.EventHandler(this.Op4Button_Click);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Silver;
            this.AddButton.CausesValidation = false;
            this.AddButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.AddButton.Location = new System.Drawing.Point(234, 298);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(68, 62);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "+";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.Op4Button_Click);
            // 
            // EqlButton
            // 
            this.EqlButton.BackColor = System.Drawing.Color.Silver;
            this.EqlButton.CausesValidation = false;
            this.EqlButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.EqlButton.Location = new System.Drawing.Point(234, 366);
            this.EqlButton.Name = "EqlButton";
            this.EqlButton.Size = new System.Drawing.Size(68, 62);
            this.EqlButton.TabIndex = 15;
            this.EqlButton.Text = "=";
            this.EqlButton.UseVisualStyleBackColor = false;
            this.EqlButton.Click += new System.EventHandler(this.Op4Button_Click);
            // 
            // DivButton
            // 
            this.DivButton.BackColor = System.Drawing.Color.Silver;
            this.DivButton.CausesValidation = false;
            this.DivButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.DivButton.Location = new System.Drawing.Point(234, 94);
            this.DivButton.Name = "DivButton";
            this.DivButton.Size = new System.Drawing.Size(68, 62);
            this.DivButton.TabIndex = 16;
            this.DivButton.Text = "÷";
            this.DivButton.UseVisualStyleBackColor = false;
            this.DivButton.Click += new System.EventHandler(this.Op4Button_Click);
            // 
            // DelButton
            // 
            this.DelButton.BackColor = System.Drawing.Color.Silver;
            this.DelButton.CausesValidation = false;
            this.DelButton.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.DelButton.Location = new System.Drawing.Point(160, 94);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(68, 62);
            this.DelButton.TabIndex = 17;
            this.DelButton.Text = "⌫";
            this.DelButton.UseVisualStyleBackColor = false;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ClrButton
            // 
            this.ClrButton.BackColor = System.Drawing.Color.Silver;
            this.ClrButton.CausesValidation = false;
            this.ClrButton.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.ClrButton.Location = new System.Drawing.Point(86, 94);
            this.ClrButton.Name = "ClrButton";
            this.ClrButton.Size = new System.Drawing.Size(68, 62);
            this.ClrButton.TabIndex = 18;
            this.ClrButton.Text = "C";
            this.ClrButton.UseVisualStyleBackColor = false;
            this.ClrButton.Click += new System.EventHandler(this.ClrButton_Click);
            // 
            // NegButton
            // 
            this.NegButton.BackColor = System.Drawing.Color.Silver;
            this.NegButton.CausesValidation = false;
            this.NegButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.NegButton.Location = new System.Drawing.Point(13, 366);
            this.NegButton.Name = "NegButton";
            this.NegButton.Size = new System.Drawing.Size(68, 62);
            this.NegButton.TabIndex = 19;
            this.NegButton.Text = "±";
            this.NegButton.UseVisualStyleBackColor = false;
            this.NegButton.Click += new System.EventHandler(this.NegButton_Click);
            // 
            // SqrtButton
            // 
            this.SqrtButton.BackColor = System.Drawing.Color.Silver;
            this.SqrtButton.CausesValidation = false;
            this.SqrtButton.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.SqrtButton.Location = new System.Drawing.Point(12, 94);
            this.SqrtButton.Name = "SqrtButton";
            this.SqrtButton.Size = new System.Drawing.Size(68, 62);
            this.SqrtButton.TabIndex = 20;
            this.SqrtButton.Text = "√";
            this.SqrtButton.UseVisualStyleBackColor = false;
            this.SqrtButton.Click += new System.EventHandler(this.SqrtButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 439);
            this.Controls.Add(this.SqrtButton);
            this.Controls.Add(this.NegButton);
            this.Controls.Add(this.ClrButton);
            this.Controls.Add(this.DelButton);
            this.Controls.Add(this.DivButton);
            this.Controls.Add(this.EqlButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SubButton);
            this.Controls.Add(this.MulButton);
            this.Controls.Add(this.DotButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button DotButton;
        private System.Windows.Forms.Button SubButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EqlButton;
        private System.Windows.Forms.Button DivButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Button ClrButton;
        private System.Windows.Forms.Button NegButton;
        private System.Windows.Forms.Button SqrtButton;
        private System.Windows.Forms.Button MulButton;
    }
}

