#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["backend/4-APIs/Core/LTSSolution.Services.API.Core/LTSSolution.Services.API.Core.csproj", "backend/4-APIs/Core/LTSSolution.Services.API.Core/"]
RUN dotnet restore "backend/4-APIs/Core/LTSSolution.Services.API.Core/LTSSolution.Services.API.Core.csproj"
COPY . .
WORKDIR "/src/backend/4-APIs/Core/LTSSolution.Services.API.Core"
RUN dotnet build "LTSSolution.Services.API.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LTSSolution.Services.API.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LTSSolution.Services.API.Core.dll"]