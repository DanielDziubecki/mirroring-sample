FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["app1/app1.csproj", "app1/"]
RUN dotnet restore "app1/app1.csproj"
COPY . .
WORKDIR "/src/app1"
RUN dotnet build "app1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "app1.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "app1.dll"]