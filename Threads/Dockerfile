FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Threads/Threads.csproj", "Threads/"]
RUN dotnet restore "Threads/Threads.csproj"
COPY . .
WORKDIR "/src/Threads"
RUN dotnet build "Threads.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Threads.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Threads.dll"]
