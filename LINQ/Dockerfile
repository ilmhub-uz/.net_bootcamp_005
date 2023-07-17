FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LINQ/LINQ.csproj", "LINQ/"]
RUN dotnet restore "LINQ/LINQ.csproj"
COPY . .
WORKDIR "/src/LINQ"
RUN dotnet build "LINQ.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LINQ.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LINQ.dll"]
