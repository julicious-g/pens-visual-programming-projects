FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["CalculatorCLI/CalculatorCLI.csproj", "CalculatorCLI/"]
RUN dotnet restore "CalculatorCLI/CalculatorCLI.csproj"
COPY . .
WORKDIR "/src/CalculatorCLI"
RUN dotnet build "CalculatorCLI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculatorCLI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculatorCLI.dll"]
