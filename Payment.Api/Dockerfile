FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Payment.Api/Payment.Api.csproj", "Payment.Api/"]
RUN dotnet restore "Payment.Api/Payment.Api.csproj"
COPY . .
WORKDIR "/src/Payment.Api"
RUN dotnet build "Payment.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Payment.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Payment.Api.dll"]