using System.Threading.Tasks;

namespace NimblesPros.DotNetConf.Core.Interfaces;

public interface IEmailSender
{
  Task SendEmailAsync(string to, string from, string subject, string body);
}
