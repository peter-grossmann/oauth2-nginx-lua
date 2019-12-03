FROM mcr.microsoft.com/dotnet/core/sdk:3.0 AS build
WORKDIR /workdir

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out


FROM mcr.microsoft.com/dotnet/core/aspnet:3.0 AS runtime
WORKDIR /app
COPY --from=build /workdir/out ./
RUN chmod -R 770 /app

COPY ./idserver.pfx /app

ENTRYPOINT ["dotnet", "idServer.dll"]