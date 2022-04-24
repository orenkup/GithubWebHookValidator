public interface IWebHookValidatorFactory
{
    IGitHubWebhookValidator GetValidator(object payloadObject);
}
