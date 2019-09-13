#!/bin/sh

#dotnet clean
rm -rf bin obj .sonarqube

dotnet clean

dotnet ${SONAR_BIN_DIR}/sonar-scanner/SonarScanner.MSBuild.dll begin /k:${PROJECT_KEY} /v:${PROJECT_VERSION} /d:sonar.host.url=${SONAR_URL} /d:sonar.login=${SONAR_TOKEN} /d:sonar.verbose=true
dotnet build
dotnet ${SONAR_BIN_DIR}/sonar-scanner/SonarScanner.MSBuild.dll end /d:sonar.login=${SONAR_TOKEN}
