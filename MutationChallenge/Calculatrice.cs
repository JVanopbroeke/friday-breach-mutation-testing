namespace MutationChallenge;

public class Calculatrice
{
    public double CalculerRemise(double prix, int quantite)
    {
        if (quantite >= 10)
            return prix * 0.80;

        if (quantite >= 5)
            return prix * 0.90;

        return prix;
    }

    public double CalculerTotal(double prix, int quantite)
        => CalculerRemise(prix, quantite) * quantite;
}