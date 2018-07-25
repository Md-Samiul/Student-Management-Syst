using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Framework;
using Entities;

namespace DataLayer
{
   public class CourseTeacherData
    {
        DataAccess _da = new DataAccess();

        public void Register(CourseTeacher obj)
        {
            string insertCommand = "INSERT INTO CourseTeacher (Teacher_ID, Course_ID) " +
                                   "VALUES (@tID, @cID)";
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter idParameterT = new SqlParameter("@tID", SqlDbType.Int);
            idParameterT.Value = obj.tID;

            SqlParameter idParameterC = new SqlParameter("@cID", SqlDbType.Int);
            idParameterC.Value = obj.cID;

            command.Parameters.Add(idParameterT);
            command.Parameters.Add(idParameterC);

            _da.Execute(command);
        }

        public void Delete(CourseTeacher obj)
        {
            string insertCommand = "DELETE CourseTeacher " +
                                   "WHERE Teacher_ID = @tID AND Course_ID = @cID ";
                               
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter idParameterT = new SqlParameter("@tID", SqlDbType.Int);
            idParameterT.Value = obj.tID;
            SqlParameter idParameterC = new SqlParameter("@cID", SqlDbType.Int);
            idParameterC.Value = obj.cID;

            command.Parameters.Add(idParameterT);
            command.Parameters.Add(idParameterC);

            _da.Execute(command);
        }

        public void Update(CourseTeacher obj)
        {
            string insertCommand = "UPDATE CourseTeacher SET Course_ID = @cID " +
                                   "WHERETeacher_ID = @tID = @tID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameterT = new SqlParameter("@tID", SqlDbType.Int);
            idParameterT.Value = obj.tID;
            SqlParameter idParameterC = new SqlParameter("@cID", SqlDbType.Int);
            idParameterC.Value = obj.cID;

            command.Parameters.Add(idParameterT);
            command.Parameters.Add(idParameterC);

            _da.Execute(command);
        }

        public DataTable Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CourseTeacher");
            return _da.Query(command);
        }
    }
}