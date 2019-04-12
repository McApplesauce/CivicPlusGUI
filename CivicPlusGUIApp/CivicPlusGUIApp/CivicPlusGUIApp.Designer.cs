namespace CivicPlusGUIApp
{
    partial class CivicPlusGUIApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CivicPlusGUIApp));
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnNewEvent = new System.Windows.Forms.Button();
            this.lstBxEvents = new System.Windows.Forms.ListBox();
            this.lbConnection = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBxTitle = new System.Windows.Forms.TextBox();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.btnGetEvents = new System.Windows.Forms.Button();
            this.dtTmStart = new System.Windows.Forms.DateTimePicker();
            this.dtTmEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(71, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnNewEvent
            // 
            this.btnNewEvent.Image = ((System.Drawing.Image)(resources.GetObject("btnNewEvent.Image")));
            this.btnNewEvent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewEvent.Location = new System.Drawing.Point(142, 229);
            this.btnNewEvent.Name = "btnNewEvent";
            this.btnNewEvent.Size = new System.Drawing.Size(202, 69);
            this.btnNewEvent.TabIndex = 1;
            this.btnNewEvent.Text = "Create New Event";
            this.btnNewEvent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewEvent.UseVisualStyleBackColor = true;
            this.btnNewEvent.Click += new System.EventHandler(this.btnNewEvent_Click);
            // 
            // lstBxEvents
            // 
            this.lstBxEvents.FormattingEnabled = true;
            this.lstBxEvents.ItemHeight = 16;
            this.lstBxEvents.Location = new System.Drawing.Point(389, 38);
            this.lstBxEvents.Name = "lstBxEvents";
            this.lstBxEvents.Size = new System.Drawing.Size(627, 260);
            this.lstBxEvents.TabIndex = 2;
            // 
            // lbConnection
            // 
            this.lbConnection.AutoSize = true;
            this.lbConnection.Location = new System.Drawing.Point(68, 16);
            this.lbConnection.Name = "lbConnection";
            this.lbConnection.Size = new System.Drawing.Size(97, 17);
            this.lbConnection.TabIndex = 3;
            this.lbConnection.Text = "Connect here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "End Date:";
            // 
            // txtBxTitle
            // 
            this.txtBxTitle.Location = new System.Drawing.Point(106, 96);
            this.txtBxTitle.Name = "txtBxTitle";
            this.txtBxTitle.Size = new System.Drawing.Size(267, 22);
            this.txtBxTitle.TabIndex = 11;
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.Location = new System.Drawing.Point(106, 124);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(267, 22);
            this.txtBxDescription.TabIndex = 12;
            // 
            // btnGetEvents
            // 
            this.btnGetEvents.Location = new System.Drawing.Point(389, 10);
            this.btnGetEvents.Name = "btnGetEvents";
            this.btnGetEvents.Size = new System.Drawing.Size(108, 23);
            this.btnGetEvents.TabIndex = 15;
            this.btnGetEvents.Text = "Get Events";
            this.btnGetEvents.UseVisualStyleBackColor = true;
            this.btnGetEvents.Click += new System.EventHandler(this.btnGetEvents_Click);
            // 
            // dtTmStart
            // 
            this.dtTmStart.Location = new System.Drawing.Point(106, 153);
            this.dtTmStart.Name = "dtTmStart";
            this.dtTmStart.Size = new System.Drawing.Size(267, 22);
            this.dtTmStart.TabIndex = 16;
            // 
            // dtTmEnd
            // 
            this.dtTmEnd.Location = new System.Drawing.Point(106, 181);
            this.dtTmEnd.Name = "dtTmEnd";
            this.dtTmEnd.Size = new System.Drawing.Size(267, 22);
            this.dtTmEnd.TabIndex = 17;
            // 
            // CivicPlusGUIApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 325);
            this.Controls.Add(this.dtTmEnd);
            this.Controls.Add(this.dtTmStart);
            this.Controls.Add(this.btnGetEvents);
            this.Controls.Add(this.txtBxDescription);
            this.Controls.Add(this.txtBxTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbConnection);
            this.Controls.Add(this.lstBxEvents);
            this.Controls.Add(this.btnNewEvent);
            this.Controls.Add(this.btnConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CivicPlusGUIApp";
            this.Text = "CivicPlus Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnNewEvent;
        private System.Windows.Forms.ListBox lstBxEvents;
        private System.Windows.Forms.Label lbConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBxTitle;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.Button btnGetEvents;
        private System.Windows.Forms.DateTimePicker dtTmStart;
        private System.Windows.Forms.DateTimePicker dtTmEnd;
    }
}

