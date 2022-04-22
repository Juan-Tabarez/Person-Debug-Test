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

        //Tests de nombres validos

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

        //Tests de nombres no validos

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

        //Tests de cedulas validas

        [Test]
        public void validIdTest1()
        {
            Person person = new Person("Juan", "51369506");
            string expected = "51369506";
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        } 

        [Test]
        public void validIdTest2()
        {
            Person person = new Person("Juan", "5.136.950-6");
            string expected = "5.136.950-6";
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void validIdTest3()
        {
            Person person = new Person("Juan", "5.136.950.6");
            string expected = "5.136.950.6";
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void validIdTest4()
        {
            Person person = new Person("Juan", "5-136-950-6");
            string expected = "5-136-950-6";
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        } 

        //Tests de cedulas no validas

        [Test]
        public void noValidIdTest1()
        {
            Person person = new Person("Juan", "8.765.432-1");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidIdTest2()
        {
            Person person = new Person("Juan", "8.765.432");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidIdTest3()
        {
            Person person = new Person("Juan", "876543210");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidIdTest4()
        {
            Person person = new Person("Juan", "5");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidIdTest5()
        {
            Person person = new Person("Juan", "");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        [Test]
        public void noValidIdTest6()
        {
            Person person = new Person("Juan", null);
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }

        public void noValidIdTest7()
        {
            Person person = new Person("Juan", "ghcvzsgufds");
            string expected = null;
            string actual = person.ID;
            Assert.AreEqual(expected,actual);
        }
    }
}