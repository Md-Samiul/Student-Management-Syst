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
    public class StudentData
    {
        DataAccess _da = new DataAccess();
        public void Insert(Student objIN)
        {
            string insertCommand = "INSERT INTO Student (Student_ID, Student_Name) " +
                                   "VALUES (@ID, @Name)";
            SqlCommand command = new SqlCommand(insertCommand);

            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = objIN.ID;
            SqlParameter nameParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 50);
            nameParameter.Value = objIN.Name;
            command.Parameters.Add(idParameter);
            command.Parameters.Add(nameParameter);

            _da.Execute(command);
        }

        public void Delete(int id)
        {
            string insertCommand = "DELETE Student " +
                                   "WHERE Student_ID = @ID";
            SqlCommand command = new SqlCommand(insertCommand);
            SqlParameter idParameter = new SqlParameter("@ID", SqlDbType.Int);
            idParameter.Value = id;

            command.Parameters.Add(idParameter);

            _da.Execute(command);
        }

        public void Update(Student obj)
        {
            string insertCommand = "UPDATE Student SET Student_Name = @Name " +
                                   "WHERE Student_ID = @ID";
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
            SqlCommand command = new SqlCommand("SELECT * FROM Student");
            return _da.Query(command);
           
        }
    }
}
