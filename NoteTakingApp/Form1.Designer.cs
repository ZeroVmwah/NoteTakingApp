namespace NoteTakingApp
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
            note = new RichTextBox();
            saved = new ListView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            title = new TextBox();
            label3 = new Label();
            label4 = new Label();
            times = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // note
            // 
            note.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            note.Location = new Point(103, 185);
            note.Name = "note";
            note.Size = new Size(100, 96);
            note.TabIndex = 0;
            note.Text = "";
            note.Validating += note_Validating;
            // 
            // saved
            // 
            saved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            saved.Location = new Point(397, 189);
            saved.Name = "saved";
            saved.Size = new Size(163, 146);
            saved.TabIndex = 1;
            saved.UseCompatibleStateImageBehavior = false;
            saved.View = View.List;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(103, 167);
            label1.Name = "label1";
            label1.Size = new Size(41, 19);
            label1.TabIndex = 2;
            label1.Text = "Note:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(397, 167);
            label2.Name = "label2";
            label2.Size = new Size(86, 19);
            label2.TabIndex = 3;
            label2.Text = "Saved notes:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.DarkOrchid;
            button1.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(178, 392);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 4;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.DarkOrchid;
            button2.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(294, 392);
            button2.Name = "button2";
            button2.Size = new Size(75, 39);
            button2.TabIndex = 5;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.DarkOrchid;
            button3.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(407, 392);
            button3.Name = "button3";
            button3.Size = new Size(75, 39);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // title
            // 
            title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            title.Location = new Point(103, 111);
            title.Name = "title";
            title.Size = new Size(100, 23);
            title.TabIndex = 7;
            title.Validating += title_Validating;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(103, 93);
            label3.Name = "label3";
            label3.Size = new Size(76, 19);
            label3.TabIndex = 8;
            label3.Text = "Note Title:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(103, 312);
            label4.Name = "label4";
            label4.Size = new Size(83, 19);
            label4.TabIndex = 10;
            label4.Text = "TimeStamp:";
            // 
            // times
            // 
            times.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            times.Location = new Point(103, 330);
            times.Name = "times";
            times.Size = new Size(100, 23);
            times.TabIndex = 9;
            times.Validating += times_Validating;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(214, 23);
            label5.Name = "label5";
            label5.Size = new Size(227, 53);
            label5.TabIndex = 11;
            label5.Text = "Note Taking";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(648, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(times);
            Controls.Add(label3);
            Controls.Add(title);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saved);
            Controls.Add(note);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox note;
        private ListView saved;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox title;
        private Label label3;
        private Label label4;
        private TextBox times;
        private Label label5;
    }
}