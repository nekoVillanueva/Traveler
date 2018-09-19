using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerTests
{
    [TestFixture]

    class TravellerTests
    {
        Beach beach = new Beach();
        [Test]
        public void Enter_Eye_Color()
        {
            Beach beach = new Beach("blue");
            var response = beach.GetColor;
            Assert.That(response, Is.EqualTo("blue"));
        }
        [Test]
        public void Enter_String_Return_Beach()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("blue");
            Assert.That(response, Is.EqualTo(""));

        }
        [Test]
        public void Enter_String_Return_Beach_Not_MT()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("green");
            Assert.That(response, Is.EqualTo("Seal Beach"));
        }
        [Test]
        public void Enter_String_Return_Beach_Brown()
        {
            Beach beach = new Beach();
            string response = beach.GetBeach("brown");
            Assert.That(response, Is.EqualTo("Newport Beach"));
        }
        [Test]
        public void Set_Shoe_Size()
        {
            beach.GetShoeSize = 10.5;
            double response = beach.GetShoeSize;
            Assert.That(response, Is.EqualTo(10.5));
        }
        [Test]
        public void Get_Hotel_Size_Equals_0_and_Beach_Equals_MT_Returns_Null()
        {
            string locatation = beach.GetBeach("");
            string response = beach.GetHotel(0,locatation);
            Assert.That(response, Is.EqualTo(null));
        }
        [Test]
        public void Hotel_10_And_Beach_Seal_Hilton()
        {
            string location = beach.GetBeach("green");
            string response = beach.GetHotel(10, location);
            Assert.That(response, Is.EqualTo("Hilton"));
        }
    }
}

