using GithubWebhook.Events;

public class PushEventValidator : GitHubWebhookBaseValidator<PushEvent>
{
    protected override ValidationResult NotValidResult => new ValidationResult
    {
        ValidationCode = ValidationResultCode.PushInUnreasonableTime,
        ValidationMessage = "Hey, people are sleeping between 14:00-16:00. Can't push code at this time."
    };

    protected override bool IsValid(PushEvent evnt)
    {
        var commitHour = evnt.HeadCommit.Timestamp.GetValueOrDefault().Hour;
        return !(commitHour == 14 || commitHour == 15);
    }
}
