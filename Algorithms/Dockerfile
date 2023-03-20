FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Algorithms/Algorithms.csproj", "Algorithms/"]
RUN dotnet restore "Algorithms/Algorithms.csproj"
COPY . .
WORKDIR "/src/Algorithms"
RUN dotnet build "Algorithms.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Algorithms.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Algorithms.dll"]
