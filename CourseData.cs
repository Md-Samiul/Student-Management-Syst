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
   public class CourseData
    {
        DataAccess _da = new DataAccess();

        public void Insert(Course obj)
        {
            string insertCommand = "INSERT INTO Course (Course_ID, Course_Name) " +
                                   "VALUES (@ID, @Name)";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = obj.ID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = obj.Name;
            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            _da.Execute(command);
        }

        public void Delete(int id)
        {
            string insertCommand = "DELETE Course " +
                                   "WHERE Course_ID = @ID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = id;

            command.Parameters.Add(idParameter);

            _da.Execute(command);
        }

        public void Update(Course obj)
        {
            string insertCommand = "UPDATE Course SET Course_Name = @Name " +
                                   "WHERE Course_ID = @ID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = obj.ID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = obj.Name;
            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            _da.Execute(command);
        }

        public DataTable Query()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Course");
            return _da.Query(command);
        }
    }
}
