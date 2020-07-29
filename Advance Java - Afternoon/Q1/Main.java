
/* ---------------------------------------------------------------------------------
Given a path as input, print the count of no. of files in that path location. 
(You can extend your solution by counting directories, sub-directories and printing the count of each) ------------------------------------------------------------------------------ */

import java.io.File;

public class Main
{
    static void Rprint(File[] arr, int level)
    {
        for (File f : arr)
        {
            for (int i = 0; i < level; i++)
                System.out.print("\t");

            if(f.isFile())
                System.out.println(f.getName());

            else if(f.isDirectory())
            {
                System.out.println("[" + f.getName() + "]");
                Rprint(f.listFiles(), level + 1);
            }
        }
    }

    // Driver Method 
    public static void main(String[] args)
    {
        String path = "C:\\Users\\blin\\Desktop\\Assignments\\AU-July-2020\\SQL Concepts - Afternoon";
        File dir = new File(path);

        if(dir.exists() && dir.isDirectory())
        {
            File arr[] = dir.listFiles();

            System.out.println("**********************************************");
            System.out.println("Files from main directory : " + dir);
            System.out.println("**********************************************");

            Rprint(arr, 0);
        }
    }
} 