FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app2

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /app2
COPY ["app2.csproj", "app2/"]
RUN dotnet restore "app2/app2.csproj"
COPY . .
WORKDIR /app2
RUN dotnet build "app2.csproj" -c Release -o /build

FROM build AS publish
RUN dotnet publish "app2.csproj" -c Release -o /publish

FROM base AS final
WORKDIR /app
COPY --from=publish /publish .
ENTRYPOINT ["dotnet", "app2.dll"]