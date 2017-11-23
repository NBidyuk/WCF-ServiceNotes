using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Serialization;
using WcfServiceLibrary1;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public static List<Note> notes { get; set; }

        public Service1()
        {
            notes = new List<Note>();
            if (File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\users.xml"))
            {
                ListDeSerialize(notes);
            }
          
        }


        public void Replace(Note note)
        {
            foreach (Note n in notes)
            {
                if (n.Date == note.Date)
                {
                    n.Text = note.Text;
                }
            }
        }


        public List<Note> ShowByDate(DateTime date)
        {
            List<Note> newList = new List<Note>();
            foreach (Note n in notes)
            {
                if (n.Date == date)
                {
                    newList.Add(n);
                }
            }

            return newList;

        }

        public List<Note> ShowAll()
        {

            return notes;

        }

        public void AddNote(Note note)
        {
            if (notes==null)
                notes = new List<Note>();
            
            notes.Add(note);

        }

        /*public Note newNote()
        {
            Note n = new Note();
            return n;
        }



        public Note newNoteWithParameters(string t, DateTime d)
        {
            Note n = new Note(t, d);
            return n;

        }*/

        public void ListSerialize(List<Note> noteList)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "\\users.xml";
            if (File.Exists(path))
            {
                XmlSerializer formatter = new XmlSerializer(typeof(List<Note>));
                using (FileStream fs = new FileStream("notes.xml", FileMode.OpenOrCreate))
                {

                    formatter.Serialize(fs, noteList);


                }
            }
            else return;

        }

        public void ListDeSerialize(List<Note> noteList)
        {

            XmlSerializer formatter = new XmlSerializer(typeof(List<Note>));
            using (FileStream fs = new FileStream("notes.xml", FileMode.OpenOrCreate))
            {
                noteList = (List<Note>) formatter.Deserialize(fs);
              

            }
        }


    }
}
    

