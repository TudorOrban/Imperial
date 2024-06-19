public class BudgetCalculator
{
    public SettlementBudget ComputeSettlementBudget(Settlement settlement)
    {
        float totalUpkeep = 0;

        foreach (var building in settlement.buildings)
        {
            if (building is Farm farm)
            {
                totalUpkeep += farm.upkeep;
            }
        }



        return new SettlementBudget();
    }
}