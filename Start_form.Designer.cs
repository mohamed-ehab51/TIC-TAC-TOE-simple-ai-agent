namespace Complete_tic_tac_toe
{
    partial class Start_form
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
            label1 = new Label();
            VS_computer_RB = new RadioButton();
            VS_friend_online_RB = new RadioButton();
            VS_friend_on_the_same_pc_RB = new RadioButton();
            Start_button = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 55);
            label1.Name = "label1";
            label1.Size = new Size(193, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose the mood you want to play";
            // 
            // VS_computer_RB
            // 
            VS_computer_RB.AutoSize = true;
            VS_computer_RB.Location = new Point(168, 115);
            VS_computer_RB.Margin = new Padding(3, 2, 3, 2);
            VS_computer_RB.Name = "VS_computer_RB";
            VS_computer_RB.Size = new Size(93, 19);
            VS_computer_RB.TabIndex = 1;
            VS_computer_RB.TabStop = true;
            VS_computer_RB.Text = "VS computer";
            VS_computer_RB.UseVisualStyleBackColor = true;
            // 
            // VS_friend_online_RB
            // 
            VS_friend_online_RB.AutoSize = true;
            VS_friend_online_RB.Location = new Point(168, 150);
            VS_friend_online_RB.Margin = new Padding(3, 2, 3, 2);
            VS_friend_online_RB.Name = "VS_friend_online_RB";
            VS_friend_online_RB.Size = new Size(108, 19);
            VS_friend_online_RB.TabIndex = 2;
            VS_friend_online_RB.TabStop = true;
            VS_friend_online_RB.Text = "VS friend online";
            VS_friend_online_RB.UseVisualStyleBackColor = true;
            // 
            // VS_friend_on_the_same_pc_RB
            // 
            VS_friend_on_the_same_pc_RB.AutoSize = true;
            VS_friend_on_the_same_pc_RB.Location = new Point(168, 188);
            VS_friend_on_the_same_pc_RB.Margin = new Padding(3, 2, 3, 2);
            VS_friend_on_the_same_pc_RB.Name = "VS_friend_on_the_same_pc_RB";
            VS_friend_on_the_same_pc_RB.Size = new Size(156, 19);
            VS_friend_on_the_same_pc_RB.TabIndex = 3;
            VS_friend_on_the_same_pc_RB.TabStop = true;
            VS_friend_on_the_same_pc_RB.Text = "VS friend on the same pc";
            VS_friend_on_the_same_pc_RB.UseVisualStyleBackColor = true;
            // 
            // Start_button
            // 
            Start_button.Location = new Point(176, 243);
            Start_button.Margin = new Padding(3, 2, 3, 2);
            Start_button.Name = "Start_button";
            Start_button.Size = new Size(82, 22);
            Start_button.TabIndex = 4;
            Start_button.Text = "Start";
            Start_button.UseVisualStyleBackColor = true;
            Start_button.Click += Start_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 154);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 5;
            label2.Text = "<- Still working on it";
            // 
            // Start_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 333);
            Controls.Add(label2);
            Controls.Add(Start_button);
            Controls.Add(VS_friend_on_the_same_pc_RB);
            Controls.Add(VS_friend_online_RB);
            Controls.Add(VS_computer_RB);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Start_form";
            Text = "Start_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton VS_computer_RB;
        private RadioButton VS_friend_online_RB;
        private RadioButton VS_friend_on_the_same_pc_RB;
        private Button Start_button;
        private Label label2;
    }
}