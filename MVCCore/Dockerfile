FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MVCCore/MVCCore.csproj", "MVCCore/"]
RUN dotnet restore "MVCCore/MVCCore.csproj"
COPY . .
WORKDIR "/src/MVCCore"
RUN dotnet build "MVCCore.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MVCCore.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MVCCore.dll"]
