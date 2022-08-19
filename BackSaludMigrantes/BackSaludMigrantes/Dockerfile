#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Imagen de Produccion
#####################################################################
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
#####################################################################

#Imagen de Build
#####################################################################
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes.csproj", "."]
RUN dotnet restore "./BackSaludMigrantes.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes.csproj" -c Release -o /app/build
#####################################################################

#Imagen Publish
#####################################################################
FROM build AS publish
RUN dotnet publish "BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes/BackSaludMigrantes.csproj" -c Release -o /app/publish

#Mover publish al final
#####################################################################
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BackSaludMigrantes.dll"] 