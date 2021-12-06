using System;

namespace ClinicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // 5:
            Doctor[] persons = new Doctor[] { new Doctor(100, 1995, "doctorOne", "lastNAME", "general"),
                new Doctor(150, 2020, "doctorOne", "lastNAME", "general"),
                new Doctor(1000, 1986, "doctorOne", "lastNAME", "general") };

            //Array.Sort(persons);

            //Console.WriteLine(persons[0].YearOfBirth);

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine(persons[i].NumberOfPatient);
            //}

            List<Doctor> listOfDoctors = new List<Doctor>();
            MenuFun(listOfDoctors);
            int counter;




        }


        static void MenuFun(List<Doctor> listOfDoctors)
        {
            Console.WriteLine("Hello , please select option");
            Console.WriteLine("1.Add Doctor");
            Console.WriteLine("2.Doctor Info");
            Console.WriteLine("3.Add Patient to specific Doctor");
            Console.WriteLine("4.Show all Doctor");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    AddDoctor(listOfDoctors);
                    break;

                case 2:
                    Console.WriteLine("please Enter Doctor Name:");
                    string doctorName = Console.ReadLine();
                    ShowDoctorInfo(doctorName);
                    break;

                case 3:
                    Console.WriteLine("please Enter Doctor Name:");
                    string doctorNameToGetInto = Console.ReadLine();
                    //specificDoctor(doctorNameToGetInto , persons[]);
                    break;

                case 4:
                    ShowDoctorInfo("allDoctors");
                    break;

                default:
                    Console.WriteLine("Something went wrong");
                    MenuFun(listOfDoctors);
                    break;
            }
        }


        static void AddDoctor(List<Doctor> listOfDoctors)
        {
            Console.WriteLine("please fill Patient number , Year Of Birth , first Name , Last Name , and Section");
            int patientnumberUser = int.Parse(Console.ReadLine());
            int yearOfBirthUser = int.Parse(Console.ReadLine());
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            string part = Console.ReadLine();


            Doctor addDocterOne = new Doctor(patientnumberUser, yearOfBirthUser, fName, lName, part);

            listOfDoctors.Add(addDocterOne);

            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\06.12.2021\Files\{addDocterOne.FirstName}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStream))
            {
                writer.WriteLine($"Dr.{addDocterOne.FirstName} {addDocterOne.LastName} From dep:{addDocterOne.Part} , birth:{addDocterOne.YearOfBirth},number of Patients:{addDocterOne.NumberOfPatient}, ");
            }



            FileStream fileStreamToAll = new FileStream(@"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\06.12.2021\Files\allDoctors.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStreamToAll))
            {
                writer.WriteLine($"Dr.{addDocterOne.FirstName} {addDocterOne.LastName} From dep:{addDocterOne.Part} , birth:{addDocterOne.YearOfBirth},number of Patients:{addDocterOne.NumberOfPatient}, ");

            }
        }

        static void specificDoctor(string DoctorName, Doctor[] listOfDoctors)
        {
            int patientnumberUser = int.Parse(Console.ReadLine());
            int yearOfBirthUser = int.Parse(Console.ReadLine());
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            string part = Console.ReadLine();


            Doctor addDocterOne = new Doctor(patientnumberUser, yearOfBirthUser, fName, lName, part);
            FileStream fileStreamToAll = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\06.12.2021\Files\{DoctorName}.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fileStreamToAll))
            {
                writer.WriteLine($"Dr.{addDocterOne.FirstName} {addDocterOne.LastName} From dep:{addDocterOne.Part} , birth:{addDocterOne.YearOfBirth},number of Patients:{addDocterOne.NumberOfPatient}, ");

            }
            Array.Sort(listOfDoctors);
            Console.WriteLine(listOfDoctors);

        }
        static void ShowDoctorInfo(string doctorName)
        {
            FileStream fileStream = new FileStream(@$"C:\Users\edent\OneDrive\שולחן העבודה\טק קריירה\C#\06.12.2021\Files\{doctorName}.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }


        static void DiaryFunction()
        {
            int[,] Diary = new int[4, 7];
            Random randomNumber = new Random();
            int randomNumberUntill10 = randomNumber.Next(1, 10);
            for (int i = 0; i < Diary.GetLength(0); i++)
            {
                for (int j = 0; j < Diary.GetLength(1); j++)
                {
                    if (j==6)
                    {
                        Diary[i, j] = 0;
                    }
                    else
                    {
                        Diary[i,j] = randomNumberUntill10;
                    }
                }
            }
        }


    }



}