using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDandGCAssignment
{
    internal class SOLIDprinciple
    {
       //clinic appointment booking system
       
        // Single responsibility principle
        //appointment service clss just handle bokk appointment
        class AppointmentService
        {
            IAppointmentRepository _repository;
            INotifier _notifier;

            public AppointmentService(
                IAppointmentRepository repository,
                INotifier notifier)
            {
                _repository = repository;
                _notifier = notifier;
            }

            public void BookAppointment()
            {
                _repository.Save();
                _notifier.Notify();
            }
        }

        
        // Open / closed principle 
       
        interface INotifier
        {
            void Notify();
        }

        //can extend inotifier but can not mopify it
        class EmailNotifier : INotifier
        {
            public void Notify()
            {
                Console.WriteLine("Email notification sent");
            }
        }

        class SmsNotifier : INotifier
        {
            public void Notify()
            {
                Console.WriteLine("SMS notification sent");
            }
        }

        // liskov substitution principle
      
        abstract class Doctor
        {
            public abstract void Consult();
        }


        //all child class can override parant method
        class GeneralPhysician : Doctor
        {
            public override void Consult()
            {
                Console.WriteLine("General consultation");
            }
        }

        class Dentist : Doctor
        {
            public override void Consult()
            {
                Console.WriteLine("Dental consultation");
            }
        }


        //interface segaregation principle

        //seperate interfacec for consultation and appointment management
        interface IConsultation
        {
            void ConsultPatient();
        }

        interface IAppointmentManagement
        {
            void ManageAppointments();
        }

        class DoctorStaff : IConsultation
        {
            public void ConsultPatient()
            {
                Console.WriteLine("Doctor consulting patient");
            }
        }

        class Receptionist : IAppointmentManagement
        {
            public void ManageAppointments()
            {
                Console.WriteLine("Receptionist managing appointments");
            }
        }


        //dependancy inversion principle
        interface IAppointmentRepository
        {
            void Save();
        }

        class SqlAppointmentRepository : IAppointmentRepository
        {
            public void Save()
            {
                Console.WriteLine("Appointment saved to database");
            }
        }

        
        class Program
        {
            static void Main(string[] args)
            {

                // DIP implememnted
                IAppointmentRepository repository = new SqlAppointmentRepository();
                INotifier notifier = new EmailNotifier();

                AppointmentService service =
                    new AppointmentService(repository, notifier);

                service.BookAppointment();

                // LSP implemented
                Doctor doctor = new Dentist();
                doctor.Consult();

                Console.ReadLine();
            }
        }
    }

}

