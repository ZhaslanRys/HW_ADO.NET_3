using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ADO.NET_3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection =
               new SqlConnection("Data Source=SQL;" +
                                 "Database=ADO_NET;" +
                                 "Integrated Security=true;"))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.CommandText = "create table Gruppa (id int not null , name varchar(200) not null)";
                
                command.ExecuteNonQuery();

                Console.ReadLine();
            }
        }
    }
}
