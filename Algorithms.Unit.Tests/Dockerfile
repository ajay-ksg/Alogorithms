FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Algorithms.Unit.Tests/Algorithms.Unit.Tests.csproj", "Algorithms.Unit.Tests/"]
RUN dotnet restore "Algorithms.Unit.Tests/Algorithms.Unit.Tests.csproj"
COPY . .
WORKDIR "/src/Algorithms.Unit.Tests"
RUN dotnet build "Algorithms.Unit.Tests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Algorithms.Unit.Tests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Algorithms.Unit.Tests.dll"]
