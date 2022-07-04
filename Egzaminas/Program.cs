using Egzaminas;


var schoolService = new SchoolService();

#region To do
// Change student creating from by name to by id
#endregion
#region Tasks 1/2/3/4
//schoolService.CreateDepartment("Department_Name");
//schoolService.AddStudentToDepartment("Department_Name", "Student_Name");
//schoolService.AddLectureToDepartment("Department_Name", "Lecture_Name");
#endregion
#region Tasks 5
//schoolService.AddStudentToDepartment("Department_Name_2", "Student_Name_4"); // assing department to student
#endregion
#region 6/7/8
//schoolService.ShowAllStudentsForDepartment("Department_Name_2");
schoolService.ShowAllLecturesForDepartment("Department_Name_1");
#endregion


//var departmentName = "Department_Name_1";
//schooldService.CreateDepartment(departmentName);

//var departmentName = "Department_Name_3";
//var studentName = "Lecture_Name_4";
//schooldService.AddLectureToDepartment(departmentName, studentName);
//var departmentName = "Department_Name_3";
//var studentName = "Stduent_Name_3";
//schoolService.AddStudentToDepartment(departmentName, studentName);

//schooldService.AddStudentToLecture("Student_Name_1", Guid.Parse("F022A7F6-FDB8-4E00-1F89-08DA5CFB02CA"), "Lecture_Name_1");


