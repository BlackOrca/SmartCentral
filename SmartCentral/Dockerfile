FROM microsoft/dotnet:3.1-sdk as build

ARG BUILDCONFIG=RELEASE
ARG VERSION=1.0.0

COPY SmartCentral.csproj /build/

RUN dotnet restore ./build/SmartCentral.csproj

COPY . ./build/
WORKDIR /build/
RUN dotnet publish ./SmartCentral.csproj -c $BUILDCONFIG -o out /p:Version=$VERSION

FROM microsoft/dotnet:3.1-aspnetcore-runtime
WORKDIR /app

COPY --from=build /build/out .

ENTRYPOINT ["dotnet", "SmartCentral.dll"] 