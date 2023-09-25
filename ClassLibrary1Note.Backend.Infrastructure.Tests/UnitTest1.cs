using Note.Backend.Infrastructure.SQLServer.Context;

namespace ClassLibrary1Note.Backend.Infrastructure.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var factory = new IngredientContextFactory();

        var x = factory.CreateDbContext(null);
    }
}