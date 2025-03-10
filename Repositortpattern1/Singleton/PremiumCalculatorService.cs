namespace Repositortpattern1.Singleton
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        public decimal CalculatePremium(int age, string planType, bool hasPreExistingCondition)
        {
            decimal basePremium = planType switch
            {
                "Basic" => 5000,
                "Standard" => 7000,
                "Premium" => 10000,
                _ => throw new ArgumentException("Invalid Plan Type")
            };

            if (hasPreExistingCondition)
                basePremium *= 1.2m;

            if (age > 50)
                basePremium *= 1.5m;
            else if (age < 25)
                basePremium *= 0.8m;

            return basePremium;
        }
        }
}
