using MutationChallenge;

namespace MutationTesting;

public class CalculatriceTests
{
    //Execution de scénario sur base de valeurs seuils (4/5 - 9/10/ - 1 - 11)
    [Theory]
    [InlineData(100, 4, 100)]
    [InlineData(100, 5, 90)]
    [InlineData(100, 9, 90)]
    [InlineData(100, 10, 80)]
    [InlineData(100, 11, 80)]
    public void RemiseExisteSelonQuantity(double prix, int quantite, double prixAttendu)
    {

        var c = new Calculatrice();
        var resultat = c.CalculerRemise(prix, quantite);
        Assert.Equal(resultat, prixAttendu);
    }

    [Theory]
    [InlineData(10, 1, 10)]
    [InlineData(100, 4, 400)]
    [InlineData(100, 5, 450)]
    [InlineData(100, 10, 800)]
    //Calcul Remise Puis Total sur base de valeurs seuils (4/5 - 10 - 1)
    public void TotalSimpleAvecApplicationRemise(double prix, int quantite, double totalAttendu)
    {
        var c = new Calculatrice();
        var resultat = c.CalculerTotal(prix, quantite);
        
        Assert.Equal(resultat, totalAttendu);
    }

}