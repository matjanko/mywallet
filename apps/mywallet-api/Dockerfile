FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app

COPY *.sln .
COPY ./src/Main/MyWallet.Api/MyWallet.Api.csproj ./src/Main/MyWallet.Api/
COPY ./src/Shared/MyWallet.Infrastructure/MyWallet.Infrastructure.csproj ./src/Shared/MyWallet.Infrastructure/
RUN dotnet restore 

COPY . ./
WORKDIR /app/src/Main/MyWallet.Api/
RUN dotnet publish -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "MyWallet.Api.dll"]
