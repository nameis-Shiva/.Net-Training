using BankLoanManagement.API.DTOs;

public interface IEmiService
{
    List<EmiScheduleDto> GenerateSchedule(decimal principal, decimal annualRate, int months);
}