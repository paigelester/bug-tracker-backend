#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/services/BugTracker.API/BugTracker.API.csproj", "src/services/BugTracker.API/"]
COPY ["src/services/BugTracker.Infrastructure/BugTracker.Infrastructure.csproj", "src/services/BugTracker.Infrastructure/"]
COPY ["src/services/BugTracker.Application/BugTracker.Application.csproj", "src/services/BugTracker.Application/"]
RUN dotnet restore "src/services/BugTracker.API/BugTracker.API.csproj"
COPY . .
WORKDIR "/src/src/services/BugTracker.API"
RUN dotnet build "BugTracker.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BugTracker.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BugTracker.API.dll"]
