using GithubWebhook;

public abstract class GitHubWebhookBaseValidator<T> : IGitHubWebhookValidator
{
    protected ValidationResult ValidResult => new ValidationResult();

    protected abstract ValidationResult NotValidResult { get;}

    public ValidationResult Validate(GhWebhook ghwh)
    {
        var evnt = (T)ghwh.PayloadObject;
        return IsValid(evnt) ? ValidResult: NotValidResult;
    }

    protected abstract bool IsValid(T evnt);
}
