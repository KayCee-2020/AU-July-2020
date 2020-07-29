package com.company;
import java.sql.*;
import org.dom4j.io.SAXReader;
import org.dom4j.*;
import java.io.File;
import java.util.*;

public class Main {

    private static final String CREATE_TABLE_SQL="CREATE TABLE khushbu.student ("
            + "ID INT NOT NULL PRIMARY KEY,"
            + "NAME VARCHAR(50),"
            + "SURNAME VARCHAR(50),"
            + "GENDER VARCHAR(45) NOT NULL,"
            + "MARKS FLOAT)";

    public static void addValue(Connection con,int Id, String Fname, String Mname, String Lname,String Gender, float Marks)
    {
        try {

            PreparedStatement stmt = con.prepareStatement("insert into student values (?,?,?,?,?)");
            stmt.setInt(1, Id);
            stmt.setString(2, Fname+" "+Mname);
            stmt.setString(3, Lname);
            stmt.setString(4, Gender);
            stmt.setFloat(5, Marks);
            if(stmt.executeUpdate()>0)
                System.out.println("Student Record Inserted\n");
            else
                System.out.println("Insertion Failed");

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    public static void main(String[] args) {

        String JDBC_DRIVER = "com.mysql.jdbc.Driver";
        String DB_URL = "jdbc:mysql://localhost:3306/khushbu";
        String USER = "root";
        String PASS = "1234";
        Connection conn = null;
        Statement stmt = null;
        String Fname=null;
        String Mname=null;
        String Lname=null;
        String Gender=null;
        int Rno=0;
        float Marks=0;

        try {

            conn = DriverManager.getConnection(DB_URL,USER,PASS);
            stmt = conn.createStatement();

            stmt.executeUpdate(CREATE_TABLE_SQL);
            stmt.executeUpdate("use khushbu;");

            System.out.println("Table created");

            File xmlfile = new File("Input_file/input.txt");
            SAXReader saxReader = new SAXReader();
            Document document = saxReader.read(xmlfile);
            List<Node> nodes = document.selectNodes("/class/student");

            for (Node node : nodes) {
                Rno = Integer.parseInt(node.valueOf("@rollno"));
                Fname = node.selectSingleNode("name/firstname").getText();
                Mname = node.selectSingleNode("name/middlename").getText();
                Lname = node.selectSingleNode("name/lastname").getText();
                Gender = node.selectSingleNode("gender").getText();
                Marks = Float.parseFloat(node.selectSingleNode("marks").getText());
            }
            addValue(conn,Rno,Fname,Mname,Lname,Gender,Marks);
            System.out.println("One record Added");


        } catch (SQLException | DocumentException e) {
            e.printStackTrace();
        }finally {
            try {
                // Close connection
                if (stmt != null) {
                    stmt.close();
                }
                if (conn != null) {
                    conn.close();
                }
            } catch (Exception e) {
                e.printStackTrace();
            }
        }

    }
}