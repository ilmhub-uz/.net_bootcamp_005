FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DataStructure/DataStructure.csproj", "DataStructure/"]
RUN dotnet restore "DataStructure/DataStructure.csproj"
COPY . .
WORKDIR "/src/DataStructure"
RUN dotnet build "DataStructure.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DataStructure.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DataStructure.dll"]
