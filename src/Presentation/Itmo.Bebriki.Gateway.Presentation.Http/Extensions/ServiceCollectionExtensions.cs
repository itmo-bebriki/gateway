using Itmo.Bebriki.Gateway.Presentation.Http.Clients;
using Itmo.Bebriki.Gateway.Presentation.Http.Models;
using Microsoft.Extensions.Options;

namespace Itmo.Bebriki.Gateway.Presentation.Http.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddGateway(this IServiceCollection services)
    {
        return services
            .AddOptions()
            .AddInternalClients()
            .AddGrpcClients();
    }

    private static IServiceCollection AddOptions(this IServiceCollection services)
    {
        services.AddOptions<ClientConfiguration>("task_service")
            .BindConfiguration("Client:Configuration:TaskService");

        services.AddOptions<ClientConfiguration>("board_service")
            .BindConfiguration("Client:Configuration:BoardService");

        services.AddOptions<ClientConfiguration>("topic_service")
            .BindConfiguration("Client:Configuration:TopicService");

        services.AddOptions<ClientConfiguration>("analytics_service")
            .BindConfiguration("Client:Configuration:AnalyticsService");

        services.AddOptions<ClientConfiguration>("history_service")
            .BindConfiguration("Client:Configuration:HistoryService");

        services.AddOptions<ClientConfiguration>("agreement_service")
            .BindConfiguration("Client:Configuration:AgreementService");

        return services;
    }

    private static IServiceCollection AddInternalClients(this IServiceCollection services)
    {
        services.AddSingleton<TaskClient>();
        services.AddSingleton<BoardClient>();
        services.AddSingleton<TopicClient>();
        services.AddSingleton<AnalyticsClient>();
        services.AddSingleton<HistoryClient>();
        services.AddSingleton<AgreementClient>();

        return services;
    }

    private static IServiceCollection AddGrpcClients(this IServiceCollection services)
    {
        services.AddGrpcClient<Tasks.Contracts.JobTaskService.JobTaskServiceClient>((provider, opts) =>
        {
            IOptionsMonitor<ClientConfiguration> options =
                provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
            opts.Address = new Uri(options.Get("task_service").Address);
        });

        services.AddGrpcClient<Boards.Contracts.BoardService.BoardServiceClient>((provider, opts) =>
        {
            IOptionsMonitor<ClientConfiguration> options =
                provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
            opts.Address = new Uri(options.Get("board_service").Address);
        });

        services.AddGrpcClient<Topics.Contracts.TopicService.TopicServiceClient>((provider, opts) =>
        {
            IOptionsMonitor<ClientConfiguration> options =
                provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
            opts.Address = new Uri(options.Get("topic_service").Address);
        });

        services.AddGrpcClient<Analytics.Contracts.TaskAnalyticsService.TaskAnalyticsServiceClient>((provider, opts) =>
        {
            IOptionsMonitor<ClientConfiguration> options =
                provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
            opts.Address = new Uri(options.Get("analytics_service").Address);
        });

        services.AddGrpcClient<Analytics.Contracts.HistoryAnalyticsService.HistoryAnalyticsServiceClient>(
            (provider, opts) =>
            {
                IOptionsMonitor<ClientConfiguration> options =
                    provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
                opts.Address = new Uri(options.Get("history_service").Address);
            });

        services.AddGrpcClient<Agreement.Contracts.AgreementService.AgreementServiceClient>(
            (provider, opts) =>
            {
                IOptionsMonitor<ClientConfiguration> options =
                    provider.GetRequiredService<IOptionsMonitor<ClientConfiguration>>();
                opts.Address = new Uri(options.Get("agreement_service").Address);
            });

        return services;
    }
}