using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace ConsoleApp2
{
    class AOD
    {
        SqlConnection connection;
        string connectionString;
        SqlDataAdapter adapter;
        DataSet dataSet;


        //Creating a connection to Microsoft SQL Server Database
        public AOD()
        { 
            connectionString = "Data Source=LAPTOP-L0UF2JA0\\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True";
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            dataSet = new DataSet();
        }

        //This function displays the content of Country Table
        public void Display_country()
        {
            adapter = new SqlDataAdapter("Select * from dbo.tb_country", connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("ID: " + dataSet.Tables[0].Rows[i]["id"] + "   country Name:" + dataSet.Tables[0].Rows[i]["country"] +"  Is Active : " + dataSet.Tables[0].Rows[i]["active"]);
                }
            }
        }
        //This function displays the content of Capital Table
        public void Display_capital()
        {
            adapter = new SqlDataAdapter("Select * from dbo.tb_capital", connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {

                    Console.WriteLine("Country: " + dataSet.Tables[0].Rows[i]["country_name"] + " Capital:" + dataSet.Tables[0].Rows[i]["country_capital"]);
                }
            }
        }
        //This function accpets some details from the user and adds a new country record using those details and a stored procedure named:'data_ins'
        public void Insert_Into_country()
        {
            string input_id, input_cname;
            //bool active = true;
            Console.WriteLine("\nEnter country Name: ");
            input_cname = Console.ReadLine();
            Console.WriteLine("\nEnter  id: ");
            input_id = Console.ReadLine();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            //set command type as stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            //pass the stored procedure name
            cmd.CommandText = "data_ins";

            //pass the parameter to stored procedure
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.VarChar)).Value = input_id;
            cmd.Parameters.Add(new SqlParameter("@country", SqlDbType.VarChar)).Value = input_cname;
            cmd.Parameters.Add(new SqlParameter("@active", SqlDbType.Bit)).Value = 1;

            //Execute the query
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {

                Console.WriteLine("Data Inserted Successfully");


            }
            else
            {

                Console.WriteLine("Data Not Inserted!!!! Try Again");

            }
        }
        // This function deletes the record of a country by using id as input by calling a stored procedure named: 'data_delete'
        public void Delete_From_country()
        {
            string input_id;
            Console.WriteLine("\nEnter ID of the record to be deleted: ");
            input_id = Console.ReadLine();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            //set command type as stored procedure
            cmd.CommandType = CommandType.StoredProcedure;

            //pass the stored procedure name
            cmd.CommandText = "data_delete";

            //pass the parameter to stored procedure
            cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = input_id;
            //Execute the query
            int res = cmd.ExecuteNonQuery();
            if (res != 0)
            {
                Console.WriteLine("\nData Deleted Successfully\n");
            }
            else
            {
                Console.WriteLine("\nData Deletion Failed\n");
            }

        }


        //This function access the contents of 2 tables using a stored procedure named:'data_combine'
        //It displays the country and its capital
        public void Multiple_table()
        {
            string sqlQuery = "execute data_combine;";
            adapter = new SqlDataAdapter(sqlQuery, connection);
            dataSet = new DataSet();
            adapter.Fill(dataSet);
            if (dataSet != null)
            {
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
                {
                    Console.WriteLine("Country Name:" + dataSet.Tables[0].Rows[i]["country"] + " found capital: " + dataSet.Tables[0].Rows[i]["country_capital"]);
                }
            }
        }

        //Destructor closes connection to the database
        ~AOD()
        {
            connection.Close();
        }

    }

    //This classes calls and uses data access functions of the above class 'AOD'
    class Program
    {

        //Main Function
        static void Main(string[] args)
        {
            AOD obj = new AOD();
            Console.WriteLine("==================================\n");
            obj.Display_country();
            obj.Insert_Into_country();
            obj.Display_country();
            Console.WriteLine("\n===================================\n");
            obj.Delete_From_country();
            Console.WriteLine("\n===================================\n");
            obj.Display_country();
            obj.Display_capital();
            Console.WriteLine("\n===================================\n");
            obj.Multiple_table();
        }
    }
}

