# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 80


# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Cadastro/DZA.Cadastro.Api/DZA.Cadastro.Api.csproj", "Cadastro/DZA.Cadastro.Api/"]
COPY ["Core/DZA.Core/DZA.Core.csproj", "Core/DZA.Core/"]
COPY ["Cadastro/DZA.Cadastro.Application/DZA.Cadastro.Application.csproj", "Cadastro/DZA.Cadastro.Application/"]
COPY ["Cadastro/DZA.Cadastro.Domain/DZA.Cadastro.Domain.csproj", "Cadastro/DZA.Cadastro.Domain/"]
COPY ["Cadastro/DZA.Cadastro.Infra.Data/DZA.Cadastro.Infra.Data.csproj", "Cadastro/DZA.Cadastro.Infra.Data/"]
RUN dotnet restore "./Cadastro/DZA.Cadastro.Api/DZA.Cadastro.Api.csproj"
COPY . .
WORKDIR "/src/Cadastro/DZA.Cadastro.Api"
RUN dotnet build "./DZA.Cadastro.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./DZA.Cadastro.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DZA.Cadastro.Api.dll"]