FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LeapYearCLI/LeapYearCLI.csproj", "LeapYearCLI/"]
RUN dotnet restore "LeapYearCLI/LeapYearCLI.csproj"
COPY . .
WORKDIR "/src/LeapYearCLI"
RUN dotnet build "LeapYearCLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LeapYearCLI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LeapYearCLI.dll"]
