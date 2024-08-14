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
}