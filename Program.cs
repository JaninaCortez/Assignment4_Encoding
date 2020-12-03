using Open.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenXML.Models.Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create destination for myimage.jpg
            string imagesOutputFolder = @"C:\Users\corte\source\repos\FTPApp\Content\Image";
            List<Student> students = new List<Student>();
            //Retrieve directory
            List<string> directories = FTP.GetDirectory(Constants.FTP.BaseUrl);
            //Output directory to console
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);

                //Creates a blank student object
                Student student = new Student();
                student.FromDirectory(directory);                
                }
            }
        }
    }

