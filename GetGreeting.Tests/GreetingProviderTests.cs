using GetGreeting;
using Moq;
namespace GetGreeting.Tests
{
    public class Tests
    {
        private GreetingProvider _greetingProvider;
        private Mock<ITimeProvider> _mockedTimeProvider;

        [SetUp]
        public void Setup()
        {
            _mockedTimeProvider =new Mock<ITimeProvider>();
            _greetingProvider = new GreetingProvider(_mockedTimeProvider.Object);
        }


        [Test]
        public void Greeting_ShouldReurnMorningMessage_WhenIsMorning()
        {
            //Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000,2,2,9,9,9));
            //Act
            var result = _greetingProvider.GetGreeting();
            //Assert
            Assert.AreEqual("Good morning!", result);
        }
        [Test]
        public void GetGreeting_ShouldReturnAAfternoonMessage_WhenItIsAfterNoon()
        {
            //Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 12, 9, 9));
            //Act
            var result = _greetingProvider.GetGreeting();
            //Assert
            Assert.AreEqual("Good afternoon!", result);
        }
        [Test]
        public void GetGreeting_ShouldReturnAEveningMessage_WhenItIsEvening()
        {
            //Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 21, 9, 9));
            //Act
            var result = _greetingProvider.GetGreeting();
            //Assert
            Assert.AreEqual("Good evening!", result);
        }
        [Test]
        public void GetGreeting_ShouldReturnGoodNightMessage_WhenItIsNight()
        {
            //Arrange
            _mockedTimeProvider.Setup(x => x.GetCurrentTime()).Returns(new DateTime(2000, 2, 2, 22, 9, 9));
            //Act
            var result = _greetingProvider.GetGreeting();
            //Assert
            Assert.AreEqual("Good night!", result);
        }
    }
}