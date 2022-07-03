using Egzaminas;

var schooldService =new SchoolService();
//var departmentName = "Department_Name_1";
//schooldService.CreateDepartment(departmentName);

var departmentId = Guid.Parse("F39F7017-7722-4EEF-B41B-08DA5CE81010");
var studentName = "Student_Name_1";
schooldService.AddStudentToDepartment(departmentId, studentName);


