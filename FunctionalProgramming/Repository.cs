using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml;

namespace FunctionalProgramming
{
    public static class Repository
    {

        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee> 
            {
                new Employee
                {
                        Id = 1001,
                        FirstName = "Cochran",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m
                },
                new Employee
                {
                        Id = 1006,
                        FirstName = "Acevedo",
                        LastName = "Wall",
                        HireDate = new DateTime(2020, 10, 30),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343700m
                },
                new Employee
                {
                        Id = 1007,
                        FirstName = "Jacqueline",
                        LastName = "Pickett",
                        HireDate = new DateTime(2021, 2, 17),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 370000m
                },
                new Employee
                {
                        Id = 1008,
                        FirstName = "Oconnor",
                        LastName = "Espinoza",
                        HireDate = new DateTime(2017, 3, 12),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 155600m
                },
                new Employee
                {
                        Id = 1009,
                        FirstName = "Allie",
                        LastName = "Elliott",
                        HireDate = new DateTime(2020, 4, 20),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 315400m
                },
                new Employee
                {
                        Id = 1010,
                        FirstName = "Elva",
                        LastName = "Decker",
                        HireDate = new DateTime(2016, 9, 6),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 345900m
                },
                new Employee
                {
                        Id = 1011,
                        FirstName = "Hayes",
                        LastName = "Beasley",
                        HireDate = new DateTime(2020, 4, 25),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 372700m
                },
                new Employee
                {
                        Id = 1012,
                        FirstName = "Florine",
                        LastName = "Cervantes",
                        HireDate = new DateTime(2015, 3, 25),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 338700m
                },
                new Employee
                {
                        Id = 1013,
                        FirstName = "Bullock",
                        LastName = "Carney",
                        HireDate = new DateTime(2017, 1, 3),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 214400m
                },
                new Employee
                {
                        Id = 1014,
                        FirstName = "Carroll",
                        LastName = "Cantu",
                        HireDate = new DateTime(2021, 5, 26),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343200m
                },
                new Employee
                {
                        Id = 1015,
                        FirstName = "Debra",
                        LastName = "Hogan",
                        HireDate = new DateTime(2019, 10, 4),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 249100m
                },
                new Employee
                {
                        Id = 1016,
                        FirstName = "Winnie",
                        LastName = "Mccall",
                        HireDate = new DateTime(2019, 7, 17),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 287300m
                },
                new Employee
                {
                        Id = 1017,
                        FirstName = "Manuela",
                        LastName = "Berger",
                        HireDate = new DateTime(2015, 12, 11),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 172500m
                },
                new Employee
                {
                        Id = 1018,
                        FirstName = "Lakeisha",
                        LastName = "Lowe",
                        HireDate = new DateTime(2017, 1, 18),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 314300m
                },
                new Employee
                {
                        Id = 1019,
                        FirstName = "Stewart",
                        LastName = "Lott",
                        HireDate = new DateTime(2016, 12, 12),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 146600m
                },
                new Employee
                {
                        Id = 1020,
                        FirstName = "Stafford",
                        LastName = "Peck",
                        HireDate = new DateTime(2014, 9, 25),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 320700m
                },
                new Employee
                {
                        Id = 1021,
                        FirstName = "Barron",
                        LastName = "Bird",
                        HireDate = new DateTime(2020, 5, 18),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 151200m
                },
                new Employee
                {
                        Id = 1022,
                        FirstName = "Nona",
                        LastName = "Brooks",
                        HireDate = new DateTime(2015, 12, 4),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 136500m
                },
                new Employee
                {
                        Id = 1023,
                        FirstName = "Clara",
                        LastName = "Reeves",
                        HireDate = new DateTime(2014, 12, 6),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 245800m
                },
                new Employee
                {
                        Id = 1024,
                        FirstName = "Karin",
                        LastName = "Blanchard",
                        HireDate = new DateTime(2018, 1, 20),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 341200m
                },
                new Employee
                {
                        Id = 1025,
                        FirstName = "Burris",
                        LastName = "Morgan",
                        HireDate = new DateTime(2019, 7, 6),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 360300m
                },
                new Employee
                {
                        Id = 1026,
                        FirstName = "Owen",
                        LastName = "Cortez",
                        HireDate = new DateTime(2021, 12, 9),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 193700m
                },
                new Employee
                {
                        Id = 1027,
                        FirstName = "Letha",
                        LastName = "Finch",
                        HireDate = new DateTime(2016, 12, 18),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 357200m
                },
                new Employee
                {
                        Id = 1028,
                        FirstName = "Sondra",
                        LastName = "Rojas",
                        HireDate = new DateTime(2016, 4, 22),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 309700m
                },
                new Employee
                {
                        Id = 1029,
                        FirstName = "Hoover",
                        LastName = "Cook",
                        HireDate = new DateTime(2020, 12, 17),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 282200m
                },
                new Employee
                {
                        Id = 1030,
                        FirstName = "Wanda",
                        LastName = "Bender",
                        HireDate = new DateTime(2021, 6, 17),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 294200m
                },
                new Employee
                {
                        Id = 1031,
                        FirstName = "Sanford",
                        LastName = "Craig",
                        HireDate = new DateTime(2020, 2, 27),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 278200m
                },
                new Employee
                {
                        Id = 1032,
                        FirstName = "Christy",
                        LastName = "Middleton",
                        HireDate = new DateTime(2021, 4, 2),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 377400m
                },
                new Employee
                {
                        Id = 1033,
                        FirstName = "Day",
                        LastName = "Brady",
                        HireDate = new DateTime(2019, 1, 23),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 142600m
                },
                new Employee
                {
                        Id = 1034,
                        FirstName = "Powers",
                        LastName = "Beard",
                        HireDate = new DateTime(2014, 4, 25),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 224000m
                },
                new Employee
                {
                        Id = 1035,
                        FirstName = "Arline",
                        LastName = "Pratt",
                        HireDate = new DateTime(2017, 8, 12),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 360300m
                },
                new Employee
                {
                        Id = 1036,
                        FirstName = "Sharpe",
                        LastName = "Cardenas",
                        HireDate = new DateTime(2017, 11, 28),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 266100m
                },
                new Employee
                {
                        Id = 1037,
                        FirstName = "Madeleine",
                        LastName = "Stanton",
                        HireDate = new DateTime(2020, 7, 17),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 198300m
                },
                new Employee
                {
                        Id = 1038,
                        FirstName = "Spears",
                        LastName = "Noble",
                        HireDate = new DateTime(2014, 10, 6),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 176300m
                },
                new Employee
                {
                        Id = 1039,
                        FirstName = "Gonzalez",
                        LastName = "Gilliam",
                        HireDate = new DateTime(2021, 4, 29),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 394300m
                },
                new Employee
                {
                        Id = 1040,
                        FirstName = "Abigail",
                        LastName = "Bradford",
                        HireDate = new DateTime(2018, 4, 2),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 296100m
                },
                new Employee
                {
                        Id = 1041,
                        FirstName = "Ashlee",
                        LastName = "Farmer",
                        HireDate = new DateTime(2020, 9, 24),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 125300m
                },
                new Employee
                {
                        Id = 1042,
                        FirstName = "Glover",
                        LastName = "Lloyd",
                        HireDate = new DateTime(2014, 2, 15),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 123000m
                },
                new Employee
                {
                        Id = 1043,
                        FirstName = "Cleo",
                        LastName = "Mays",
                        HireDate = new DateTime(2018, 4, 24),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 214900m
                },
                new Employee
                {
                        Id = 1044,
                        FirstName = "Patrice",
                        LastName = "House",
                        HireDate = new DateTime(2021, 10, 16),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 124500m
                },
                new Employee
                {
                        Id = 1045,
                        FirstName = "Atkins",
                        LastName = "Shannon",
                        HireDate = new DateTime(2015, 9, 26),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 136600m
                },
                new Employee
                {
                        Id = 1046,
                        FirstName = "Luisa",
                        LastName = "Hopkins",
                        HireDate = new DateTime(2016, 8, 1),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 192900m
                },
                new Employee
                {
                        Id = 1047,
                        FirstName = "Kaufman",
                        LastName = "Gross",
                        HireDate = new DateTime(2016, 7, 24),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 223600m
                },
                new Employee
                {
                        Id = 1048,
                        FirstName = "William",
                        LastName = "Clay",
                        HireDate = new DateTime(2014, 8, 24),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 237500m
                },
                new Employee
                {
                        Id = 1049,
                        FirstName = "Alison",
                        LastName = "Kirby",
                        HireDate = new DateTime(2014, 7, 14),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 354800m
                },
                new Employee
                {
                        Id = 1050,
                        FirstName = "Morrow",
                        LastName = "Lynch",
                        HireDate = new DateTime(2014, 6, 4),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 281400m
                },
                new Employee
                {
                        Id = 1051,
                        FirstName = "Roach",
                        LastName = "Bright",
                        HireDate = new DateTime(2019, 9, 14),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 326700m
                },
                new Employee
                {
                        Id = 1052,
                        FirstName = "Carolyn",
                        LastName = "Justice",
                        HireDate = new DateTime(2019, 8, 29),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 143100m
                },
                new Employee
                {
                        Id = 1053,
                        FirstName = "Cathryn",
                        LastName = "Mathews",
                        HireDate = new DateTime(2016, 5, 31),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 366000m
                },
                new Employee
                {
                        Id = 1054,
                        FirstName = "Lindsay",
                        LastName = "Pruitt",
                        HireDate = new DateTime(2016, 6, 9),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 107300m
                },
                new Employee
                {
                        Id = 1055,
                        FirstName = "Cummings",
                        LastName = "Webster",
                        HireDate = new DateTime(2016, 1, 24),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 222700m
                },
                new Employee
                {
                        Id = 1056,
                        FirstName = "Cannon",
                        LastName = "Pace",
                        HireDate = new DateTime(2017, 7, 29),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 345000m
                },
                new Employee
                {
                        Id = 1057,
                        FirstName = "Barber",
                        LastName = "Singleton",
                        HireDate = new DateTime(2017, 5, 8),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 192400m
                },
                new Employee
                {
                        Id = 1058,
                        FirstName = "Aileen",
                        LastName = "Sweet",
                        HireDate = new DateTime(2018, 7, 4),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 262400m
                },
                new Employee
                {
                        Id = 1059,
                        FirstName = "Lindsey",
                        LastName = "Hughes",
                        HireDate = new DateTime(2014, 4, 26),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 370000m
                },
                new Employee
                {
                        Id = 1060,
                        FirstName = "Stout",
                        LastName = "Phillips",
                        HireDate = new DateTime(2019, 6, 19),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 151000m
                },
                new Employee
                {
                        Id = 1061,
                        FirstName = "Benjamin",
                        LastName = "Stephens",
                        HireDate = new DateTime(2021, 5, 7),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 399600m
                },
                new Employee
                {
                        Id = 1062,
                        FirstName = "Mandy",
                        LastName = "Odom",
                        HireDate = new DateTime(2018, 10, 28),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 226400m
                },
                new Employee
                {
                        Id = 1063,
                        FirstName = "Hays",
                        LastName = "Austin",
                        HireDate = new DateTime(2017, 5, 28),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 292000m
                },
                new Employee
                {
                        Id = 1064,
                        FirstName = "Jean",
                        LastName = "Salas",
                        HireDate = new DateTime(2020, 10, 27),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 211600m
                },
                new Employee
                {
                        Id = 1065,
                        FirstName = "Luann",
                        LastName = "Hubbard",
                        HireDate = new DateTime(2021, 7, 17),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 301600m
                },
                new Employee
                {
                        Id = 1066,
                        FirstName = "Eaton",
                        LastName = "Lyons",
                        HireDate = new DateTime(2021, 7, 3),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 237600m
                },
                new Employee
                {
                        Id = 1067,
                        FirstName = "Beck",
                        LastName = "Ortiz",
                        HireDate = new DateTime(2015, 5, 13),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192900m
                },
                new Employee
                {
                        Id = 1068,
                        FirstName = "Patty",
                        LastName = "Knight",
                        HireDate = new DateTime(2017, 8, 22),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 173100m
                },
                new Employee
                {
                        Id = 1069,
                        FirstName = "Bowman",
                        LastName = "Hampton",
                        HireDate = new DateTime(2017, 10, 10),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 145200m
                },
                new Employee
                {
                        Id = 1070,
                        FirstName = "Pace",
                        LastName = "Bryant",
                        HireDate = new DateTime(2019, 3, 1),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 160100m
                },
                new Employee
                {
                        Id = 1071,
                        FirstName = "Watts",
                        LastName = "Green",
                        HireDate = new DateTime(2016, 10, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 330300m
                },
                new Employee
                {
                        Id = 1072,
                        FirstName = "Sonia",
                        LastName = "Clarke",
                        HireDate = new DateTime(2014, 9, 15),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 201800m
                },
                new Employee
                {
                        Id = 1073,
                        FirstName = "Donovan",
                        LastName = "Brennan",
                        HireDate = new DateTime(2018, 5, 18),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 243600m
                },
                new Employee
                {
                        Id = 1074,
                        FirstName = "Rutledge",
                        LastName = "Harris",
                        HireDate = new DateTime(2016, 7, 10),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 153300m
                },
                new Employee
                {
                        Id = 1075,
                        FirstName = "Buckley",
                        LastName = "Meyers",
                        HireDate = new DateTime(2021, 10, 16),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 342000m
                },
                new Employee
                {
                        Id = 1076,
                        FirstName = "Reynolds",
                        LastName = "Hammond",
                        HireDate = new DateTime(2019, 10, 9),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 232600m
                },
                new Employee
                {
                        Id = 1077,
                        FirstName = "Butler",
                        LastName = "Bowen",
                        HireDate = new DateTime(2019, 8, 13),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 239100m
                },
                new Employee
                {
                        Id = 1078,
                        FirstName = "Karina",
                        LastName = "Miles",
                        HireDate = new DateTime(2018, 11, 20),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 185500m
                },
                new Employee
                {
                        Id = 1079,
                        FirstName = "Fulton",
                        LastName = "Conner",
                        HireDate = new DateTime(2018, 7, 12),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 198100m
                },
                new Employee
                {
                        Id = 1080,
                        FirstName = "Jewell",
                        LastName = "Tran",
                        HireDate = new DateTime(2019, 6, 22),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 264800m
                },
                new Employee
                {
                        Id = 1081,
                        FirstName = "Avis",
                        LastName = "Herrera",
                        HireDate = new DateTime(2017, 11, 17),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 298800m
                },
                new Employee
                {
                        Id = 1082,
                        FirstName = "Nora",
                        LastName = "Dale",
                        HireDate = new DateTime(2021, 7, 26),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 368900m
                },
                new Employee
                {
                        Id = 1083,
                        FirstName = "Hillary",
                        LastName = "Duran",
                        HireDate = new DateTime(2017, 2, 19),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 282200m
                },
                new Employee
                {
                        Id = 1084,
                        FirstName = "Hamilton",
                        LastName = "Macias",
                        HireDate = new DateTime(2017, 10, 21),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 237300m
                },
                new Employee
                {
                        Id = 1085,
                        FirstName = "Kent",
                        LastName = "Parsons",
                        HireDate = new DateTime(2018, 3, 30),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 176400m
                },
                new Employee
                {
                        Id = 1086,
                        FirstName = "Dunn",
                        LastName = "Oliver",
                        HireDate = new DateTime(2018, 9, 3),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 244400m
                },
                new Employee
                {
                        Id = 1087,
                        FirstName = "Betsy",
                        LastName = "Dean",
                        HireDate = new DateTime(2018, 11, 23),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 196900m
                },
                new Employee
                {
                        Id = 1088,
                        FirstName = "Kay",
                        LastName = "May",
                        HireDate = new DateTime(2020, 9, 8),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 224000m
                },
                new Employee
                {
                        Id = 1089,
                        FirstName = "Farley",
                        LastName = "Bartlett",
                        HireDate = new DateTime(2014, 7, 3),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 369600m
                },
                new Employee
                {
                        Id = 1090,
                        FirstName = "Agnes",
                        LastName = "Riggs",
                        HireDate = new DateTime(2016, 11, 20),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 106800m
                },
                new Employee
                {
                        Id = 1091,
                        FirstName = "White",
                        LastName = "Figueroa",
                        HireDate = new DateTime(2014, 6, 30),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 226400m
                },
                new Employee
                {
                        Id = 1092,
                        FirstName = "Estes",
                        LastName = "Stone",
                        HireDate = new DateTime(2016, 7, 10),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 293800m
                },
                new Employee
                {
                        Id = 1093,
                        FirstName = "Julia",
                        LastName = "Contreras",
                        HireDate = new DateTime(2017, 7, 1),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 203800m
                },
                new Employee
                {
                        Id = 1094,
                        FirstName = "Cecilia",
                        LastName = "Cooper",
                        HireDate = new DateTime(2017, 3, 31),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 329400m
                },
                new Employee
                {
                        Id = 1095,
                        FirstName = "Zelma",
                        LastName = "Frank",
                        HireDate = new DateTime(2015, 11, 29),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 311100m
                },
                new Employee
                {
                        Id = 1096,
                        FirstName = "Peters",
                        LastName = "Morales",
                        HireDate = new DateTime(2021, 5, 19),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 120300m
                },
                new Employee
                {
                        Id = 1097,
                        FirstName = "Leigh",
                        LastName = "Moss",
                        HireDate = new DateTime(2016, 8, 2),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 167100m
                },
                new Employee
                {
                        Id = 1098,
                        FirstName = "Megan",
                        LastName = "Bailey",
                        HireDate = new DateTime(2014, 3, 4),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 232500m
                },
                new Employee
                {
                        Id = 1099,
                        FirstName = "Juliana",
                        LastName = "Pope",
                        HireDate = new DateTime(2020, 7, 3),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 305300m
                },
                new Employee
                {
                        Id = 1100,
                        FirstName = "Cervantes",
                        LastName = "Wong",
                        HireDate = new DateTime(2019, 11, 8),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 235100m
                }
            };
        } 
    }
}
