using Elsa.Activities.Webhooks.ActivityTypes;
using Elsa.Activities.Webhooks.Bookmarks;
using Elsa.Activities.Webhooks.Handlers;
using Elsa.Options;
using Elsa.Providers.Activities;
using Microsoft.Extensions.DependencyInjection;

namespace Elsa.Activities.Webhooks.Extensions
{
    public static class WebhookOptionsBuilderExtensions
    {
        public static ElsaOptionsBuilder AddWebhooks(this ElsaOptionsBuilder elsaOptions)
        {
            elsaOptions.Services
                .AddScoped<IActivityTypeProvider, WebhookActivityTypeProvider>()
                .AddBookmarkProvider<WebhookBookmarkProvider>()
                .AddNotificationHandlersFrom<EvictWorkflowRegistryCacheHandler>();

            return elsaOptions;
        }
    }
}
