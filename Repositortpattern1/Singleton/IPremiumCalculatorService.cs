namespace Repositortpattern1.Singleton
{
    public interface IPremiumCalculatorService
    {
        decimal CalculatePremium(int age, string planType, bool hasPreExistingCondition);
    }
}
