# syntax=docker/dockerfile:1

# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy only project files first to leverage Docker cache for restore
COPY src/Back/Plankton.API/Plankton.API.csproj src/Back/Plankton.API/
COPY src/Kernel/Plankton.CryptoHelper/Plankton.CryptoHelper.csproj src/Kernel/Plankton.CryptoHelper/
COPY src/Kernel/Plankton.DTO/Plankton.DTO.csproj src/Kernel/Plankton.DTO/
RUN dotnet restore src/Back/Plankton.API/Plankton.API.csproj

# Copy source and publish
COPY . .
RUN dotnet publish src/Back/Plankton.API/Plankton.API.csproj -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

# Render injects PORT at runtime; fallback to 8080 for local runs
EXPOSE 8080

ENTRYPOINT ["sh", "-c", "ASPNETCORE_URLS=http://+:${PORT:-8080} dotnet Plankton.API.dll"]
