FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
EXPOSE 80
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Account/Account.csproj", "Account/"]
RUN dotnet restore "Account/Account.csproj"
COPY . .
WORKDIR "/src/Account"
RUN dotnet build "Account.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Account.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Account.dll"]