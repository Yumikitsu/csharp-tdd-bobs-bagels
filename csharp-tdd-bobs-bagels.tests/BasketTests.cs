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
        bool expected = true;
        bool expected2 = false;
        basket.Add(bagel);

        //act
        bool result = basket.Remove();
        bool result2 = basket.Remove();

        //assert
        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result2, Is.EqualTo(expected2));
    }
}