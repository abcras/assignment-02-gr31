using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public record ImmutableStudent
    {
        int Id { get; init; }
        string GivenName { get; init; }
        string SurName { get; init; }

        public Status status { get; init; }
        DateTime StartDate { get; init; }
        DateTime EndDate { get; init; }
        DateTime GraduationDate { get; init; }

        public ImmutableStudent(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
        {
            Id = id;
            GivenName = givenName;
            SurName = surName;
            StartDate = startDate;
            EndDate = endDate;
            GraduationDate = graduationDate;

            {
                var now = DateTime.Now;
                if (now > StartDate && now < StartDate.AddMonths(6))
                {
                    status = Status.New; return;
                }
                if (now < GraduationDate && now < EndDate)
                {
                    status = Status.Active;return;
                }

                if (now > EndDate && EndDate < GraduationDate)
                {
                    status = Status.Dropout; return;
                }
                if (now > GraduationDate && GraduationDate == EndDate)
                {
                    status = Status.Graduated; return;
                }
            }
        }

    }

    /*
         * The Business rules for property status
         If DateTime.Now greater than StartDate but less than StartDate +1 year status = New
         If DateTime.Now != Status.new && DateTime.Now < GraduationDate && DateTime.Now < EndDate = Active
            EndDate is graduation date until updated
         If DateTime.Now > EndDate && EndDate < GraduationDate = Dropout
         If DateTime.Now > GraduationDate && EndDate == GraduationDate = Graduated
         */

    public enum Status
    {
        New,
        Active,
        Dropout,
        Graduated,
    }

    internal class Student
    {
        int Id { get; init; }
        string GivenName { get; set; }
        string SurName { get; set; }

        Status status { get; init; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        DateTime GraduationDate { get; set; }

        /*
         * The Business rules for property status
         If DateTime.Now greater than StartDate but less than StartDate +1 year status = New
         If DateTime.Now != Status.new && DateTime.Now < GraduationDate && DateTime.Now < EndDate = Active
            EndDate is graduation date until updated
         If DateTime.Now > EndDate && EndDate < GraduationDate = Dropout
         If DateTime.Now > GraduationDate && EndDate == GraduationDate = Graduated
         */

        public override string ToString()
        {
            return $"({Id}, {GivenName} {SurName}, {status})";
        }
    }
}
