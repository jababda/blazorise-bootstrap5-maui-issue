using System.Reflection;
using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;

using Microsoft.Extensions.DependencyInjection;

namespace Blazorise_Shared;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddUI(this IServiceCollection services)
    {
        services.AddBlazorise(options => { options.ChangeTextOnKeyPress = true; })
            .AddBootstrap5Providers()
            .AddFontAwesomeIcons();

        return services;
    }
}
