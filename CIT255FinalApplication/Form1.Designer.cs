namespace CIT255FinalApplication
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnVoteUp = new System.Windows.Forms.Button();
            this.btnVoteDown = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstDisplayList = new System.Windows.Forms.ListBox();
            this.btnQueryByName = new System.Windows.Forms.Button();
            this.btnQueryByGenre = new System.Windows.Forms.Button();
            this.btnQueryByRating = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnVote = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lbGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.lbRating = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 416);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(114, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 37);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnVoteUp
            // 
            this.btnVoteUp.Location = new System.Drawing.Point(310, 415);
            this.btnVoteUp.Name = "btnVoteUp";
            this.btnVoteUp.Size = new System.Drawing.Size(92, 37);
            this.btnVoteUp.TabIndex = 3;
            this.btnVoteUp.Text = "Vote Up";
            this.btnVoteUp.UseVisualStyleBackColor = true;
            this.btnVoteUp.Click += new System.EventHandler(this.btnVoteUp_Click);
            // 
            // btnVoteDown
            // 
            this.btnVoteDown.Location = new System.Drawing.Point(408, 416);
            this.btnVoteDown.Name = "btnVoteDown";
            this.btnVoteDown.Size = new System.Drawing.Size(92, 37);
            this.btnVoteDown.TabIndex = 4;
            this.btnVoteDown.Text = "Vote Down";
            this.btnVoteDown.UseVisualStyleBackColor = true;
            this.btnVoteDown.Click += new System.EventHandler(this.btnVoteDown_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(408, 416);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(92, 37);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "Query";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(506, 416);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 37);
            this.btnExit.TabIndex = 99;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstDisplayList
            // 
            this.lstDisplayList.FormattingEnabled = true;
            this.lstDisplayList.Location = new System.Drawing.Point(26, 12);
            this.lstDisplayList.Name = "lstDisplayList";
            this.lstDisplayList.Size = new System.Drawing.Size(561, 264);
            this.lstDisplayList.TabIndex = 100;
            // 
            // btnQueryByName
            // 
            this.btnQueryByName.Location = new System.Drawing.Point(212, 415);
            this.btnQueryByName.Name = "btnQueryByName";
            this.btnQueryByName.Size = new System.Drawing.Size(92, 37);
            this.btnQueryByName.TabIndex = 20;
            this.btnQueryByName.Text = "Query By Name";
            this.btnQueryByName.UseVisualStyleBackColor = true;
            this.btnQueryByName.Click += new System.EventHandler(this.btnQueryByName_Click);
            // 
            // btnQueryByGenre
            // 
            this.btnQueryByGenre.Location = new System.Drawing.Point(310, 415);
            this.btnQueryByGenre.Name = "btnQueryByGenre";
            this.btnQueryByGenre.Size = new System.Drawing.Size(92, 37);
            this.btnQueryByGenre.TabIndex = 21;
            this.btnQueryByGenre.Text = "Query By Genre";
            this.btnQueryByGenre.UseVisualStyleBackColor = true;
            this.btnQueryByGenre.Click += new System.EventHandler(this.btnQueryByType_Click);
            // 
            // btnQueryByRating
            // 
            this.btnQueryByRating.Location = new System.Drawing.Point(408, 415);
            this.btnQueryByRating.Name = "btnQueryByRating";
            this.btnQueryByRating.Size = new System.Drawing.Size(92, 37);
            this.btnQueryByRating.TabIndex = 23;
            this.btnQueryByRating.Text = "Query By Rating";
            this.btnQueryByRating.UseVisualStyleBackColor = true;
            this.btnQueryByRating.Click += new System.EventHandler(this.btnQueryByRating_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(114, 415);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(92, 37);
            this.btnMainMenu.TabIndex = 2;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnVote
            // 
            this.btnVote.Location = new System.Drawing.Point(310, 416);
            this.btnVote.Name = "btnVote";
            this.btnVote.Size = new System.Drawing.Size(92, 36);
            this.btnVote.TabIndex = 4;
            this.btnVote.Text = "Vote";
            this.btnVote.UseVisualStyleBackColor = true;
            this.btnVote.Click += new System.EventHandler(this.btnVote_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(212, 415);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(34, 281);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(18, 13);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(34, 307);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "Name";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(34, 333);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 17;
            this.lbYear.Text = "Year";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(76, 281);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(522, 20);
            this.txtID.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(76, 307);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(522, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(76, 333);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(522, 20);
            this.txtYear.TabIndex = 21;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(212, 416);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(92, 37);
            this.btnContinue.TabIndex = 22;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(34, 360);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(36, 13);
            this.lbGenre.TabIndex = 23;
            this.lbGenre.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(76, 360);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(522, 20);
            this.txtGenre.TabIndex = 22;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(76, 386);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(522, 20);
            this.txtRating.TabIndex = 26;
            // 
            // lbRating
            // 
            this.lbRating.AutoSize = true;
            this.lbRating.Location = new System.Drawing.Point(34, 386);
            this.lbRating.Name = "lbRating";
            this.lbRating.Size = new System.Drawing.Size(38, 13);
            this.lbRating.TabIndex = 25;
            this.lbRating.Text = "Rating";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 464);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.lbRating);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.lbGenre);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lstDisplayList);
            this.Controls.Add(this.btnVoteUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVote);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.btnVoteDown);
            this.Controls.Add(this.btnQueryByName);
            this.Controls.Add(this.btnQueryByGenre);
            this.Controls.Add(this.btnQueryByRating);
            this.Controls.Add(this.btnContinue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstDisplayList;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnVoteUp;
        public System.Windows.Forms.Button btnVoteDown;
        public System.Windows.Forms.Button btnQuery;
        public System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.Button btnQueryByName;
        public System.Windows.Forms.Button btnQueryByGenre;
        public System.Windows.Forms.Button btnQueryByRating;
        public System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnVote;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label lbRating;
    }
}

