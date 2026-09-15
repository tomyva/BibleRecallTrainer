using Microsoft.Extensions.DependencyInjection;
namespace BibleRecallTrainer;
public sealed class ServiceRouteFactory(IServiceProvider services, Type pageType) : RouteFactory { public override Element GetOrCreate() => (Element)services.GetRequiredService(pageType); }
