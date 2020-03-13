using System;
using Xunit;

namespace PersonHello.Test
{
    public class PersonTests
    {
        [Theory]
        [InlineData(19)]
        [InlineData(59)]
        public void AdulthoodTest(int age)
        {
            IMessageStrategy strategies = new AdulthoodMessageStrategy();
            Person person = new Person("N", "N", "M", age);
            string massage = $"Hello { person.FirstName } you already enjoy your adulthood";

            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }

        [Theory]
        [InlineData("M", 17)]
        [InlineData("M", 15)]
        public void ArmyTest(string sex, int age)
        {
            IMessageStrategy strategies = new ArmyMessageStrategy();
            Person person = new Person("N", "N", sex, age);
            string massage = $"Hi, how are you going to the army? you are already {age} years old, which means that in {18 - age} years you will be in the army";

            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }

        [Theory]
        [InlineData("M", 66)]
        [InlineData("F", 61)]
        public void RetirementTest(string sex, int age)
        {
            IMessageStrategy strategies = new RetirementMessageStrategy();
            Person person = new Person("N", "N", sex, age);
            string massage = $"Hello { person.FirstName } you already enjoy your retirement";

            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }

        [Theory]
        [InlineData(81)]
        [InlineData(111)]
        public void OldTest(int age)
        {
            IMessageStrategy strategies = new OldMessageStrategy();
            Person person = new Person("N", "N", "F", age);
            string massage = $"Hello! Mr. { person.FirstName }, how did you manage to live to such an age";

            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }

        [Theory]
        [InlineData(81)]
        public void CompositeTest(int age)
        {
            IMessageStrategy retirement = new RetirementMessageStrategy();
            IMessageStrategy old = new OldMessageStrategy();
            IMessageStrategy strategies = new CompositeMessageStrategy(retirement, old);

            Person person = new Person("N", "N", "F", age);
            string massage = $"Hello { person.FirstName } you already enjoy your retirement Hello! Mr. { person.FirstName }, how did you manage to live to such an age";
            
            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }
    }
}
