#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MoneyPattern.Clients.Api/MoneyPattern.Clients.Api.csproj", "MoneyPattern.Clients.Api/"]
RUN dotnet restore "MoneyPattern.Clients.Api/MoneyPattern.Clients.Api.csproj"
COPY . .
WORKDIR "/src/MoneyPattern.Clients.Api"
RUN dotnet build "MoneyPattern.Clients.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MoneyPattern.Clients.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MoneyPattern.Clients.Api.dll"]