using GithubWebhook;

public interface IGitHubWebhookValidator
{
    ValidationResult Validate(GhWebhook ghwh);
}
