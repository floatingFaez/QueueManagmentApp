namespace QueueManagmentAppForm
{
    partial class CustomerQueueManagmentForm
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
            this.complainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SerialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.queueListView = new System.Windows.Forms.ListView();
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.waitingQeueGroupBox = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.serialNoLabel = new System.Windows.Forms.Label();
            this.dequeeComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueeComplainLabel = new System.Windows.Forms.Label();
            this.enqueeNameLabel = new System.Windows.Forms.Label();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.dequeeNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeeComplainLabel = new System.Windows.Forms.Label();
            this.dequeeNameLabel = new System.Windows.Forms.Label();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueeComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueeNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueGroupBox = new System.Windows.Forms.GroupBox();
            this.enqueueGroupBox = new System.Windows.Forms.GroupBox();
            this.waitingQeueGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.enqueueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // complainColumnHeader
            // 
            this.complainColumnHeader.Text = "Complain";
            this.complainColumnHeader.Width = 436;
            // 
            // SerialColumnHeader
            // 
            this.SerialColumnHeader.Text = "Serial No";
            // 
            // queueListView
            // 
            this.queueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SerialColumnHeader,
            this.nameColumnHeader,
            this.complainColumnHeader});
            this.queueListView.FullRowSelect = true;
            this.queueListView.GridLines = true;
            this.queueListView.Location = new System.Drawing.Point(18, 22);
            this.queueListView.MultiSelect = false;
            this.queueListView.Name = "queueListView";
            this.queueListView.Size = new System.Drawing.Size(680, 199);
            this.queueListView.TabIndex = 3;
            this.queueListView.UseCompatibleStateImageBehavior = false;
            this.queueListView.View = System.Windows.Forms.View.Details;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 150;
            // 
            // waitingQeueGroupBox
            // 
            this.waitingQeueGroupBox.Controls.Add(this.queueListView);
            this.waitingQeueGroupBox.Location = new System.Drawing.Point(17, 202);
            this.waitingQeueGroupBox.Name = "waitingQeueGroupBox";
            this.waitingQeueGroupBox.Size = new System.Drawing.Size(716, 235);
            this.waitingQeueGroupBox.TabIndex = 4;
            this.waitingQeueGroupBox.TabStop = false;
            this.waitingQeueGroupBox.Text = "Waiting Queue";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(247, 19);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(93, 32);
            this.dequeueButton.TabIndex = 4;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // serialNoLabel
            // 
            this.serialNoLabel.AutoSize = true;
            this.serialNoLabel.Location = new System.Drawing.Point(18, 31);
            this.serialNoLabel.Name = "serialNoLabel";
            this.serialNoLabel.Size = new System.Drawing.Size(44, 13);
            this.serialNoLabel.TabIndex = 0;
            this.serialNoLabel.Text = "Srial No";
            // 
            // dequeeComplainTextBox
            // 
            this.dequeeComplainTextBox.Location = new System.Drawing.Point(84, 96);
            this.dequeeComplainTextBox.Multiline = true;
            this.dequeeComplainTextBox.Name = "dequeeComplainTextBox";
            this.dequeeComplainTextBox.Size = new System.Drawing.Size(246, 60);
            this.dequeeComplainTextBox.TabIndex = 7;
            // 
            // enqueeComplainLabel
            // 
            this.enqueeComplainLabel.AutoSize = true;
            this.enqueeComplainLabel.Location = new System.Drawing.Point(15, 64);
            this.enqueeComplainLabel.Name = "enqueeComplainLabel";
            this.enqueeComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.enqueeComplainLabel.TabIndex = 0;
            this.enqueeComplainLabel.Text = "Complain";
            // 
            // enqueeNameLabel
            // 
            this.enqueeNameLabel.AutoSize = true;
            this.enqueeNameLabel.Location = new System.Drawing.Point(30, 31);
            this.enqueeNameLabel.Name = "enqueeNameLabel";
            this.enqueeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.enqueeNameLabel.TabIndex = 0;
            this.enqueeNameLabel.Text = "Name";
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(84, 31);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(53, 20);
            this.serialNoTextBox.TabIndex = 5;
            // 
            // dequeeNameTextBox
            // 
            this.dequeeNameTextBox.Location = new System.Drawing.Point(84, 63);
            this.dequeeNameTextBox.Name = "dequeeNameTextBox";
            this.dequeeNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.dequeeNameTextBox.TabIndex = 6;
            // 
            // dequeeComplainLabel
            // 
            this.dequeeComplainLabel.AutoSize = true;
            this.dequeeComplainLabel.Location = new System.Drawing.Point(12, 99);
            this.dequeeComplainLabel.Name = "dequeeComplainLabel";
            this.dequeeComplainLabel.Size = new System.Drawing.Size(50, 13);
            this.dequeeComplainLabel.TabIndex = 0;
            this.dequeeComplainLabel.Text = "Complain";
            // 
            // dequeeNameLabel
            // 
            this.dequeeNameLabel.AutoSize = true;
            this.dequeeNameLabel.Location = new System.Drawing.Point(27, 66);
            this.dequeeNameLabel.Name = "dequeeNameLabel";
            this.dequeeNameLabel.Size = new System.Drawing.Size(35, 13);
            this.dequeeNameLabel.TabIndex = 0;
            this.dequeeNameLabel.Text = "Name";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(87, 134);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(93, 32);
            this.enqueueButton.TabIndex = 3;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueeComplainTextBox
            // 
            this.enqueeComplainTextBox.Location = new System.Drawing.Point(87, 61);
            this.enqueeComplainTextBox.Multiline = true;
            this.enqueeComplainTextBox.Name = "enqueeComplainTextBox";
            this.enqueeComplainTextBox.Size = new System.Drawing.Size(246, 60);
            this.enqueeComplainTextBox.TabIndex = 2;
            // 
            // enqueeNameTextBox
            // 
            this.enqueeNameTextBox.Location = new System.Drawing.Point(87, 28);
            this.enqueeNameTextBox.Name = "enqueeNameTextBox";
            this.enqueeNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.enqueeNameTextBox.TabIndex = 1;
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.serialNoLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeeComplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.serialNoTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeeNameTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeeComplainLabel);
            this.dequeueGroupBox.Controls.Add(this.dequeeNameLabel);
            this.dequeueGroupBox.Location = new System.Drawing.Point(375, 8);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(358, 185);
            this.dequeueGroupBox.TabIndex = 2;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue Customer";
            // 
            // enqueueGroupBox
            // 
            this.enqueueGroupBox.Controls.Add(this.enqueueButton);
            this.enqueueGroupBox.Controls.Add(this.enqueeComplainTextBox);
            this.enqueueGroupBox.Controls.Add(this.enqueeNameTextBox);
            this.enqueueGroupBox.Controls.Add(this.enqueeComplainLabel);
            this.enqueueGroupBox.Controls.Add(this.enqueeNameLabel);
            this.enqueueGroupBox.Location = new System.Drawing.Point(17, 8);
            this.enqueueGroupBox.Name = "enqueueGroupBox";
            this.enqueueGroupBox.Size = new System.Drawing.Size(352, 185);
            this.enqueueGroupBox.TabIndex = 1;
            this.enqueueGroupBox.TabStop = false;
            this.enqueueGroupBox.Text = "Enqueue Customer";
            // 
            // CustomerQueueManagmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 448);
            this.Controls.Add(this.waitingQeueGroupBox);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.enqueueGroupBox);
            this.Name = "CustomerQueueManagmentForm";
            this.Text = "Customer Queue Managment Application";
            this.waitingQeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.enqueueGroupBox.ResumeLayout(false);
            this.enqueueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader complainColumnHeader;
        private System.Windows.Forms.ColumnHeader SerialColumnHeader;
        private System.Windows.Forms.ListView queueListView;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.GroupBox waitingQeueGroupBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Label serialNoLabel;
        private System.Windows.Forms.TextBox dequeeComplainTextBox;
        private System.Windows.Forms.Label enqueeComplainLabel;
        private System.Windows.Forms.Label enqueeNameLabel;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.TextBox dequeeNameTextBox;
        private System.Windows.Forms.Label dequeeComplainLabel;
        private System.Windows.Forms.Label dequeeNameLabel;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox enqueeComplainTextBox;
        private System.Windows.Forms.TextBox enqueeNameTextBox;
        private System.Windows.Forms.GroupBox dequeueGroupBox;
        private System.Windows.Forms.GroupBox enqueueGroupBox;
    }
}

