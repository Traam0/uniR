using System.Threading;
using System.Threading.Tasks;

namespace UniR.Contracts.Services;

public interface IMailService
{
    IMailService From(string from);
    IMailService To(string to);
    IMailService Subject(string subject);
    IMailService Body(string body);
    Task SendAsync(CancellationToken cancellationToken);
}