using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using Client.ServiceReference1;

namespace Client
{
    public partial class Form1 : Form
    {
     
        public bool newNoteProcess;
        public bool textChanged=false;
        public Form1()
        {
            InitializeComponent();
                      
            FillListBox();
            newNoteProcess = false;
        } 

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                MessageBox.Show("The note is empty. Type something here.");

            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save the changes?", "Save your note", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Yes)
                {
                    if (newNoteProcess)
                    {
                        Service1Client client = new Service1Client("BasicHttpBinding_IService1");
                        Note n = new Note();
                        n.Text = textBox1.Text;
                        n.Title = textBox2.Text;
                        n.Date=DateTime.Now;
                        client.AddNote(n);

                        client.ListSerialize(client.ShowAll());
            
                        
                        client.Close();

                        FillListBox();
                        
                        textChanged = false;
                    }
                    else
                    {
                        DateTime date = ((Note)listBox1.SelectedItem).Date;
                        string title= ((Note)listBox1.SelectedItem).Title;
                        Service1Client client = new Service1Client("BasicHttpBinding_IService1");
                        Note n = new Note();
                        n.Text = textBox1.Text;
                        n.Date = date;
                        n.Title = title;
                        client.Replace(n);
                        client.Close();
                        FillListBox();
                        textChanged = false;
                    }
                    newNoteProcess = false;
                    listBox1.ClearSelected();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                if (dialogResult == DialogResult.Cancel)
                {

                    

                }

            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            newNoteProcess = true;
            listBox1.ClearSelected();
            textBox1.Clear();
            textBox2.Text = "New Note";

        }


        private void FillListBox()
        {
            Service1Client client = new Service1Client("BasicHttpBinding_IService1");
            List<Note> notes = client.ShowAll().ToList();
       
            if (notes.Count > 0)
            {
                listBox1.DataSource = notes;
                listBox1.DisplayMember = "Title";
                listBox1.ValueMember = "Text";
                labelNoNotes.Visible = false;
                labelNoNotes.Refresh();
                
                listBox1.Refresh();

            }
            else
            {
                labelNoNotes.Visible = true;
            }
            client.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textChanged)
                saveButton.PerformClick();
            
            if (listBox1.SelectedIndices.Count > 0)
                {
                    textBox1.Text = listBox1.SelectedValue.ToString();

                }
            
        }
    }
}
