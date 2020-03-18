#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Infraero.Relprev.WebApi/Infraero.Relprev.WebApi.csproj", "Infraero.Relprev.WebApi/"]
COPY ["Infraero.Relprev.CrossCutting/Infraero.Relprev.CrossCutting.csproj", "Infraero.Relprev.CrossCutting/"]
COPY ["Infraero.Relprev.Application/Infraero.Relprev.Application.csproj", "Infraero.Relprev.Application/"]
COPY ["Infraero.Relprev.Domain/Infraero.Relprev.Domain.csproj", "Infraero.Relprev.Domain/"]
COPY ["Infraero.Relprev.Infrastructure/Infraero.Relprev.Infrastructure.csproj", "Infraero.Relprev.Infrastructure/"]
RUN dotnet restore "Infraero.Relprev.WebApi/Infraero.Relprev.WebApi.csproj"
COPY . .
WORKDIR "/src/Infraero.Relprev.WebApi"
RUN dotnet build "Infraero.Relprev.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Infraero.Relprev.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Infraero.Relprev.WebApi.dll"]