using GithubWebhook.Events;

public class TeamEventValidator : GitHubWebhookBaseValidator<TeamEvent>
{
    protected override ValidationResult NotValidResult => new ValidationResult
    {
        ValidationCode = ValidationResultCode.HackerTeam,
        ValidationMessage = "Hacker team was detected!!! Help!!"
    };

    protected override bool IsValid(TeamEvent evnt) => !evnt.Team.Name.StartsWith("hacker", StringComparison.CurrentCultureIgnoreCase);
}
