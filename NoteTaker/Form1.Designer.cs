
namespace NoteTaker
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.MessageText = new System.Windows.Forms.TextBox();
            this.NoteViewer = new System.Windows.Forms.DataGridView();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReadButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Message";
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(76, 67);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(140, 23);
            this.TitleText.TabIndex = 2;
            // 
            // MessageText
            // 
            this.MessageText.Location = new System.Drawing.Point(41, 127);
            this.MessageText.Multiline = true;
            this.MessageText.Name = "MessageText";
            this.MessageText.Size = new System.Drawing.Size(269, 155);
            this.MessageText.TabIndex = 3;
            // 
            // NoteViewer
            // 
            this.NoteViewer.AllowUserToAddRows = false;
            this.NoteViewer.AllowUserToDeleteRows = false;
            this.NoteViewer.AllowUserToResizeColumns = false;
            this.NoteViewer.AllowUserToResizeRows = false;
            this.NoteViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteViewer.Location = new System.Drawing.Point(388, 70);
            this.NoteViewer.Name = "NoteViewer";
            this.NoteViewer.ReadOnly = true;
            this.NoteViewer.RowHeadersVisible = false;
            this.NoteViewer.RowTemplate.Height = 25;
            this.NoteViewer.Size = new System.Drawing.Size(104, 212);
            this.NoteViewer.TabIndex = 4;
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(57, 321);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(71, 32);
            this.NewButton.TabIndex = 5;
            this.NewButton.Text = "New";
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(134, 321);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 32);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(295, 321);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(81, 32);
            this.ReadButton.TabIndex = 7;
            this.ReadButton.Text = "Read";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(382, 321);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 32);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(214, 321);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 32);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 379);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.NoteViewer);
            this.Controls.Add(this.MessageText);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "NoteTaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.TextBox MessageText;
        private System.Windows.Forms.DataGridView NoteViewer;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
    }
}

