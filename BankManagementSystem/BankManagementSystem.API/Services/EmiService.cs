using BankLoanManagement.API.DTOs;

public class EmiService : IEmiService
{
    public List<EmiScheduleDto> GenerateSchedule(decimal principal, decimal annualRate, int months)
    {
        var schedule = new List<EmiScheduleDto>();

        if (principal <= 0 || annualRate <= 0 || months <= 0)
            throw new Exception("Invalid EMI inputs");

        decimal monthlyRate = annualRate / 12 / 100;

        double emiDouble =
            (double)(principal * monthlyRate * (decimal)Math.Pow(1 + (double)monthlyRate, months))
            /
            (double)(Math.Pow(1 + (double)monthlyRate, months) - 1);

        decimal emi = (decimal)emiDouble;

        decimal balance = principal;

        for (int i = 1; i <= months; i++)
        {
            decimal interest = balance * monthlyRate;
            decimal principalComponent = emi - interest;
            balance -= principalComponent;

            schedule.Add(new EmiScheduleDto
            {
                Month = i,
                EMI = Math.Round(emi, 2),
                Interest = Math.Round(interest, 2),
                Principal = Math.Round(principalComponent, 2),
                RemainingBalance = Math.Round(balance < 0 ? 0 : balance, 2)
            });
        }

        return schedule;
    }
}