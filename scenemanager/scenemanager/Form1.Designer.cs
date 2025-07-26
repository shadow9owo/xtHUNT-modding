namespace scenemanager
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
            this.components = new System.ComponentModel.Container();
            this.textureidlist = new System.Windows.Forms.ComboBox();
            this.objectidlist = new System.Windows.Forms.ComboBox();
            this.append = new System.Windows.Forms.Button();
            this.wipe = new System.Windows.Forms.Button();
            this.clickable = new System.Windows.Forms.CheckBox();
            this.screenposition = new System.Windows.Forms.RichTextBox();
            this.screensize = new System.Windows.Forms.RichTextBox();
            this.actionlist = new System.Windows.Forms.ComboBox();
            this.save = new System.Windows.Forms.Button();
            this.scenename = new System.Windows.Forms.RichTextBox();
            this.sceneid = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.arguments = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textureidlist
            // 
            this.textureidlist.FormattingEnabled = true;
            this.textureidlist.Location = new System.Drawing.Point(34, 31);
            this.textureidlist.Name = "textureidlist";
            this.textureidlist.Size = new System.Drawing.Size(139, 21);
            this.textureidlist.TabIndex = 0;
            // 
            // objectidlist
            // 
            this.objectidlist.FormattingEnabled = true;
            this.objectidlist.Location = new System.Drawing.Point(199, 31);
            this.objectidlist.Name = "objectidlist";
            this.objectidlist.Size = new System.Drawing.Size(139, 21);
            this.objectidlist.TabIndex = 1;
            // 
            // append
            // 
            this.append.Location = new System.Drawing.Point(34, 581);
            this.append.Name = "append";
            this.append.Size = new System.Drawing.Size(75, 23);
            this.append.TabIndex = 3;
            this.append.Text = "append";
            this.append.UseVisualStyleBackColor = true;
            this.append.Click += new System.EventHandler(this.append_Click);
            // 
            // wipe
            // 
            this.wipe.Location = new System.Drawing.Point(135, 581);
            this.wipe.Name = "wipe";
            this.wipe.Size = new System.Drawing.Size(75, 23);
            this.wipe.TabIndex = 4;
            this.wipe.Text = "wipe buffer";
            this.wipe.UseVisualStyleBackColor = true;
            this.wipe.Click += new System.EventHandler(this.wipe_Click);
            // 
            // clickable
            // 
            this.clickable.AutoSize = true;
            this.clickable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clickable.Location = new System.Drawing.Point(34, 76);
            this.clickable.Name = "clickable";
            this.clickable.Size = new System.Drawing.Size(65, 17);
            this.clickable.TabIndex = 5;
            this.clickable.Text = "clickable";
            this.clickable.UseVisualStyleBackColor = true;
            // 
            // screenposition
            // 
            this.screenposition.Location = new System.Drawing.Point(199, 76);
            this.screenposition.Name = "screenposition";
            this.screenposition.Size = new System.Drawing.Size(139, 29);
            this.screenposition.TabIndex = 6;
            this.screenposition.Text = "";
            this.screenposition.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.screenposition_KeyPress);
            this.screenposition.MouseHover += new System.EventHandler(this.screenposition_MouseHover);
            // 
            // screensize
            // 
            this.screensize.Location = new System.Drawing.Point(355, 76);
            this.screensize.Name = "screensize";
            this.screensize.Size = new System.Drawing.Size(139, 29);
            this.screensize.TabIndex = 7;
            this.screensize.Text = "";
            this.screensize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.screensize_KeyPress);
            this.screensize.MouseHover += new System.EventHandler(this.screensize_MouseHover);
            // 
            // actionlist
            // 
            this.actionlist.FormattingEnabled = true;
            this.actionlist.Location = new System.Drawing.Point(355, 31);
            this.actionlist.Name = "actionlist";
            this.actionlist.Size = new System.Drawing.Size(139, 21);
            this.actionlist.TabIndex = 8;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(710, 581);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 9;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // scenename
            // 
            this.scenename.Location = new System.Drawing.Point(34, 293);
            this.scenename.Multiline = false;
            this.scenename.Name = "scenename";
            this.scenename.Size = new System.Drawing.Size(139, 29);
            this.scenename.TabIndex = 10;
            this.scenename.Text = "";
            this.scenename.MouseHover += new System.EventHandler(this.scenename_MouseHover);
            // 
            // sceneid
            // 
            this.sceneid.Location = new System.Drawing.Point(199, 293);
            this.sceneid.Multiline = false;
            this.sceneid.Name = "sceneid";
            this.sceneid.Size = new System.Drawing.Size(139, 29);
            this.sceneid.TabIndex = 11;
            this.sceneid.Text = "";
            this.sceneid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sceneid_KeyPress);
            this.sceneid.MouseHover += new System.EventHandler(this.sceneid_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "textures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "itemid (objectid) list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "actions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "sceneinfo";
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(618, 581);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 16;
            this.load.Text = "load";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // arguments
            // 
            this.arguments.Location = new System.Drawing.Point(34, 146);
            this.arguments.Name = "arguments";
            this.arguments.Size = new System.Drawing.Size(139, 29);
            this.arguments.TabIndex = 17;
            this.arguments.Text = "";
            this.arguments.MouseHover += new System.EventHandler(this.arguments_MouseHover);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "custom argumenrts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.arguments);
            this.Controls.Add(this.load);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sceneid);
            this.Controls.Add(this.scenename);
            this.Controls.Add(this.save);
            this.Controls.Add(this.actionlist);
            this.Controls.Add(this.screensize);
            this.Controls.Add(this.screenposition);
            this.Controls.Add(this.clickable);
            this.Controls.Add(this.wipe);
            this.Controls.Add(this.append);
            this.Controls.Add(this.objectidlist);
            this.Controls.Add(this.textureidlist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textureidlist;
        private System.Windows.Forms.ComboBox objectidlist;
        private System.Windows.Forms.Button append;
        private System.Windows.Forms.Button wipe;
        private System.Windows.Forms.CheckBox clickable;
        private System.Windows.Forms.RichTextBox screenposition;
        private System.Windows.Forms.RichTextBox screensize;
        private System.Windows.Forms.ComboBox actionlist;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RichTextBox scenename;
        private System.Windows.Forms.RichTextBox sceneid;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.RichTextBox arguments;
        private System.Windows.Forms.Label label4;
    }
}

