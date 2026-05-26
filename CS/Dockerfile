#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0-jammy AS base

#Install dependencies
RUN apt-get update
RUN apt-get install -y libc6 libicu-dev libfontconfig1

WORKDIR /app
ENV ASPNETCORE_URLS=http://+:80
EXPOSE 80
EXPOSE 443

FROM node:18 as build-frontend
WORKDIR /modules
COPY ["package.json", "./"]
RUN npm install

FROM mcr.microsoft.com/dotnet/sdk:8.0-jammy AS build
WORKDIR /src
COPY ["DocumentViewerApp.csproj", "DocumentViewerApp/"]
RUN dotnet restore "DocumentViewerApp/DocumentViewerApp.csproj"
COPY ["./", "DocumentViewerApp/"]
WORKDIR "/src/DocumentViewerApp"
COPY --from=build-frontend ./modules .
RUN --mount=type=secret,id=dxLicense,env=DevExpress_License \
    dotnet build "DocumentViewerApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN --mount=type=secret,id=dxLicense,env=DevExpress_License \
    dotnet publish "DocumentViewerApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DocumentViewerApp.dll"]
