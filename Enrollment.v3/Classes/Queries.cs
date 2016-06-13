using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrollment.Classes
{
    public class Queries
    {
        private static Dictionary<String, String> Qrys = new Dictionary<String, String>()
        {
            // user accounts
            {"USER_CREATE",             "INSERT INTO tbl_users VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', 0, 0);"},
            {"USER_DATA",               "SELECT * FROM tbl_users WHERE UserID = '{0}';"},
            {"USER_LOGIN_DATA",         "SELECT * FROM tbl_users WHERE Username = '{0}';"},
            {"USER_LOGIN_USER",         "UPDATE tbl_users SET LoginStatus = 1 WHERE UserID = '{0}';"},
            {"USER_LOGOUT_USER",        "UPDATE tbl_users SET LoginStatus = 0 WHERE UserID = '{0}';"},
            {"USER_UPDATEINFO",         "UPDATE tbl_users SET LastName = '{1}', FirstName = '{2}', MiddleName = '{3}', Address = '{4}', EmailAddress = '{5}', ContactNo = '{6}' WHERE UserID = '{0}';"},
            {"USER_CHANGEPW",           "UPDATE tbl_users SET Password = '{1}' WHERE Username = '{0}';"},
            {"USER_CHANGEPW_LOG",       "INSERT INTO tbl_pwchangelogs(UserID, LastChanged) VALUES('{0}', NOW()) ON DUPLICATE KEY UPDATE LastChanged=VALUES(LastChanged);"},
            {"USER_UPDATELEVEL",        "UPDATE tbl_users SET UserLevel = '{1}' WHERE UserID = '{0}';"},
            {"USER_RECORDS_ALL",        "SELECT UserID, Username, CONCAT(LastName,', ',FirstName,' ',SUBSTRING(MiddleName,1,1),'.') AS FullName, EmailAddress, CASE AccessLevel WHEN 'A' THEN 'Administrator' WHEN 'S' THEN 'Staff' END AS UserLevel FROM tbl_users;"},
            {"USER_RECORDS_SIMPLE",     "SELECT tbl_users.Username, CONCAT(tbl_users.LastName,', ',tbl_users.FirstName,' ',SUBSTRING(tbl_users.MiddleName,1,1),'.') AS FullName, CASE tbl_users.AccountStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'Inactive' END AS Status, tbl_pwchangelogs.LastChanged FROM tbl_users LEFT JOIN tbl_pwchangelogs ON tbl_users.UserID = tbl_pwchangelogs.UserID;"},
            {"USER_RECORDS_SIMPLE_FIND","SELECT tbl_users.Username, CONCAT(tbl_users.LastName,', ',tbl_users.FirstName,' ',SUBSTRING(tbl_users.MiddleName,1,1),'.') AS FullName, CASE tbl_users.AccountStatus WHEN 1 THEN 'Active' WHEN 0 THEN 'Inactive' END AS Status, tbl_pwchangelogs.LastChanged FROM tbl_users LEFT JOIN tbl_pwchangelogs ON tbl_users.UserID = tbl_pwchangelogs.UserID WHERE Username LIKE '{0}%' OR LastName LIKE '{0}%';"},
            {"USER_LAST_ID",            "SELECT UserID FROM tbl_users ORDER BY UserID DESC LIMIT 1;"},
            // User Log
            {"USER_LOG_QUERY_ID",       "SELECT tbl_sessions.*, tbl_users.Username FROM tbl_sessions, tbl_users WHERE tbl_sessions.UserID = tbl_users.UserID AND tbl_sessions.UserID = '{0}';"},
            {"USER_LOG_QUERY",          "SELECT tbl_sessions.*, DATE_FORMAT(tbl_sessions.LoginTime,'%Y-%m-%d') As LogDate, tbl_users.Username FROM tbl_sessions, tbl_users WHERE tbl_sessions.UserID = tbl_users.UserID;"},
            {"USER_LOG_QUERY_DATE",     "SELECT tbl_sessions.*, DATE_FORMAT(tbl_sessions.LoginTime,'%Y-%m-%d') As LogDate, tbl_users.Username FROM tbl_sessions, tbl_users WHERE tbl_sessions.UserID = tbl_users.UserID AND tbl_sessions.LogDate = '{0}';"},
            {"USER_LOG_LOGIN",          "INSERT INTO tbl_sessions(SessionID, UserID, LogDate, LoginTime) VALUES ('{0}', '{1}', NOW(), NOW());"},
            {"USER_LOG_LOGOUT",         "UPDATE tbl_sessions SET LogoutTime = NOW() WHERE SessionID = '{0}';"},
            {"USER_UPDATE_STATUS",      "UPDATE tbl_users SET AccountStatus = {1} WHERE Username = '{0}';"},
            
            // Student
            {"STUDENT_NEW",             "INSERT INTO tbl_students VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', {15}, {16});"},
            {"STUDENT_RECORDS_ALL",     "SELECT StudentID, CONCAT(LastName,', ',FirstName,' ',SUBSTRING(MiddleName,1,1),'.') AS FullName, CASE Gender WHEN 'M' THEN 'Male' WHEN 'F' THEN 'Female' END AS Gender, BirthDate, Address, LastSchool FROM tbl_students;"},
            {"STUDENT_RECORDS_SECTION", "SELECT tbl_students.StudentID, CONCAT(tbl_students.LastName,', ',tbl_students.FirstName,' ',SUBSTRING(tbl_students.MiddleName,1,1),'.') AS FullName, CASE tbl_students.Gender WHEN 'M' THEN 'Male' WHEN 'F' THEN 'Female' END AS Gender, tbl_students.BirthDate, tbl_students.Address, tbl_students.LastSchool FROM tbl_students, tbl_enlistment WHERE tbl_students.StudentID = tbl_enlistment.StudentID AND tbl_enlistment.SectionID = {0};"},
            {"STUDENT_LAST_ID",         "SELECT StudentID FROM tbl_students ORDER BY StudentID DESC LIMIT 1;"},
            {"STUDENT_ENROLL",          "INSERT INTO tbl_enrollment VALUES('{0}', NOW(), '{1}', '{2}', '{3}');"},
            {"STUDENT_DATA_FROM_ID",    "SELECT * FROM tbl_students WHERE StudentID = '{0}';"},
            {"STUDENT_SEARCH_NAME",     "SELECT StudentID, LastName, FirstName, MiddleName FROM tbl_students WHERE LastName LIKE '{0}%' OR FirstName LIKE '{0}%';"},
            {"STUDENT_SEARCH_ID",       "SELECT StudentID, LastName, FirstName, MiddleName FROM tbl_students WHERE StudentID LIKE '{0}%';"},
            // Payment            
            {"PAYMENT_MATRIX",          "SELECT * FROM tbl_paymentmatrix WHERE SchoolYearID = '{0}';"},
            {"PAYMENT_MATRIX_DATA",     "SELECT * FROM tbl_paymentmatrix WHERE ID = {0};"},
            {"PAYMENT_BREAKDOWN",       "SELECT * FROM tbl_paymentbreakdown WHERE MatrixID = {0};"},
            {"PAYMENT_BDN_ASSESSMENT",  "SELECT Description, Amount FROM tbl_paymentbreakdown WHERE MatrixID = {0};"},
            {"PAYMENT_MATRIX_NEW",      "INSERT INTO tbl_paymentmatrix(GradeLevel, SchoolYearID) VALUES('{0}', '{1}');"},
            {"PAYMENT_BREAKDOWN_NEW",   "INSERT INTO tbl_paymentbreakdown(Description, Amount, MatrixID) VALUES('{0}', {1}, {2});"},
            {"PAYMENT_UPDATE_AMOUNT",   "UPDATE tbl_paymentmatrix SET Amount = {1} WHERE ID = {0}"},
            {"PAYMENT_MATRIX_FR_GLSY",  "SELECT * FROM tbl_paymentmatrix WHERE GradeLevel = '{0}' AND SchoolYearID = '{1}';"},
            {"PAYMENT_AMOUNT_GRADE",    "SELECT Amount FROM tbl_paymentmatrix WHERE GradeLevel = '{0}' AND SchoolYearID = '{1}';"},
            {"MATRIX_LOG",              "SELECT SchoolYear FROM tbl_matrixlogs WHERE SchoolYearID = '{0}';"},
            {"MATRIX_NEW",              "INSERT INTO tbl_matrixlogs (SchoolYearID) VALUES('{0}');"},
            {"PAYMENT_PAYMODE",         "INSERT INTO tbl_paymentmodes VALUES('{0}', '{1}');"},
            {"MATRIX_CLEAR_ID",         "DELETE FROM tbl_paymentbreakdown WHERE MatrixID = {0};"},
            // Schoolyear
            {"SCHOOLYEAR_DATA",         "SELECT * FROM tbl_schoolyears WHERE SchoolYearID = '{0}';"},
            {"SCHOOLYEAR_ALL",          "SELECT * FROM tbl_schoolyears;"},
            {"SCHOOLYEAR_CURRENT",      "SELECT * FROM tbl_schoolyears WHERE Current = 1;"},
            {"SCHOOLYEAR_NEW_SY",       "INSERT INTO tbl_schoolyears(SchoolYearID, Description, Current) VALUES('{0}', '{1}', {2});"},
            {"SCHOOLYEAR_NEW_DEAC",     "UPDATE tbl_schoolyears SET Current = 0;"},
            {"SCHOOLYEAR_SET_DEF",      "UPDATE tbl_schoolyears SET Current = 1 WHERE SchoolYearID = '{0}';"},
            {"SCHOOLYEAR_LATEST",       "SELECT * FROM tbl_schoolyears ORDER BY SchoolYearID DESC LIMIT 1;"},
            //
            {"SECTION_FRM_GL_SY",       "SELECT * FROM tbl_sections WHERE GradeLevel = '{0}' AND SchoolYearID = '{1}';"},
            {"SECTION_ADVISER",         "SELECT tbl_teachers.* FROM tbl_teachers, tbl_advisoryclasses WHERE tbl_teachers.TeacherID = tbl_advisoryclasses.TeacherID AND tbl_advisoryclasses.SectionID = {0};"},
            {"SECTION_NEW_DATA",        "INSERT INTO tbl_sections(GradeLevel, Name, SchoolYearID) VALUES ('{0}','{1}','{2}');"},
            {"SECTION_NEW_ADVISER",     "INSERT INTO tbl_advisoryclasses(SectionID, TeacherID) VALUES ('{0}','{1}');"},
            {"SECTION_UPDATE_DATA",     "UPDATE tbl_sections SET Name = '{1}' WHERE SectionID = {0};"},
            {"SECTION_UPDATE_COUNT",    "UPDATE tbl_sections SET StudentCount = StudentCount+1 WHERE SectionID = {0};"},
            {"SECTION_UPDATE_ADVISER",  "INSERT INTO tbl_advisoryclasses(SectionID, TeacherID) VALUES({0}, '{1}') ON DUPLICATE KEY UPDATE TeacherID=VALUES(TeacherID);"},
            {"SECTION_DATA_SECTID",     "SELECT * FROM tbl_sections WHERE SectionID = '{0}';"},
            {"SECTION_DELETE",          "UPDATE tbl_sections SET Status = 0 WHERE SectionID = '{0}';"},
            {"SECTION_LAST",            "SELECT * FROM tbl_sections ORDER BY SectionID DESC LIMIT 1;" },
            //
            {"ENLISTMENT_NEW",          "INSERT INTO tbl_enlistment(StudentID, SectionID, EnlistDate, Balance, Remarks) VALUES ('{0}', '{1}', NOW(), {2}, '{3}');"},
            {"ENLISTMENT_CURRCNT_SEC",  "SELECT COUNT(StudentID) as Count FROM tbl_enlistment WHERE SectionID = '{0}';"},
            {"ENLISTMENT_STUDCOUNT",    "SELECT tbl_sections.*, COUNT(tbl_enlistment.StudentID) as Count FROM tbl_sections, tbl_enlistment WHERE tbl_sections.GradeLevel = '{0}' AND tbl_sections.SchoolYearID = '{1}' AND tbl_enlistment.SectionID = tbl_sections.SectionID;"},
            {"ENLISTMENT_SECT_FRM_ID",  "SELECT * FROM tbl_enlistment WHERE StudentID = '{0}' ORDER BY EnlistDate DESC LIMIT 1;"},
            {"ENLISTMENT_ADD_PAYMENT",  "INSERT INTO tbl_payments(EnlistmentID, AmountPayable, DueDate) VALUES({0}, {1}, '{2}');"},
            {"ENLISTMENT_DATA_FRM_ID",  "SELECT * FROM tbl_enlistment WHERE EnlistmentID = {0};"},
            {"ENLISTMENT_FRM_PYMNTID",  "SELECT tbl_enlistment.* FROM tbl_payments, tbl_enlistment WHERE tbl_payments.EnlistmentID = tbl_enlistment.EnlistmentID AND tbl_payments.PaymentID = {0};"},
            {"ENLISTMENT_UPDATE_BAL",   "UPDATE tbl_enlistment SET Balance = Balance-{1} WHERE EnlistmentID = {0};"},
            {"ENLISTMENT_UPDATE_GRADES","UPDATE tbl_enlistment SET Grades = {1} WHERE EnlistmentID = {0};"},
            //
            {"TEACHER_RECORDS_ALL",     "SELECT TeacherID, CONCAT(LastName,', ',FirstName,' ',SUBSTRING(MiddleName,1,1),'.') AS FullName, EmailAddress, ContactNo, Address FROM tbl_teachers;"},
            {"TEACHER_RECORDS_SEARCH",  "SELECT TeacherID, CONCAT(LastName,', ',FirstName,' ',SUBSTRING(MiddleName,1,1),'.') AS FullName, EmailAddress, ContactNo, Address FROM tbl_teachers WHERE LastName LIKE '{0}%' OR FirstName LastName LIKE '{0}%' OR TeacherID LastName LIKE '{0}%';"},
            {"TEACHER_NEW",             "INSERT INTO tbl_teachers VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}');"},
            {"TEACHER_UPDATE",          "UPDATE tbl_teachers SET LastName = '{1}', FirstName = '{2}', MiddleName = '{3}', Gender = '{4}', BirthDate = '{5}', EmailAddress = '{6}', Address = '{7}', ContactNo = '{8}', Nationality = '{9}', Religion = '{10}' WHERE TeacherID = '{0}');"},
            {"TEACHER_LAST_ID",         "SELECT TeacherID FROM tbl_teachers ORDER BY TeacherID DESC LIMIT 1;"},
            {"TEACHER_FROM_SECTION",    "SELECT * FROM tbl_advisoryclasses WHERE SectionID = {0};"},
            {"TEACHER_FROM_ID",         "SELECT * FROM tbl_teachers WHERE TeacherID = '{0}';"},
            {"TEACHER_SECTIONS",        "SELECT CONCAT(tbl_teachers.LastName,', ',tbl_teachers.FirstName,' ',SUBSTRING(tbl_teachers.MiddleName,1,1),'.') AS FullName, tbl_sections.* FROM tbl_teachers, tbl_advisoryclasses, tbl_sections WHERE tbl_teachers.TeacherID = tbl_advisoryclasses.TeacherID AND tbl_sections.SectionID = tbl_advisoryclasses.SectionID AND tbl_teachers.TeacherID = '{0}';"},
            //
            {"EDUCATION_BG_NEW",        "INSERT INTO tbl_education VALUES('{0}','{1}','{2}','{3}','{4}','{5}');"},
            {"EDUCATION_BG_ID",         "SELECT * FROM tbl_education WHERE TeacherID = '{0}';"},
            //
            {"EMERGENCY_INFO",          "INSERT INTO tbl_emergency VALUES('{0}', '{1}', '{2}', '{3}', '{4}');"},
            {"EMERGENCY_DATA_STUDID",   "SELECT * FROM tbl_emergency WHERE PersonID = '{0}';"},
            //
            {"SIBLING_NEW",             "INSERT INTO tbl_siblings(StudentID, Name, Age, School) VALUES('{0}', '{1}', '{2}', '{3}');"},
            {"SIBLING_DATA_FRM_STUDID", "SELECT * FROM tbl_siblings WHERE StudentID = '{0}';"},
            ///
            {"FAMILY_INFO",             "INSERT INTO tbl_familyinfo VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}');"},
            {"FAMILY_DATA_FRM_STUDID",  "SELECT * FROM tbl_familyinfo WHERE StudentID = '{0}';"},
            //
            {"CUSTODIAN_NEW",           "INSERT INTO tbl_custodians VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');"},
            {"CUSTODIAN_DATA_STUDID",   "SELECT * FROM tbl_custodians WHERE StudentID = '{0}';"},
            //
            {"BUILDING_NEW",            "INSERT INTO tbl_buildings VALUES('{0}', '{1}', '{2}', 1);"},
            {"BUILDING_FROM_ID",        "SELECT * FROM tbl_buildings WHERE BuildingID = '{0}';"},
            {"BUILDING_ALL",            "SELECT * FROM tbl_buildings WHERE Status = 1;"},
            {"BUILDING_DELETE",         "UPDATE tbl_buildings SET Status = 0 WHERE BuildingID = '{0}';"},
            //
            {"ROOM_NEW",                "INSERT INTO tbl_rooms(BuildingID, Name, Description) VALUES('{0}', '{1}', '{2}');"},
            {"ROOM_FROM_ID",            "SELECT * FROM tbl_rooms WHERE RoomID = '{0}';"},
            {"ROOM_ALL",                "SELECT * FROM tbl_rooms WHERE Status = 1;"},
            {"ROOM_BY_BUILDING",        "SELECT * FROM tbl_rooms WHERE BuildingID = '{0}' AND Status = 1;"},
            {"ROOM_FROM_SECTID",        "SELECT tbl_rooms.* FROM tbl_rooms, tbl_advisoryclasses WHERE tbl_rooms.RoomID = tbl_advisoryclasses.RoomID AND tbl_advisoryclasses.SectionID = {0};"},
            {"ROOM_DELETE",             "UPDATE tbl_rooms SET Status = 0 WHERE RoomID = '{0}';"},
            //
            {"GRADE_BY_ENLISTMENTID",   "SELECT * FROM tbl_grades WHERE EnlistmentID = '{0}';"},
            {"GRADE_ENL_ADDSUBJ",       "INSERT INTO tbl_grades(EnlistmentID, SubjectID) VALUES ({0}, '{1}');"},
            //
            {"RECEIPT_LAST",            "SELECT * FROM tbl_paymentlogs ORDER BY ReceiptNo DESC LIMIT 1;"},
            {"RECEIPT_NEW",             "INSERT INTO tbl_paymentlogs(PaymentID, Tendered, `Change`, DatePaid, UserID) VALUES({0}, {1}, {2}, NOW(), '{3}');"},
            //
            {"BREAKDOWN_FROM_ENLID",    "SELECT * FROM tbl_payments WHERE EnlistmentID = {0} AND Status = 0;"},
            //
            {"PAYMENT_UPDATE_STATUS",   "UPDATE tbl_payments SET Status = 1 WHERE PaymentID = {0};"},
            //
            {"LOG",                     "INSERT INTO tbl_logs (UserID, Module, LogType, LogDate, RelativeObject, Remarks) VALUES('{0}', '{1}', '{2}', NOW(), '{3}', '{4}');"},
            {"LOG_ACTIONLOGS",          "SELECT tbl_users.Username, CASE tbl_logs.LogType WHEN 'C' THEN 'CREATE' WHEN 'R' THEN 'READ' WHEN 'U' THEN 'UPDATE' WHEN 'D' THEN 'DELETE' END AS Action, CASE tbl_logs.Module WHEN 'E' THEN 'ENROLLMENT' WHEN 'L' THEN 'ENLISTMENT' WHEN 'P' THEN 'PAYMENT' WHEN 'U' THEN 'USER' WHEN 'S' THEN 'SECTION' WHEN 'R' THEN 'ROOM' WHEN 'B' THEN 'BUILDING' WHEN 'Y' THEN 'SCHOOLYEAR' WHEN 'T' THEN 'TEACHER' WHEN 'G' THEN 'GRADES' END AS Module, tbl_logs.RelativeObject, tbl_logs.Remarks FROM tbl_users, tbl_logs WHERE tbl_users.UserID = tbl_logs.UserID;"},
            {"LOG_ACTIONLOGS_DATE",     "SELECT tbl_users.Username, CASE tbl_logs.LogType WHEN 'C' THEN 'CREATE' WHEN 'R' THEN 'READ' WHEN 'U' THEN 'UPDATE' WHEN 'D' THEN 'DELETE' END AS Action, CASE tbl_logs.Module WHEN 'E' THEN 'ENROLLMENT' WHEN 'L' THEN 'ENLISTMENT' WHEN 'P' THEN 'PAYMENT' WHEN 'U' THEN 'USER' WHEN 'S' THEN 'SECTION' WHEN 'R' THEN 'ROOM' WHEN 'B' THEN 'BUILDING' WHEN 'Y' THEN 'SCHOOLYEAR' WHEN 'T' THEN 'TEACHER' WHEN 'G' THEN 'GRADES' END AS Module, tbl_logs.RelativeObject, tbl_logs.Remarks FROM tbl_users, tbl_logs WHERE tbl_users.UserID = tbl_logs.UserID AND tbl_logs.LogDate BETWEEN '{0}' AND '{1}';"},
            //
            {"GLOBAL_CONFIG",           "SELECT Value FROM global_config WHERE KeyCode = '{0}';"},
            //
        };

        public static Dictionary<String, String> Data { get { return Qrys; } }
    }
}
