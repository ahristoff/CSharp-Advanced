
class Patient
{
    public string Name { get; set; }
    public string Department { get; set; }
    public string Doctor { get; set; }

    public Patient(string name, string department, string doctor)
    {
        Name = name;
        Department = department;
        Doctor = doctor;
    }
}

