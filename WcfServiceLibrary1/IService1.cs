 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void Replace(Note note);

        [OperationContract]
       List<Note> ShowByDate(DateTime date);

         [OperationContract]
       List<Note> ShowAll();
        
        [OperationContract]
       void AddNote(Note note);

       /* [OperationContract]
        Note newNote();


        [OperationContract]
        Note newNoteWithParameters(string t, DateTime d);*/


        [OperationContract]
        void ListSerialize(List<Note> noteList);


        [OperationContract]
        void ListDeSerialize(List<Note> noteList);
        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceLibrary1.ContractType".
    [DataContract]
    public class Note
    {

        [DataMember]
        public string Text { get; set; }

        [DataMember]
        public DateTime Date { get; set; }


        [DataMember]
        public string Title { get; set; }
    }


}
