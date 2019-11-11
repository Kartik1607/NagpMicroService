FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["OnBoard/OnBoard.csproj", "OnBoard/"]
RUN dotnet restore "OnBoard/OnBoard.csproj"
COPY . .
WORKDIR "/src/OnBoard"
RUN dotnet build "OnBoard.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "OnBoard.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "OnBoard.dll"]