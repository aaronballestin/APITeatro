FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY *.sln .
COPY Models/*.csproj Models/
COPY Business/*.csproj Business/
COPY Data/*.csproj Data/
COPY Api/*.csproj Api/
RUN dotnet restore TeatroApi.sln

COPY . .
RUN dotnet publish TeatroApi.sln -c Release -o Api/out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/Api/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "TeatroApi.Api.dll"]