namespace Decision_tree {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblName = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.imgGame = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.treeView = new System.Windows.Forms.TreeView();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgGame)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(660, 162);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn0
            // 
            this.btn0.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn0.BackColor = System.Drawing.Color.White;
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(55, 169);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(163, 72);
            this.btn0.TabIndex = 1;
            this.btn0.Tag = "0";
            this.btn0.Text = "button0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(224, 169);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(163, 72);
            this.btn1.TabIndex = 2;
            this.btn1.Tag = "1";
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // panelBtn
            // 
            this.panelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBtn.Controls.Add(this.btn3);
            this.panelBtn.Controls.Add(this.btn2);
            this.panelBtn.Controls.Add(this.btn5);
            this.panelBtn.Controls.Add(this.btn4);
            this.panelBtn.Controls.Add(this.btn1);
            this.panelBtn.Controls.Add(this.btn0);
            this.panelBtn.Location = new System.Drawing.Point(132, 228);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(436, 241);
            this.panelBtn.TabIndex = 3;
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(224, 13);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(163, 72);
            this.btn3.TabIndex = 6;
            this.btn3.Tag = "3";
            this.btn3.Text = "button3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Visible = false;
            this.btn3.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(55, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(163, 72);
            this.btn2.TabIndex = 5;
            this.btn2.Tag = "2";
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(224, 91);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(163, 72);
            this.btn5.TabIndex = 4;
            this.btn5.Tag = "5";
            this.btn5.Text = "button5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Visible = false;
            this.btn5.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(55, 91);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(163, 72);
            this.btn4.TabIndex = 3;
            this.btn4.Tag = "4";
            this.btn4.Text = "button4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Visible = false;
            this.btn4.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(12, 422);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 47);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "К началу";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imgGame
            // 
            this.imgGame.Location = new System.Drawing.Point(63, 65);
            this.imgGame.Name = "imgGame";
            this.imgGame.Size = new System.Drawing.Size(573, 288);
            this.imgGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgGame.TabIndex = 5;
            this.imgGame.TabStop = false;
            this.imgGame.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(131, 356);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(447, 116);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "label1";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDescription.Visible = false;
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.treeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeView.Location = new System.Drawing.Point(678, 0);
            this.treeView.Name = "treeView";
            this.treeView.ShowPlusMinus = false;
            this.treeView.Size = new System.Drawing.Size(477, 481);
            this.treeView.TabIndex = 7;
            this.treeView.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_BeforeCollapse);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1155, 481);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.imgGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panelBtn);
            this.Controls.Add(this.lblName);
            this.MinimumSize = new System.Drawing.Size(850, 520);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Экспертная система \"Выбор рогалика\"";
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblName;
        private Button btn0;
        private Button btn1;
        private Panel panelBtn;
        private Button btn3;
        private Button btn2;
        private Button btn5;
        private Button btn4;
        private Button btnReset;
        private PictureBox imgGame;
        private Label lblDescription;
        private TreeView treeView;
    }
}