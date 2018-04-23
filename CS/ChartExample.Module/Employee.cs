using System;
using System.ComponentModel;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace ChartExample.Module {
    [DefaultClassOptions, DefaultProperty("FullName"), ImageName("BO_Person")]
    public class Employee : BaseObject {
        public Employee(Session session) : base(session) {}
        private string firstName;
        private string lastName;
        private string position;
        [VisibleInListView(false)]
        public string FirstName {
            get { return firstName; }
            set { SetPropertyValue("FirstName", ref firstName, value); }
        }
        [VisibleInListView(false)]
        public string LastName {
            get { return lastName; }
            set { SetPropertyValue("LastName", ref lastName, value); }
        }
        [VisibleInDetailView(false)]
        public string FullName {
            get { return String.Format("{0} {1}", FirstName, LastName); }
        }
        public string Position {
            get { return position; }
            set { SetPropertyValue("Position", ref position, value); }
        }
    }
}
