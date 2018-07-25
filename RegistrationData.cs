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
    public class RegistrationData
    {
        DataAccess _da = new DataAccess();

        public void Insert(Registration obj)
        {
            string insertCommand = "INSERT INTO Registration (Registration_ID, Student_ID, Course1_ID, Course2_ID, Course3_ID) " +
                                   "VALUES (@regID, @sID, @c1ID, @c2ID, @c3ID)";

            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter regParameter = new SqlParameter("@regID", SqlDbType.Int);
            regParameter.Value = obj.regID;
            SqlParameter stdParameter = new SqlParameter("@sID", SqlDbType.Int);
            stdParameter.Value = obj.sID;
            SqlParameter crse1Parameter = new SqlParameter("@c1ID", SqlDbType.Int);
            crse1Parameter.Value = obj.c1ID;
            SqlParameter crse2Parameter = new SqlParameter("@c2ID", SqlDbType.Int);
            crse2Parameter.Value = obj.c2ID;
            SqlParameter crse3Parameter = new SqlParameter("@c3ID", SqlDbType.Int);
            crse3Parameter.Value = obj.c3ID;

            command.Parameters.Add(regParameter);
            command.Parameters.Add(stdParameter);
            command.Parameters.Add(crse1Parameter);
            command.Parameters.Add(crse2Parameter);
            command.Parameters.Add(crse3Parameter);

            _da.Execute(command);
        }

        public void Delete(int id)
        {
            string insertCommand = "DELETE Registration " +
                                   "WHERE Registration_ID = @regID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter regParameter = new SqlParameter("@regID", SqlDbType.Int);
            regParameter.Value = id;

            command.Parameters.Add(regParameter);

            _da.Execute(command);
        }

        /*public void Update(Registration obj)
        {
            string insertCommand = "UPDATE Registration (Student_ID, Course_ID) "+
                                    " VALUES (@studentID, @courseID) " +
                                   "WHERE Registration_ID = @registrationID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter regParameter = new SqlParameter("@registrationID", SqlDbType.Int);
            regParameter.Value = obj.registrationID;
            SqlParameter stdParameter = new SqlParameter("@studentID", SqlDbType.Int);
            stdParameter.Value = obj.studentID;
            SqlParameter crseParameter = new SqlParameter("@courseID", SqlDbType.Int);
            crseParameter.Value = obj.courseID;
            
            command.Parameters.Add(crseParameter);
            command.Parameters.Add(regParameter);
            command.Parameters.Add(stdParameter);
            _da.Execute(command);
        }*/

        public DataTable Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Registration");
            return _da.Query(command);
        }

    }
}
