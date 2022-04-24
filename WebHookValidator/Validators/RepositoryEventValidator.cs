using GithubWebhook.Events;

public class RepositoryEventValidator : GitHubWebhookBaseValidator<RepositoryEvent>
{
    protected override ValidationResult NotValidResult => new ValidationResult
    {
        ValidationCode = ValidationResultCode.ShortLivedRespository,
        ValidationMessage = "Repository is deleted less than 10 minutes after it was created, somwthing is suspicious here...."
    };

    protected override bool IsValid(RepositoryEvent evnt) => (DateTime.Now - evnt.Repository.CreatedAt.GetValueOrDefault()).TotalMinutes > 10;
    
}