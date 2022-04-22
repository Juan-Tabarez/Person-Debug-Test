using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        }

        //Test de nombres validos

        [Test]
        public void validNameTest1() 
        {   
            Person person = new Person("Juan","51369506");
            string expected = "Juan";
            string actual = person.Name;
            Assert.AreEqual(expected,actual);
        }
        
        [Test]
        public void validNameTest2() 
        {   
            Person person = new Person("Juan Román Riquelme","51369506");
            string expected = "Juan Román Riquelme";
            string actual = person.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void validNameTest3() 
        {   
            Person person = new Person("a","51369506");
            string expected = "a";
            string actual = person.Name;
            Assert.AreEqual(expected,actual);
        }

        //Test de nombres no validos

        [Test]
        public void noValidNameTest1() 
        {   
            Person person = new Person("","51369506");
            string expected = null;
            string actual = person.Name;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidNameTest2() 
        {   
            Person person = new Person(null,"51369506");
            string expected = null;
            string actual = person.Name;
            Assert.AreEqual(expected,actual);
        }     
    }
}