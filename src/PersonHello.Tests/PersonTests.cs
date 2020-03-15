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
            DateTime birthday = new DateTime(2010, 10, 10);
            Person person = new Person("N", "N", "M", age, birthday);
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
            DateTime birthday = new DateTime(2010, 10, 10);
            Person person = new Person("N", "N", sex, age, birthday);
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
            DateTime birthday = new DateTime(2010, 10, 10);
            Person person = new Person("N", "N", sex, age, birthday);
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
            DateTime birthday = new DateTime(2010, 10, 10);
            Person person = new Person("N", "N", "F", age, birthday);
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
            DateTime birthday = new DateTime(2010, 10, 10);

            Person person = new Person("N", "N", "F", age, birthday);
            string massage = $"Hello { person.FirstName } you already enjoy your retirement Hello! Mr. { person.FirstName }, how did you manage to live to such an age";
            
            strategies.Execute(person);

            Assert.Equal(massage, strategies.Message);
        }

        [Theory]
        [InlineData(17900315)]
        [InlineData(20000311)]
        [InlineData(19950319)]
        [InlineData(19800317)]

        public void BirthdayTest(long bir)
        {
            IMessageStrategy retirement = new BirthdayMessageStrategy();
            DateTime birthday = new DateTime(bir);
            Person person = new Person("N", "N", "F", 30, birthday);
            string massage = $"Hello { person.FirstName } you already enjoy your birthday";

            retirement.Execute(person);

            Assert.Equal(massage, retirement.Message);

        }
    }
}
