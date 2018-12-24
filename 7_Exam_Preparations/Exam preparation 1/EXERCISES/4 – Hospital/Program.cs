using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();

        var patients = GetPatient(command);

        var newCommand = Console.ReadLine();

        Print(newCommand, patients);
    }

    private static void Print(string newCommand, List<Patient> patients)
    {

        while (newCommand != "End")
        {
            var newCom = newCommand.Split().ToList();

            if (newCom.Count == 1)
            {

                for (int i = 0; i < patients.Count; i++)
                {

                    if (newCom[0] == patients[i].Department)
                    {
                        Console.WriteLine(patients[i].Name);
                    }
                }
            }

            if (newCom.Count > 1)
            {
                int num = 1;

                bool parsed = int.TryParse(newCom[1], out num);

                if (parsed == false)
                {
                    var list1 = patients.OrderBy(s => s.Name).ToList();

                    for (int i = 0; i < list1.Count; i++)
                    {

                        if (newCom[0] + " " + newCom[1] == list1[i].Doctor)
                        {
                            Console.WriteLine(list1[i].Name);
                        }
                    }
                }

                if (parsed == true)
                {

                    var roomPats = new List<string>();
                    var pats = new List<string>();

                    for (int i = 0; i < patients.Count; i++)
                    {

                        if (num <= 20)
                        {

                            if (newCom[0] == patients[i].Department)
                            {
                                pats.Add(patients[i].Name);
                            }
                        }
                    }

                    for (int i = 0; i < pats.Count; i++)
                    {

                        if (i >= num * 3 - 3 && i < num * 3)
                        {
                            roomPats.Add(pats[i]);
                        }
                    }

                    var p = roomPats.OrderBy(c => c);

                    Console.WriteLine(string.Join("\n", p));
                }
            }

            newCommand = Console.ReadLine();
        }
    }

    private static List<Patient> GetPatient(string command)
    {
        var list = new List<Patient>();

        while (command != "Output")
        {
            var com = command.Split().ToList();

            var name = com[com.Count - 1];
            var department = com[0];
            var doctor = com[1] + " " + com[2];

            var currPatient = new Patient(name, department, doctor);

            list.Add(currPatient);
            command = Console.ReadLine();
        }

        return list;
    }
}

