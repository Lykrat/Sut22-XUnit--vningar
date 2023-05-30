using Sut22_XUnit_Övningar;

namespace SUT22_XUnit_Övningar_Testar
{
    public class ShoppingCartTests
    {
        [Fact]
        public void GetTotalPrice_ShouldReturnCorrectTotalPrice()
        {
            //Arrange
            Product prod1 = new Product
            {
                Name = "MTG kort",
                Price = 67.5m
            };
            Product prod2 = new Product
            {
                Name = "Ko",
                Price = 55624.7m
            };
            ShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddProduct(prod1);
            shoppingCart.AddProduct(prod2);

            //Act
            var expected = prod1.Price + prod2.Price;
            var request = shoppingCart.GetTotalPrice();

            //Assert
            Assert.Equal(expected, request);
        }
    }
}