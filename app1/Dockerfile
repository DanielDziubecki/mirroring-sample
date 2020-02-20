FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app1

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /app1
COPY ["app1.csproj", "app1/"]
RUN dotnet restore "app1/app1.csproj"
COPY . .
WORKDIR /app1
RUN dotnet build "app1.csproj" -c Release -o /build

FROM build AS publish
RUN dotnet publish "app1.csproj" -c Release -o /publish

FROM base AS final
WORKDIR /app
COPY --from=publish /publish .
ENTRYPOINT ["dotnet", "app1.dll"]