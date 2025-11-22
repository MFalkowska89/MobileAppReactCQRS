FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
#EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Instalacja Node.js dla projektu React
RUN curl -fsSL https://deb.nodesource.com/setup_22.x | bash -
RUN apt-get install -y nodejs

# Kopiowanie plików projektu Server
COPY ["SolutionReact.Server/SolutionReact.Server.csproj", "SolutionReact.Server/"]
# Kopiowanie plików projektu Client (esproj)
COPY ["solutionreact.client/solutionreact.client.esproj", "solutionreact.client/"]
COPY ["solutionreact.client/package.json", "solutionreact.client/"]
COPY ["solutionreact.client/package-lock.json", "solutionreact.client/"]

# Restore projektu Server
RUN dotnet restore "SolutionReact.Server/SolutionReact.Server.csproj"

# Kopiowanie całego kodu
COPY . .

# Instalacja zależności npm dla frontendu
WORKDIR "/src/solutionreact.client"
RUN npm install

# Build projektu Server
WORKDIR "/src/SolutionReact.Server"
RUN dotnet build "SolutionReact.Server.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publish
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
WORKDIR "/src/SolutionReact.Server"
RUN dotnet publish "SolutionReact.Server.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SolutionReact.Server.dll"]