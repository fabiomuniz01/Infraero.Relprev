#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Infraero.Relprev.WebUi/Infraero.Relprev.WebUi.csproj", "Infraero.Relprev.WebUi/"]
COPY ["Infraero.Relprev.CoreApiClient/Infraero.Relprev.CoreApiClient.csproj", "Infraero.Relprev.CoreApiClient/"]
COPY ["Infraero.Relprev.Application/Infraero.Relprev.Application.csproj", "Infraero.Relprev.Application/"]
COPY ["Infraero.Relprev.Domain/Infraero.Relprev.Domain.csproj", "Infraero.Relprev.Domain/"]
COPY ["Infraero.Relprev.CrossCutting/Infraero.Relprev.CrossCutting.csproj", "Infraero.Relprev.CrossCutting/"]
COPY ["Infraero.Relprev.Infrastructure/Infraero.Relprev.Infrastructure.csproj", "Infraero.Relprev.Infrastructure/"]
RUN dotnet restore "Infraero.Relprev.WebUi/Infraero.Relprev.WebUi.csproj"
COPY . .
WORKDIR "/src/Infraero.Relprev.WebUi"
RUN dotnet build "Infraero.Relprev.WebUi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Infraero.Relprev.WebUi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Infraero.Relprev.WebUi.dll"]
