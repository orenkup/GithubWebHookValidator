using GithubWebhook.Events;

public class WebHookValidatorFactory : IWebHookValidatorFactory
{
    public IGitHubWebhookValidator GetValidator (object payloadObject)
    {
        if (payloadObject is PushEvent)
            return new PushEventValidator();
        else if (payloadObject is TeamEvent)
            return new TeamEventValidator();
        else if (payloadObject is RepositoryEvent)
            return new RepositoryEventValidator();
        else
            throw new NotImplementedException($"{ payloadObject.GetType().Name} is not supported yet");
    }
}
