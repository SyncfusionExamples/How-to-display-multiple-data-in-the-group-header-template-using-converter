﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace GroupingMultipleData
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        #region Fields

        private ObservableCollection<Employee> employeeInfo;
        Random random = new Random();

        #endregion

        #region Properties

        public ObservableCollection<Employee> EmployeeInfo
        {
            get { return employeeInfo; }
            set
            {
                if (employeeInfo != null)
                {
                    employeeInfo = value;
                    RaisedOnPropertyChanged("EmployeeInfo");
                }
            }
        }

        #endregion

        #region Constructor

        public EmployeeViewModel()
        {
            employeeInfo = new ObservableCollection<Employee>();
            for (int i = 0; i < EmployeeNames.Count(); i++)
            {
                var employee = new Employee();
                employee.EmployeeName = EmployeeNames[i];
                employee.DisplayString = employee.EmployeeName[0].ToString();
                employee.ContactNumber = random.Next(720, 799).ToString() + " - " + random.Next(3010, 3999).ToString();
                var groupdata = new GroupingData();
                groupdata.Level = random.Next(1, 5);
                groupdata.Designation = Desgination[groupdata.Level];
                groupdata.EmployeeImage = ImageSource.FromResource("GroupingMultipleData.Images.Image" + groupdata.Level + ".png");
                groupdata.GroupingImage = ImageSource.FromResource("GroupingMultipleData.Images.Grouping.png");
                employee.GroupingData = groupdata;
                employeeInfo.Add(employee);
            }
        }

        #endregion

        #region Fields

        private string[] Desgination = new string[]
       {
                "Marketing Assistant",
                "Engineering Manager",
                "Senior Tool Designer",
                "Tool Designer",
                "Marketing Manager",
                "Production Supervisor",
                "Design Engineer",
                "Production Technician",
                "Design Engineer",
                "Vice President of Engineering",
                "Production Control Manager",
                "Network Administrator",
                "Stocker",
                "Shipping and Receiving Clerk",
                "Quality Assurance Supervisor",
                "Information Services Manager",
                "Master Scheduler",
                "Marketing Specialist",
                "Recruiter",
                "Maintenance Supervisor",
        };

        string[] EmployeeNames = new string[] {
                "Sean Jacobson",
                "Phyllis Allen",
                "Marvin Allen",
                "Michael Allen",
                "Cecil Allison",
                "Oscar Alpuerto",
                "Sandra Altamirano",
                "Selena Alvarad",
                "Emilio Alvaro",
                "Maxwell Amland",
                "Mae Anderson",
                "Ramona Antrim",
                "Sabria Appelbaum",
                "Hannah Arakawa",
                "Kyley Arbelaez",
                "Tom Johnston",
                "Thomas Armstrong",
                "John Arthur",
                "Chris Ashton",
                "Teresa Atkinson",
                "John Ault",
                "Robert Avalos",
                "Stephen Ayers",
                "Phillip Bacalzo",
                "Gustavo Achong",
                "Catherine Abel",
                "Kim Abercrombie",
                "Humberto Acevedo",
                "Pilar Ackerman",
                "Frances Adams",
                "Margar Smith",
                "Carla Adams",
                "Jay Adams",
                "Ronald Adina",
                "Samuel Agcaoili",
                "James Aguilar",
                "Robert Ahlering",
                "Francois Ferrier",
                "Kim Akers",
                "Lili Alameda",
                "Amy Alberts",
                "Anna Albright",
                "Milton Albury",
                "Paul Alcorn",
                "Gregory Alderson",
                "J. Phillip Alexander",
                "Michelle Alexander",
                "Daniel Blanco",
                "Cory Booth",
                "James Bailey"
        };

        #endregion

        #region Interface Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
