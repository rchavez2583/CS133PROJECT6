using System;
using System.Collections.Generic;

namespace CS133PROJECT6
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital myHospital = new Hospital();

            myHospital.AddPeopleIntoTheQueue("First Patient " +
                "                           (Appointment at 3:45 P.M) ");
            myHospital.AddPeopleIntoTheQueue("Second Patient (Appointment at 4:00 P.M) ");
            myHospital.AddPeopleIntoTheQueue("Third Patient (Appointment at 4:15 P.M) ");
            myHospital.AddPeopleIntoTheQueue("Fourth Patient (Appointment at 4:30 P.M) ");
            myHospital.AddPeopleIntoTheQueue("Fifth Patient (Appointment at 4:45 P.M)");

            

            myHospital.PatientAppointment();

            myHospital.ShowMeTheActualPatients();
        }   
    }
}
public class Hospital
{
    private Queue<string> waitinQueue = new Queue<string>();

    public void AddPeopleIntoTheQueue(string parameter)
    {
        waitinQueue.Enqueue(parameter);
    }

    public void ShowMeHowManyPatientsIHave()
    {
        Console.WriteLine(" I have these many Patients: " +
                          waitinQueue.Count +
                          " Patients ");
    }

    public void ShowMeTheActualPatients()
    {
        foreach(var item in waitinQueue)
        {
            Console.WriteLine("Patient: " + item);
        }
    }

    public void PatientAppointment()
    {
        waitinQueue.Dequeue();
    }
}







