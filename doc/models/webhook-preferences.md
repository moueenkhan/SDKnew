
# Webhook Preferences

## Structure

`WebhookPreferences`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OnboardingWebhook` | `string` | Optional | Client supplied URL that will be notified for all onboarding events. |
| `OnboardingWebhookAuthentication` | [`Models.WebhookAuthenticationPreference`](../../doc/models/webhook-authentication-preference.md) | Optional | - |

## Example (as JSON)

```json
{
  "onboardingWebhook": null,
  "onboardingWebhookAuthentication": null
}
```

