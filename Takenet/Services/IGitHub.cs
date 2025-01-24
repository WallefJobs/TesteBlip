using Refit;
using System.Xml.Linq;

namespace Takenet.Services
{
    public interface IGitHub
    {
        [Get("/users/{owner}/repos")]
        Task<List<GitHubDadosDTO>> ReturnGitRepository([AliasAs("owner")] string owner, [Header("User-Agent")] string userAgent);
    }
}

public class GitHubDadosDTO
{
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime created_at { get; set; }
}
