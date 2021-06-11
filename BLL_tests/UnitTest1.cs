using DAL2.Model;
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
        [TestMethod]
        public void RemoveGroup()
        {
            string namegroup = "PI-224";
            bool expected = true;


            ServiceGroup group = new ServiceGroup();
            bool result = group.RemoveGroup(namegroup);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ChangeGroup()
        {
            string namegroup = "PI-224";
            bool expected = true;


            ServiceGroup group = new ServiceGroup();
            bool result = group.ChangeGroup(namegroup);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SearchGroup()
        {
            string namegroup = "PI-224";
            bool expected = true;
            //123 test
            ServiceGroup group = new ServiceGroup();
            var result = group.SearchGroup(namegroup);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]

        public void RemoveStudent()
        {
            string name = "Ivan";
            string surname = "Morozov";
            bool expected = true;

            StudentService student = new StudentService();
            bool result = student.RemoveStudent(name,surname);

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




    }
}
