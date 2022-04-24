### GitHub Webhooks validator
This repo is validating github webhooks using asp.net 6.
currently validations fails in the following cases:

1. pushing code between 14:00-16:00
2. create a team with the prefix hacker”
3. creating a repository and deleting it in less than 10 minutes

Note:
currently it does not support a secret from github webhooks.

You can test the validations using GitHubWebHooks.postman_collection.json postman collection.
