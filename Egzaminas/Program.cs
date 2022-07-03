using Egzaminas;

#region To do
// Change student creating from by name to by id
#endregion

var schooldService =new SchoolService();
//var departmentName = "Department_Name_1";
//schooldService.CreateDepartment(departmentName);

var departmentName = "Department_Name_3";
var studentName = "Lecture_Name_4";
schooldService.AddLectureToDepartment(departmentName, studentName);

//schooldService.AddStudentToLecture("Student_Name_1", Guid.Parse("F022A7F6-FDB8-4E00-1F89-08DA5CFB02CA"), "Lecture_Name_1");


