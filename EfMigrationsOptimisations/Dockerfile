FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["EfMigrationsOptimisations/EfMigrationsOptimisations.csproj", "EfMigrationsOptimisations/"]
RUN dotnet restore "EfMigrationsOptimisations/EfMigrationsOptimisations.csproj"
COPY . .
WORKDIR "/src/EfMigrationsOptimisations"
RUN dotnet build "EfMigrationsOptimisations.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EfMigrationsOptimisations.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EfMigrationsOptimisations.dll"]
