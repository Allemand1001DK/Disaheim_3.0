using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;

namespace DisaheimTest
{
    [TestClass]
    public class UnitTest4
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2;

        CourseRepository courses;
        MerchandiseRepository merchandise;
        
        [TestInitialize]
        public void Init()
        {
            // Arrange
            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");

            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);

            merchandise = new MerchandiseRepository();
            courses = new CourseRepository();
            
            // Act
            merchandise.AddMerchandise(b1);
            merchandise.AddMerchandise(b2);
            merchandise.AddMerchandise(b3);

            merchandise.AddMerchandise(a1);
            merchandise.AddMerchandise(a2);
            merchandise.AddMerchandise(a3);

            courses.AddCourse(c1);
            courses.AddCourse(c2);
        }

        [TestMethod]
        public void TestGetBook()
        {
            // Assert
            Assert.AreEqual(b2, merchandise.GetMerchandise("2"));
        }
        [TestMethod]
        public void TestGetAmulet()
        {
            // Assert
            Assert.AreEqual(a3, merchandise.GetMerchandise("13"));
        }
        [TestMethod]
        public void TestGetCourse()
        {
            // Assert
            Assert.AreEqual(c1, courses.GetCourse("Eufori med røg"));
        }
        [TestMethod]
        public void TestGetTotalValueForMerchandise()
        {
            // Assert
            Assert.AreEqual(123.55 + 60, merchandise.GetTotalValue());
        }
        [TestMethod]
        public void TestGetTotalValueForCourse()
        {
            // Assert
            Assert.AreEqual(2625.0, courses.GetTotalValue());
        }
    }

}
