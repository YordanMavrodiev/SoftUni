using NUnit.Framework;
using System;
using System.Linq;

namespace RobotFactory.Tests
{
    public class Tests
    {
        Supplement supplement1;
        Supplement supplement2;
        Robot robot1;
        Robot robot2;
        Factory factory;
        [SetUp]
        public void Setup()
        {
            robot1 = new Robot("ROBOT", 100000, 1);
            robot2 = new Robot("Pathfinder", 200000, 2);
            supplement1 = new Supplement("Laser", 2);
            supplement2 = new Supplement("ExtraArm", 3);
            factory = new Factory("Doofenshmirtz Evil inc", 10);
        }

        [Test]
        public void SupplementCreatesCorrectly()
        {
            Assert.That(supplement1, Is.Not.Null);
            Assert.That(supplement1.Name, Is.EqualTo("Laser"));
            Assert.That(supplement1.InterfaceStandard, Is.EqualTo(2));
        }
        [Test]
        public void SupplementToStringRetursCorrectly()
        {
            Assert.AreEqual(supplement1.ToString(), "Supplement: Laser IS: 2");
        }

        [Test]
        public void RobotCreatesCorrectly()
        {
            Assert.That(robot1, Is.Not.Null);
            Assert.That(robot1.Model, Is.EqualTo("ROBOT"));
            Assert.That(robot1.Price, Is.EqualTo(100000));
            Assert.That(robot1.InterfaceStandard, Is.EqualTo(1));
            Assert.That(robot1.Supplements, Is.Not.Null);
        }

        [Test]
        public void RobotToStringReturnsCorrectly()
        {
            Assert.That(robot1.ToString(), Is.EqualTo("Robot model: ROBOT IS: 1, Price: 100000.00"));
        }

        [Test]
        public void FactoryCreatesCorrectly()
        {
            Assert.That(factory, Is.Not.Null);
            Assert.AreEqual("Doofenshmirtz Evil inc", factory.Name);
            Assert.AreEqual(10, factory.Capacity);
            Assert.That(factory.Robots, Is.Not.Null);
            Assert.That(factory.Supplements, Is.Not.Null);
        }

        [Test]
        public void ProduceRobotProducesCorrectly()
        {
            Assert.That(factory.ProduceRobot(robot2.Model, robot2.Price, robot2.InterfaceStandard), Is.EqualTo($"Produced --> {robot2.ToString()}"));
            Assert.That(factory.Robots.Any());
        }

        [Test]
        public void ProduceRobotReturnsAboveCapacity()
        {
            factory = new Factory("bad factory", 0);
            Assert.That(factory.ProduceRobot(robot2.Model, robot2.Price, robot2.InterfaceStandard), Is.EqualTo("The factory is unable to produce more robots for this production day!"));
        }

        [Test]
        public void ProduceSupplementProducesCorrectly()
        {
            Assert.That(factory.ProduceSupplement(supplement2.Name, supplement2.InterfaceStandard), Is.EqualTo(supplement2.ToString()));
            Assert.That(factory.Supplements.Any());
            
        }

        [Test]
        public void UpgradeRobotUpgradesCorrectly()
        {
            robot2.InterfaceStandard = 2;
            supplement2.InterfaceStandard = 2;
            Assert.That(factory.UpgradeRobot(robot2, supplement2), Is.True);
            Assert.That(factory.UpgradeRobot(robot2, supplement2), Is.False);
        }
        [Test]
        public void UpgradeRobotDoesntUpgradeCorrectly()
        {
            robot2.InterfaceStandard = 2;
            supplement2.InterfaceStandard = 3;
            Assert.That(factory.UpgradeRobot(robot2, supplement2), Is.False);
        }

        [Test]
        public void SellRobotReturnsSoldRobot()
        {
            factory.ProduceRobot("Garen", 25000, 3);
            factory.ProduceRobot("Baren", 32000, 81);
            factory.ProduceRobot("Daren", 76000, 90);
            factory.ProduceRobot("Saren", 44000, 8);
            factory.ProduceRobot("Faren", 88000, 7);
            factory.ProduceRobot("Aaren", 9000000, 2);
            factory.ProduceRobot("Taren", 2000, 5);

            Assert.That(factory.SellRobot(10000).Model, Is.EqualTo("Taren"));
            Assert.That(factory.SellRobot(10000).Price, Is.EqualTo(2000));
            Assert.That(factory.SellRobot(10000).InterfaceStandard, Is.EqualTo(5));
        }

        [Test]
        public void SellRobotThrowsWhenNoRobots()
        {
            factory.ProduceRobot("Garen", 25000, 3);
            factory.ProduceRobot("Baren", 32000, 81);
            factory.ProduceRobot("Daren", 76000, 90);
            factory.ProduceRobot("Saren", 44000, 8);
            factory.ProduceRobot("Faren", 88000, 7);
            factory.ProduceRobot("Aaren", 9000000, 2);
            factory.ProduceRobot("Taren", 2000, 5);

            Assert.That(factory.SellRobot(1000), Is.Null);
        }

    }
}