using tdd_bobs_bagels.CSharp.Main;
namespace csharp_tdd_bobs_bagels.tests;

public class Tests
{

    [TestCase("Chocolate Bagel")]
    public void AddBagelTest(string bagel)
    {
        //arrange
        Basket basket = new Basket();
        bool expected = true;

        //act
        bool result = basket.Add(bagel);

        //assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Chocolate Bagel")]
    public void RemoveBagelTest(string bagel)
    {
        //arrange
        Basket basket = new Basket();
        bool expectedHasBagel = true;
        bool expectedEmpty = false;
        basket.Add(bagel);

        //act
        bool resultHasBagel = basket.Remove();
        bool resultEmpty = basket.Remove();

        //assert
        Assert.That(resultHasBagel, Is.EqualTo(expectedHasBagel));
        Assert.That(resultEmpty, Is.EqualTo(expectedEmpty));
    }

    [TestCase("Chocolate Bagel", "Frosted Bagel")]
    public void OverfillTest(string bagel1, string bagel2)
    {
        //arrange
        Basket basket = new Basket();
        bool expected = false;
        basket.Add(bagel1);

        //act
        bool result = basket.Add(bagel2);

        //assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("Red Bagel", "Green Bagel", "Blue Bagel")]
    public void CapacityTest(string bagel1, string bagel2, string bagel3)
    {
        //arrange
        Basket basket = new Basket();
        basket.SetCapacity(2);
        bool expectedIllegalDecrease = false;
        bool expectedAllowedIncrease = true;
        bool expectedAllowedDecrease = true;
        basket.Add(bagel1);
        basket.Add(bagel2);

        //act
        bool resultIllegalDecrease = basket.SetCapacity(1);
        bool resultAllowedIncrease = basket.SetCapacity(4);
        basket.Add(bagel3); //Add another bagel
        bool resultAllowedDecrease = basket.SetCapacity(3);

        //assert
        Assert.That(resultIllegalDecrease, Is.EqualTo(expectedIllegalDecrease));
        Assert.That(resultAllowedIncrease, Is.EqualTo(expectedAllowedIncrease));
        Assert.That(resultAllowedDecrease, Is.EqualTo(expectedAllowedDecrease));
    }

    [TestCase("Strawberry Bagel", "Vanilla Bagel")]
    public void RemoveSpecificBagelTest(string bagel1, string bagel2)
    {
        //arrange
        Basket basket = new Basket();
        basket.SetCapacity(3);
        basket.Add(bagel1); //First Strawberry
        basket.Add(bagel1); //Second Strawberry
        basket.Add(bagel2); //First Vanilla
        bool expectedRemoveVanilla = true;
        bool expectedRemoveVanillaAgain = false;
        bool expectedRemoveStrawberry = true;
        bool expectedRemoveStrawberryAgain = true;

        //act
        bool resultRemoveVanilla = basket.Remove(bagel2);
        bool resultRemoveVanillaAgain = basket.Remove(bagel2);
        bool resultRemoveStrawberry = basket.Remove(bagel1);
        bool resultRemoveStrawberryAgain = basket.Remove(bagel1);

        //assert
        Assert.That(resultRemoveVanilla, Is.EqualTo(expectedRemoveVanilla));
        Assert.That(resultRemoveVanillaAgain, Is.EqualTo(expectedRemoveVanillaAgain));
        Assert.That(resultRemoveStrawberry, Is.EqualTo(expectedRemoveStrawberry));
        Assert.That(resultRemoveStrawberryAgain, Is.EqualTo(expectedRemoveStrawberryAgain));
    }
}