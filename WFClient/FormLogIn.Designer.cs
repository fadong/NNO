namespace WFClient {
    partial class FormLogIn {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.docTab = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tabColor = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabFiscal = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOption = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.colorDiag = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.docTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password :";
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.docTab);
            this.c1Sizer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer1.GridDefinition = "33.0917874396135:False:False;54.3478260869565:False:False;12.0772946859903:False:" +
    "False;\t100:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Padding = new System.Windows.Forms.Padding(0);
            this.c1Sizer1.Size = new System.Drawing.Size(438, 414);
            this.c1Sizer1.SplitterWidth = 1;
            this.c1Sizer1.TabIndex = 5;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // docTab
            // 
            this.docTab.Controls.Add(this.tabGeneral);
            this.docTab.Controls.Add(this.tabColor);
            this.docTab.Controls.Add(this.tabFiscal);
            this.docTab.Location = new System.Drawing.Point(0, 138);
            this.docTab.Margin = new System.Windows.Forms.Padding(0);
            this.docTab.Name = "docTab";
            this.docTab.Padding = new System.Drawing.Point(0, 0);
            this.docTab.SelectedIndex = 0;
            this.docTab.Size = new System.Drawing.Size(438, 225);
            this.docTab.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(430, 199);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tabColor
            // 
            this.tabColor.Location = new System.Drawing.Point(4, 22);
            this.tabColor.Name = "tabColor";
            this.tabColor.Padding = new System.Windows.Forms.Padding(3);
            this.tabColor.Size = new System.Drawing.Size(430, 199);
            this.tabColor.TabIndex = 1;
            this.tabColor.Text = "Color";
            this.tabColor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 137);
            this.panel1.TabIndex = 1;
            // 
            // tabFiscal
            // 
            this.tabFiscal.Location = new System.Drawing.Point(4, 22);
            this.tabFiscal.Name = "tabFiscal";
            this.tabFiscal.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiscal.Size = new System.Drawing.Size(430, 199);
            this.tabFiscal.TabIndex = 2;
            this.tabFiscal.Text = "Fiscal Date";
            this.tabFiscal.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.btnOption);
            this.panel2.Location = new System.Drawing.Point(0, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 50);
            this.panel2.TabIndex = 2;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(12, 15);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(102, 23);
            this.btnOption.TabIndex = 0;
            this.btnOption.Text = "옵션 숨기기";
            this.btnOption.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.Location = new System.Drawing.Point(337, 9);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "연결";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 414);
            this.Controls.Add(this.c1Sizer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.docTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.TabControl docTab;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabFiscal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.ColorDialog colorDiag;
    }
}