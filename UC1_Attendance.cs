﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageComp
{
    class UC1_Attendance
    {
        //UC1
        public static void GetAttendance()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee is present");
            else

                Console.WriteLine("Employee is absent");

        }


    }
}