using Egzaminas;

var schoolService = new SchoolService();

#region To do
// Change student creating from by name to by id
//writelines only in program.cs
#endregion
#region 1 Sukurti departamentą ir į jį pridėti studentus, paskaitas(papildomi points jei pridedamos paskaitos jau egzistuojančios duomenų bazėje).

//schoolService.CreateDepartment("Department_Name_4");
//schoolService.AddStudentToDepartment("Department_Name", "Student_Name");
//schoolService.AddLectureToDepartment("Department_Name", "Lecture_Name");
#endregion
#region 2 Pridėti studentus/paskaitas į jau egzistuojantį departamentą.
//schoolService.AddStudentToDepartment("Department_Name", "Student_Name");

#endregion
#region 3 Sukurti paskaitą ir ją priskirti prie departamento.

//schoolService.AddLectureToDepartment("Department_Name", "Lecture_Name");

#endregion
#region 4 Sukurti studentą, jį pridėti prie egzistuojančio departamento ir priskirti jam egzistuojančias paskaitas.

//schoolService.AddStudentToDepartment("Department_Name_1", "Student_Name_5");

#endregion
#region 5 Perkelti studentą į kitą departamentą(bonus points jei pakeičiamos ir jo paskaitos).
//schoolService.AddStudentToDepartment("Department_Name_2", "Student_Name_4"); // assing department to student

#endregion
#region 6 Atvaizduoti visus departamento studentus.
//schoolService.ShowAllStudentsForDepartment("Department_Name_2");
#endregion
#region 7 Atvaizduoti visas departamento paskaitas.
//schoolService.ShowAllLecturesForDepartment("Department_Name_1");
#endregion
#region 8 Atvaizduoti visas paskaitas pagal studentą.
schoolService.ShowAllLecturesForStudent(Guid.Parse("6638C1D3-1097-4502-BC62-08DA5EA82164"));
#endregion




//var departmentName = "Department_Name_1";
//schooldService.CreateDepartment(departmentName);

//var departmentName = "Department_Name_3";
//var studentName = "Lecture_Name_4";
//schooldService.AddLectureToDepartment(departmentName, studentName);
//var departmentName = "Department_Name_3";
//var studentName = "Stduent_Name_3";
//schoolService.AddStudentToDepartment(departmentName, studentName);

//schooldService.AddStudentToLecture("Student_Name_1", "Lecture_Name_1");


