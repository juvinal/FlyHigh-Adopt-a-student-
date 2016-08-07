using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyHigh
{
    public class ClsProcedures
    {
        public static void SignUpStudent(tblUser tbl1, StudentReference tbl2)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.sp_SignUpStudent(tbl1.BankID, tbl1.Username, tbl1.PAssword, tbl1.LastName, tbl1.Firstname, tbl1.Gender, tbl1.Address, tbl1.Contact, tbl1.Usertype, tbl2.ReferenceLastname, tbl2.ReferenceLastname, tbl2.ReferenceContact, tbl2.Form137, tbl2.Endorsement, tbl2.Others);
        }

        public static void SignUp(tblUser tbl1)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.sp_SignUp(tbl1.BankID, tbl1.Username, tbl1.PAssword, tbl1.LastName, tbl1.Firstname, tbl1.Gender, tbl1.Address, tbl1.Contact, tbl1.Usertype);
        }

        public static List<sp_AccountsResult> Accounts()
        {

            DataClasses1DataContext db = new DataClasses1DataContext();
            List<sp_AccountsResult> accounts = db.sp_Accounts().ToList<sp_AccountsResult>();
            return accounts;
        }

        public static List<sp_StudentsResult> Students()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<sp_StudentsResult> students = db.sp_Students().ToList<sp_StudentsResult>();
            return students;
        }

        public static List<sp_ReferencesResult> References ()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<sp_ReferencesResult> references = db.sp_References().ToList<sp_ReferencesResult>();
            return references;
        }

        public static void UpdateStudent(tblUser tbl)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            db.UpdateStudent(tbl.BankID, tbl.Usertype);
        }

        public static List<sp_MyStudentsResult>MyStudent(string student)
        {
            DataClasses1DataContext db = new DataClasses1DataContext();
            List<sp_MyStudentsResult> mystudents = db.sp_MyStudents(student).ToList<sp_MyStudentsResult>();
            return mystudents;
        }
    }
}
