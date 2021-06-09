using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;
namespace BLL_tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
       
        public void AddGroup()
        {
            string namegroup = "PI-224";
            bool expected = true;


            ServiceGroup group = new ServiceGroup();
            bool result = group.AddGroup(namegroup);

            Assert.AreEqual(expected, result);
       
        }
        //public void StudentAddtoDataBaseEqualsTrue()
        //{
        //    string name = "Ivan";
        //    string surname = "Morozov";
        //    int year = 2002;
        //    int day = 12;
        //    int mounth = 2;
        //    int number = 11;
        //    int room = 5;
        //    string group = "PI-224";
        //    bool expected = true;

            
        //    StudentService student = new StudentService();
        //    bool actual = true; //student.AddStudent(name, surname, year, day, mounth,group,number,room);


        //    Assert.AreEqual(expected, actual);
        //}
   
    }
}
