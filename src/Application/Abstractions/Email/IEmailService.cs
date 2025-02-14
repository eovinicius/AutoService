namespace Application.Abstractions.Email;

public interface IEmailService
{
    Task Send(string recipient, string subject, string body);
}
