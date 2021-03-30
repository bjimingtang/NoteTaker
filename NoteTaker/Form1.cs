using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaker
{
    public partial class Form1 : Form
    {
        DataTable NoteTable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewButton.Click += new EventHandler(NewButton_Click);
            SaveButton.Click += new EventHandler(SaveButton_Click);
            EditButton.Click += new EventHandler(EditButton_Click);
            ReadButton.Click += new EventHandler(ReadButton_Click);
            DeleteButton.Click += new EventHandler(DeleteButton_Click);
            NoteTable = new DataTable();
            NoteTable.TableName = "notes";
            NoteTable.Columns.Add("Title", typeof(String));
            NoteTable.Columns.Add("message", typeof(String));
            var settingCheck = Properties.Settings.Default.Notes;
            if (settingCheck != "" && settingCheck != null)
            {
                StringReader reader = new StringReader(Properties.Settings.Default.Notes);
                NoteTable.ReadXml(reader);
            }            

            NoteViewer.DataSource = NoteTable;
            NoteViewer.Columns["message"].Visible = false;
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            TitleText.Clear();
            MessageText.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NoteTable.Rows.Add(TitleText.Text, MessageText.Text);
            StringWriter writer = new StringWriter();
            NoteTable.WriteXml(writer);
            Properties.Settings.Default.Notes = writer.ToString();
            Properties.Settings.Default.Save();
            TitleText.Clear();
            MessageText.Clear();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = NoteViewer.CurrentCell.RowIndex;

                if (rowIndex > -1)
                {
                    NoteTable.Rows[rowIndex].SetField(0, TitleText.Text);
                    NoteTable.Rows[rowIndex].SetField(1, MessageText.Text);
                    StringWriter writer = new StringWriter();
                    NoteTable.WriteXml(writer);
                    Properties.Settings.Default.Notes = writer.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception error)
            {
                return;
            }
            
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = NoteViewer.CurrentCell.RowIndex;

                if (rowIndex > -1)
                {
                    TitleText.Text = NoteTable.Rows[rowIndex].ItemArray[0].ToString();
                    MessageText.Text = NoteTable.Rows[rowIndex].ItemArray[1].ToString();
                    StringWriter writer = new StringWriter();
                    NoteTable.WriteXml(writer);
                    Properties.Settings.Default.Notes = writer.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception error)
            {
                return;
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = NoteViewer.CurrentCell.RowIndex;

                if (rowIndex > -1)
                {
                    NoteTable.Rows[rowIndex].Delete();
                    StringWriter writer = new StringWriter();
                    NoteTable.WriteXml(writer);
                    Properties.Settings.Default.Notes = writer.ToString();
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception error)
            {
                return;
            }
            
        }
    }
}
