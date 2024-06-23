#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 5000
EXPOSE 5001

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["NuGet.Config", "."]
#COPY ["src/ProjectX.HttpApi.Host/ProjectX.HttpApi.Host.csproj", "src/ProjectX.HttpApi.Host/"]
#COPY ["src/ProjectX.Application/ProjectX.Application.csproj", "src/ProjectX.Application/"]
#COPY ["src/ProjectX.Domain/ProjectX.Domain.csproj", "src/ProjectX.Domain/"]
#COPY ["src/ProjectX.Domain.Shared/ProjectX.Domain.Shared.csproj", "src/ProjectX.Domain.Shared/"]
#COPY ["src/ProjectX.Application.Contracts/ProjectX.Application.Contracts.csproj", "src/ProjectX.Application.Contracts/"]
#COPY ["src/ProjectX.EntityFrameworkCore/ProjectX.EntityFrameworkCore.csproj", "src/ProjectX.EntityFrameworkCore/"]
#COPY ["src/ProjectX.HttpApi/ProjectX.HttpApi.csproj", "src/ProjectX.HttpApi/"]
COPY src ./src
RUN dotnet restore "./src/ProjectX.HttpApi.Host/ProjectX.HttpApi.Host.csproj"
COPY . .
WORKDIR "/src/src/ProjectX.HttpApi.Host"
RUN dotnet build "./ProjectX.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ProjectX.HttpApi.Host.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectX.HttpApi.Host.dll"]