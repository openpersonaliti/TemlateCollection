﻿using Eleven_collection_.DefaultPersonInfo;
using Eleven_collection_.MenuClasses;
using Eleven_collection_.PersonObjects;

namespace Eleven_collection_.CallMethodsOfPersons
{
    public class EmployeMethodsCallinger : Person
    {
        public EmployeMethodsCallinger()
        {
            objectName = "СОТРУДНИКОВ";
            idefaultinformatable = new EmployeDefaultInformator();
            imenu = new MenuEmployer();
        }
    }
}
