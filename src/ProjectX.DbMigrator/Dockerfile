#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER app
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
#COPY ["src/ProjectX.DbMigrator/ProjectX.DbMigrator.csproj", "src/ProjectX.DbMigrator/"]
#COPY ["src/ProjectX.Application.Contracts/ProjectX.Application.Contracts.csproj", "src/ProjectX.Application.Contracts/"]
#COPY ["src/ProjectX.Domain.Shared/ProjectX.Domain.Shared.csproj", "src/ProjectX.Domain.Shared/"]
#COPY ["src/ProjectX.EntityFrameworkCore/ProjectX.EntityFrameworkCore.csproj", "src/ProjectX.EntityFrameworkCore/"]
#COPY ["src/ProjectX.Domain/ProjectX.Domain.csproj", "src/ProjectX.Domain/"]
COPY src ./src
RUN dotnet restore "./src/ProjectX.DbMigrator/ProjectX.DbMigrator.csproj"
COPY . .
WORKDIR "/src/src/ProjectX.DbMigrator"
RUN dotnet build "./ProjectX.DbMigrator.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./ProjectX.DbMigrator.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectX.DbMigrator.dll"]