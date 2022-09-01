using NUnit.Framework;
using ArmInterface;

namespace ArmInterfaceTests
{
    [TestFixture]
    public class ArmInterfaceTestSuite
    {
        [Test, Description("Test to check ToDirectionEnum extension method for integer works properly.")]
        [TestCase(3, ExpectedResult = Direction.Right, Description = "An integer value of 3 should be equilant to the Direction Right.")]
        [TestCase(0, ExpectedResult = Direction.Up, Description = "An integer value of 0 should be equilant to the Direction Up.")]
        [TestCase(1, ExpectedResult = Direction.Down, Description = "An integer value of 1 should be equilant to the Direction Down.")]
        [TestCase(2, ExpectedResult = Direction.Left, Description = "An integer value of 2 should be equilant to the Direction Left.")]
        [TestCase(-4, ExpectedResult = Direction.Up, Description = "An integer value outside the Direction enumeration should return default value of Up.")]
        public Direction Test_IntToDirection_ConvertionMethod(int iDirection)
        {
            return iDirection.ToDirectionEnum<Direction>();
        }


        [Test, Description("Test to check the implemented Interface for the arm works properly and follows correct workflow.")]
        public void Test_ArmSingletonInterface()
        {
            // The program should not drop an object without picking it up first. The method should return false.
            Assert.IsFalse(ArmSingletonInterface.Instance.DropObject());

            // The program should not move an object without picking it up first. The method Move should return false.
            Assert.IsFalse(ArmSingletonInterface.Instance.MoveObject(0));
            Assert.IsFalse(ArmSingletonInterface.Instance.MoveObject(1));
            Assert.IsFalse(ArmSingletonInterface.Instance.MoveObject(2));
            Assert.IsFalse(ArmSingletonInterface.Instance.MoveObject(3));
            // The program should consider an invalid enumeration value to be default direction of Up.
            Assert.IsFalse(ArmSingletonInterface.Instance.MoveObject(6));

            // lets pick the Object. The method should return true because no object has been picked up so far.
            Assert.IsTrue(ArmSingletonInterface.Instance.PickObject());

            // If the object is picked up, and a command is made to pick the object up again, the program should fail to do so and return false.
            Assert.IsFalse(ArmSingletonInterface.Instance.PickObject());

            // Till this point, the arm is holding the object. The program should be able to move the arm in any direction now.
            Assert.IsTrue(ArmSingletonInterface.Instance.MoveObject(0));
            Assert.IsTrue(ArmSingletonInterface.Instance.MoveObject(1));
            Assert.IsTrue(ArmSingletonInterface.Instance.MoveObject(2));
            Assert.IsTrue(ArmSingletonInterface.Instance.MoveObject(3));
            // The program should consider an invalid enumeration value to be default direction of Up.
            Assert.IsTrue(ArmSingletonInterface.Instance.MoveObject(6));

            // Since the arm is holding an object, it should be able to drop the object successfully.
            Assert.IsTrue(ArmSingletonInterface.Instance.DropObject());

            //Sinc the object was dropped already, the command to drop the object again should fail.
            Assert.IsFalse(ArmSingletonInterface.Instance.DropObject());
        }

    }
}