FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ./*.props ./

COPY ["src/Itmo.Bebriki.Gateway/Itmo.Bebriki.Gateway.csproj", "src/Itmo.Bebriki.Gateway/"]

COPY ["src/Presentation/Itmo.Bebriki.Gateway.Presentation.Http/Itmo.Bebriki.Gateway.Presentation.Http.csproj", "src/Presentation/Itmo.Bebriki.Gateway.Presentation.Http/"]

RUN dotnet restore "src/Itmo.Bebriki.Gateway/Itmo.Bebriki.Gateway.csproj"

COPY . .
WORKDIR "/src/src/Itmo.Bebriki.Gateway"
RUN dotnet build "Itmo.Bebriki.Gateway.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Itmo.Bebriki.Gateway.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Itmo.Bebriki.Gateway.dll"]
